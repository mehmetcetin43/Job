namespace Job.WinUI
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ShowDataTab = new System.Windows.Forms.TabPage();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalMissWrking = new System.Windows.Forms.TextBox();
            this.txtTotalExtrWrking = new System.Windows.Forms.TextBox();
            this.btnGetSelectedDateData = new System.Windows.Forms.Button();
            this.cmbxYears = new System.Windows.Forms.ComboBox();
            this.cmbxMonths = new System.Windows.Forms.ComboBox();
            this.btnGetAllData = new System.Windows.Forms.Button();
            this.btnReflesh = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DataEntryTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.cmbxChckOutMinute = new System.Windows.Forms.ComboBox();
            this.cmbxChckOutHour = new System.Windows.Forms.ComboBox();
            this.cmbxChckInMinute = new System.Windows.Forms.ComboBox();
            this.cmbxChckInHour = new System.Windows.Forms.ComboBox();
            this.dgvWorking = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyWorkingHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraWorkingHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissingWorkingHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyWorkingHour2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraWorkingHour2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissingWorkingHour2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.ShowDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.DataEntryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ShowDataTab);
            this.tabControl1.Controls.Add(this.DataEntryTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(74, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 606);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // ShowDataTab
            // 
            this.ShowDataTab.AutoScroll = true;
            this.ShowDataTab.Controls.Add(this.txtTotal);
            this.ShowDataTab.Controls.Add(this.label14);
            this.ShowDataTab.Controls.Add(this.label12);
            this.ShowDataTab.Controls.Add(this.label11);
            this.ShowDataTab.Controls.Add(this.label13);
            this.ShowDataTab.Controls.Add(this.label10);
            this.ShowDataTab.Controls.Add(this.label9);
            this.ShowDataTab.Controls.Add(this.txtTotalMissWrking);
            this.ShowDataTab.Controls.Add(this.txtTotalExtrWrking);
            this.ShowDataTab.Controls.Add(this.btnGetSelectedDateData);
            this.ShowDataTab.Controls.Add(this.cmbxYears);
            this.ShowDataTab.Controls.Add(this.cmbxMonths);
            this.ShowDataTab.Controls.Add(this.btnGetAllData);
            this.ShowDataTab.Controls.Add(this.btnReflesh);
            this.ShowDataTab.Controls.Add(this.dataGridView2);
            this.ShowDataTab.Location = new System.Drawing.Point(4, 25);
            this.ShowDataTab.Margin = new System.Windows.Forms.Padding(2);
            this.ShowDataTab.Name = "ShowDataTab";
            this.ShowDataTab.Padding = new System.Windows.Forms.Padding(2);
            this.ShowDataTab.Size = new System.Drawing.Size(999, 577);
            this.ShowDataTab.TabIndex = 1;
            this.ShowDataTab.Text = "Show Data";
            this.ShowDataTab.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(789, 59);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(61, 20);
            this.txtTotal.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(776, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(776, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(776, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(656, 61);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(656, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total Missing Work Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total Extra Work Time";
            // 
            // txtTotalMissWrking
            // 
            this.txtTotalMissWrking.Location = new System.Drawing.Point(789, 36);
            this.txtTotalMissWrking.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalMissWrking.Name = "txtTotalMissWrking";
            this.txtTotalMissWrking.Size = new System.Drawing.Size(61, 20);
            this.txtTotalMissWrking.TabIndex = 23;
            // 
            // txtTotalExtrWrking
            // 
            this.txtTotalExtrWrking.Location = new System.Drawing.Point(789, 12);
            this.txtTotalExtrWrking.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalExtrWrking.Name = "txtTotalExtrWrking";
            this.txtTotalExtrWrking.Size = new System.Drawing.Size(61, 20);
            this.txtTotalExtrWrking.TabIndex = 24;
            // 
            // btnGetSelectedDateData
            // 
            this.btnGetSelectedDateData.Location = new System.Drawing.Point(11, 37);
            this.btnGetSelectedDateData.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetSelectedDateData.Name = "btnGetSelectedDateData";
            this.btnGetSelectedDateData.Size = new System.Drawing.Size(188, 24);
            this.btnGetSelectedDateData.TabIndex = 9;
            this.btnGetSelectedDateData.Text = "Get Data Of Selected Date";
            this.btnGetSelectedDateData.UseVisualStyleBackColor = true;
            this.btnGetSelectedDateData.Click += new System.EventHandler(this.btnGetSelectedDateData_Click);
            // 
            // cmbxYears
            // 
            this.cmbxYears.FormattingEnabled = true;
            this.cmbxYears.Location = new System.Drawing.Point(11, 15);
            this.cmbxYears.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxYears.Name = "cmbxYears";
            this.cmbxYears.Size = new System.Drawing.Size(92, 21);
            this.cmbxYears.TabIndex = 8;
            this.cmbxYears.SelectedValueChanged += new System.EventHandler(this.cmbxYears_SelectedValueChanged);
            // 
            // cmbxMonths
            // 
            this.cmbxMonths.FormattingEnabled = true;
            this.cmbxMonths.Location = new System.Drawing.Point(108, 15);
            this.cmbxMonths.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxMonths.Name = "cmbxMonths";
            this.cmbxMonths.Size = new System.Drawing.Size(92, 21);
            this.cmbxMonths.TabIndex = 8;
            // 
            // btnGetAllData
            // 
            this.btnGetAllData.Location = new System.Drawing.Point(243, 15);
            this.btnGetAllData.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAllData.Name = "btnGetAllData";
            this.btnGetAllData.Size = new System.Drawing.Size(80, 21);
            this.btnGetAllData.TabIndex = 7;
            this.btnGetAllData.Text = "Get All Data";
            this.btnGetAllData.UseVisualStyleBackColor = true;
            this.btnGetAllData.Click += new System.EventHandler(this.btnGetAllData_Click);
            // 
            // btnReflesh
            // 
            this.btnReflesh.Location = new System.Drawing.Point(243, 40);
            this.btnReflesh.Margin = new System.Windows.Forms.Padding(2);
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Size = new System.Drawing.Size(80, 21);
            this.btnReflesh.TabIndex = 7;
            this.btnReflesh.Text = "Reflesh Data";
            this.btnReflesh.UseVisualStyleBackColor = true;
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date2,
            this.CheckInTime2,
            this.CheckOutTime2,
            this.DailyWorkingHour2,
            this.ExtraWorkingHour2,
            this.MissingWorkingHour2});
            this.dataGridView2.Location = new System.Drawing.Point(10, 95);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(916, 477);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // DataEntryTab
            // 
            this.DataEntryTab.Controls.Add(this.label6);
            this.DataEntryTab.Controls.Add(this.label8);
            this.DataEntryTab.Controls.Add(this.label7);
            this.DataEntryTab.Controls.Add(this.label5);
            this.DataEntryTab.Controls.Add(this.label4);
            this.DataEntryTab.Controls.Add(this.btnClear);
            this.DataEntryTab.Controls.Add(this.btnConfirm);
            this.DataEntryTab.Controls.Add(this.dtpDate);
            this.DataEntryTab.Controls.Add(this.label3);
            this.DataEntryTab.Controls.Add(this.label2);
            this.DataEntryTab.Controls.Add(this.label1);
            this.DataEntryTab.Controls.Add(this.btnCheckOut);
            this.DataEntryTab.Controls.Add(this.btnCheckIn);
            this.DataEntryTab.Controls.Add(this.cmbxChckOutMinute);
            this.DataEntryTab.Controls.Add(this.cmbxChckOutHour);
            this.DataEntryTab.Controls.Add(this.cmbxChckInMinute);
            this.DataEntryTab.Controls.Add(this.cmbxChckInHour);
            this.DataEntryTab.Controls.Add(this.dgvWorking);
            this.DataEntryTab.Location = new System.Drawing.Point(4, 25);
            this.DataEntryTab.Margin = new System.Windows.Forms.Padding(2);
            this.DataEntryTab.Name = "DataEntryTab";
            this.DataEntryTab.Padding = new System.Windows.Forms.Padding(2);
            this.DataEntryTab.Size = new System.Drawing.Size(999, 577);
            this.DataEntryTab.TabIndex = 2;
            this.DataEntryTab.Text = "Data Entry";
            this.DataEntryTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(244, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(322, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(322, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(244, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(244, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = ":";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(626, 241);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 46);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(538, 241);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(78, 46);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(287, 37);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(246, 20);
            this.dtpDate.TabIndex = 19;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Check_Out Hour and Minute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Check-In Hour and Minute";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.Location = new System.Drawing.Point(386, 106);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(146, 23);
            this.btnCheckOut.TabIndex = 18;
            this.btnCheckOut.Text = "Complete Check-Out Time";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(386, 69);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(146, 23);
            this.btnCheckIn.TabIndex = 15;
            this.btnCheckIn.Text = "Complete Check-In Time";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // cmbxChckOutMinute
            // 
            this.cmbxChckOutMinute.Enabled = false;
            this.cmbxChckOutMinute.FormattingEnabled = true;
            this.cmbxChckOutMinute.Location = new System.Drawing.Point(332, 108);
            this.cmbxChckOutMinute.Name = "cmbxChckOutMinute";
            this.cmbxChckOutMinute.Size = new System.Drawing.Size(35, 21);
            this.cmbxChckOutMinute.TabIndex = 17;
            this.cmbxChckOutMinute.SelectedValueChanged += new System.EventHandler(this.cmbxChckOutMinute_SelectedValueChanged);
            // 
            // cmbxChckOutHour
            // 
            this.cmbxChckOutHour.Enabled = false;
            this.cmbxChckOutHour.FormattingEnabled = true;
            this.cmbxChckOutHour.Location = new System.Drawing.Point(287, 108);
            this.cmbxChckOutHour.Name = "cmbxChckOutHour";
            this.cmbxChckOutHour.Size = new System.Drawing.Size(35, 21);
            this.cmbxChckOutHour.TabIndex = 16;
            this.cmbxChckOutHour.SelectedValueChanged += new System.EventHandler(this.cmbxChckOutHour_SelectedValueChanged);
            // 
            // cmbxChckInMinute
            // 
            this.cmbxChckInMinute.FormattingEnabled = true;
            this.cmbxChckInMinute.Location = new System.Drawing.Point(332, 71);
            this.cmbxChckInMinute.Name = "cmbxChckInMinute";
            this.cmbxChckInMinute.Size = new System.Drawing.Size(35, 21);
            this.cmbxChckInMinute.TabIndex = 11;
            // 
            // cmbxChckInHour
            // 
            this.cmbxChckInHour.DisplayMember = "6";
            this.cmbxChckInHour.FormattingEnabled = true;
            this.cmbxChckInHour.Location = new System.Drawing.Point(287, 71);
            this.cmbxChckInHour.Name = "cmbxChckInHour";
            this.cmbxChckInHour.Size = new System.Drawing.Size(35, 21);
            this.cmbxChckInHour.TabIndex = 10;
            // 
            // dgvWorking
            // 
            this.dgvWorking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWorking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvWorking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.CheckInTime,
            this.CheckOutTime,
            this.DailyWorkingHour,
            this.ExtraWorkingHour,
            this.MissingWorkingHour});
            this.dgvWorking.Location = new System.Drawing.Point(28, 174);
            this.dgvWorking.Name = "dgvWorking";
            this.dgvWorking.RowHeadersWidth = 51;
            this.dgvWorking.Size = new System.Drawing.Size(674, 62);
            this.dgvWorking.TabIndex = 9;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 55;
            // 
            // CheckInTime
            // 
            this.CheckInTime.HeaderText = "CheckInTime";
            this.CheckInTime.MinimumWidth = 6;
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.Width = 95;
            // 
            // CheckOutTime
            // 
            this.CheckOutTime.HeaderText = "CheckOutTime";
            this.CheckOutTime.MinimumWidth = 6;
            this.CheckOutTime.Name = "CheckOutTime";
            this.CheckOutTime.Width = 103;
            // 
            // DailyWorkingHour
            // 
            this.DailyWorkingHour.HeaderText = "DailyWorkingHour";
            this.DailyWorkingHour.MinimumWidth = 6;
            this.DailyWorkingHour.Name = "DailyWorkingHour";
            this.DailyWorkingHour.Width = 118;
            // 
            // ExtraWorkingHour
            // 
            this.ExtraWorkingHour.HeaderText = "ExtraWorkingHour";
            this.ExtraWorkingHour.MinimumWidth = 6;
            this.ExtraWorkingHour.Name = "ExtraWorkingHour";
            this.ExtraWorkingHour.Width = 119;
            // 
            // MissingWorkingHour
            // 
            this.MissingWorkingHour.HeaderText = "MissingWorkingHour";
            this.MissingWorkingHour.MinimumWidth = 6;
            this.MissingWorkingHour.Name = "MissingWorkingHour";
            this.MissingWorkingHour.Width = 130;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // Date2
            // 
            this.Date2.HeaderText = "Date";
            this.Date2.Name = "Date2";
            this.Date2.Width = 55;
            // 
            // CheckInTime2
            // 
            this.CheckInTime2.HeaderText = "CheckInTime";
            this.CheckInTime2.Name = "CheckInTime2";
            this.CheckInTime2.Width = 95;
            // 
            // CheckOutTime2
            // 
            this.CheckOutTime2.HeaderText = "CheckOutTime";
            this.CheckOutTime2.Name = "CheckOutTime2";
            this.CheckOutTime2.Width = 103;
            // 
            // DailyWorkingHour2
            // 
            this.DailyWorkingHour2.HeaderText = "DailyWorkingHour";
            this.DailyWorkingHour2.Name = "DailyWorkingHour2";
            this.DailyWorkingHour2.Width = 118;
            // 
            // ExtraWorkingHour2
            // 
            this.ExtraWorkingHour2.HeaderText = "ExtraWorkingHour";
            this.ExtraWorkingHour2.Name = "ExtraWorkingHour2";
            this.ExtraWorkingHour2.Width = 119;
            // 
            // MissingWorkingHour2
            // 
            this.MissingWorkingHour2.HeaderText = "MissingWorkingHour";
            this.MissingWorkingHour2.Name = "MissingWorkingHour2";
            this.MissingWorkingHour2.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 597);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ShowDataTab.ResumeLayout(false);
            this.ShowDataTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.DataEntryTab.ResumeLayout(false);
            this.DataEntryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ShowDataTab;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage DataEntryTab;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.ComboBox cmbxChckOutMinute;
        private System.Windows.Forms.ComboBox cmbxChckOutHour;
        private System.Windows.Forms.ComboBox cmbxChckInMinute;
        private System.Windows.Forms.ComboBox cmbxChckInHour;
        private System.Windows.Forms.DataGridView dgvWorking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyWorkingHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraWorkingHour;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissingWorkingHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReflesh;
        private System.Windows.Forms.ComboBox cmbxYears;
        private System.Windows.Forms.ComboBox cmbxMonths;
        private System.Windows.Forms.Button btnGetAllData;
        private System.Windows.Forms.Button btnGetSelectedDateData;
        private System.Windows.Forms.TextBox txtTotalMissWrking;
        private System.Windows.Forms.TextBox txtTotalExtrWrking;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyWorkingHour2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraWorkingHour2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissingWorkingHour2;
    }
}

