using librpc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace PS4_Cheater
{
    public partial class FrmMain : Form
    {
        private ProcessManager processManager = new ProcessManager();
        private MemoryHelper memoryHelper = new MemoryHelper(true, 0);
        private CheatList cheatList = new CheatList();

        private const int CHEAT_LIST_DEL = 0;
        private const int CHEAT_LIST_ADDRESS = 1;
        private const int CHEAT_LIST_TYPE = 2;
        private const int CHEAT_LIST_ENABLED = 3;
        private const int CHEAT_LIST_VALUE = 4;
        private const int CHEAT_LIST_SECTION = 5;
        private const int CHEAT_LIST_LOCK = 6;
        private const int CHEAT_LIST_DESC = 7;

        private const int RESULT_LIST_ADDRESS = 0;
        private const int RESULT_LIST_TYPE = 1;
        private const int RESULT_LIST_VALUE = 2;
        private const int RESULT_LIST_SECTION = 4;

        private const int VERSION_LIST_405 = 2;
        private const int VERSION_LIST_455 = 1;
        private const int VERSION_LIST_505 = 0;

        private const int VERSION_LIST_DEFAULT = VERSION_LIST_505;

        private string[] SEARCH_BY_FLOAT_FIRST = new string[]
        {
             CONSTANT.EXACT_VALUE,
             CONSTANT.FUZZY_VALUE,
             CONSTANT.BIGGER_THAN,
             CONSTANT.SMALLER_THAN,
             CONSTANT.BETWEEN_VALUE,
             CONSTANT.UNKNOWN_INITIAL_VALUE
        };

        private string[] SEARCH_BY_BYTES_FIRST = new string[]
        {
            CONSTANT.EXACT_VALUE,
            CONSTANT.BIGGER_THAN,
            CONSTANT.SMALLER_THAN,
            CONSTANT.BETWEEN_VALUE,
            CONSTANT.UNKNOWN_INITIAL_VALUE
        };

        private string[] SEARCH_BY_FLOAT_NEXT = new string[]
        {
             CONSTANT.EXACT_VALUE,
             CONSTANT.FUZZY_VALUE,
             CONSTANT.INCREASED_VALUE,
             CONSTANT.INCREASED_VALUE_BY,
             CONSTANT.DECREASED_VALUE,
             CONSTANT.DECREASED_VALUE_BY,
             CONSTANT.BIGGER_THAN,
             CONSTANT.SMALLER_THAN,
             CONSTANT.CHANGED_VALUE,
             CONSTANT.UNCHANGED_VALUE,
             CONSTANT.BETWEEN_VALUE,
        };

        private string[] SEARCH_BY_BYTES_NEXT = new string[]
        {
            CONSTANT.EXACT_VALUE,
            CONSTANT.INCREASED_VALUE,
            CONSTANT.INCREASED_VALUE_BY,
            CONSTANT.DECREASED_VALUE,
            CONSTANT.DECREASED_VALUE_BY,
            CONSTANT.BIGGER_THAN,
            CONSTANT.SMALLER_THAN,
            CONSTANT.CHANGED_VALUE,
            CONSTANT.UNCHANGED_VALUE,
            CONSTANT.BETWEEN_VALUE,
        };

        private string[] SEARCH_BY_HEX = new string[]
        {
            CONSTANT.EXACT_VALUE,
        };

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cbValueTypeList.Items.AddRange(CONSTANT.SEARCH_VALUE_TYPE);
            cbValueTypeList.SelectedIndex = 2;

            string version = Config.getSetting("ps4 version");
            string ip = Config.getSetting("ip");

            Util.Version = 505;

            if (!string.IsNullOrEmpty(ip))
            {
                txtIpAddress.Text = ip;
            }

            this.btnNextScan.Text = CONSTANT.NEXT_SCAN;
            this.btnNewScan.Text = CONSTANT.FIRST_SCAN;
            this.btnRefresh.Text = CONSTANT.REFRESH;
            this.Text += " " + CONSTANT.MAJOR_VERSION + "." + CONSTANT.SECONDARY_VERSION + "." + CONSTANT.THIRD_VERSION;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.updateSeeting("ps4 version", "5.05");

            if (!string.IsNullOrWhiteSpace(txtIpAddress.Text))
            {
                Config.updateSeeting("ip", txtIpAddress.Text);
            }

            //MemoryHelper.Disconnect();
        }

        private void update_result_list_view(BackgroundWorker worker, bool refresh, int start, float percent)
        {
            worker.ReportProgress(start);

            List<ListViewItem> listViewItems = new List<ListViewItem>();
            bool[] mappedSectionCheckeSet = new bool[processManager.MappedSectionList.Count];

            ulong totalResultCount = processManager.MappedSectionList.TotalResultCount();
            ulong curResultCount = 0;
            string value_type = MemoryHelper.GetStringOfValueType(memoryHelper.ValueType);

            const int MAX_RESULTS_NUM = 0x1000;

            for (int idx = 0; idx < processManager.MappedSectionList.Count; ++idx)
            {
                MappedSection mapped_section = processManager.MappedSectionList[idx];
                ResultList result_list = mapped_section.ResultList;
                if (result_list == null)
                {
                    continue;
                }
                if (!mapped_section.Check)
                {
                    continue;
                }

                mappedSectionCheckeSet[idx] = result_list.Count > 0;

                for (result_list.Begin(); !result_list.End(); result_list.Next())
                {
                    if (curResultCount >= MAX_RESULTS_NUM)
                    {
                        break;
                    }

                    uint memory_address_offset = 0;
                    byte[] memory_value = null;

                    result_list.Get(ref memory_address_offset, ref memory_value);

                    curResultCount++;
                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = String.Format("{0:X}", memory_address_offset + mapped_section.Start);

                    if (refresh && !worker.CancellationPending)
                    {
                        memory_value = memoryHelper.GetBytesByType(memory_address_offset + mapped_section.Start);
                        result_list.Set(memory_value);
                        worker.ReportProgress(start + (int)(100.0f * curResultCount / MAX_RESULTS_NUM));
                    }

                    lvi.SubItems.Add(value_type);
                    lvi.SubItems.Add(memoryHelper.BytesToString(memory_value));
                    lvi.SubItems.Add(memoryHelper.BytesToHexString(memory_value));
                    lvi.SubItems.Add(processManager.MappedSectionList.GetSectionName(idx));

                    listViewItems.Add(lvi);
                }
            }

            WorkerReturn workerReturn = new WorkerReturn();
            workerReturn.ListViewItems = listViewItems;
            workerReturn.MappedSectionCheckeSet = mappedSectionCheckeSet;
            workerReturn.Results = totalResultCount;

            worker.ReportProgress(start + (int)(100 * percent), workerReturn);
        }

        void setButtons(bool enabled)
        {
            btnNewScan.Enabled = enabled;
            btnRefresh.Enabled = enabled;
            btnNextScan.Enabled = enabled;
            cmbProcesses.Enabled = enabled;
            btnRefreshProcess.Enabled = enabled;
            cmsSectionMenu.Enabled = enabled;
            cbCompareTypeList.Enabled = enabled;
        }

        private void btnNewScan_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnNewScan.Text == CONSTANT.FIRST_SCAN)
                {
                    if (MessageBox.Show("search size:" + (processManager.MappedSectionList.TotalMemorySize / 1024).ToString() + "KB") != DialogResult.OK)
                    {
                        return;
                    }

                    memoryHelper.InitMemoryHandler((string)cbValueTypeList.SelectedItem, (string)cbCompareTypeList.SelectedItem, cbAlignment.Checked, txtValue.Text.Length);

                    setButtons(false);
                    btnNewScan.Enabled = true;
                    cbValueTypeList.Enabled = false;
                    cbAlignment.Enabled = false;
                    //section_list_box.lo = false;

                    bwNewScan.RunWorkerAsync();

                    btnNewScan.Text = CONSTANT.STOP;
                }
                else if (btnNewScan.Text == CONSTANT.NEW_SCAN)
                {
                    cbValueTypeList.Enabled = true;
                    cbAlignment.Enabled = true;
                    //section_list_box.Enabled = true;
                    btnRefresh.Enabled = false;
                    btnNextScan.Enabled = false;
                    btnNewScan.Text = CONSTANT.FIRST_SCAN;

                    lvResult.Items.Clear();
                    processManager.MappedSectionList.ClearResultList();
                    InitCompareTypeListOfFirstScan();
                }
                else if (btnNewScan.Text == CONSTANT.STOP)
                {
                    bwNewScan.CancelAsync();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRefresh.Text == "Refresh")
                {
                    setButtons(false);
                    btnRefresh.Enabled = true;
                    btnRefresh.Text = CONSTANT.STOP;
                    bwUpdateResult.RunWorkerAsync();
                }
                else if (btnRefresh.Text == CONSTANT.STOP)
                {
                    bwUpdateResult.CancelAsync();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnNextScan_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnNextScan.Text == "Next Scan")
                {
                    memoryHelper.InitNextScanMemoryHandler((string)cbCompareTypeList.SelectedItem);
                    setButtons(false);
                    btnNextScan.Enabled = true;
                    btnNextScan.Text = CONSTANT.STOP;
                    bwNextScan.RunWorkerAsync();
                }
                else if (btnNextScan.Text == CONSTANT.STOP)
                {
                    bwNextScan.CancelAsync();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void set_section_list_box(bool check)
        {
            for (int i = 0; i < lstSection.Items.Count; ++i)
            {
                lstSection.SetItemChecked(i, check);
            }
        }

        private void cbSelectAll_Click(object sender, EventArgs e)
        {
            bool check = cbSelectAll.Checked;
            set_section_list_box(check);
        }

        private void update_result_list_view_ui(WorkerReturn ret)
        {
            lvResult.Items.Clear();
            lvResult.BeginUpdate();
            lvResult.Items.AddRange(ret.ListViewItems.ToArray());
            lvResult.EndUpdate();

            for (int i = 0; i < lstSection.Items.Count; ++i)
            {
                lstSection.SetItemChecked(i, ret.MappedSectionCheckeSet[i]);
            }
            lblMsg.Text = ret.Results + " results";
        }

        private void Scan_worker_DoWorker(object sender, DoWorkEventArgs e, bool isFirstScan)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            string value_0 = txtValue.Text;
            string value_1 = txtValue2.Text;
            worker.ReportProgress(0);

            Mutex scan_wait_mutex = new Mutex();
            scan_wait_mutex.WaitOne();

            List<byte[]> buffer_queue = new List<byte[]>(CONSTANT.MAX_PEEK_QUEUE);

            Semaphore consumerMutex = new Semaphore(0, CONSTANT.MAX_PEEK_QUEUE);
            Semaphore producerMutex = new Semaphore(CONSTANT.MAX_PEEK_QUEUE, CONSTANT.MAX_PEEK_QUEUE);

            PeekThread peekThread = new PeekThread(processManager, buffer_queue, consumerMutex, producerMutex);
            ComparerThread comparer_thread = new ComparerThread(processManager, memoryHelper, buffer_queue,
                value_0, value_1, worker, consumerMutex, producerMutex, scan_wait_mutex);

            Thread producer = new Thread(peekThread.Peek);
            producer.Start();

            Thread consumer = null;
            if (isFirstScan)
            {
                consumer = new Thread(comparer_thread.ResultListOfNewScan);
            }
            else
            {
                consumer = new Thread(comparer_thread.ResultListOfNextScan);
            }
            consumer.Start();

            scan_wait_mutex.WaitOne();
            producer.Abort();
            consumer.Abort();

            worker.ReportProgress(80);

            update_result_list_view(worker, false, 80, 0.2f);
        }

        private void bwNextScan_DoWork(object sender, DoWorkEventArgs e)
        {
            long processed_memory_len = 0;
            ulong total_memory_size = processManager.MappedSectionList.TotalMemorySize + 1;
            string value_0 = txtValue.Text;
            string value_1 = txtValue2.Text;
            bwNextScan.ReportProgress(0);
            for (int section_idx = 0; section_idx < processManager.MappedSectionList.Count; ++section_idx)
            {
                if (bwNextScan.CancellationPending) break;
                MappedSection mappedSection = processManager.MappedSectionList[section_idx];
                mappedSection.UpdateResultList(processManager, memoryHelper, value_0, value_1, cbHex.Checked, false);
                if (mappedSection.Check) processed_memory_len += mappedSection.Length;
                bwNextScan.ReportProgress((int)(((float)processed_memory_len / total_memory_size) * 80));
            }
            bwNextScan.ReportProgress(80);

            update_result_list_view(bwNextScan, false, 80, 0.2f);
        }

        private void bwNewScan_DoWork(object sender, DoWorkEventArgs e)
        {
            //scan_worker_DoWorker(sender, e, true);
            long processed_memory_len = 0;
            ulong total_memory_size = processManager.MappedSectionList.TotalMemorySize + 1;
            string value_0 = txtValue.Text;
            string value_1 = txtValue2.Text;
            bwNewScan.ReportProgress(0);
            for (int section_idx = 0; section_idx < processManager.MappedSectionList.Count; ++section_idx)
            {
                if (bwNewScan.CancellationPending) break;
                MappedSection mappedSection = processManager.MappedSectionList[section_idx];
                mappedSection.UpdateResultList(processManager, memoryHelper, value_0, value_1, cbHex.Checked, true);
                if (mappedSection.Check) processed_memory_len += mappedSection.Length;
                bwNewScan.ReportProgress((int)(((float)processed_memory_len / total_memory_size) * 80));
            }
            bwNewScan.ReportProgress(80);
            update_result_list_view(bwNewScan, false, 80, 0.2f);
        }

        private void bwUpdateResult_DoWork(object sender, DoWorkEventArgs e)
        {
            update_result_list_view(bwUpdateResult, true, 0, 1.0f);
        }

        private void bwNewScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                lblMsg.Text = "Peeking memory...";
            }

            if (e.ProgressPercentage == 50)
            {
                lblMsg.Text = "Analysing memory...";
            }

            if (e.ProgressPercentage == 100)
            {
                if (e.UserState is WorkerReturn)
                {
                    update_result_list_view_ui((WorkerReturn)e.UserState);
                }
            }

            progressBar.Value = e.ProgressPercentage;
        }

        private void bwUpdateResult_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                lblMsg.Text = "Processing memory...";
            }

            if (e.ProgressPercentage == 100 && e.UserState is WorkerReturn)
            {
                update_result_list_view_ui((WorkerReturn)e.UserState);
            }

            progressBar.Value = e.ProgressPercentage;
        }

        private void dump_dialog(int sectionID)
        {
            if (sectionID >= 0)
            {
                MappedSection section = processManager.MappedSectionList[sectionID];

                sfdSaveFile.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
                sfdSaveFile.FilterIndex = 1;
                sfdSaveFile.RestoreDirectory = true;
                sfdSaveFile.FileName = (string)lstSection.Items[lstSection.SelectedIndex];

                if (sfdSaveFile.ShowDialog() == DialogResult.OK)
                {
                    byte[] buffer = memoryHelper.ReadMemory(section.Start, (int)section.Length);

                    FileStream myStream = new FileStream(sfdSaveFile.FileName, FileMode.OpenOrCreate);
                    myStream.Write(buffer, 0, buffer.Length);
                    myStream.Close();
                }
            }
        }

        private void cmsResultMenuHex_Click(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lvResult.SelectedItems;

                ulong address = ulong.Parse(lvResult.SelectedItems[0].
                    SubItems[RESULT_LIST_ADDRESS].Text, NumberStyles.HexNumber);
                int sectionID = processManager.MappedSectionList.GetMappedSectionID(address);

                if (sectionID >= 0)
                {
                    int offset = 0;

                    MappedSection section = processManager.MappedSectionList[sectionID];

                    offset = (int)(address - section.Start);
                    FrmHexEditor hexEdit = new FrmHexEditor(memoryHelper, offset, section);
                    hexEdit.Show(this);
                }
            }
        }

        private void cmsResultMenuDump_Click(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count == 1)
            {
                ulong address = ulong.Parse(lvResult.SelectedItems[0].
                    SubItems[RESULT_LIST_ADDRESS].Text, NumberStyles.HexNumber);

                int sectionID = processManager.MappedSectionList.GetMappedSectionID(address);

                dump_dialog(sectionID);
            }
        }

        private void cmsSectionMenuHex_Click(object sender, EventArgs e)
        {
            int sectionID = -1;
            int offset = 0;

            sectionID = lstSection.SelectedIndex;

            if (sectionID >= 0)
            {
                MappedSection section = processManager.MappedSectionList[sectionID];
                FrmHexEditor hexEdit = new FrmHexEditor(memoryHelper, offset, section);
                hexEdit.Show(this);
            }
        }

        private void cmsSectionMenuDump_Click(object sender, EventArgs e)
        {
            if (lstSection.SelectedIndex >= 0)
            {
                dump_dialog(lstSection.SelectedIndex);
            }
        }

        private void lstSection_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            processManager.MappedSectionList.SectionCheck(e.Index, e.NewValue == CheckState.Checked);
        }

        void add_new_row_to_cheat_list_view(Cheat cheat)
        {
            int index = this.lvCheatList.Rows.Add();

            DataGridViewRow cheat_list_view_item = lvCheatList.Rows[index];
            CheatOperator destination = cheat.GetDestination();
            CheatOperator source = cheat.GetSource();

            cheat_list_view_item.Cells[CHEAT_LIST_ADDRESS].Value = destination.Display();
            cheat_list_view_item.Cells[CHEAT_LIST_TYPE].Value = MemoryHelper.GetStringOfValueType(source.ValueType);
            cheat_list_view_item.Cells[CHEAT_LIST_VALUE].Value = source.Display();
            cheat_list_view_item.Cells[CHEAT_LIST_SECTION].Value = processManager.MappedSectionList.GetSectionName(destination.GetSectionID());
            cheat_list_view_item.Cells[CHEAT_LIST_LOCK].Value = cheat.Lock;
            cheat_list_view_item.Cells[CHEAT_LIST_DESC].Value = cheat.Description;
        }

        void new_data_cheat(ulong address, string type, string data, bool lock_, string description)
        {
            try
            {
                int sectionID = processManager.MappedSectionList.GetMappedSectionID(address);

                if (sectionID == -1)
                {
                    MessageBox.Show("Address is out of range!");
                    return;
                }

                if (cheatList.Exist(address))
                {
                    return;
                }

                ValueType valueType = MemoryHelper.GetValueTypeByString(type);

                DataCheatOperator dataCheatOperator = new DataCheatOperator(data, valueType, processManager);
                AddressCheatOperator addressCheatOperator = new AddressCheatOperator(address, processManager);

                DataCheat dataCheat = new DataCheat(dataCheatOperator, addressCheatOperator, lock_, description, processManager);
                add_new_row_to_cheat_list_view(dataCheat);
                cheatList.Add(dataCheat);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void new_pointer_cheat(ulong address, List<long> offset_list, string type, string data, bool lock_, string description)
        {
            try
            {
                int sectionID = processManager.MappedSectionList.GetMappedSectionID(address);

                if (sectionID == -1)
                {
                    MessageBox.Show("Address is out of range!");
                    return;
                }

                if (cheatList.Exist(address))
                {
                    return;
                }

                ValueType valueType = MemoryHelper.GetValueTypeByString(type);

                DataCheatOperator sourceOperator = new DataCheatOperator(data, valueType, processManager);
                AddressCheatOperator addressCheatOperator = new AddressCheatOperator(address, processManager);
                List<OffsetCheatOperator> offsetOperators = new List<OffsetCheatOperator>();

                for (int i = 0; i < offset_list.Count; ++i)
                {
                    OffsetCheatOperator offsetOperator = new OffsetCheatOperator(offset_list[i],
                        ValueType.ULONG_TYPE, processManager);
                    offsetOperators.Add(offsetOperator);
                }

                SimplePointerCheatOperator destOperator = new SimplePointerCheatOperator(addressCheatOperator, offsetOperators, valueType, processManager);

                SimplePointerCheat simplePointerCheat = new SimplePointerCheat(sourceOperator, destOperator,
                    lock_, description, processManager);

                add_new_row_to_cheat_list_view(simplePointerCheat);
                cheatList.Add(simplePointerCheat);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void add_to_cheat_list(ListViewItem item)
        {
            string address = item.SubItems[RESULT_LIST_ADDRESS].Text;
            string type = item.SubItems[RESULT_LIST_TYPE].Text;
            string value = item.SubItems[RESULT_LIST_VALUE].Text;
            bool lock_ = false;
            string description = "";

            new_data_cheat(ulong.Parse(address, NumberStyles.HexNumber), type, value, lock_, description);
        }

        private void lvResult_DoubleClick(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lvResult.SelectedItems;
                add_to_cheat_list(items[0]);
            }
        }

        private void lvCheatList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow edited_row = lvCheatList.Rows[e.RowIndex];
            object edited_col = edited_row.Cells[e.ColumnIndex].Value;

            switch (e.ColumnIndex)
            {
                case CHEAT_LIST_VALUE:
                    DataCheatOperator dataCheatOperator = (DataCheatOperator)cheatList[e.RowIndex].GetSource();
                    CheatOperator destOperator = cheatList[e.RowIndex].GetDestination();
                    dataCheatOperator.Set((string)edited_col);
                    destOperator.SetRuntime(dataCheatOperator);
                    break;
                case CHEAT_LIST_DESC:
                    cheatList[e.RowIndex].Description = (string)edited_col;
                    break;
            }
        }

        private void lvCheatList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            DataGridViewRow edited_row = lvCheatList.Rows[e.RowIndex];
            object edited_col = null;

            switch (e.ColumnIndex)
            {
                case CHEAT_LIST_ENABLED:
                    lvCheatList.EndEdit();
                    DataCheatOperator dataCheatOperator = (DataCheatOperator)cheatList[e.RowIndex].GetSource();
                    CheatOperator destOperator = cheatList[e.RowIndex].GetDestination();
                    edited_col = edited_row.Cells[CHEAT_LIST_VALUE].Value;
                    dataCheatOperator.Set((string)edited_col);
                    destOperator.SetRuntime(dataCheatOperator);
                    break;
                case CHEAT_LIST_DEL:
                    lvCheatList.Rows.RemoveAt(e.RowIndex);
                    break;
                case CHEAT_LIST_LOCK:
                    lvCheatList.EndEdit();
                    edited_col = edited_row.Cells[e.ColumnIndex].Value;
                    cheatList[e.RowIndex].Lock = (bool)edited_col;
                    break;
            }
        }

        private void btnNewCheat_Click(object sender, EventArgs e)
        {
            FrmNewAddress newAddress = new FrmNewAddress(processManager);
            if (newAddress.ShowDialog() != DialogResult.OK)
                return;

            ulong address = newAddress.Address;
            string value_type = newAddress.ValueTypeStr;
            string value = newAddress.Value;
            bool lock_ = newAddress.Lock;
            string description = newAddress.Descriptioin;

            int sectionID = processManager.MappedSectionList.GetMappedSectionID(address);

            if (sectionID < 0)
            {
                MessageBox.Show("Invalid Address!!");
                return;
            }

            if (!newAddress.Pointer)
            {
                new_data_cheat(address, value_type, value, lock_, description);
            }
            else
            {
                new_pointer_cheat(address, newAddress.OffsetList, value_type, value, lock_, description);
            }
        }

        private void lvCheatList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cheatList.RemoveAt(e.RowIndex);
            }
        }

        private void btnSaveCheat_Click(object sender, EventArgs e)
        {
            sfdSaveFile.Filter = "Cheat files (*.cht)|*.cht";
            sfdSaveFile.FilterIndex = 1;
            sfdSaveFile.RestoreDirectory = true;

            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                cheatList.SaveFile(sfdSaveFile.FileName, (string)cmbProcesses.SelectedItem, processManager);
            }
        }

        private void btnLoadCheat_Click(object sender, EventArgs e)
        {
            ofdOpenFile.Filter = "Cheat files (*.cht)|*.cht";
            ofdOpenFile.FilterIndex = 1;
            ofdOpenFile.RestoreDirectory = true;

            if (ofdOpenFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            lvCheatList.Rows.Clear();
            cheatList.LoadFile(ofdOpenFile.FileName, processManager, cmbProcesses);

            for (int i = 0; i < cheatList.Count; ++i)
            {
                Cheat cheat = cheatList[i];
                if (cheat.CheatType == CheatType.DATA_TYPE)
                {
                    add_new_row_to_cheat_list_view((DataCheat)cheat);
                }
                else if (cheat.CheatType == CheatType.SIMPLE_POINTER_TYPE)
                {
                    add_new_row_to_cheat_list_view((SimplePointerCheat)cheat);
                }
            }
        }

        private void btnRefreshCheat_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < cheatList.Count; ++i)
                {
                    DataGridViewRow row = lvCheatList.Rows[i];

                    DataCheatOperator dataCheatOperator = (DataCheatOperator)cheatList[i].GetSource();
                    CheatOperator destOperator = cheatList[i].GetDestination();
                    dataCheatOperator.Set(destOperator.GetRuntime());
                    row.Cells[CHEAT_LIST_VALUE].Value = dataCheatOperator.Display();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void timeRefreshLock_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < cheatList.Count; ++i)
            {
                if (!cheatList[i].Lock)
                {
                    continue;
                }

                DataCheatOperator dataCheatOperator = (DataCheatOperator)cheatList[i].GetSource();
                CheatOperator destOperator = cheatList[i].GetDestination();
                destOperator.SetRuntime(dataCheatOperator);
            }
        }

        private void cmbProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstSection.Items.Clear();
                lvResult.Items.Clear();
                btnNewScan.Enabled = true;
                cbValueTypeList.Enabled = true;
                cbCompareTypeList.Enabled = true;
                lstSection.Enabled = true;

                ProcessInfo processInfo = processManager.GetProcessInfo(cmbProcesses.Text);
                Util.DefaultProcessID = processInfo.pid;
                processManager.MappedSectionList.InitMemorySectionList(processInfo);

                lstSection.BeginUpdate();
                for (int i = 0; i < processManager.MappedSectionList.Count; ++i)
                {
                    lstSection.Items.Add(processManager.MappedSectionList.GetSectionName(i), false);
                }
                lstSection.EndUpdate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRefreshProcess_Click(object sender, EventArgs e)
        {
            try
            {
                btnRefreshProcess.Enabled = false;
                Cursor = Cursors.WaitCursor;

                int index = 0;

                MemoryHelper.Connect(txtIpAddress.Text, true);

                this.cmbProcesses.Items.Clear();
                ProcessList pl = MemoryHelper.GetProcessList();

                if (pl != null)
                {
                    int i = 0;
                    foreach (Process process in pl.processes)
                    {
                        this.cmbProcesses.Items.Add(process.name);
                        if (process.name.Contains("eboot.bin"))
                            index = i;
                    }

                    this.cmbProcesses.SelectedIndex = index;
                }
                this.cmbProcesses.SelectedIndex = -1;
                MessageBox.Show(this, "Cannot connect to PS4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                btnRefreshProcess.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void send_pay_load(string IP, string payloadPath, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
            socket.SendFile(payloadPath);
            socket.Close();
        }

        private void btnSendPayload_Click(object sender, EventArgs e)
        {
            try
            {
                btnSendPayload.Enabled = false;
                Cursor = Cursors.WaitCursor;

                string patch_path = Application.StartupPath;

               // this.lblMsg.ForeColor = Color.White;
                this.lblMsg.Text = "Injecting payload.bin...";
                Thread.Sleep(100);
                this.send_pay_load(this.txtIpAddress.Text, patch_path + @"payload.bin", 9020);
                Thread.Sleep(1000);
                this.lblMsg.Text = "Injecting kpayload.elf...";
                Thread.Sleep(100);
                this.send_pay_load(this.txtIpAddress.Text, patch_path + @"kpayload.elf", 9023);
                Thread.Sleep(2500);
                this.lblMsg.ForeColor = Color.Green;
                this.lblMsg.Text = "Payload injected successfully!";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                this.lblMsg.Text = "";
                btnSendPayload.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void InitCompareTypeListOfFirstScan()
        {
            string selected_type = (string)cbCompareTypeList.SelectedItem;
            cbCompareTypeList.Items.Clear();
            switch (MemoryHelper.GetValueTypeByString((string)cbValueTypeList.SelectedItem))
            {
                case ValueType.ULONG_TYPE:
                case ValueType.UINT_TYPE:
                case ValueType.USHORT_TYPE:
                case ValueType.BYTE_TYPE:
                    cbHex.Enabled = true;
                    cbCompareTypeList.Items.AddRange(SEARCH_BY_BYTES_FIRST);
                    break;
                case ValueType.DOUBLE_TYPE:
                case ValueType.FLOAT_TYPE:
                    cbHex.Enabled = true;
                    cbCompareTypeList.Items.AddRange(SEARCH_BY_FLOAT_FIRST);
                    break;
                case ValueType.HEX_TYPE:
                case ValueType.STRING_TYPE:
                    cbHex.Enabled = false;
                    cbHex.Checked = false;
                    cbCompareTypeList.Items.AddRange(SEARCH_BY_HEX);
                    break;
                default:
                    throw new Exception("GetStringOfValueType!!!");
            }

            int list_idx = 0;
            int list_count = cbCompareTypeList.Items.Count;

            for (; list_idx < list_count; ++list_idx)
            {
                if ((string)cbCompareTypeList.Items[list_idx] == selected_type)
                {
                    break;
                }
            }

            cbCompareTypeList.SelectedIndex = list_idx == list_count ? 0 : list_idx;
        }

        private void InitCompareTypeListOfNextScan()
        {
            string selected_type = (string)cbCompareTypeList.SelectedItem;
            cbCompareTypeList.Items.Clear();
            switch (MemoryHelper.GetValueTypeByString((string)cbValueTypeList.SelectedItem))
            {
                case ValueType.ULONG_TYPE:
                case ValueType.UINT_TYPE:
                case ValueType.USHORT_TYPE:
                case ValueType.BYTE_TYPE:
                    cbCompareTypeList.Items.AddRange(SEARCH_BY_BYTES_NEXT);
                    break;
                case ValueType.DOUBLE_TYPE:
                case ValueType.FLOAT_TYPE:
                    cbCompareTypeList.Items.AddRange(SEARCH_BY_FLOAT_NEXT);
                    break;
                case ValueType.HEX_TYPE:
                case ValueType.STRING_TYPE:
                    cbCompareTypeList.Items.AddRange(SEARCH_BY_HEX);
                    break;
                default:
                    throw new Exception("GetStringOfValueType!!!");
            }

            int list_idx = 0;
            int list_count = cbCompareTypeList.Items.Count;

            for (; list_idx < list_count; ++list_idx)
            {
                if ((string)cbCompareTypeList.Items[list_idx] == selected_type)
                {
                    break;
                }
            }

            cbCompareTypeList.SelectedIndex = list_idx == list_count ? 0 : list_idx;
        }

        private void cbValueTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitCompareTypeListOfFirstScan();
        }

        private void cbCompareTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbCompareTypeList.SelectedItem == CONSTANT.BETWEEN_VALUE)
            {
                txtValue2.Visible = true;
                value_label.Visible = true;
                and_label.Visible = true;
               // txtValue.Width = 87;
            }
            else
            {
                txtValue2.Visible = false;
                value_label.Visible = false;
                and_label.Visible = false;
                //txtValue.Width = 210;
            }
        }

        private void bwNewScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnNewScan.Text = CONSTANT.NEW_SCAN;
            InitCompareTypeListOfNextScan();
            if (e.Error != null)
            {
                lblMsg.Text = e.Error.Message;
            }
            setButtons(true);
        }

        private void bwUpdateResult_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnRefresh.Text = CONSTANT.REFRESH;
            if (e.Error != null)
            {
                lblMsg.Text = e.Error.Message;
            }
            setButtons(true);
        }

        private void bwNextScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnNextScan.Text = CONSTANT.NEXT_SCAN;
            if (e.Error != null)
            {
                lblMsg.Text = e.Error.Message;
            }
            setButtons(true);
        }

        private void cmsResultMenuAdd_Click(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems == null)
                return;

            ListView.SelectedListViewItemCollection items = lvResult.SelectedItems;
            for (int i = 0; i < items.Count; ++i)
            {
                add_to_cheat_list(items[i]);
            }
        }

        private void cmsCheatListActive_Click(object sender, EventArgs e)
        {
            if (lvCheatList.SelectedRows == null)
                return;

            DataGridViewSelectedRowCollection items = lvCheatList.SelectedRows;
            for (int i = 0; i < items.Count; ++i)
            {
                Cheat cheat = cheatList[items[i].Index];

                cheat.GetDestination().SetRuntime(cheat.GetSource());
            }
        }

        private void cmsCheatListDelete_Click(object sender, EventArgs e)
        {
            if (lvCheatList.SelectedRows == null)
                return;

            DataGridViewSelectedRowCollection items = lvCheatList.SelectedRows;
            for (int i = 0; i < items.Count; ++i)
            {
                lvCheatList.Rows.Remove(items[i]);
            }
        }

        private void cmsCheatListLock_Click(object sender, EventArgs e)
        {
            if (lvCheatList.SelectedRows == null)
                return;

            DataGridViewSelectedRowCollection items = lvCheatList.SelectedRows;
            for (int i = 0; i < items.Count; ++i)
            {
                cheatList[items[i].Index].Lock = true;
                items[i].Cells[CHEAT_LIST_LOCK].Value = true;
            }
        }

        private void cmsCheatListUnlock_Click(object sender, EventArgs e)
        {
            if (lvCheatList.SelectedRows == null)
                return;

            DataGridViewSelectedRowCollection items = lvCheatList.SelectedRows;
            for (int i = 0; i < items.Count; ++i)
            {
                cheatList[items[i].Index].Lock = false;
                items[i].Cells[CHEAT_LIST_LOCK].Value = false;
            }
        }

        private void cmsCheatListHex_Click(object sender, EventArgs e)
        {
            if (lvCheatList.SelectedRows == null)
                return;

            if (lvCheatList.SelectedRows.Count != 1)
                return;

            DataGridViewSelectedRowCollection items = lvCheatList.SelectedRows;

            ulong address = ulong.Parse((string)items[0].Cells[CHEAT_LIST_ADDRESS].Value, NumberStyles.HexNumber);
            int sectionID = processManager.MappedSectionList.GetMappedSectionID(address);

            if (sectionID >= 0)
            {
                int offset = 0;

                MappedSection section = processManager.MappedSectionList[sectionID];

                offset = (int)(address - section.Start);
                FrmHexEditor hexEdit = new FrmHexEditor(memoryHelper, offset, section);
                hexEdit.Show(this);
            }
        }

        private void cmsCheatListFindPointer_Click(object sender, EventArgs e)
        {
            if (lvCheatList.SelectedRows == null)
                return;

            if (lvCheatList.SelectedRows.Count != 1)
                return;

            DataGridViewSelectedRowCollection items = lvCheatList.SelectedRows;

            try
            {
                ulong address = ulong.Parse((string)items[0].Cells[CHEAT_LIST_ADDRESS].Value, NumberStyles.HexNumber);
                string type = (string)items[0].Cells[CHEAT_LIST_TYPE].Value;

                FrmPointerFinder pointerFinder = new FrmPointerFinder(this, address, type, processManager, lvCheatList);
                pointerFinder.Show();
            }
            catch
            {

            }
        }
    }
}
