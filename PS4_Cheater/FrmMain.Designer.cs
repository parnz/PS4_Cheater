namespace PS4_Cheater
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnNewCheat = new System.Windows.Forms.Button();
            this.btnRefreshCheat = new System.Windows.Forms.Button();
            this.btnSaveCheat = new System.Windows.Forms.Button();
            this.btnLoadCheat = new System.Windows.Forms.Button();
            this.lstSection = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.btnSendPayload = new System.Windows.Forms.Button();
            this.cmbProcesses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshProcess = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbHex = new System.Windows.Forms.CheckBox();
            this.cbAlignment = new System.Windows.Forms.CheckBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            this.and_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbValueTypeList = new System.Windows.Forms.ComboBox();
            this.cbCompareTypeList = new System.Windows.Forms.ComboBox();
            this.btnNewScan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNextScan = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lvCheatList = new System.Windows.Forms.DataGridView();
            this.cheat_list_view_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cheat_list_view_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_active = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cheat_list_view_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_lock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cheat_list_view_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvResult = new System.Windows.Forms.ListView();
            this.result_list_view_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_hex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
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
            this.cmsSectionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSectionMenuHex = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSectionMenuDump = new System.Windows.Forms.ToolStripMenuItem();
            this.timeRefreshLock = new System.Windows.Forms.Timer(this.components);
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.cmsResultMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsResultMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.result_list_view_separator = new System.Windows.Forms.ToolStripSeparator();
            this.cmsResultMenuHex = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsResultMenuDump = new System.Windows.Forms.ToolStripMenuItem();
            this.bwNewScan = new System.ComponentModel.BackgroundWorker();
            this.bwNextScan = new System.ComponentModel.BackgroundWorker();
            this.bwUpdateResult = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvCheatList)).BeginInit();
            this.cmsCheatListMenu.SuspendLayout();
            this.cmsSectionMenu.SuspendLayout();
            this.cmsResultMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.Size = new System.Drawing.Size(1213, 713);
            this.splitContainer1.SplitterDistance = 900;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.cmbProcesses);
            this.splitContainer2.Panel1.Controls.Add(this.btnRefreshProcess);
            this.splitContainer2.Panel1.Controls.Add(this.btnSendPayload);
            this.splitContainer2.Panel1.Controls.Add(this.txtIpAddress);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(309, 713);
            this.splitContainer2.SplitterDistance = 66;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lstSection);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lblMsg);
            this.splitContainer3.Panel2.Controls.Add(this.cbCompareTypeList);
            this.splitContainer3.Panel2.Controls.Add(this.cbValueTypeList);
            this.splitContainer3.Panel2.Controls.Add(this.txtValue);
            this.splitContainer3.Panel2.Controls.Add(this.btnNextScan);
            this.splitContainer3.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer3.Panel2.Controls.Add(this.btnNewScan);
            this.splitContainer3.Panel2.Controls.Add(this.cbHex);
            this.splitContainer3.Panel2.Controls.Add(this.cbAlignment);
            this.splitContainer3.Panel2.Controls.Add(this.txtValue2);
            this.splitContainer3.Panel2.Controls.Add(this.value_label);
            this.splitContainer3.Panel2.Controls.Add(this.and_label);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.cbSelectAll);
            this.splitContainer3.Panel2.Controls.Add(this.progressBar);
            this.splitContainer3.Size = new System.Drawing.Size(309, 643);
            this.splitContainer3.SplitterDistance = 334;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
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
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(900, 713);
            this.splitContainer4.SplitterDistance = 300;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnLoadCheat);
            this.splitContainer5.Panel1.Controls.Add(this.btnSaveCheat);
            this.splitContainer5.Panel1.Controls.Add(this.btnRefreshCheat);
            this.splitContainer5.Panel1.Controls.Add(this.btnNewCheat);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.lvCheatList);
            this.splitContainer5.Size = new System.Drawing.Size(900, 409);
            this.splitContainer5.SplitterDistance = 40;
            this.splitContainer5.TabIndex = 0;
            // 
            // btnNewCheat
            // 
            this.btnNewCheat.Location = new System.Drawing.Point(12, 3);
            this.btnNewCheat.Name = "btnNewCheat";
            this.btnNewCheat.Size = new System.Drawing.Size(123, 34);
            this.btnNewCheat.TabIndex = 0;
            this.btnNewCheat.Text = "New";
            this.btnNewCheat.UseVisualStyleBackColor = true;
            this.btnNewCheat.Click += new System.EventHandler(this.btnNewCheat_Click);
            // 
            // btnRefreshCheat
            // 
            this.btnRefreshCheat.Location = new System.Drawing.Point(141, 3);
            this.btnRefreshCheat.Name = "btnRefreshCheat";
            this.btnRefreshCheat.Size = new System.Drawing.Size(123, 34);
            this.btnRefreshCheat.TabIndex = 0;
            this.btnRefreshCheat.Text = "Refresh";
            this.btnRefreshCheat.UseVisualStyleBackColor = true;
            this.btnRefreshCheat.Click += new System.EventHandler(this.btnRefreshCheat_Click);
            // 
            // btnSaveCheat
            // 
            this.btnSaveCheat.Location = new System.Drawing.Point(270, 3);
            this.btnSaveCheat.Name = "btnSaveCheat";
            this.btnSaveCheat.Size = new System.Drawing.Size(123, 34);
            this.btnSaveCheat.TabIndex = 0;
            this.btnSaveCheat.Text = "Save";
            this.btnSaveCheat.UseVisualStyleBackColor = true;
            this.btnSaveCheat.Click += new System.EventHandler(this.btnSaveCheat_Click);
            // 
            // btnLoadCheat
            // 
            this.btnLoadCheat.Location = new System.Drawing.Point(399, 3);
            this.btnLoadCheat.Name = "btnLoadCheat";
            this.btnLoadCheat.Size = new System.Drawing.Size(123, 34);
            this.btnLoadCheat.TabIndex = 0;
            this.btnLoadCheat.Text = "Load";
            this.btnLoadCheat.UseVisualStyleBackColor = true;
            this.btnLoadCheat.Click += new System.EventHandler(this.btnLoadCheat_Click);
            // 
            // lstSection
            // 
            this.lstSection.CheckOnClick = true;
            this.lstSection.ContextMenuStrip = this.cmsSectionMenu;
            this.lstSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSection.FormattingEnabled = true;
            this.lstSection.HorizontalScrollbar = true;
            this.lstSection.Location = new System.Drawing.Point(0, 0);
            this.lstSection.Name = "lstSection";
            this.lstSection.Size = new System.Drawing.Size(309, 334);
            this.lstSection.TabIndex = 8;
            this.lstSection.TabStop = false;
            this.lstSection.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSection_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PS4 IP Address:";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(93, 12);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIpAddress.TabIndex = 1;
            // 
            // btnSendPayload
            // 
            this.btnSendPayload.Location = new System.Drawing.Point(199, 10);
            this.btnSendPayload.Name = "btnSendPayload";
            this.btnSendPayload.Size = new System.Drawing.Size(98, 23);
            this.btnSendPayload.TabIndex = 2;
            this.btnSendPayload.Text = "Send Payload";
            this.btnSendPayload.UseVisualStyleBackColor = true;
            this.btnSendPayload.Click += new System.EventHandler(this.btnSendPayload_Click);
            // 
            // cmbProcesses
            // 
            this.cmbProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcesses.FormattingEnabled = true;
            this.cmbProcesses.Location = new System.Drawing.Point(93, 39);
            this.cmbProcesses.Name = "cmbProcesses";
            this.cmbProcesses.Size = new System.Drawing.Size(141, 21);
            this.cmbProcesses.TabIndex = 3;
            this.cmbProcesses.SelectedIndexChanged += new System.EventHandler(this.cmbProcesses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Process List:";
            // 
            // btnRefreshProcess
            // 
            this.btnRefreshProcess.Location = new System.Drawing.Point(240, 37);
            this.btnRefreshProcess.Name = "btnRefreshProcess";
            this.btnRefreshProcess.Size = new System.Drawing.Size(57, 23);
            this.btnRefreshProcess.TabIndex = 2;
            this.btnRefreshProcess.Text = "Refresh";
            this.btnRefreshProcess.UseVisualStyleBackColor = true;
            this.btnRefreshProcess.Click += new System.EventHandler(this.btnRefreshProcess_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 280);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(309, 25);
            this.progressBar.TabIndex = 23;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbSelectAll.Location = new System.Drawing.Point(25, 10);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbSelectAll.TabIndex = 24;
            this.cbSelectAll.Text = "Select All";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.Click += new System.EventHandler(this.cbSelectAll_Click);
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtValue.Location = new System.Drawing.Point(66, 59);
            this.txtValue.MaxLength = 500;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(87, 20);
            this.txtValue.TabIndex = 34;
            this.txtValue.Text = "0";
            // 
            // cbHex
            // 
            this.cbHex.AutoSize = true;
            this.cbHex.Location = new System.Drawing.Point(23, 61);
            this.cbHex.Name = "cbHex";
            this.cbHex.Size = new System.Drawing.Size(45, 17);
            this.cbHex.TabIndex = 39;
            this.cbHex.Text = "Hex";
            this.cbHex.UseVisualStyleBackColor = true;
            // 
            // cbAlignment
            // 
            this.cbAlignment.AutoSize = true;
            this.cbAlignment.Checked = true;
            this.cbAlignment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlignment.Location = new System.Drawing.Point(189, 10);
            this.cbAlignment.Name = "cbAlignment";
            this.cbAlignment.Size = new System.Drawing.Size(72, 17);
            this.cbAlignment.TabIndex = 33;
            this.cbAlignment.Text = "Alignment";
            this.cbAlignment.UseVisualStyleBackColor = true;
            // 
            // txtValue2
            // 
            this.txtValue2.BackColor = System.Drawing.SystemColors.Window;
            this.txtValue2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtValue2.Location = new System.Drawing.Point(189, 59);
            this.txtValue2.MaxLength = 31;
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(87, 20);
            this.txtValue2.TabIndex = 37;
            this.txtValue2.Text = "0";
            // 
            // value_label
            // 
            this.value_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value_label.AutoSize = true;
            this.value_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.value_label.Location = new System.Drawing.Point(187, 37);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(37, 13);
            this.value_label.TabIndex = 38;
            this.value_label.Text = "Value:";
            // 
            // and_label
            // 
            this.and_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.and_label.AutoSize = true;
            this.and_label.Location = new System.Drawing.Point(158, 62);
            this.and_label.Name = "and_label";
            this.and_label.Size = new System.Drawing.Size(25, 13);
            this.and_label.TabIndex = 36;
            this.and_label.Text = "and";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(50, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Value:";
            // 
            // cbValueTypeList
            // 
            this.cbValueTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbValueTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValueTypeList.FormattingEnabled = true;
            this.cbValueTypeList.Location = new System.Drawing.Point(53, 96);
            this.cbValueTypeList.Name = "cbValueTypeList";
            this.cbValueTypeList.Size = new System.Drawing.Size(100, 21);
            this.cbValueTypeList.TabIndex = 40;
            this.cbValueTypeList.SelectedIndexChanged += new System.EventHandler(this.cbValueTypeList_SelectedIndexChanged);
            // 
            // cbCompareTypeList
            // 
            this.cbCompareTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompareTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompareTypeList.FormattingEnabled = true;
            this.cbCompareTypeList.Location = new System.Drawing.Point(176, 96);
            this.cbCompareTypeList.Name = "cbCompareTypeList";
            this.cbCompareTypeList.Size = new System.Drawing.Size(100, 21);
            this.cbCompareTypeList.TabIndex = 41;
            this.cbCompareTypeList.SelectedIndexChanged += new System.EventHandler(this.cbCompareTypeList_SelectedIndexChanged);
            // 
            // btnNewScan
            // 
            this.btnNewScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewScan.Location = new System.Drawing.Point(15, 132);
            this.btnNewScan.Name = "btnNewScan";
            this.btnNewScan.Size = new System.Drawing.Size(279, 34);
            this.btnNewScan.TabIndex = 0;
            this.btnNewScan.UseVisualStyleBackColor = true;
            this.btnNewScan.Click += new System.EventHandler(this.btnNewScan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(15, 172);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(279, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNextScan
            // 
            this.btnNextScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextScan.Location = new System.Drawing.Point(15, 212);
            this.btnNextScan.Name = "btnNextScan";
            this.btnNextScan.Size = new System.Drawing.Size(279, 34);
            this.btnNextScan.TabIndex = 0;
            this.btnNextScan.UseVisualStyleBackColor = true;
            this.btnNextScan.Click += new System.EventHandler(this.btnNextScan_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.Location = new System.Drawing.Point(23, 246);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(271, 31);
            this.lblMsg.TabIndex = 42;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvCheatList
            // 
            this.lvCheatList.AllowUserToAddRows = false;
            this.lvCheatList.AllowUserToResizeRows = false;
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
            this.lvCheatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCheatList.Location = new System.Drawing.Point(0, 0);
            this.lvCheatList.Name = "lvCheatList";
            this.lvCheatList.RowHeadersVisible = false;
            this.lvCheatList.RowTemplate.Height = 23;
            this.lvCheatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvCheatList.Size = new System.Drawing.Size(900, 365);
            this.lvCheatList.TabIndex = 51;
            this.lvCheatList.TabStop = false;
            this.lvCheatList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvCheatList_CellClick);
            this.lvCheatList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvCheatList_CellEndEdit);
            this.lvCheatList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.lvCheatList_RowsRemoved);
            // 
            // cheat_list_view_del
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Delete";
            this.cheat_list_view_del.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "X";
            this.cheat_list_view_active.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.lvResult.Size = new System.Drawing.Size(900, 300);
            this.lvResult.TabIndex = 17;
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
            // result_list_view_value
            // 
            this.result_list_view_value.Text = "Value";
            this.result_list_view_value.Width = 120;
            // 
            // result_list_view_hex
            // 
            this.result_list_view_hex.Text = "Hex";
            this.result_list_view_hex.Width = 120;
            // 
            // result_list_view_section
            // 
            this.result_list_view_section.Text = "Section";
            this.result_list_view_section.Width = 180;
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
            // timeRefreshLock
            // 
            this.timeRefreshLock.Enabled = true;
            this.timeRefreshLock.Interval = 500;
            this.timeRefreshLock.Tick += new System.EventHandler(this.timeRefreshLock_Tick);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 713);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.Text = "PS4 Cheater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvCheatList)).EndInit();
            this.cmsCheatListMenu.ResumeLayout(false);
            this.cmsSectionMenu.ResumeLayout(false);
            this.cmsResultMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button btnLoadCheat;
        private System.Windows.Forms.Button btnSaveCheat;
        private System.Windows.Forms.Button btnRefreshCheat;
        private System.Windows.Forms.Button btnNewCheat;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.CheckedListBox lstSection;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendPayload;
        private System.Windows.Forms.ComboBox cmbProcesses;
        private System.Windows.Forms.Button btnRefreshProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.CheckBox cbHex;
        private System.Windows.Forms.CheckBox cbAlignment;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label value_label;
        private System.Windows.Forms.Label and_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCompareTypeList;
        private System.Windows.Forms.ComboBox cbValueTypeList;
        private System.Windows.Forms.Button btnNextScan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNewScan;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridView lvCheatList;
        private System.Windows.Forms.DataGridViewButtonColumn cheat_list_view_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_type;
        private System.Windows.Forms.DataGridViewButtonColumn cheat_list_view_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_section;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cheat_list_view_lock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_description;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader result_list_view_address;
        private System.Windows.Forms.ColumnHeader result_list_view_type;
        private System.Windows.Forms.ColumnHeader result_list_view_value;
        private System.Windows.Forms.ColumnHeader result_list_view_hex;
        private System.Windows.Forms.ColumnHeader result_list_view_section;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.ContextMenuStrip cmsCheatListMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsCheatListHex;
        private System.Windows.Forms.ToolStripSeparator cheat_list_item_separator_1;
        private System.Windows.Forms.ToolStripMenuItem cmsCheatListLock;
        private System.Windows.Forms.ToolStripMenuItem cmsCheatListUnlock;
        private System.Windows.Forms.ToolStripMenuItem cmsCheatListActive;
        private System.Windows.Forms.ToolStripSeparator cheat_list_item_separator_0;
        private System.Windows.Forms.ToolStripMenuItem cmsCheatListFindPointer;
        private System.Windows.Forms.ToolStripSeparator cheat_list_item_separator_2;
        private System.Windows.Forms.ToolStripMenuItem cmsCheatListDelete;
        private System.Windows.Forms.ContextMenuStrip cmsSectionMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsSectionMenuHex;
        private System.Windows.Forms.ToolStripMenuItem cmsSectionMenuDump;
        private System.Windows.Forms.Timer timeRefreshLock;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.ContextMenuStrip cmsResultMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsResultMenuAdd;
        private System.Windows.Forms.ToolStripSeparator result_list_view_separator;
        private System.Windows.Forms.ToolStripMenuItem cmsResultMenuHex;
        private System.Windows.Forms.ToolStripMenuItem cmsResultMenuDump;
        private System.ComponentModel.BackgroundWorker bwNewScan;
        private System.ComponentModel.BackgroundWorker bwNextScan;
        private System.ComponentModel.BackgroundWorker bwUpdateResult;
    }
}