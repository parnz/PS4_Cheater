using System.ComponentModel;
using System.Windows.Forms;

namespace PS4_Cheater
{
    partial class FrmMain1
    {
        private ColumnHeader result_list_view_value;
        private ColumnHeader result_list_view_section;
        private Button btnRefreshCheat;
        private Button btnLoadCheat;
        private ColumnHeader result_list_view_hex;
        private Button btnSaveCheat;
        private Button btnNewCheat;
        private DataGridView lvCheatList;
        private CheckedListBox lstSection;
        private ContextMenuStrip cmsSectionMenu;
        private ToolStripMenuItem cmsSectionMenuHex;
        private ToolStripMenuItem cmsSectionMenuDump;
        private TextBox txtValue;
        private Timer timeRefreshLock;
        private SaveFileDialog sfdSaveFile;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer4;
        private ListView lvResult;
        private ColumnHeader result_list_view_address;
        private ColumnHeader result_list_view_type;
        private SplitContainer splitContainer2;
        private ComboBox cmbProcesses;
        private TextBox txtIpAddress;
        private TextBox txtPort;
        private Button btnSendPayload;
        private Button btnRefreshProcess;
        private Label lblMsg;
        private CheckBox cbSelectAll;
        private ProgressBar progressBar;
        private ComboBox cbCompareTypeList;
        private ComboBox cbValueTypeList;
        private Label label4;
        private Button btnNextScan;
        private Button btnNewScan;
        private Button btnRefresh;
        private BackgroundWorker bwNewScan;
        private BackgroundWorker bwNextScan;
        private OpenFileDialog ofdOpenFile;
        private Panel parent;
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.parent = new System.Windows.Forms.Panel();
            this.result_list_view_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshCheat = new System.Windows.Forms.Button();
            this.btnLoadCheat = new System.Windows.Forms.Button();
            this.result_list_view_hex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveCheat = new System.Windows.Forms.Button();
            this.btnNewCheat = new System.Windows.Forms.Button();
            this.lvCheatList = new System.Windows.Forms.DataGridView();
            this.cheat_list_view_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cheat_list_view_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_active = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cheat_list_view_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_lock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cheat_list_view_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsCheatListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCheatListHex = new System.Windows.Forms.ToolStripMenuItem();
            this.cheat_list_item_separator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCheatListLock = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCheatListUnlock = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCheatListActive = new System.Windows.Forms.ToolStripMenuItem();
            this.cheat_list_item_separator_0 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCheatListFindPointer = new System.Windows.Forms.ToolStripMenuItem();
            this.cheat_list_item_separator_2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCheatListDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lstSection = new System.Windows.Forms.CheckedListBox();
            this.cmsSectionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSectionMenuHex = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSectionMenuDump = new System.Windows.Forms.ToolStripMenuItem();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.timeRefreshLock = new System.Windows.Forms.Timer(this.components);
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lvResult = new System.Windows.Forms.ListView();
            this.result_list_view_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsResultMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsResultMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.result_list_view_separator = new System.Windows.Forms.ToolStripSeparator();
            this.cmsResultMenuHex = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsResultMenuDump = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProcesses = new System.Windows.Forms.ComboBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnSendPayload = new System.Windows.Forms.Button();
            this.btnRefreshProcess = new System.Windows.Forms.Button();
            this.cbHex = new System.Windows.Forms.CheckBox();
            this.cbAlignment = new System.Windows.Forms.CheckBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            this.and_label = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cbCompareTypeList = new System.Windows.Forms.ComboBox();
            this.cbValueTypeList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNextScan = new System.Windows.Forms.Button();
            this.btnNewScan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bwNewScan = new System.ComponentModel.BackgroundWorker();
            this.bwNextScan = new System.ComponentModel.BackgroundWorker();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.bwUpdateResult = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.lvCheatList)).BeginInit();
            this.cmsCheatListMenu.SuspendLayout();
            this.cmsSectionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.cmsResultMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // parent
            // 
            this.parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent.Location = new System.Drawing.Point(0, 0);
            this.parent.Name = "parent";
            this.parent.Size = new System.Drawing.Size(1015, 671);
            this.parent.TabIndex = 11;
            // 
            // result_list_view_value
            // 
            this.result_list_view_value.Text = "Value";
            this.result_list_view_value.Width = 120;
            // 
            // result_list_view_section
            // 
            this.result_list_view_section.Text = "Section";
            this.result_list_view_section.Width = 180;
            // 
            // btnRefreshCheat
            // 
            this.btnRefreshCheat.Location = new System.Drawing.Point(179, 2);
            this.btnRefreshCheat.Name = "btnRefreshCheat";
            this.btnRefreshCheat.Size = new System.Drawing.Size(165, 27);
            this.btnRefreshCheat.TabIndex = 31;
            this.btnRefreshCheat.TabStop = false;
            this.btnRefreshCheat.Text = "Refresh";
            this.btnRefreshCheat.Click += new System.EventHandler(this.btnRefreshCheat_Click);
            // 
            // btnLoadCheat
            // 
            this.btnLoadCheat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnLoadCheat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLoadCheat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoadCheat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.btnLoadCheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCheat.ForeColor = System.Drawing.Color.White;
            this.btnLoadCheat.Location = new System.Drawing.Point(521, 2);
            this.btnLoadCheat.Name = "btnLoadCheat";
            this.btnLoadCheat.Size = new System.Drawing.Size(165, 27);
            this.btnLoadCheat.TabIndex = 33;
            this.btnLoadCheat.TabStop = false;
            this.btnLoadCheat.Text = "Load";
            this.btnLoadCheat.UseMnemonic = false;
            this.btnLoadCheat.UseVisualStyleBackColor = false;
            this.btnLoadCheat.Click += new System.EventHandler(this.btnLoadCheat_Click);
            // 
            // result_list_view_hex
            // 
            this.result_list_view_hex.Text = "Hex";
            this.result_list_view_hex.Width = 120;
            // 
            // btnSaveCheat
            // 
            this.btnSaveCheat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSaveCheat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSaveCheat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaveCheat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.btnSaveCheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCheat.ForeColor = System.Drawing.Color.White;
            this.btnSaveCheat.Location = new System.Drawing.Point(350, 2);
            this.btnSaveCheat.Name = "btnSaveCheat";
            this.btnSaveCheat.Size = new System.Drawing.Size(165, 27);
            this.btnSaveCheat.TabIndex = 32;
            this.btnSaveCheat.TabStop = false;
            this.btnSaveCheat.Text = "Save";
            this.btnSaveCheat.UseMnemonic = false;
            this.btnSaveCheat.UseVisualStyleBackColor = false;
            this.btnSaveCheat.Click += new System.EventHandler(this.btnSaveCheat_Click);
            // 
            // btnNewCheat
            // 
            this.btnNewCheat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnNewCheat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNewCheat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNewCheat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.btnNewCheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCheat.ForeColor = System.Drawing.Color.White;
            this.btnNewCheat.Location = new System.Drawing.Point(12, 2);
            this.btnNewCheat.Name = "btnNewCheat";
            this.btnNewCheat.Size = new System.Drawing.Size(158, 27);
            this.btnNewCheat.TabIndex = 30;
            this.btnNewCheat.TabStop = false;
            this.btnNewCheat.Text = "New";
            this.btnNewCheat.UseMnemonic = false;
            this.btnNewCheat.UseVisualStyleBackColor = false;
            this.btnNewCheat.Click += new System.EventHandler(this.btnNewCheat_Click);
            // 
            // lvCheatList
            // 
            this.lvCheatList.AllowUserToAddRows = false;
            this.lvCheatList.AllowUserToResizeRows = false;
            this.lvCheatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCheatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvCheatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cheat_list_view_del,
            this.cheat_list_view_address,
            this.cheat_list_view_type,
            this.cheat_list_view_active,
            this.cheat_list_view_value,
            this.cheat_list_view_section,
            this.cheat_list_view_lock,
            this.cheat_list_view_description});
            this.lvCheatList.ContextMenuStrip = this.cmsCheatListMenu;
            this.lvCheatList.Location = new System.Drawing.Point(0, 39);
            this.lvCheatList.Name = "lvCheatList";
            this.lvCheatList.RowHeadersVisible = false;
            this.lvCheatList.RowTemplate.Height = 23;
            this.lvCheatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvCheatList.Size = new System.Drawing.Size(705, 277);
            this.lvCheatList.TabIndex = 50;
            this.lvCheatList.TabStop = false;
            this.lvCheatList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvCheatList_CellClick);
            this.lvCheatList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvCheatList_CellEndEdit);
            this.lvCheatList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.lvCheatList_RowsRemoved);
            // 
            // cheat_list_view_del
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Delete";
            this.cheat_list_view_del.DefaultCellStyle = dataGridViewCellStyle3;
            this.cheat_list_view_del.HeaderText = "Delete";
            this.cheat_list_view_del.Name = "cheat_list_view_del";
            this.cheat_list_view_del.Width = 50;
            // 
            // cheat_list_view_address
            // 
            this.cheat_list_view_address.HeaderText = "Address";
            this.cheat_list_view_address.Name = "cheat_list_view_address";
            this.cheat_list_view_address.ReadOnly = true;
            this.cheat_list_view_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cheat_list_view_type
            // 
            this.cheat_list_view_type.HeaderText = "Type";
            this.cheat_list_view_type.Name = "cheat_list_view_type";
            this.cheat_list_view_type.ReadOnly = true;
            this.cheat_list_view_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cheat_list_view_active
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "X";
            this.cheat_list_view_active.DefaultCellStyle = dataGridViewCellStyle4;
            this.cheat_list_view_active.HeaderText = "X";
            this.cheat_list_view_active.Name = "cheat_list_view_active";
            this.cheat_list_view_active.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cheat_list_view_active.Text = "X";
            this.cheat_list_view_active.Width = 25;
            // 
            // cheat_list_view_value
            // 
            this.cheat_list_view_value.HeaderText = "Value";
            this.cheat_list_view_value.Name = "cheat_list_view_value";
            this.cheat_list_view_value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cheat_list_view_section
            // 
            this.cheat_list_view_section.HeaderText = "Section";
            this.cheat_list_view_section.Name = "cheat_list_view_section";
            this.cheat_list_view_section.ReadOnly = true;
            this.cheat_list_view_section.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cheat_list_view_lock
            // 
            this.cheat_list_view_lock.HeaderText = "Lock";
            this.cheat_list_view_lock.Name = "cheat_list_view_lock";
            this.cheat_list_view_lock.Width = 35;
            // 
            // cheat_list_view_description
            // 
            this.cheat_list_view_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cheat_list_view_description.HeaderText = "Description";
            this.cheat_list_view_description.Name = "cheat_list_view_description";
            this.cheat_list_view_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsCheatListMenu
            // 
            this.cmsCheatListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCheatListHex,
            this.cheat_list_item_separator_1,
            this.cmsCheatListLock,
            this.cmsCheatListUnlock,
            this.cmsCheatListActive,
            this.cheat_list_item_separator_0,
            this.cmsCheatListFindPointer,
            this.cheat_list_item_separator_2,
            this.cmsCheatListDelete});
            this.cmsCheatListMenu.Name = "cheat_list_menu";
            this.cmsCheatListMenu.Size = new System.Drawing.Size(139, 154);
            // 
            // cmsCheatListHex
            // 
            this.cmsCheatListHex.Name = "cmsCheatListHex";
            this.cmsCheatListHex.Size = new System.Drawing.Size(138, 22);
            this.cmsCheatListHex.Text = "Hex Editor";
            this.cmsCheatListHex.Click += new System.EventHandler(this.cmsCheatListHex_Click);
            // 
            // cheat_list_item_separator_1
            // 
            this.cheat_list_item_separator_1.Name = "cheat_list_item_separator_1";
            this.cheat_list_item_separator_1.Size = new System.Drawing.Size(135, 6);
            // 
            // cmsCheatListLock
            // 
            this.cmsCheatListLock.Name = "cmsCheatListLock";
            this.cmsCheatListLock.Size = new System.Drawing.Size(138, 22);
            this.cmsCheatListLock.Text = "Lock";
            this.cmsCheatListLock.Click += new System.EventHandler(this.cmsCheatListLock_Click);
            // 
            // cmsCheatListUnlock
            // 
            this.cmsCheatListUnlock.Name = "cmsCheatListUnlock";
            this.cmsCheatListUnlock.Size = new System.Drawing.Size(138, 22);
            this.cmsCheatListUnlock.Text = "Unlock";
            this.cmsCheatListUnlock.Click += new System.EventHandler(this.cmsCheatListUnlock_Click);
            // 
            // cmsCheatListActive
            // 
            this.cmsCheatListActive.Name = "cmsCheatListActive";
            this.cmsCheatListActive.Size = new System.Drawing.Size(138, 22);
            this.cmsCheatListActive.Text = "Active";
            this.cmsCheatListActive.Click += new System.EventHandler(this.cmsCheatListActive_Click);
            // 
            // cheat_list_item_separator_0
            // 
            this.cheat_list_item_separator_0.Name = "cheat_list_item_separator_0";
            this.cheat_list_item_separator_0.Size = new System.Drawing.Size(135, 6);
            // 
            // cmsCheatListFindPointer
            // 
            this.cmsCheatListFindPointer.Name = "cmsCheatListFindPointer";
            this.cmsCheatListFindPointer.Size = new System.Drawing.Size(138, 22);
            this.cmsCheatListFindPointer.Text = "Find Pointer";
            this.cmsCheatListFindPointer.Click += new System.EventHandler(this.cmsCheatListFindPointer_Click);
            // 
            // cheat_list_item_separator_2
            // 
            this.cheat_list_item_separator_2.Name = "cheat_list_item_separator_2";
            this.cheat_list_item_separator_2.Size = new System.Drawing.Size(135, 6);
            // 
            // cmsCheatListDelete
            // 
            this.cmsCheatListDelete.Name = "cmsCheatListDelete";
            this.cmsCheatListDelete.Size = new System.Drawing.Size(138, 22);
            this.cmsCheatListDelete.Text = "Delete";
            this.cmsCheatListDelete.Click += new System.EventHandler(this.cmsCheatListDelete_Click);
            // 
            // lstSection
            // 
            this.lstSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSection.CheckOnClick = true;
            this.lstSection.ContextMenuStrip = this.cmsSectionMenu;
            this.lstSection.FormattingEnabled = true;
            this.lstSection.HorizontalScrollbar = true;
            this.lstSection.Location = new System.Drawing.Point(10, 3);
            this.lstSection.Name = "lstSection";
            this.lstSection.Size = new System.Drawing.Size(286, 214);
            this.lstSection.TabIndex = 7;
            this.lstSection.TabStop = false;
            this.lstSection.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSection_ItemCheck);
            // 
            // cmsSectionMenu
            // 
            this.cmsSectionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSectionMenuHex,
            this.cmsSectionMenuDump});
            this.cmsSectionMenu.Name = "section_list_boxMenu";
            this.cmsSectionMenu.Size = new System.Drawing.Size(129, 48);
            // 
            // cmsSectionMenuHex
            // 
            this.cmsSectionMenuHex.Name = "cmsSectionMenuHex";
            this.cmsSectionMenuHex.Size = new System.Drawing.Size(128, 22);
            this.cmsSectionMenuHex.Text = "Hex Editor";
            this.cmsSectionMenuHex.Click += new System.EventHandler(this.cmsSectionMenuHex_Click);
            // 
            // cmsSectionMenuDump
            // 
            this.cmsSectionMenuDump.Name = "cmsSectionMenuDump";
            this.cmsSectionMenuDump.Size = new System.Drawing.Size(128, 22);
            this.cmsSectionMenuDump.Text = "Dump";
            this.cmsSectionMenuDump.Click += new System.EventHandler(this.cmsSectionMenuDump_Click);
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.ForeColor = System.Drawing.Color.White;
            this.txtValue.Location = new System.Drawing.Point(51, 293);
            this.txtValue.MaxLength = 500;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 10;
            this.txtValue.Text = "0";
            // 
            // timeRefreshLock
            // 
            this.timeRefreshLock.Enabled = true;
            this.timeRefreshLock.Interval = 500;
            this.timeRefreshLock.Tick += new System.EventHandler(this.timeRefreshLock_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 671);
            this.splitContainer1.SplitterDistance = 705;
            this.splitContainer1.TabIndex = 47;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lvResult);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnRefreshCheat);
            this.splitContainer4.Panel2.Controls.Add(this.btnLoadCheat);
            this.splitContainer4.Panel2.Controls.Add(this.btnSaveCheat);
            this.splitContainer4.Panel2.Controls.Add(this.btnNewCheat);
            this.splitContainer4.Panel2.Controls.Add(this.lvCheatList);
            this.splitContainer4.Size = new System.Drawing.Size(705, 671);
            this.splitContainer4.SplitterDistance = 350;
            this.splitContainer4.TabIndex = 0;
            this.splitContainer4.TabStop = false;
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.result_list_view_address,
            this.result_list_view_type,
            this.result_list_view_value,
            this.result_list_view_hex,
            this.result_list_view_section});
            this.lvResult.ContextMenuStrip = this.cmsResultMenu;
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResult.Location = new System.Drawing.Point(0, 0);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(705, 350);
            this.lvResult.TabIndex = 16;
            this.lvResult.TabStop = false;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.DoubleClick += new System.EventHandler(this.lvResult_DoubleClick);
            // 
            // result_list_view_address
            // 
            this.result_list_view_address.Text = "Address";
            this.result_list_view_address.Width = 120;
            // 
            // result_list_view_type
            // 
            this.result_list_view_type.Text = "Type";
            this.result_list_view_type.Width = 120;
            // 
            // cmsResultMenu
            // 
            this.cmsResultMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsResultMenuAdd,
            this.result_list_view_separator,
            this.cmsResultMenuHex,
            this.cmsResultMenuDump});
            this.cmsResultMenu.Name = "result_list_menu";
            this.cmsResultMenu.Size = new System.Drawing.Size(166, 76);
            // 
            // cmsResultMenuAdd
            // 
            this.cmsResultMenuAdd.Name = "cmsResultMenuAdd";
            this.cmsResultMenuAdd.Size = new System.Drawing.Size(165, 22);
            this.cmsResultMenuAdd.Text = "Add to Cheat List";
            this.cmsResultMenuAdd.Click += new System.EventHandler(this.cmsResultMenuAdd_Click);
            // 
            // result_list_view_separator
            // 
            this.result_list_view_separator.Name = "result_list_view_separator";
            this.result_list_view_separator.Size = new System.Drawing.Size(162, 6);
            // 
            // cmsResultMenuHex
            // 
            this.cmsResultMenuHex.Name = "cmsResultMenuHex";
            this.cmsResultMenuHex.Size = new System.Drawing.Size(165, 22);
            this.cmsResultMenuHex.Text = "Hex Editor";
            this.cmsResultMenuHex.Click += new System.EventHandler(this.cmsResultMenuHex_Click);
            // 
            // cmsResultMenuDump
            // 
            this.cmsResultMenuDump.Name = "cmsResultMenuDump";
            this.cmsResultMenuDump.Size = new System.Drawing.Size(165, 22);
            this.cmsResultMenuDump.Text = "Dump";
            this.cmsResultMenuDump.Click += new System.EventHandler(this.cmsResultMenuDump_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.cmbProcesses);
            this.splitContainer2.Panel1.Controls.Add(this.txtIpAddress);
            this.splitContainer2.Panel1.Controls.Add(this.txtPort);
            this.splitContainer2.Panel1.Controls.Add(this.btnSendPayload);
            this.splitContainer2.Panel1.Controls.Add(this.btnRefreshProcess);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtValue);
            this.splitContainer2.Panel2.Controls.Add(this.cbHex);
            this.splitContainer2.Panel2.Controls.Add(this.cbAlignment);
            this.splitContainer2.Panel2.Controls.Add(this.txtValue2);
            this.splitContainer2.Panel2.Controls.Add(this.value_label);
            this.splitContainer2.Panel2.Controls.Add(this.and_label);
            this.splitContainer2.Panel2.Controls.Add(this.lstSection);
            this.splitContainer2.Panel2.Controls.Add(this.lblMsg);
            this.splitContainer2.Panel2.Controls.Add(this.cbSelectAll);
            this.splitContainer2.Panel2.Controls.Add(this.progressBar);
            this.splitContainer2.Panel2.Controls.Add(this.cbCompareTypeList);
            this.splitContainer2.Panel2.Controls.Add(this.cbValueTypeList);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.btnNextScan);
            this.splitContainer2.Panel2.Controls.Add(this.btnNewScan);
            this.splitContainer2.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer2.Size = new System.Drawing.Size(306, 671);
            this.splitContainer2.SplitterDistance = 121;
            this.splitContainer2.TabIndex = 47;
            this.splitContainer2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PS4 IP Address:";
            // 
            // cmbProcesses
            // 
            this.cmbProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cmbProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProcesses.ForeColor = System.Drawing.Color.White;
            this.cmbProcesses.FormattingEnabled = true;
            this.cmbProcesses.Location = new System.Drawing.Point(10, 62);
            this.cmbProcesses.Name = "cmbProcesses";
            this.cmbProcesses.Size = new System.Drawing.Size(277, 21);
            this.cmbProcesses.TabIndex = 6;
            this.cmbProcesses.TabStop = false;
            this.cmbProcesses.SelectedIndexChanged += new System.EventHandler(this.cmbProcesses_SelectedIndexChanged);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIpAddress.ForeColor = System.Drawing.Color.White;
            this.txtIpAddress.Location = new System.Drawing.Point(99, 7);
            this.txtIpAddress.MaxLength = 15;
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(93, 20);
            this.txtIpAddress.TabIndex = 1;
            this.txtIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.Location = new System.Drawing.Point(233, 7);
            this.txtPort.MaxLength = 4;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(43, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.TabStop = false;
            this.txtPort.Text = "9020";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendPayload
            // 
            this.btnSendPayload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendPayload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSendPayload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSendPayload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSendPayload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.btnSendPayload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPayload.ForeColor = System.Drawing.Color.White;
            this.btnSendPayload.Location = new System.Drawing.Point(10, 33);
            this.btnSendPayload.Name = "btnSendPayload";
            this.btnSendPayload.Size = new System.Drawing.Size(277, 26);
            this.btnSendPayload.TabIndex = 3;
            this.btnSendPayload.TabStop = false;
            this.btnSendPayload.Text = "Send Payload";
            this.btnSendPayload.UseMnemonic = false;
            this.btnSendPayload.UseVisualStyleBackColor = false;
            this.btnSendPayload.Click += new System.EventHandler(this.btnSendPayload_Click);
            // 
            // btnRefreshProcess
            // 
            this.btnRefreshProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshProcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefreshProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnRefreshProcess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnRefreshProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefreshProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.btnRefreshProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProcess.ForeColor = System.Drawing.Color.White;
            this.btnRefreshProcess.Location = new System.Drawing.Point(10, 91);
            this.btnRefreshProcess.Name = "btnRefreshProcess";
            this.btnRefreshProcess.Size = new System.Drawing.Size(277, 26);
            this.btnRefreshProcess.TabIndex = 5;
            this.btnRefreshProcess.TabStop = false;
            this.btnRefreshProcess.Text = "Refresh Processes";
            this.btnRefreshProcess.UseMnemonic = false;
            this.btnRefreshProcess.UseVisualStyleBackColor = false;
            this.btnRefreshProcess.Click += new System.EventHandler(this.btnRefreshProcess_Click);
            // 
            // cbHex
            // 
            this.cbHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbHex.AutoSize = true;
            this.cbHex.Location = new System.Drawing.Point(10, 294);
            this.cbHex.Name = "cbHex";
            this.cbHex.Size = new System.Drawing.Size(45, 17);
            this.cbHex.TabIndex = 32;
            this.cbHex.Text = "Hex";
            this.cbHex.UseVisualStyleBackColor = true;
            // 
            // cbAlignment
            // 
            this.cbAlignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlignment.AutoSize = true;
            this.cbAlignment.Checked = true;
            this.cbAlignment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlignment.Location = new System.Drawing.Point(175, 241);
            this.cbAlignment.Name = "cbAlignment";
            this.cbAlignment.Size = new System.Drawing.Size(72, 17);
            this.cbAlignment.TabIndex = 9;
            this.cbAlignment.Text = "Alignment";
            this.cbAlignment.UseVisualStyleBackColor = true;
            // 
            // txtValue2
            // 
            this.txtValue2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue2.ForeColor = System.Drawing.Color.White;
            this.txtValue2.Location = new System.Drawing.Point(188, 293);
            this.txtValue2.MaxLength = 31;
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 20);
            this.txtValue2.TabIndex = 30;
            this.txtValue2.Text = "0";
            // 
            // value_label
            // 
            this.value_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.value_label.AutoSize = true;
            this.value_label.ForeColor = System.Drawing.Color.White;
            this.value_label.Location = new System.Drawing.Point(186, 271);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(37, 13);
            this.value_label.TabIndex = 31;
            this.value_label.Text = "Value:";
            // 
            // and_label
            // 
            this.and_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.and_label.AutoSize = true;
            this.and_label.Location = new System.Drawing.Point(159, 295);
            this.and_label.Name = "and_label";
            this.and_label.Size = new System.Drawing.Size(25, 13);
            this.and_label.TabIndex = 29;
            this.and_label.Text = "and";
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(16, 487);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(271, 16);
            this.lblMsg.TabIndex = 21;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbSelectAll.Location = new System.Drawing.Point(19, 242);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbSelectAll.TabIndex = 8;
            this.cbSelectAll.Text = "Select All";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.Click += new System.EventHandler(this.cbSelectAll_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 508);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(277, 25);
            this.progressBar.TabIndex = 22;
            // 
            // cbCompareTypeList
            // 
            this.cbCompareTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompareTypeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbCompareTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompareTypeList.Enabled = false;
            this.cbCompareTypeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCompareTypeList.ForeColor = System.Drawing.Color.White;
            this.cbCompareTypeList.FormattingEnabled = true;
            this.cbCompareTypeList.Location = new System.Drawing.Point(12, 357);
            this.cbCompareTypeList.Name = "cbCompareTypeList";
            this.cbCompareTypeList.Size = new System.Drawing.Size(276, 21);
            this.cbCompareTypeList.TabIndex = 12;
            this.cbCompareTypeList.SelectedIndexChanged += new System.EventHandler(this.cbCompareTypeList_SelectedIndexChanged);
            // 
            // cbValueTypeList
            // 
            this.cbValueTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbValueTypeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbValueTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValueTypeList.Enabled = false;
            this.cbValueTypeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbValueTypeList.ForeColor = System.Drawing.Color.White;
            this.cbValueTypeList.FormattingEnabled = true;
            this.cbValueTypeList.Location = new System.Drawing.Point(12, 329);
            this.cbValueTypeList.Name = "cbValueTypeList";
            this.cbValueTypeList.Size = new System.Drawing.Size(276, 21);
            this.cbValueTypeList.TabIndex = 11;
            this.cbValueTypeList.SelectedIndexChanged += new System.EventHandler(this.cbValueTypeList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Value:";
            // 
            // btnNextScan
            // 
            this.btnNextScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnNextScan.Enabled = false;
            this.btnNextScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNextScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNextScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.btnNextScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextScan.ForeColor = System.Drawing.Color.White;
            this.btnNextScan.Location = new System.Drawing.Point(12, 452);
            this.btnNextScan.Name = "btnNextScan";
            this.btnNextScan.Size = new System.Drawing.Size(277, 27);
            this.btnNextScan.TabIndex = 15;
            this.btnNextScan.UseMnemonic = false;
            this.btnNextScan.UseVisualStyleBackColor = false;
            this.btnNextScan.Click += new System.EventHandler(this.btnNextScan_Click);
            // 
            // btnNewScan
            // 
            this.btnNewScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnNewScan.Enabled = false;
            this.btnNewScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNewScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNewScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.btnNewScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewScan.ForeColor = System.Drawing.Color.White;
            this.btnNewScan.Location = new System.Drawing.Point(12, 383);
            this.btnNewScan.Name = "btnNewScan";
            this.btnNewScan.Size = new System.Drawing.Size(276, 27);
            this.btnNewScan.TabIndex = 13;
            this.btnNewScan.UseMnemonic = false;
            this.btnNewScan.UseVisualStyleBackColor = false;
            this.btnNewScan.Click += new System.EventHandler(this.btnNewScan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnRefresh.Enabled = false;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(12, 417);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(277, 27);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bwNewScan
            // 
            this.bwNewScan.WorkerReportsProgress = true;
            this.bwNewScan.WorkerSupportsCancellation = true;
            this.bwNewScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwNewScan_DoWork);
            this.bwNewScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwNewScan_ProgressChanged);
            this.bwNewScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwNewScan_RunWorkerCompleted);
            // 
            // bwNextScan
            // 
            this.bwNextScan.WorkerReportsProgress = true;
            this.bwNextScan.WorkerSupportsCancellation = true;
            this.bwNextScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwNextScan_DoWork);
            this.bwNextScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwUpdateResult_ProgressChanged);
            this.bwNextScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwNextScan_RunWorkerCompleted);
            // 
            // bwUpdateResult
            // 
            this.bwUpdateResult.WorkerReportsProgress = true;
            this.bwUpdateResult.WorkerSupportsCancellation = true;
            this.bwUpdateResult.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateResult_DoWork);
            this.bwUpdateResult.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwUpdateResult_ProgressChanged);
            this.bwUpdateResult.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdateResult_RunWorkerCompleted);
            // 
            // FrmMain1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 671);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.parent);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMain1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4 Cheater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvCheatList)).EndInit();
            this.cmsCheatListMenu.ResumeLayout(false);
            this.cmsSectionMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.cmsResultMenu.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private ContextMenuStrip cmsResultMenu;
        private ToolStripMenuItem cmsResultMenuHex;
        private ToolStripMenuItem cmsResultMenuDump;
        private TextBox txtValue2;
        private Label value_label;
        private Label and_label;
        private CheckBox cbAlignment;
        private BackgroundWorker bwUpdateResult;
        private DataGridViewButtonColumn cheat_list_view_del;
        private DataGridViewTextBoxColumn cheat_list_view_address;
        private DataGridViewTextBoxColumn cheat_list_view_type;
        private DataGridViewButtonColumn cheat_list_view_active;
        private DataGridViewTextBoxColumn cheat_list_view_value;
        private DataGridViewTextBoxColumn cheat_list_view_section;
        private DataGridViewCheckBoxColumn cheat_list_view_lock;
        private DataGridViewTextBoxColumn cheat_list_view_description;
        private ToolStripSeparator result_list_view_separator;
        private ToolStripMenuItem cmsResultMenuAdd;
        private ContextMenuStrip cmsCheatListMenu;
        private ToolStripMenuItem cmsCheatListLock;
        private ToolStripMenuItem cmsCheatListActive;
        private ToolStripSeparator cheat_list_item_separator_0;
        private ToolStripMenuItem cmsCheatListDelete;
        private ToolStripMenuItem cmsCheatListUnlock;
        private ToolStripSeparator cheat_list_item_separator_1;
        private ToolStripMenuItem cmsCheatListHex;
        private CheckBox cbHex;
        private ToolStripMenuItem cmsCheatListFindPointer;
        private ToolStripSeparator cheat_list_item_separator_2;
        private Label label2;
        private Label label1;
    }
}