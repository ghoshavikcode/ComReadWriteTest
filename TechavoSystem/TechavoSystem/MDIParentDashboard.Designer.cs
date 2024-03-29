namespace TechavoSystem
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode11 = new TreeNode("General Settings");
            TreeNode treeNode12 = new TreeNode("DO Settings", 1, 1);
            TreeNode treeNode13 = new TreeNode("DI Settings", 1, 1);
            TreeNode treeNode14 = new TreeNode("AI Settings", 1, 1);
            TreeNode treeNode15 = new TreeNode("IO Settings", new TreeNode[] { treeNode12, treeNode13, treeNode14 });
            TreeNode treeNode16 = new TreeNode("Modbus Settings");
            TreeNode treeNode17 = new TreeNode("Pulse Settings", 0, 0);
            TreeNode treeNode18 = new TreeNode("User", 0, 0);
            TreeNode treeNode19 = new TreeNode("Modbus Master", 0, 0);
            TreeNode treeNode20 = new TreeNode("Modbus Slave", 0, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            lnkLogin = new LinkLabel();
            pnlDashboard = new Panel();
            pnlGeneralSettings = new Panel();
            btnGeneralWriteMemory = new Button();
            btnGeneralReadMemory = new Button();
            groupBox13 = new GroupBox();
            txtIemiNo = new TextBox();
            chkGeneralRtcDebug = new CheckBox();
            label136 = new Label();
            chkGeneralModbusDebug = new CheckBox();
            label135 = new Label();
            label111 = new Label();
            txtGeneralSetTime = new TextBox();
            dtGeneralSetDate = new DateTimePicker();
            label61 = new Label();
            label60 = new Label();
            txtGeneralUserId = new TextBox();
            txtGeneralDataLogSec = new TextBox();
            label63 = new Label();
            txtGeneralSmsLogSec = new TextBox();
            label66 = new Label();
            label109 = new Label();
            label110 = new Label();
            label2 = new Label();
            pnlUser = new Panel();
            cmbUserIndex = new ComboBox();
            label128 = new Label();
            btnUserWriteMemory = new Button();
            btnUserReadMemory = new Button();
            groupBox15 = new GroupBox();
            chkUserSmsTimerReport = new CheckBox();
            label134 = new Label();
            cmbUserSelectDo = new ComboBox();
            chkUserIsVolatile = new CheckBox();
            label129 = new Label();
            label112 = new Label();
            chkUserCanCall = new CheckBox();
            chkUserIsAlarm = new CheckBox();
            chkUserIsAdmin = new CheckBox();
            chkUserSmsOnGprsFail = new CheckBox();
            chkUserSmsOnLowTower = new CheckBox();
            label113 = new Label();
            label122 = new Label();
            chkUserSmsOnPowerOn = new CheckBox();
            txtUserMobileNo = new TextBox();
            label123 = new Label();
            label124 = new Label();
            label125 = new Label();
            label126 = new Label();
            label127 = new Label();
            label43 = new Label();
            pnlDOSettings = new Panel();
            btnDOWriteMemory = new Button();
            btnDOReadMemory = new Button();
            cmbDOSelectChannel = new ComboBox();
            label115 = new Label();
            groupBox14 = new GroupBox();
            label121 = new Label();
            label120 = new Label();
            txtDoOnTime = new TextBox();
            label117 = new Label();
            txtDoOffTime = new TextBox();
            label116 = new Label();
            txtDoRelayDelayTime = new TextBox();
            label118 = new Label();
            txtDoRelayCloseOn = new TextBox();
            label119 = new Label();
            cmbDOType = new ComboBox();
            label114 = new Label();
            label40 = new Label();
            pnlDISettings = new Panel();
            btnDIWriteMemory = new Button();
            btnDIReadMemory = new Button();
            groupBox5 = new GroupBox();
            chkDIUser6 = new CheckBox();
            label46 = new Label();
            chkDIUser5 = new CheckBox();
            label47 = new Label();
            chkDIUser4 = new CheckBox();
            label48 = new Label();
            chkDIUser3 = new CheckBox();
            label49 = new Label();
            chkDIUser2 = new CheckBox();
            label50 = new Label();
            chkDIUser1 = new CheckBox();
            label51 = new Label();
            groupBox6 = new GroupBox();
            cmbDIDO8 = new ComboBox();
            label52 = new Label();
            cmbDIDO7 = new ComboBox();
            label53 = new Label();
            cmbDIDO6 = new ComboBox();
            label54 = new Label();
            cmbDIDO5 = new ComboBox();
            label55 = new Label();
            cmbDIDO4 = new ComboBox();
            label56 = new Label();
            cmbDIDO3 = new ComboBox();
            label57 = new Label();
            cmbDIDO2 = new ComboBox();
            label58 = new Label();
            cmbDIDO1 = new ComboBox();
            label59 = new Label();
            cmbDISelectChannel = new ComboBox();
            label68 = new Label();
            groupBox8 = new GroupBox();
            cmbDIReportDt = new ComboBox();
            label132 = new Label();
            txtDISMSRepeatSec = new TextBox();
            label69 = new Label();
            chkDIDataReport = new CheckBox();
            label102 = new Label();
            txtDISmsRepeatTime = new TextBox();
            label103 = new Label();
            txtDIAlarmVerifySec = new TextBox();
            label104 = new Label();
            cmbDIAlarm = new ComboBox();
            cmbDIType = new ComboBox();
            txtDIUnit = new TextBox();
            txtDIName = new TextBox();
            label105 = new Label();
            label106 = new Label();
            label107 = new Label();
            label108 = new Label();
            label41 = new Label();
            pnlPulseSettings = new Panel();
            btnPulseWriteMemory = new Button();
            btnPulseReadMemory = new Button();
            groupBox7 = new GroupBox();
            cmbPulseReportDT = new ComboBox();
            label131 = new Label();
            txtPulseDurationRef = new TextBox();
            label130 = new Label();
            chkPulseIsVolatile = new CheckBox();
            label62 = new Label();
            txtPulseKfactor = new TextBox();
            label64 = new Label();
            txtAdjustPulseCount = new TextBox();
            label65 = new Label();
            label42 = new Label();
            pnlModbusSettings = new Panel();
            button5 = new Button();
            button6 = new Button();
            groupBox9 = new GroupBox();
            checkBox16 = new CheckBox();
            label70 = new Label();
            checkBox17 = new CheckBox();
            label71 = new Label();
            checkBox18 = new CheckBox();
            label72 = new Label();
            checkBox19 = new CheckBox();
            label73 = new Label();
            checkBox20 = new CheckBox();
            label74 = new Label();
            checkBox21 = new CheckBox();
            label75 = new Label();
            groupBox10 = new GroupBox();
            comboBox29 = new ComboBox();
            label76 = new Label();
            comboBox30 = new ComboBox();
            label77 = new Label();
            comboBox31 = new ComboBox();
            label78 = new Label();
            comboBox32 = new ComboBox();
            label79 = new Label();
            comboBox33 = new ComboBox();
            label80 = new Label();
            comboBox34 = new ComboBox();
            label81 = new Label();
            comboBox35 = new ComboBox();
            label82 = new Label();
            comboBox36 = new ComboBox();
            label83 = new Label();
            groupBox11 = new GroupBox();
            textBox19 = new TextBox();
            label84 = new Label();
            comboBox37 = new ComboBox();
            label85 = new Label();
            checkBox22 = new CheckBox();
            label86 = new Label();
            textBox20 = new TextBox();
            label87 = new Label();
            checkBox23 = new CheckBox();
            label88 = new Label();
            comboBox38 = new ComboBox();
            label89 = new Label();
            textBox21 = new TextBox();
            label90 = new Label();
            comboBox39 = new ComboBox();
            label91 = new Label();
            comboBox40 = new ComboBox();
            label92 = new Label();
            groupBox12 = new GroupBox();
            comboBox41 = new ComboBox();
            comboBox42 = new ComboBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            textBox24 = new TextBox();
            textBox25 = new TextBox();
            textBox26 = new TextBox();
            textBox27 = new TextBox();
            label93 = new Label();
            label94 = new Label();
            label95 = new Label();
            label96 = new Label();
            label97 = new Label();
            label98 = new Label();
            label99 = new Label();
            checkBox24 = new CheckBox();
            label100 = new Label();
            label101 = new Label();
            label3 = new Label();
            pnlMenu = new Panel();
            menu = new TreeView();
            menuImgList = new ImageList(components);
            pnlModbusMaster = new Panel();
            label45 = new Label();
            pnlModbusSlave = new Panel();
            label44 = new Label();
            pnlAISettings = new Panel();
            btnWriteMemoryAI = new Button();
            btnReadMemoryAI = new Button();
            groupBox4 = new GroupBox();
            chkUser6 = new CheckBox();
            label36 = new Label();
            chkUser5 = new CheckBox();
            label35 = new Label();
            chkUser4 = new CheckBox();
            label34 = new Label();
            chkUser3 = new CheckBox();
            label33 = new Label();
            chkUser2 = new CheckBox();
            label32 = new Label();
            chkUser1 = new CheckBox();
            label31 = new Label();
            groupBox3 = new GroupBox();
            cmbDO8 = new ComboBox();
            label30 = new Label();
            cmbDO7 = new ComboBox();
            label29 = new Label();
            cmbDO6 = new ComboBox();
            label28 = new Label();
            cmbDO5 = new ComboBox();
            label27 = new Label();
            cmbDO4 = new ComboBox();
            label26 = new Label();
            cmbDO3 = new ComboBox();
            label25 = new Label();
            cmbDO2 = new ComboBox();
            label24 = new Label();
            cmbDO1 = new ComboBox();
            label23 = new Label();
            groupBox2 = new GroupBox();
            txtKFactor = new TextBox();
            chkDataReport = new CheckBox();
            label1 = new Label();
            txtTotalizerUnit = new TextBox();
            label22 = new Label();
            cmbReportDataType = new ComboBox();
            label21 = new Label();
            txtDisplayDecimalPoint = new TextBox();
            label19 = new Label();
            chkVolatileFlag = new CheckBox();
            label18 = new Label();
            txtTimebase = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label11 = new Label();
            chkTotalizer = new CheckBox();
            cmbSelectChannel = new ComboBox();
            label15 = new Label();
            groupBox1 = new GroupBox();
            cmbAIReportDataType = new ComboBox();
            label39 = new Label();
            chkAIDataReport = new CheckBox();
            label38 = new Label();
            txtAlarmSmsInterval = new TextBox();
            label37 = new Label();
            txtAlarmConfirmationSec = new TextBox();
            label20 = new Label();
            cmbAIAlarm = new ComboBox();
            cmbAIType = new ComboBox();
            txtThresoldLow = new TextBox();
            txtThresoldHigh = new TextBox();
            txtMaxValue = new TextBox();
            txtMinValue = new TextBox();
            txtUnit = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label13 = new Label();
            label6 = new Label();
            label12 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            LoginTimer = new System.Windows.Forms.Timer(components);
            btnConnect = new Button();
            cmbComPorts = new ComboBox();
            label14 = new Label();
            pnlConnect = new Panel();
            label133 = new Label();
            lblProgressPercent = new Label();
            pbProcessing = new ProgressBar();
            pnlDashboard.SuspendLayout();
            pnlGeneralSettings.SuspendLayout();
            groupBox13.SuspendLayout();
            pnlUser.SuspendLayout();
            groupBox15.SuspendLayout();
            pnlDOSettings.SuspendLayout();
            groupBox14.SuspendLayout();
            pnlDISettings.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            pnlPulseSettings.SuspendLayout();
            groupBox7.SuspendLayout();
            pnlModbusSettings.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlModbusMaster.SuspendLayout();
            pnlModbusSlave.SuspendLayout();
            pnlAISettings.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlConnect.SuspendLayout();
            SuspendLayout();
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Location = new Point(1388, 9);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(46, 20);
            lnkLogin.TabIndex = 0;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Login";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlAISettings);
            pnlDashboard.Controls.Add(pnlDISettings);
            pnlDashboard.Controls.Add(pnlDOSettings);
            pnlDashboard.Controls.Add(pnlPulseSettings);
            pnlDashboard.Controls.Add(pnlUser);
            pnlDashboard.Controls.Add(pnlGeneralSettings);
            pnlDashboard.Controls.Add(pnlModbusSettings);
            pnlDashboard.Controls.Add(pnlMenu);
            pnlDashboard.Controls.Add(pnlModbusMaster);
            pnlDashboard.Controls.Add(pnlModbusSlave);
            pnlDashboard.Location = new Point(7, 87);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1460, 834);
            pnlDashboard.TabIndex = 1;
            pnlDashboard.Visible = false;
            // 
            // pnlGeneralSettings
            // 
            pnlGeneralSettings.Controls.Add(btnGeneralWriteMemory);
            pnlGeneralSettings.Controls.Add(btnGeneralReadMemory);
            pnlGeneralSettings.Controls.Add(groupBox13);
            pnlGeneralSettings.Controls.Add(label2);
            pnlGeneralSettings.Location = new Point(321, 9);
            pnlGeneralSettings.Name = "pnlGeneralSettings";
            pnlGeneralSettings.Size = new Size(1133, 822);
            pnlGeneralSettings.TabIndex = 1;
            pnlGeneralSettings.Visible = false;
            // 
            // btnGeneralWriteMemory
            // 
            btnGeneralWriteMemory.BackColor = Color.Red;
            btnGeneralWriteMemory.Cursor = Cursors.Hand;
            btnGeneralWriteMemory.ForeColor = Color.White;
            btnGeneralWriteMemory.Location = new Point(604, 690);
            btnGeneralWriteMemory.Name = "btnGeneralWriteMemory";
            btnGeneralWriteMemory.Size = new Size(172, 42);
            btnGeneralWriteMemory.TabIndex = 59;
            btnGeneralWriteMemory.Text = "Write Memory";
            btnGeneralWriteMemory.UseVisualStyleBackColor = false;
            btnGeneralWriteMemory.Click += btnGeneralWriteMemory_Click;
            // 
            // btnGeneralReadMemory
            // 
            btnGeneralReadMemory.BackColor = Color.DarkKhaki;
            btnGeneralReadMemory.Cursor = Cursors.Hand;
            btnGeneralReadMemory.ForeColor = Color.White;
            btnGeneralReadMemory.Location = new Point(332, 690);
            btnGeneralReadMemory.Name = "btnGeneralReadMemory";
            btnGeneralReadMemory.Size = new Size(190, 42);
            btnGeneralReadMemory.TabIndex = 58;
            btnGeneralReadMemory.Text = "Read Memory";
            btnGeneralReadMemory.UseVisualStyleBackColor = false;
            btnGeneralReadMemory.Click += btnGeneralReadMemory_Click;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(txtIemiNo);
            groupBox13.Controls.Add(chkGeneralRtcDebug);
            groupBox13.Controls.Add(label136);
            groupBox13.Controls.Add(chkGeneralModbusDebug);
            groupBox13.Controls.Add(label135);
            groupBox13.Controls.Add(label111);
            groupBox13.Controls.Add(txtGeneralSetTime);
            groupBox13.Controls.Add(dtGeneralSetDate);
            groupBox13.Controls.Add(label61);
            groupBox13.Controls.Add(label60);
            groupBox13.Controls.Add(txtGeneralUserId);
            groupBox13.Controls.Add(txtGeneralDataLogSec);
            groupBox13.Controls.Add(label63);
            groupBox13.Controls.Add(txtGeneralSmsLogSec);
            groupBox13.Controls.Add(label66);
            groupBox13.Controls.Add(label109);
            groupBox13.Controls.Add(label110);
            groupBox13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox13.Location = new Point(273, 93);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(533, 427);
            groupBox13.TabIndex = 57;
            groupBox13.TabStop = false;
            groupBox13.Text = "Settings";
            // 
            // txtIemiNo
            // 
            txtIemiNo.BorderStyle = BorderStyle.FixedSingle;
            txtIemiNo.Location = new Point(324, 84);
            txtIemiNo.MaxLength = 15;
            txtIemiNo.Name = "txtIemiNo";
            txtIemiNo.Size = new Size(188, 27);
            txtIemiNo.TabIndex = 45;
            // 
            // chkGeneralRtcDebug
            // 
            chkGeneralRtcDebug.AutoSize = true;
            chkGeneralRtcDebug.Location = new Point(325, 338);
            chkGeneralRtcDebug.Name = "chkGeneralRtcDebug";
            chkGeneralRtcDebug.Size = new Size(18, 17);
            chkGeneralRtcDebug.TabIndex = 44;
            chkGeneralRtcDebug.UseVisualStyleBackColor = true;
            // 
            // label136
            // 
            label136.AutoSize = true;
            label136.Location = new Point(15, 337);
            label136.MaximumSize = new Size(150, 0);
            label136.Name = "label136";
            label136.Size = new Size(82, 20);
            label136.TabIndex = 43;
            label136.Text = "Rtc Debug";
            // 
            // chkGeneralModbusDebug
            // 
            chkGeneralModbusDebug.AutoSize = true;
            chkGeneralModbusDebug.Location = new Point(325, 304);
            chkGeneralModbusDebug.Name = "chkGeneralModbusDebug";
            chkGeneralModbusDebug.Size = new Size(18, 17);
            chkGeneralModbusDebug.TabIndex = 42;
            chkGeneralModbusDebug.UseVisualStyleBackColor = true;
            // 
            // label135
            // 
            label135.AutoSize = true;
            label135.Location = new Point(15, 295);
            label135.MaximumSize = new Size(150, 0);
            label135.Name = "label135";
            label135.Size = new Size(116, 20);
            label135.TabIndex = 41;
            label135.Text = "Modbus Debug";
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Location = new Point(450, 264);
            label111.MaximumSize = new Size(164, 60);
            label111.Name = "label111";
            label111.Size = new Size(63, 20);
            label111.TabIndex = 40;
            label111.Text = "HH:MM";
            // 
            // txtGeneralSetTime
            // 
            txtGeneralSetTime.BorderStyle = BorderStyle.FixedSingle;
            txtGeneralSetTime.Location = new Point(324, 260);
            txtGeneralSetTime.MaxLength = 5;
            txtGeneralSetTime.Name = "txtGeneralSetTime";
            txtGeneralSetTime.Size = new Size(114, 27);
            txtGeneralSetTime.TabIndex = 39;
            // 
            // dtGeneralSetDate
            // 
            dtGeneralSetDate.Location = new Point(325, 216);
            dtGeneralSetDate.Name = "dtGeneralSetDate";
            dtGeneralSetDate.Size = new Size(188, 27);
            dtGeneralSetDate.TabIndex = 38;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Location = new Point(15, 253);
            label61.MaximumSize = new Size(164, 60);
            label61.Name = "label61";
            label61.Size = new Size(70, 20);
            label61.TabIndex = 37;
            label61.Text = "Set Time";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(15, 211);
            label60.MaximumSize = new Size(164, 60);
            label60.Name = "label60";
            label60.Size = new Size(68, 20);
            label60.TabIndex = 36;
            label60.Text = "Set Date";
            // 
            // txtGeneralUserId
            // 
            txtGeneralUserId.BorderStyle = BorderStyle.FixedSingle;
            txtGeneralUserId.Location = new Point(324, 40);
            txtGeneralUserId.MaxLength = 10;
            txtGeneralUserId.Name = "txtGeneralUserId";
            txtGeneralUserId.Size = new Size(188, 27);
            txtGeneralUserId.TabIndex = 34;
            // 
            // txtGeneralDataLogSec
            // 
            txtGeneralDataLogSec.BorderStyle = BorderStyle.FixedSingle;
            txtGeneralDataLogSec.Location = new Point(324, 128);
            txtGeneralDataLogSec.MaxLength = 6;
            txtGeneralDataLogSec.Name = "txtGeneralDataLogSec";
            txtGeneralDataLogSec.Size = new Size(188, 27);
            txtGeneralDataLogSec.TabIndex = 31;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Location = new Point(14, 127);
            label63.MaximumSize = new Size(164, 60);
            label63.Name = "label63";
            label63.Size = new Size(99, 20);
            label63.TabIndex = 30;
            label63.Text = "Data Log Sec";
            // 
            // txtGeneralSmsLogSec
            // 
            txtGeneralSmsLogSec.BorderStyle = BorderStyle.FixedSingle;
            txtGeneralSmsLogSec.Location = new Point(324, 172);
            txtGeneralSmsLogSec.MaxLength = 6;
            txtGeneralSmsLogSec.Name = "txtGeneralSmsLogSec";
            txtGeneralSmsLogSec.Size = new Size(189, 27);
            txtGeneralSmsLogSec.TabIndex = 29;
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new Point(13, 169);
            label66.MaximumSize = new Size(164, 60);
            label66.Name = "label66";
            label66.Size = new Size(123, 20);
            label66.TabIndex = 28;
            label66.Text = "SMS Log Second";
            // 
            // label109
            // 
            label109.AutoSize = true;
            label109.Location = new Point(13, 85);
            label109.MaximumSize = new Size(150, 0);
            label109.Name = "label109";
            label109.Size = new Size(103, 20);
            label109.TabIndex = 19;
            label109.Text = "IEMI Number";
            // 
            // label110
            // 
            label110.AutoSize = true;
            label110.Location = new Point(15, 43);
            label110.Name = "label110";
            label110.Size = new Size(75, 20);
            label110.TabIndex = 28;
            label110.Text = "Device ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(463, 19);
            label2.Name = "label2";
            label2.Size = new Size(190, 31);
            label2.TabIndex = 35;
            label2.Text = "General Settings";
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(cmbUserIndex);
            pnlUser.Controls.Add(label128);
            pnlUser.Controls.Add(btnUserWriteMemory);
            pnlUser.Controls.Add(btnUserReadMemory);
            pnlUser.Controls.Add(groupBox15);
            pnlUser.Controls.Add(label43);
            pnlUser.Location = new Point(321, 9);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(1133, 822);
            pnlUser.TabIndex = 5;
            pnlUser.Visible = false;
            // 
            // cmbUserIndex
            // 
            cmbUserIndex.FormattingEnabled = true;
            cmbUserIndex.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            cmbUserIndex.Location = new Point(556, 75);
            cmbUserIndex.Name = "cmbUserIndex";
            cmbUserIndex.Size = new Size(151, 28);
            cmbUserIndex.TabIndex = 64;
            // 
            // label128
            // 
            label128.AutoSize = true;
            label128.Location = new Point(424, 79);
            label128.Name = "label128";
            label128.Size = new Size(122, 20);
            label128.TabIndex = 63;
            label128.Text = "Select User Index";
            // 
            // btnUserWriteMemory
            // 
            btnUserWriteMemory.BackColor = Color.Red;
            btnUserWriteMemory.Cursor = Cursors.Hand;
            btnUserWriteMemory.ForeColor = Color.White;
            btnUserWriteMemory.Location = new Point(631, 689);
            btnUserWriteMemory.Name = "btnUserWriteMemory";
            btnUserWriteMemory.Size = new Size(172, 42);
            btnUserWriteMemory.TabIndex = 62;
            btnUserWriteMemory.Text = "Write Memory";
            btnUserWriteMemory.UseVisualStyleBackColor = false;
            btnUserWriteMemory.Click += btnUserWriteMemory_Click;
            // 
            // btnUserReadMemory
            // 
            btnUserReadMemory.BackColor = Color.DarkKhaki;
            btnUserReadMemory.Cursor = Cursors.Hand;
            btnUserReadMemory.ForeColor = Color.White;
            btnUserReadMemory.Location = new Point(359, 689);
            btnUserReadMemory.Name = "btnUserReadMemory";
            btnUserReadMemory.Size = new Size(190, 42);
            btnUserReadMemory.TabIndex = 61;
            btnUserReadMemory.Text = "Read Memory";
            btnUserReadMemory.UseVisualStyleBackColor = false;
            btnUserReadMemory.Click += btnUserReadMemory_Click;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(chkUserSmsTimerReport);
            groupBox15.Controls.Add(label134);
            groupBox15.Controls.Add(cmbUserSelectDo);
            groupBox15.Controls.Add(chkUserIsVolatile);
            groupBox15.Controls.Add(label129);
            groupBox15.Controls.Add(label112);
            groupBox15.Controls.Add(chkUserCanCall);
            groupBox15.Controls.Add(chkUserIsAlarm);
            groupBox15.Controls.Add(chkUserIsAdmin);
            groupBox15.Controls.Add(chkUserSmsOnGprsFail);
            groupBox15.Controls.Add(chkUserSmsOnLowTower);
            groupBox15.Controls.Add(label113);
            groupBox15.Controls.Add(label122);
            groupBox15.Controls.Add(chkUserSmsOnPowerOn);
            groupBox15.Controls.Add(txtUserMobileNo);
            groupBox15.Controls.Add(label123);
            groupBox15.Controls.Add(label124);
            groupBox15.Controls.Add(label125);
            groupBox15.Controls.Add(label126);
            groupBox15.Controls.Add(label127);
            groupBox15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox15.Location = new Point(300, 120);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new Size(533, 509);
            groupBox15.TabIndex = 60;
            groupBox15.TabStop = false;
            groupBox15.Text = "User Setup";
            // 
            // chkUserSmsTimerReport
            // 
            chkUserSmsTimerReport.AutoSize = true;
            chkUserSmsTimerReport.Location = new Point(325, 92);
            chkUserSmsTimerReport.Name = "chkUserSmsTimerReport";
            chkUserSmsTimerReport.Size = new Size(18, 17);
            chkUserSmsTimerReport.TabIndex = 67;
            chkUserSmsTimerReport.UseVisualStyleBackColor = true;
            // 
            // label134
            // 
            label134.AutoSize = true;
            label134.Location = new Point(15, 84);
            label134.MaximumSize = new Size(150, 0);
            label134.Name = "label134";
            label134.Size = new Size(135, 20);
            label134.TabIndex = 66;
            label134.Text = "Sms Timer Report";
            // 
            // cmbUserSelectDo
            // 
            cmbUserSelectDo.FormattingEnabled = true;
            cmbUserSelectDo.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbUserSelectDo.Location = new Point(324, 386);
            cmbUserSelectDo.Name = "cmbUserSelectDo";
            cmbUserSelectDo.Size = new Size(188, 28);
            cmbUserSelectDo.TabIndex = 65;
            // 
            // chkUserIsVolatile
            // 
            chkUserIsVolatile.AutoSize = true;
            chkUserIsVolatile.Location = new Point(325, 439);
            chkUserIsVolatile.Name = "chkUserIsVolatile";
            chkUserIsVolatile.Size = new Size(18, 17);
            chkUserIsVolatile.TabIndex = 45;
            chkUserIsVolatile.UseVisualStyleBackColor = true;
            // 
            // label129
            // 
            label129.AutoSize = true;
            label129.Location = new Point(15, 435);
            label129.MaximumSize = new Size(164, 60);
            label129.Name = "label129";
            label129.Size = new Size(77, 20);
            label129.TabIndex = 44;
            label129.Text = "Is Volatile";
            // 
            // label112
            // 
            label112.AutoSize = true;
            label112.Location = new Point(13, 390);
            label112.MaximumSize = new Size(164, 60);
            label112.Name = "label112";
            label112.Size = new Size(76, 20);
            label112.TabIndex = 43;
            label112.Text = "Select DO";
            // 
            // chkUserCanCall
            // 
            chkUserCanCall.AutoSize = true;
            chkUserCanCall.Location = new Point(325, 344);
            chkUserCanCall.Name = "chkUserCanCall";
            chkUserCanCall.Size = new Size(18, 17);
            chkUserCanCall.TabIndex = 42;
            chkUserCanCall.UseVisualStyleBackColor = true;
            // 
            // chkUserIsAlarm
            // 
            chkUserIsAlarm.AutoSize = true;
            chkUserIsAlarm.Location = new Point(324, 302);
            chkUserIsAlarm.Name = "chkUserIsAlarm";
            chkUserIsAlarm.Size = new Size(18, 17);
            chkUserIsAlarm.TabIndex = 41;
            chkUserIsAlarm.UseVisualStyleBackColor = true;
            // 
            // chkUserIsAdmin
            // 
            chkUserIsAdmin.AutoSize = true;
            chkUserIsAdmin.Location = new Point(325, 260);
            chkUserIsAdmin.Name = "chkUserIsAdmin";
            chkUserIsAdmin.Size = new Size(18, 17);
            chkUserIsAdmin.TabIndex = 40;
            chkUserIsAdmin.UseVisualStyleBackColor = true;
            // 
            // chkUserSmsOnGprsFail
            // 
            chkUserSmsOnGprsFail.AutoSize = true;
            chkUserSmsOnGprsFail.Location = new Point(325, 218);
            chkUserSmsOnGprsFail.Name = "chkUserSmsOnGprsFail";
            chkUserSmsOnGprsFail.Size = new Size(18, 17);
            chkUserSmsOnGprsFail.TabIndex = 39;
            chkUserSmsOnGprsFail.UseVisualStyleBackColor = true;
            // 
            // chkUserSmsOnLowTower
            // 
            chkUserSmsOnLowTower.AutoSize = true;
            chkUserSmsOnLowTower.Location = new Point(325, 176);
            chkUserSmsOnLowTower.Name = "chkUserSmsOnLowTower";
            chkUserSmsOnLowTower.Size = new Size(18, 17);
            chkUserSmsOnLowTower.TabIndex = 38;
            chkUserSmsOnLowTower.UseVisualStyleBackColor = true;
            // 
            // label113
            // 
            label113.AutoSize = true;
            label113.Location = new Point(15, 342);
            label113.MaximumSize = new Size(164, 60);
            label113.Name = "label113";
            label113.Size = new Size(64, 20);
            label113.TabIndex = 37;
            label113.Text = "Can Call";
            // 
            // label122
            // 
            label122.AutoSize = true;
            label122.Location = new Point(15, 299);
            label122.MaximumSize = new Size(164, 60);
            label122.Name = "label122";
            label122.Size = new Size(68, 20);
            label122.TabIndex = 36;
            label122.Text = "Is Alarm";
            // 
            // chkUserSmsOnPowerOn
            // 
            chkUserSmsOnPowerOn.AutoSize = true;
            chkUserSmsOnPowerOn.Location = new Point(325, 134);
            chkUserSmsOnPowerOn.Name = "chkUserSmsOnPowerOn";
            chkUserSmsOnPowerOn.Size = new Size(18, 17);
            chkUserSmsOnPowerOn.TabIndex = 35;
            chkUserSmsOnPowerOn.UseVisualStyleBackColor = true;
            // 
            // txtUserMobileNo
            // 
            txtUserMobileNo.BorderStyle = BorderStyle.FixedSingle;
            txtUserMobileNo.Location = new Point(324, 40);
            txtUserMobileNo.MaxLength = 10;
            txtUserMobileNo.Name = "txtUserMobileNo";
            txtUserMobileNo.Size = new Size(188, 27);
            txtUserMobileNo.TabIndex = 34;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Location = new Point(14, 213);
            label123.MaximumSize = new Size(164, 60);
            label123.Name = "label123";
            label123.Size = new Size(131, 20);
            label123.TabIndex = 30;
            label123.Text = "SMS on GPRS Fail";
            // 
            // label124
            // 
            label124.AutoSize = true;
            label124.Location = new Point(13, 256);
            label124.MaximumSize = new Size(164, 60);
            label124.Name = "label124";
            label124.Size = new Size(72, 20);
            label124.TabIndex = 28;
            label124.Text = "Is Admin";
            // 
            // label125
            // 
            label125.AutoSize = true;
            label125.Location = new Point(14, 170);
            label125.Name = "label125";
            label125.Size = new Size(141, 20);
            label125.TabIndex = 21;
            label125.Text = "SMS on Low Tower";
            // 
            // label126
            // 
            label126.AutoSize = true;
            label126.Location = new Point(13, 127);
            label126.MaximumSize = new Size(150, 0);
            label126.Name = "label126";
            label126.Size = new Size(131, 20);
            label126.TabIndex = 19;
            label126.Text = "SMS on Power on";
            // 
            // label127
            // 
            label127.AutoSize = true;
            label127.Location = new Point(15, 41);
            label127.Name = "label127";
            label127.Size = new Size(119, 20);
            label127.TabIndex = 28;
            label127.Text = "Mobile Number";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label43.Location = new Point(538, 6);
            label43.Name = "label43";
            label43.Size = new Size(62, 31);
            label43.TabIndex = 1;
            label43.Text = "User";
            // 
            // pnlDOSettings
            // 
            pnlDOSettings.Controls.Add(btnDOWriteMemory);
            pnlDOSettings.Controls.Add(btnDOReadMemory);
            pnlDOSettings.Controls.Add(cmbDOSelectChannel);
            pnlDOSettings.Controls.Add(label115);
            pnlDOSettings.Controls.Add(groupBox14);
            pnlDOSettings.Controls.Add(label40);
            pnlDOSettings.Location = new Point(321, 9);
            pnlDOSettings.Name = "pnlDOSettings";
            pnlDOSettings.Size = new Size(1133, 822);
            pnlDOSettings.TabIndex = 2;
            pnlDOSettings.Visible = false;
            // 
            // btnDOWriteMemory
            // 
            btnDOWriteMemory.BackColor = Color.Red;
            btnDOWriteMemory.Cursor = Cursors.Hand;
            btnDOWriteMemory.ForeColor = Color.White;
            btnDOWriteMemory.Location = new Point(597, 729);
            btnDOWriteMemory.Name = "btnDOWriteMemory";
            btnDOWriteMemory.Size = new Size(172, 42);
            btnDOWriteMemory.TabIndex = 56;
            btnDOWriteMemory.Text = "Write Memory";
            btnDOWriteMemory.UseVisualStyleBackColor = false;
            btnDOWriteMemory.Click += btnDOWriteMemory_Click;
            // 
            // btnDOReadMemory
            // 
            btnDOReadMemory.BackColor = Color.DarkKhaki;
            btnDOReadMemory.Cursor = Cursors.Hand;
            btnDOReadMemory.ForeColor = Color.White;
            btnDOReadMemory.Location = new Point(325, 729);
            btnDOReadMemory.Name = "btnDOReadMemory";
            btnDOReadMemory.Size = new Size(190, 42);
            btnDOReadMemory.TabIndex = 55;
            btnDOReadMemory.Text = "Read Memory";
            btnDOReadMemory.UseVisualStyleBackColor = false;
            btnDOReadMemory.Click += btnDOReadMemory_Click;
            // 
            // cmbDOSelectChannel
            // 
            cmbDOSelectChannel.BackColor = SystemColors.HighlightText;
            cmbDOSelectChannel.Cursor = Cursors.Hand;
            cmbDOSelectChannel.FlatStyle = FlatStyle.Popup;
            cmbDOSelectChannel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDOSelectChannel.FormattingEnabled = true;
            cmbDOSelectChannel.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cmbDOSelectChannel.Location = new Point(491, 76);
            cmbDOSelectChannel.Name = "cmbDOSelectChannel";
            cmbDOSelectChannel.Size = new Size(224, 28);
            cmbDOSelectChannel.TabIndex = 52;
            // 
            // label115
            // 
            label115.AutoSize = true;
            label115.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label115.Location = new Point(362, 79);
            label115.Name = "label115";
            label115.Size = new Size(110, 20);
            label115.TabIndex = 51;
            label115.Text = "Select Channel";
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(label121);
            groupBox14.Controls.Add(label120);
            groupBox14.Controls.Add(txtDoOnTime);
            groupBox14.Controls.Add(label117);
            groupBox14.Controls.Add(txtDoOffTime);
            groupBox14.Controls.Add(label116);
            groupBox14.Controls.Add(txtDoRelayDelayTime);
            groupBox14.Controls.Add(label118);
            groupBox14.Controls.Add(txtDoRelayCloseOn);
            groupBox14.Controls.Add(label119);
            groupBox14.Controls.Add(cmbDOType);
            groupBox14.Controls.Add(label114);
            groupBox14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox14.Location = new Point(362, 129);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(361, 300);
            groupBox14.TabIndex = 50;
            groupBox14.TabStop = false;
            groupBox14.Text = "DO Channel Setup";
            // 
            // label121
            // 
            label121.AutoSize = true;
            label121.Location = new Point(290, 212);
            label121.MaximumSize = new Size(164, 60);
            label121.Name = "label121";
            label121.Size = new Size(63, 20);
            label121.TabIndex = 33;
            label121.Text = "HH:MM";
            // 
            // label120
            // 
            label120.AutoSize = true;
            label120.Location = new Point(289, 166);
            label120.MaximumSize = new Size(164, 60);
            label120.Name = "label120";
            label120.Size = new Size(63, 20);
            label120.TabIndex = 32;
            label120.Text = "HH:MM";
            // 
            // txtDoOnTime
            // 
            txtDoOnTime.BorderStyle = BorderStyle.FixedSingle;
            txtDoOnTime.Location = new Point(162, 163);
            txtDoOnTime.MaxLength = 5;
            txtDoOnTime.Name = "txtDoOnTime";
            txtDoOnTime.Size = new Size(118, 27);
            txtDoOnTime.TabIndex = 31;
            // 
            // label117
            // 
            label117.AutoSize = true;
            label117.Location = new Point(14, 169);
            label117.MaximumSize = new Size(164, 60);
            label117.Name = "label117";
            label117.Size = new Size(68, 20);
            label117.TabIndex = 30;
            label117.Text = "On Time";
            // 
            // txtDoOffTime
            // 
            txtDoOffTime.BorderStyle = BorderStyle.FixedSingle;
            txtDoOffTime.Location = new Point(162, 210);
            txtDoOffTime.MaxLength = 5;
            txtDoOffTime.Name = "txtDoOffTime";
            txtDoOffTime.Size = new Size(117, 27);
            txtDoOffTime.TabIndex = 29;
            // 
            // label116
            // 
            label116.AutoSize = true;
            label116.Location = new Point(13, 211);
            label116.MaximumSize = new Size(164, 60);
            label116.Name = "label116";
            label116.Size = new Size(71, 20);
            label116.TabIndex = 28;
            label116.Text = "Off Time";
            // 
            // txtDoRelayDelayTime
            // 
            txtDoRelayDelayTime.BorderStyle = BorderStyle.FixedSingle;
            txtDoRelayDelayTime.Location = new Point(162, 120);
            txtDoRelayDelayTime.MaxLength = 10;
            txtDoRelayDelayTime.Name = "txtDoRelayDelayTime";
            txtDoRelayDelayTime.Size = new Size(189, 27);
            txtDoRelayDelayTime.TabIndex = 22;
            // 
            // label118
            // 
            label118.AutoSize = true;
            label118.Location = new Point(14, 127);
            label118.Name = "label118";
            label118.Size = new Size(129, 20);
            label118.TabIndex = 21;
            label118.Text = "Relay Delay Time";
            // 
            // txtDoRelayCloseOn
            // 
            txtDoRelayCloseOn.BorderStyle = BorderStyle.FixedSingle;
            txtDoRelayCloseOn.Location = new Point(162, 77);
            txtDoRelayCloseOn.MaxLength = 10;
            txtDoRelayCloseOn.Name = "txtDoRelayCloseOn";
            txtDoRelayCloseOn.Size = new Size(188, 27);
            txtDoRelayCloseOn.TabIndex = 20;
            // 
            // label119
            // 
            label119.AutoSize = true;
            label119.Location = new Point(13, 85);
            label119.MaximumSize = new Size(150, 0);
            label119.Name = "label119";
            label119.Size = new Size(127, 20);
            label119.TabIndex = 19;
            label119.Text = "Relay Close Time";
            // 
            // cmbDOType
            // 
            cmbDOType.FormattingEnabled = true;
            cmbDOType.Items.AddRange(new object[] { "Ignore - 0", "Close Alarm-1", "OC-CO-3", "Close Alarm-4", "Static Command-5", "Dynamic Command-6" });
            cmbDOType.Location = new Point(162, 33);
            cmbDOType.Name = "cmbDOType";
            cmbDOType.Size = new Size(187, 28);
            cmbDOType.TabIndex = 29;
            // 
            // label114
            // 
            label114.AutoSize = true;
            label114.Location = new Point(15, 43);
            label114.Name = "label114";
            label114.Size = new Size(66, 20);
            label114.TabIndex = 28;
            label114.Text = "D0 Type";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label40.Location = new Point(486, 6);
            label40.Name = "label40";
            label40.Size = new Size(142, 31);
            label40.TabIndex = 0;
            label40.Text = "DO Settings";
            // 
            // pnlDISettings
            // 
            pnlDISettings.Controls.Add(btnDIWriteMemory);
            pnlDISettings.Controls.Add(btnDIReadMemory);
            pnlDISettings.Controls.Add(groupBox5);
            pnlDISettings.Controls.Add(groupBox6);
            pnlDISettings.Controls.Add(cmbDISelectChannel);
            pnlDISettings.Controls.Add(label68);
            pnlDISettings.Controls.Add(groupBox8);
            pnlDISettings.Controls.Add(label41);
            pnlDISettings.Location = new Point(321, 9);
            pnlDISettings.Name = "pnlDISettings";
            pnlDISettings.Size = new Size(1133, 822);
            pnlDISettings.TabIndex = 3;
            pnlDISettings.Visible = false;
            // 
            // btnDIWriteMemory
            // 
            btnDIWriteMemory.BackColor = Color.Red;
            btnDIWriteMemory.Cursor = Cursors.Hand;
            btnDIWriteMemory.ForeColor = Color.White;
            btnDIWriteMemory.Location = new Point(597, 757);
            btnDIWriteMemory.Name = "btnDIWriteMemory";
            btnDIWriteMemory.Size = new Size(172, 42);
            btnDIWriteMemory.TabIndex = 49;
            btnDIWriteMemory.Text = "Write Memory";
            btnDIWriteMemory.UseVisualStyleBackColor = false;
            btnDIWriteMemory.Click += btnDIWriteMemory_Click;
            // 
            // btnDIReadMemory
            // 
            btnDIReadMemory.BackColor = Color.DarkKhaki;
            btnDIReadMemory.Cursor = Cursors.Hand;
            btnDIReadMemory.ForeColor = Color.White;
            btnDIReadMemory.Location = new Point(325, 757);
            btnDIReadMemory.Name = "btnDIReadMemory";
            btnDIReadMemory.Size = new Size(190, 42);
            btnDIReadMemory.TabIndex = 48;
            btnDIReadMemory.Text = "Read Memory";
            btnDIReadMemory.UseVisualStyleBackColor = false;
            btnDIReadMemory.Click += btnDIReadMemory_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(chkDIUser6);
            groupBox5.Controls.Add(label46);
            groupBox5.Controls.Add(chkDIUser5);
            groupBox5.Controls.Add(label47);
            groupBox5.Controls.Add(chkDIUser4);
            groupBox5.Controls.Add(label48);
            groupBox5.Controls.Add(chkDIUser3);
            groupBox5.Controls.Add(label49);
            groupBox5.Controls.Add(chkDIUser2);
            groupBox5.Controls.Add(label50);
            groupBox5.Controls.Add(chkDIUser1);
            groupBox5.Controls.Add(label51);
            groupBox5.Location = new Point(763, 126);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(355, 400);
            groupBox5.TabIndex = 47;
            groupBox5.TabStop = false;
            groupBox5.Text = "Telephone to Alarm";
            // 
            // chkDIUser6
            // 
            chkDIUser6.AutoSize = true;
            chkDIUser6.Location = new Point(119, 199);
            chkDIUser6.Name = "chkDIUser6";
            chkDIUser6.Size = new Size(18, 17);
            chkDIUser6.TabIndex = 37;
            chkDIUser6.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(15, 196);
            label46.Name = "label46";
            label46.Size = new Size(58, 20);
            label46.TabIndex = 36;
            label46.Text = "USER-6";
            // 
            // chkDIUser5
            // 
            chkDIUser5.AutoSize = true;
            chkDIUser5.Location = new Point(119, 167);
            chkDIUser5.Name = "chkDIUser5";
            chkDIUser5.Size = new Size(18, 17);
            chkDIUser5.TabIndex = 35;
            chkDIUser5.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(15, 164);
            label47.Name = "label47";
            label47.Size = new Size(58, 20);
            label47.TabIndex = 34;
            label47.Text = "USER-5";
            // 
            // chkDIUser4
            // 
            chkDIUser4.AutoSize = true;
            chkDIUser4.Location = new Point(119, 135);
            chkDIUser4.Name = "chkDIUser4";
            chkDIUser4.Size = new Size(18, 17);
            chkDIUser4.TabIndex = 33;
            chkDIUser4.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(15, 132);
            label48.Name = "label48";
            label48.Size = new Size(58, 20);
            label48.TabIndex = 32;
            label48.Text = "USER-4";
            // 
            // chkDIUser3
            // 
            chkDIUser3.AutoSize = true;
            chkDIUser3.Location = new Point(119, 103);
            chkDIUser3.Name = "chkDIUser3";
            chkDIUser3.Size = new Size(18, 17);
            chkDIUser3.TabIndex = 31;
            chkDIUser3.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(15, 100);
            label49.Name = "label49";
            label49.Size = new Size(58, 20);
            label49.TabIndex = 30;
            label49.Text = "USER-3";
            // 
            // chkDIUser2
            // 
            chkDIUser2.AutoSize = true;
            chkDIUser2.Location = new Point(119, 71);
            chkDIUser2.Name = "chkDIUser2";
            chkDIUser2.Size = new Size(18, 17);
            chkDIUser2.TabIndex = 29;
            chkDIUser2.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(15, 68);
            label50.Name = "label50";
            label50.Size = new Size(58, 20);
            label50.TabIndex = 28;
            label50.Text = "USER-2";
            // 
            // chkDIUser1
            // 
            chkDIUser1.AutoSize = true;
            chkDIUser1.Location = new Point(119, 39);
            chkDIUser1.Name = "chkDIUser1";
            chkDIUser1.Size = new Size(18, 17);
            chkDIUser1.TabIndex = 27;
            chkDIUser1.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(15, 36);
            label51.Name = "label51";
            label51.Size = new Size(58, 20);
            label51.TabIndex = 26;
            label51.Text = "USER-1";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cmbDIDO8);
            groupBox6.Controls.Add(label52);
            groupBox6.Controls.Add(cmbDIDO7);
            groupBox6.Controls.Add(label53);
            groupBox6.Controls.Add(cmbDIDO6);
            groupBox6.Controls.Add(label54);
            groupBox6.Controls.Add(cmbDIDO5);
            groupBox6.Controls.Add(label55);
            groupBox6.Controls.Add(cmbDIDO4);
            groupBox6.Controls.Add(label56);
            groupBox6.Controls.Add(cmbDIDO3);
            groupBox6.Controls.Add(label57);
            groupBox6.Controls.Add(cmbDIDO2);
            groupBox6.Controls.Add(label58);
            groupBox6.Controls.Add(cmbDIDO1);
            groupBox6.Controls.Add(label59);
            groupBox6.Location = new Point(389, 126);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(361, 400);
            groupBox6.TabIndex = 46;
            groupBox6.TabStop = false;
            groupBox6.Text = "Digital Output";
            // 
            // cmbDIDO8
            // 
            cmbDIDO8.FormattingEnabled = true;
            cmbDIDO8.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDIDO8.Location = new Point(166, 289);
            cmbDIDO8.Name = "cmbDIDO8";
            cmbDIDO8.Size = new Size(185, 28);
            cmbDIDO8.TabIndex = 43;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(8, 303);
            label52.Name = "label52";
            label52.Size = new Size(53, 20);
            label52.TabIndex = 42;
            label52.Text = "DO - 8";
            // 
            // cmbDIDO7
            // 
            cmbDIDO7.FormattingEnabled = true;
            cmbDIDO7.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDIDO7.Location = new Point(166, 252);
            cmbDIDO7.Name = "cmbDIDO7";
            cmbDIDO7.Size = new Size(185, 28);
            cmbDIDO7.TabIndex = 41;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(6, 265);
            label53.Name = "label53";
            label53.Size = new Size(53, 20);
            label53.TabIndex = 40;
            label53.Text = "DO - 7";
            // 
            // cmbDIDO6
            // 
            cmbDIDO6.FormattingEnabled = true;
            cmbDIDO6.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDIDO6.Location = new Point(166, 215);
            cmbDIDO6.Name = "cmbDIDO6";
            cmbDIDO6.Size = new Size(185, 28);
            cmbDIDO6.TabIndex = 39;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(8, 227);
            label54.Name = "label54";
            label54.Size = new Size(53, 20);
            label54.TabIndex = 38;
            label54.Text = "DO - 6";
            // 
            // cmbDIDO5
            // 
            cmbDIDO5.FormattingEnabled = true;
            cmbDIDO5.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDIDO5.Location = new Point(166, 178);
            cmbDIDO5.Name = "cmbDIDO5";
            cmbDIDO5.Size = new Size(185, 28);
            cmbDIDO5.TabIndex = 37;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(8, 189);
            label55.Name = "label55";
            label55.Size = new Size(53, 20);
            label55.TabIndex = 36;
            label55.Text = "DO - 5";
            // 
            // cmbDIDO4
            // 
            cmbDIDO4.FormattingEnabled = true;
            cmbDIDO4.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDIDO4.Location = new Point(166, 141);
            cmbDIDO4.Name = "cmbDIDO4";
            cmbDIDO4.Size = new Size(185, 28);
            cmbDIDO4.TabIndex = 35;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(6, 151);
            label56.Name = "label56";
            label56.Size = new Size(53, 20);
            label56.TabIndex = 34;
            label56.Text = "DO - 4";
            // 
            // cmbDIDO3
            // 
            cmbDIDO3.FormattingEnabled = true;
            cmbDIDO3.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDIDO3.Location = new Point(166, 104);
            cmbDIDO3.Name = "cmbDIDO3";
            cmbDIDO3.Size = new Size(185, 28);
            cmbDIDO3.TabIndex = 33;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(6, 113);
            label57.Name = "label57";
            label57.Size = new Size(53, 20);
            label57.TabIndex = 32;
            label57.Text = "DO - 3";
            // 
            // cmbDIDO2
            // 
            cmbDIDO2.FormattingEnabled = true;
            cmbDIDO2.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDIDO2.Location = new Point(166, 67);
            cmbDIDO2.Name = "cmbDIDO2";
            cmbDIDO2.Size = new Size(185, 28);
            cmbDIDO2.TabIndex = 31;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new Point(6, 75);
            label58.Name = "label58";
            label58.Size = new Size(53, 20);
            label58.TabIndex = 30;
            label58.Text = "DO - 2";
            // 
            // cmbDIDO1
            // 
            cmbDIDO1.FormattingEnabled = true;
            cmbDIDO1.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDIDO1.Location = new Point(166, 30);
            cmbDIDO1.Name = "cmbDIDO1";
            cmbDIDO1.Size = new Size(185, 28);
            cmbDIDO1.TabIndex = 29;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Location = new Point(6, 37);
            label59.Name = "label59";
            label59.Size = new Size(53, 20);
            label59.TabIndex = 28;
            label59.Text = "DO - 1";
            // 
            // cmbDISelectChannel
            // 
            cmbDISelectChannel.BackColor = SystemColors.HighlightText;
            cmbDISelectChannel.Cursor = Cursors.Hand;
            cmbDISelectChannel.FlatStyle = FlatStyle.Popup;
            cmbDISelectChannel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDISelectChannel.FormattingEnabled = true;
            cmbDISelectChannel.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cmbDISelectChannel.Location = new Point(491, 79);
            cmbDISelectChannel.Name = "cmbDISelectChannel";
            cmbDISelectChannel.Size = new Size(224, 28);
            cmbDISelectChannel.TabIndex = 44;
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label68.Location = new Point(362, 82);
            label68.Name = "label68";
            label68.Size = new Size(110, 20);
            label68.TabIndex = 43;
            label68.Text = "Select Channel";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(cmbDIReportDt);
            groupBox8.Controls.Add(label132);
            groupBox8.Controls.Add(txtDISMSRepeatSec);
            groupBox8.Controls.Add(label69);
            groupBox8.Controls.Add(chkDIDataReport);
            groupBox8.Controls.Add(label102);
            groupBox8.Controls.Add(txtDISmsRepeatTime);
            groupBox8.Controls.Add(label103);
            groupBox8.Controls.Add(txtDIAlarmVerifySec);
            groupBox8.Controls.Add(label104);
            groupBox8.Controls.Add(cmbDIAlarm);
            groupBox8.Controls.Add(cmbDIType);
            groupBox8.Controls.Add(txtDIUnit);
            groupBox8.Controls.Add(txtDIName);
            groupBox8.Controls.Add(label105);
            groupBox8.Controls.Add(label106);
            groupBox8.Controls.Add(label107);
            groupBox8.Controls.Add(label108);
            groupBox8.Location = new Point(14, 126);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(361, 404);
            groupBox8.TabIndex = 42;
            groupBox8.TabStop = false;
            groupBox8.Text = "Channel Setup";
            // 
            // cmbDIReportDt
            // 
            cmbDIReportDt.FormattingEnabled = true;
            cmbDIReportDt.Items.AddRange(new object[] { "Decimal", "Hex", "Bin" });
            cmbDIReportDt.Location = new Point(164, 154);
            cmbDIReportDt.Name = "cmbDIReportDt";
            cmbDIReportDt.Size = new Size(185, 28);
            cmbDIReportDt.TabIndex = 31;
            // 
            // label132
            // 
            label132.AutoSize = true;
            label132.Location = new Point(14, 161);
            label132.Name = "label132";
            label132.Size = new Size(95, 20);
            label132.TabIndex = 30;
            label132.Text = "DI Report DT";
            // 
            // txtDISMSRepeatSec
            // 
            txtDISMSRepeatSec.BorderStyle = BorderStyle.FixedSingle;
            txtDISMSRepeatSec.Location = new Point(165, 279);
            txtDISMSRepeatSec.MaxLength = 10;
            txtDISMSRepeatSec.Name = "txtDISMSRepeatSec";
            txtDISMSRepeatSec.Size = new Size(185, 27);
            txtDISMSRepeatSec.TabIndex = 29;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Location = new Point(14, 286);
            label69.MaximumSize = new Size(164, 60);
            label69.Name = "label69";
            label69.Size = new Size(142, 20);
            label69.TabIndex = 28;
            label69.Text = "SMS Repeat Second";
            // 
            // chkDIDataReport
            // 
            chkDIDataReport.AutoSize = true;
            chkDIDataReport.Location = new Point(164, 118);
            chkDIDataReport.Name = "chkDIDataReport";
            chkDIDataReport.Size = new Size(18, 17);
            chkDIDataReport.TabIndex = 24;
            chkDIDataReport.UseVisualStyleBackColor = true;
            // 
            // label102
            // 
            label102.AutoSize = true;
            label102.Location = new Point(14, 118);
            label102.Name = "label102";
            label102.Size = new Size(109, 20);
            label102.TabIndex = 23;
            label102.Text = "DI Data Report";
            // 
            // txtDISmsRepeatTime
            // 
            txtDISmsRepeatTime.BorderStyle = BorderStyle.FixedSingle;
            txtDISmsRepeatTime.Location = new Point(165, 239);
            txtDISmsRepeatTime.MaxLength = 10;
            txtDISmsRepeatTime.Name = "txtDISmsRepeatTime";
            txtDISmsRepeatTime.Size = new Size(185, 27);
            txtDISmsRepeatTime.TabIndex = 22;
            // 
            // label103
            // 
            label103.AutoSize = true;
            label103.Location = new Point(15, 247);
            label103.Name = "label103";
            label103.Size = new Size(126, 20);
            label103.TabIndex = 21;
            label103.Text = "SMS Repeat Time";
            // 
            // txtDIAlarmVerifySec
            // 
            txtDIAlarmVerifySec.BorderStyle = BorderStyle.FixedSingle;
            txtDIAlarmVerifySec.Location = new Point(164, 199);
            txtDIAlarmVerifySec.MaxLength = 10;
            txtDIAlarmVerifySec.Name = "txtDIAlarmVerifySec";
            txtDIAlarmVerifySec.Size = new Size(185, 27);
            txtDIAlarmVerifySec.TabIndex = 20;
            // 
            // label104
            // 
            label104.AutoSize = true;
            label104.Location = new Point(14, 208);
            label104.MaximumSize = new Size(150, 0);
            label104.Name = "label104";
            label104.Size = new Size(117, 20);
            label104.TabIndex = 19;
            label104.Text = "Alarm Verify Sec";
            // 
            // cmbDIAlarm
            // 
            cmbDIAlarm.FormattingEnabled = true;
            cmbDIAlarm.Items.AddRange(new object[] { "AQUIRE 4~20mA", "AQUIRE & ALARM ABOVE HIGH THRESHOLD ", "AQUIRE & ALARM AT BELOW  LOW THRESHOLD 0~10 V", "AQUIRE & ALARM AT BOTH THRESHOLD" });
            cmbDIAlarm.Location = new Point(164, 360);
            cmbDIAlarm.Name = "cmbDIAlarm";
            cmbDIAlarm.Size = new Size(185, 28);
            cmbDIAlarm.TabIndex = 18;
            // 
            // cmbDIType
            // 
            cmbDIType.FormattingEnabled = true;
            cmbDIType.Items.AddRange(new object[] { "Ignore - 0", "4~20mA-1", "0~20mA-2", "0~5 V-3", "0~10 V-4" });
            cmbDIType.Location = new Point(164, 319);
            cmbDIType.Name = "cmbDIType";
            cmbDIType.Size = new Size(185, 28);
            cmbDIType.TabIndex = 17;
            // 
            // txtDIUnit
            // 
            txtDIUnit.BorderStyle = BorderStyle.FixedSingle;
            txtDIUnit.Location = new Point(164, 78);
            txtDIUnit.MaxLength = 10;
            txtDIUnit.Name = "txtDIUnit";
            txtDIUnit.Size = new Size(185, 27);
            txtDIUnit.TabIndex = 12;
            // 
            // txtDIName
            // 
            txtDIName.BorderStyle = BorderStyle.FixedSingle;
            txtDIName.Location = new Point(164, 38);
            txtDIName.MaxLength = 10;
            txtDIName.Name = "txtDIName";
            txtDIName.Size = new Size(185, 27);
            txtDIName.TabIndex = 11;
            // 
            // label105
            // 
            label105.AutoSize = true;
            label105.Location = new Point(14, 40);
            label105.Name = "label105";
            label105.Size = new Size(49, 20);
            label105.TabIndex = 1;
            label105.Text = "Name";
            // 
            // label106
            // 
            label106.AutoSize = true;
            label106.Location = new Point(14, 364);
            label106.Name = "label106";
            label106.Size = new Size(68, 20);
            label106.TabIndex = 10;
            label106.Text = "DI Alarm";
            // 
            // label107
            // 
            label107.AutoSize = true;
            label107.Location = new Point(14, 79);
            label107.Name = "label107";
            label107.Size = new Size(36, 20);
            label107.TabIndex = 2;
            label107.Text = "Unit";
            // 
            // label108
            // 
            label108.AutoSize = true;
            label108.Location = new Point(14, 325);
            label108.Name = "label108";
            label108.Size = new Size(59, 20);
            label108.TabIndex = 9;
            label108.Text = "DI Type";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label41.Location = new Point(498, 14);
            label41.Name = "label41";
            label41.Size = new Size(132, 31);
            label41.TabIndex = 1;
            label41.Text = "DI Settings";
            // 
            // pnlPulseSettings
            // 
            pnlPulseSettings.Controls.Add(btnPulseWriteMemory);
            pnlPulseSettings.Controls.Add(btnPulseReadMemory);
            pnlPulseSettings.Controls.Add(groupBox7);
            pnlPulseSettings.Controls.Add(label42);
            pnlPulseSettings.Location = new Point(321, 9);
            pnlPulseSettings.Name = "pnlPulseSettings";
            pnlPulseSettings.Size = new Size(1133, 822);
            pnlPulseSettings.TabIndex = 4;
            pnlPulseSettings.Visible = false;
            // 
            // btnPulseWriteMemory
            // 
            btnPulseWriteMemory.BackColor = Color.Red;
            btnPulseWriteMemory.Cursor = Cursors.Hand;
            btnPulseWriteMemory.ForeColor = Color.White;
            btnPulseWriteMemory.Location = new Point(620, 598);
            btnPulseWriteMemory.Name = "btnPulseWriteMemory";
            btnPulseWriteMemory.Size = new Size(172, 42);
            btnPulseWriteMemory.TabIndex = 58;
            btnPulseWriteMemory.Text = "Write Memory";
            btnPulseWriteMemory.UseVisualStyleBackColor = false;
            btnPulseWriteMemory.Click += btnPulseWriteMemory_Click;
            // 
            // btnPulseReadMemory
            // 
            btnPulseReadMemory.BackColor = Color.DarkKhaki;
            btnPulseReadMemory.Cursor = Cursors.Hand;
            btnPulseReadMemory.ForeColor = Color.White;
            btnPulseReadMemory.Location = new Point(348, 598);
            btnPulseReadMemory.Name = "btnPulseReadMemory";
            btnPulseReadMemory.Size = new Size(190, 42);
            btnPulseReadMemory.TabIndex = 57;
            btnPulseReadMemory.Text = "Read Memory";
            btnPulseReadMemory.UseVisualStyleBackColor = false;
            btnPulseReadMemory.Click += btnPulseReadMemory_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cmbPulseReportDT);
            groupBox7.Controls.Add(label131);
            groupBox7.Controls.Add(txtPulseDurationRef);
            groupBox7.Controls.Add(label130);
            groupBox7.Controls.Add(chkPulseIsVolatile);
            groupBox7.Controls.Add(label62);
            groupBox7.Controls.Add(txtPulseKfactor);
            groupBox7.Controls.Add(label64);
            groupBox7.Controls.Add(txtAdjustPulseCount);
            groupBox7.Controls.Add(label65);
            groupBox7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(375, 77);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(361, 300);
            groupBox7.TabIndex = 51;
            groupBox7.TabStop = false;
            groupBox7.Text = "Pulse Setup";
            // 
            // cmbPulseReportDT
            // 
            cmbPulseReportDT.FormattingEnabled = true;
            cmbPulseReportDT.Items.AddRange(new object[] { "Decimal", "Hex", "Bin" });
            cmbPulseReportDT.Location = new Point(162, 230);
            cmbPulseReportDT.Name = "cmbPulseReportDT";
            cmbPulseReportDT.Size = new Size(189, 28);
            cmbPulseReportDT.TabIndex = 35;
            // 
            // label131
            // 
            label131.AutoSize = true;
            label131.Location = new Point(16, 231);
            label131.MaximumSize = new Size(164, 60);
            label131.Name = "label131";
            label131.Size = new Size(121, 20);
            label131.TabIndex = 34;
            label131.Text = "Pulse Report DT";
            // 
            // txtPulseDurationRef
            // 
            txtPulseDurationRef.BorderStyle = BorderStyle.FixedSingle;
            txtPulseDurationRef.Location = new Point(162, 185);
            txtPulseDurationRef.MaxLength = 6;
            txtPulseDurationRef.Name = "txtPulseDurationRef";
            txtPulseDurationRef.Size = new Size(189, 27);
            txtPulseDurationRef.TabIndex = 33;
            // 
            // label130
            // 
            label130.AutoSize = true;
            label130.Location = new Point(14, 189);
            label130.MaximumSize = new Size(164, 60);
            label130.Name = "label130";
            label130.Size = new Size(140, 20);
            label130.TabIndex = 32;
            label130.Text = "Pulse Duration Ref";
            // 
            // chkPulseIsVolatile
            // 
            chkPulseIsVolatile.AutoSize = true;
            chkPulseIsVolatile.Location = new Point(163, 150);
            chkPulseIsVolatile.Name = "chkPulseIsVolatile";
            chkPulseIsVolatile.Size = new Size(18, 17);
            chkPulseIsVolatile.TabIndex = 31;
            chkPulseIsVolatile.UseVisualStyleBackColor = true;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Location = new Point(14, 147);
            label62.MaximumSize = new Size(164, 60);
            label62.Name = "label62";
            label62.Size = new Size(77, 20);
            label62.TabIndex = 30;
            label62.Text = "Is Volatile";
            // 
            // txtPulseKfactor
            // 
            txtPulseKfactor.BorderStyle = BorderStyle.FixedSingle;
            txtPulseKfactor.Location = new Point(162, 105);
            txtPulseKfactor.MaxLength = 10;
            txtPulseKfactor.Name = "txtPulseKfactor";
            txtPulseKfactor.Size = new Size(189, 27);
            txtPulseKfactor.TabIndex = 22;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new Point(14, 105);
            label64.Name = "label64";
            label64.Size = new Size(67, 20);
            label64.TabIndex = 21;
            label64.Text = "K Factor";
            // 
            // txtAdjustPulseCount
            // 
            txtAdjustPulseCount.BorderStyle = BorderStyle.FixedSingle;
            txtAdjustPulseCount.Location = new Point(162, 60);
            txtAdjustPulseCount.MaxLength = 10;
            txtAdjustPulseCount.Name = "txtAdjustPulseCount";
            txtAdjustPulseCount.Size = new Size(188, 27);
            txtAdjustPulseCount.TabIndex = 20;
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Location = new Point(13, 63);
            label65.MaximumSize = new Size(150, 0);
            label65.Name = "label65";
            label65.Size = new Size(142, 20);
            label65.TabIndex = 19;
            label65.Text = "Adjust Pulse Count";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label42.Location = new Point(475, 4);
            label42.Name = "label42";
            label42.Size = new Size(165, 31);
            label42.TabIndex = 1;
            label42.Text = "Pulse Settings";
            // 
            // pnlModbusSettings
            // 
            pnlModbusSettings.Controls.Add(button5);
            pnlModbusSettings.Controls.Add(button6);
            pnlModbusSettings.Controls.Add(groupBox9);
            pnlModbusSettings.Controls.Add(groupBox10);
            pnlModbusSettings.Controls.Add(groupBox11);
            pnlModbusSettings.Controls.Add(comboBox39);
            pnlModbusSettings.Controls.Add(label91);
            pnlModbusSettings.Controls.Add(comboBox40);
            pnlModbusSettings.Controls.Add(label92);
            pnlModbusSettings.Controls.Add(groupBox12);
            pnlModbusSettings.Controls.Add(label3);
            pnlModbusSettings.Location = new Point(321, 9);
            pnlModbusSettings.Name = "pnlModbusSettings";
            pnlModbusSettings.Size = new Size(1133, 822);
            pnlModbusSettings.TabIndex = 1;
            pnlModbusSettings.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = Color.White;
            button5.Location = new Point(762, 774);
            button5.Name = "button5";
            button5.Size = new Size(172, 42);
            button5.TabIndex = 30;
            button5.Text = "Write Memory";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkKhaki;
            button6.Cursor = Cursors.Hand;
            button6.ForeColor = Color.White;
            button6.Location = new Point(490, 774);
            button6.Name = "button6";
            button6.Size = new Size(190, 42);
            button6.TabIndex = 29;
            button6.Text = "Read Memory";
            button6.UseVisualStyleBackColor = false;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(checkBox16);
            groupBox9.Controls.Add(label70);
            groupBox9.Controls.Add(checkBox17);
            groupBox9.Controls.Add(label71);
            groupBox9.Controls.Add(checkBox18);
            groupBox9.Controls.Add(label72);
            groupBox9.Controls.Add(checkBox19);
            groupBox9.Controls.Add(label73);
            groupBox9.Controls.Add(checkBox20);
            groupBox9.Controls.Add(label74);
            groupBox9.Controls.Add(checkBox21);
            groupBox9.Controls.Add(label75);
            groupBox9.Location = new Point(12, 474);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(361, 342);
            groupBox9.TabIndex = 28;
            groupBox9.TabStop = false;
            groupBox9.Text = "Telephone to Alarm";
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(164, 204);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(18, 17);
            checkBox16.TabIndex = 37;
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(15, 201);
            label70.Name = "label70";
            label70.Size = new Size(58, 20);
            label70.TabIndex = 36;
            label70.Text = "USER-6";
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(164, 171);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(18, 17);
            checkBox17.TabIndex = 35;
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new Point(15, 168);
            label71.Name = "label71";
            label71.Size = new Size(58, 20);
            label71.TabIndex = 34;
            label71.Text = "USER-5";
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point(164, 138);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(18, 17);
            checkBox18.TabIndex = 33;
            checkBox18.UseVisualStyleBackColor = true;
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.Location = new Point(15, 135);
            label72.Name = "label72";
            label72.Size = new Size(58, 20);
            label72.TabIndex = 32;
            label72.Text = "USER-4";
            // 
            // checkBox19
            // 
            checkBox19.AutoSize = true;
            checkBox19.Location = new Point(164, 105);
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size(18, 17);
            checkBox19.TabIndex = 31;
            checkBox19.UseVisualStyleBackColor = true;
            // 
            // label73
            // 
            label73.AutoSize = true;
            label73.Location = new Point(15, 102);
            label73.Name = "label73";
            label73.Size = new Size(58, 20);
            label73.TabIndex = 30;
            label73.Text = "USER-3";
            // 
            // checkBox20
            // 
            checkBox20.AutoSize = true;
            checkBox20.Location = new Point(164, 72);
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size(18, 17);
            checkBox20.TabIndex = 29;
            checkBox20.UseVisualStyleBackColor = true;
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.Location = new Point(15, 69);
            label74.Name = "label74";
            label74.Size = new Size(58, 20);
            label74.TabIndex = 28;
            label74.Text = "USER-2";
            // 
            // checkBox21
            // 
            checkBox21.AutoSize = true;
            checkBox21.Location = new Point(164, 39);
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size(18, 17);
            checkBox21.TabIndex = 27;
            checkBox21.UseVisualStyleBackColor = true;
            // 
            // label75
            // 
            label75.AutoSize = true;
            label75.Location = new Point(15, 36);
            label75.Name = "label75";
            label75.Size = new Size(58, 20);
            label75.TabIndex = 26;
            label75.Text = "USER-1";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(comboBox29);
            groupBox10.Controls.Add(label76);
            groupBox10.Controls.Add(comboBox30);
            groupBox10.Controls.Add(label77);
            groupBox10.Controls.Add(comboBox31);
            groupBox10.Controls.Add(label78);
            groupBox10.Controls.Add(comboBox32);
            groupBox10.Controls.Add(label79);
            groupBox10.Controls.Add(comboBox33);
            groupBox10.Controls.Add(label80);
            groupBox10.Controls.Add(comboBox34);
            groupBox10.Controls.Add(label81);
            groupBox10.Controls.Add(comboBox35);
            groupBox10.Controls.Add(label82);
            groupBox10.Controls.Add(comboBox36);
            groupBox10.Controls.Add(label83);
            groupBox10.Location = new Point(756, 104);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(361, 364);
            groupBox10.TabIndex = 27;
            groupBox10.TabStop = false;
            groupBox10.Text = "Digital Output";
            // 
            // comboBox29
            // 
            comboBox29.FormattingEnabled = true;
            comboBox29.Location = new Point(166, 289);
            comboBox29.Name = "comboBox29";
            comboBox29.Size = new Size(185, 28);
            comboBox29.TabIndex = 43;
            // 
            // label76
            // 
            label76.AutoSize = true;
            label76.Location = new Point(8, 303);
            label76.Name = "label76";
            label76.Size = new Size(53, 20);
            label76.TabIndex = 42;
            label76.Text = "DO - 8";
            // 
            // comboBox30
            // 
            comboBox30.FormattingEnabled = true;
            comboBox30.Location = new Point(166, 252);
            comboBox30.Name = "comboBox30";
            comboBox30.Size = new Size(185, 28);
            comboBox30.TabIndex = 41;
            // 
            // label77
            // 
            label77.AutoSize = true;
            label77.Location = new Point(6, 265);
            label77.Name = "label77";
            label77.Size = new Size(53, 20);
            label77.TabIndex = 40;
            label77.Text = "DO - 7";
            // 
            // comboBox31
            // 
            comboBox31.FormattingEnabled = true;
            comboBox31.Location = new Point(166, 215);
            comboBox31.Name = "comboBox31";
            comboBox31.Size = new Size(185, 28);
            comboBox31.TabIndex = 39;
            // 
            // label78
            // 
            label78.AutoSize = true;
            label78.Location = new Point(8, 227);
            label78.Name = "label78";
            label78.Size = new Size(53, 20);
            label78.TabIndex = 38;
            label78.Text = "DO - 6";
            // 
            // comboBox32
            // 
            comboBox32.FormattingEnabled = true;
            comboBox32.Location = new Point(166, 178);
            comboBox32.Name = "comboBox32";
            comboBox32.Size = new Size(185, 28);
            comboBox32.TabIndex = 37;
            // 
            // label79
            // 
            label79.AutoSize = true;
            label79.Location = new Point(8, 189);
            label79.Name = "label79";
            label79.Size = new Size(53, 20);
            label79.TabIndex = 36;
            label79.Text = "DO - 5";
            // 
            // comboBox33
            // 
            comboBox33.FormattingEnabled = true;
            comboBox33.Location = new Point(166, 141);
            comboBox33.Name = "comboBox33";
            comboBox33.Size = new Size(185, 28);
            comboBox33.TabIndex = 35;
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Location = new Point(6, 151);
            label80.Name = "label80";
            label80.Size = new Size(53, 20);
            label80.TabIndex = 34;
            label80.Text = "DO - 4";
            // 
            // comboBox34
            // 
            comboBox34.FormattingEnabled = true;
            comboBox34.Location = new Point(166, 104);
            comboBox34.Name = "comboBox34";
            comboBox34.Size = new Size(185, 28);
            comboBox34.TabIndex = 33;
            // 
            // label81
            // 
            label81.AutoSize = true;
            label81.Location = new Point(6, 113);
            label81.Name = "label81";
            label81.Size = new Size(53, 20);
            label81.TabIndex = 32;
            label81.Text = "DO - 3";
            // 
            // comboBox35
            // 
            comboBox35.FormattingEnabled = true;
            comboBox35.Location = new Point(166, 67);
            comboBox35.Name = "comboBox35";
            comboBox35.Size = new Size(185, 28);
            comboBox35.TabIndex = 31;
            // 
            // label82
            // 
            label82.AutoSize = true;
            label82.Location = new Point(6, 75);
            label82.Name = "label82";
            label82.Size = new Size(53, 20);
            label82.TabIndex = 30;
            label82.Text = "DO - 2";
            // 
            // comboBox36
            // 
            comboBox36.FormattingEnabled = true;
            comboBox36.Location = new Point(166, 30);
            comboBox36.Name = "comboBox36";
            comboBox36.Size = new Size(185, 28);
            comboBox36.TabIndex = 29;
            // 
            // label83
            // 
            label83.AutoSize = true;
            label83.Location = new Point(6, 37);
            label83.Name = "label83";
            label83.Size = new Size(53, 20);
            label83.TabIndex = 28;
            label83.Text = "DO - 1";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(textBox19);
            groupBox11.Controls.Add(label84);
            groupBox11.Controls.Add(comboBox37);
            groupBox11.Controls.Add(label85);
            groupBox11.Controls.Add(checkBox22);
            groupBox11.Controls.Add(label86);
            groupBox11.Controls.Add(textBox20);
            groupBox11.Controls.Add(label87);
            groupBox11.Controls.Add(checkBox23);
            groupBox11.Controls.Add(label88);
            groupBox11.Controls.Add(comboBox38);
            groupBox11.Controls.Add(label89);
            groupBox11.Controls.Add(textBox21);
            groupBox11.Controls.Add(label90);
            groupBox11.Location = new Point(384, 104);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(361, 364);
            groupBox11.TabIndex = 26;
            groupBox11.TabStop = false;
            groupBox11.Text = "Totalizer Parameters";
            // 
            // textBox19
            // 
            textBox19.BorderStyle = BorderStyle.FixedSingle;
            textBox19.Location = new Point(166, 236);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(186, 27);
            textBox19.TabIndex = 29;
            // 
            // label84
            // 
            label84.AutoSize = true;
            label84.Location = new Point(6, 239);
            label84.Name = "label84";
            label84.Size = new Size(97, 20);
            label84.TabIndex = 28;
            label84.Text = "Totalizer Unit";
            // 
            // comboBox37
            // 
            comboBox37.FormattingEnabled = true;
            comboBox37.Location = new Point(166, 198);
            comboBox37.Name = "comboBox37";
            comboBox37.Size = new Size(185, 28);
            comboBox37.TabIndex = 27;
            // 
            // label85
            // 
            label85.AutoSize = true;
            label85.Location = new Point(6, 205);
            label85.Name = "label85";
            label85.Size = new Size(125, 20);
            label85.TabIndex = 26;
            label85.Text = "Report Data Type";
            // 
            // checkBox22
            // 
            checkBox22.AutoSize = true;
            checkBox22.Location = new Point(166, 171);
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size(18, 17);
            checkBox22.TabIndex = 25;
            checkBox22.UseVisualStyleBackColor = true;
            // 
            // label86
            // 
            label86.AutoSize = true;
            label86.Location = new Point(6, 171);
            label86.Name = "label86";
            label86.Size = new Size(91, 20);
            label86.TabIndex = 24;
            label86.Text = "Volatile Flag";
            // 
            // textBox20
            // 
            textBox20.BorderStyle = BorderStyle.FixedSingle;
            textBox20.Location = new Point(166, 134);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(186, 27);
            textBox20.TabIndex = 23;
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.Location = new Point(6, 137);
            label87.Name = "label87";
            label87.Size = new Size(154, 20);
            label87.TabIndex = 22;
            label87.Text = "Display Decimal Point";
            // 
            // checkBox23
            // 
            checkBox23.AutoSize = true;
            checkBox23.Location = new Point(166, 107);
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size(18, 17);
            checkBox23.TabIndex = 21;
            checkBox23.UseVisualStyleBackColor = true;
            // 
            // label88
            // 
            label88.AutoSize = true;
            label88.Location = new Point(6, 103);
            label88.Name = "label88";
            label88.Size = new Size(91, 20);
            label88.TabIndex = 20;
            label88.Text = "Volatile Flag";
            // 
            // comboBox38
            // 
            comboBox38.FormattingEnabled = true;
            comboBox38.Location = new Point(166, 69);
            comboBox38.Name = "comboBox38";
            comboBox38.Size = new Size(185, 28);
            comboBox38.TabIndex = 19;
            // 
            // label89
            // 
            label89.AutoSize = true;
            label89.Location = new Point(6, 69);
            label89.Name = "label89";
            label89.Size = new Size(77, 20);
            label89.TabIndex = 18;
            label89.Text = "Time Base";
            // 
            // textBox21
            // 
            textBox21.BorderStyle = BorderStyle.FixedSingle;
            textBox21.Location = new Point(166, 32);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(185, 27);
            textBox21.TabIndex = 13;
            // 
            // label90
            // 
            label90.AutoSize = true;
            label90.Location = new Point(6, 35);
            label90.Name = "label90";
            label90.Size = new Size(62, 20);
            label90.TabIndex = 12;
            label90.Text = "K Factor";
            // 
            // comboBox39
            // 
            comboBox39.FormattingEnabled = true;
            comboBox39.Location = new Point(604, 52);
            comboBox39.Name = "comboBox39";
            comboBox39.Size = new Size(224, 28);
            comboBox39.TabIndex = 25;
            // 
            // label91
            // 
            label91.AutoSize = true;
            label91.Location = new Point(475, 52);
            label91.Name = "label91";
            label91.Size = new Size(106, 20);
            label91.TabIndex = 24;
            label91.Text = "Select Channel";
            // 
            // comboBox40
            // 
            comboBox40.FormattingEnabled = true;
            comboBox40.Location = new Point(154, 50);
            comboBox40.Name = "comboBox40";
            comboBox40.Size = new Size(224, 28);
            comboBox40.TabIndex = 23;
            // 
            // label92
            // 
            label92.AutoSize = true;
            label92.Location = new Point(25, 50);
            label92.Name = "label92";
            label92.Size = new Size(98, 20);
            label92.TabIndex = 22;
            label92.Text = "Select Device";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(comboBox41);
            groupBox12.Controls.Add(comboBox42);
            groupBox12.Controls.Add(textBox22);
            groupBox12.Controls.Add(textBox23);
            groupBox12.Controls.Add(textBox24);
            groupBox12.Controls.Add(textBox25);
            groupBox12.Controls.Add(textBox26);
            groupBox12.Controls.Add(textBox27);
            groupBox12.Controls.Add(label93);
            groupBox12.Controls.Add(label94);
            groupBox12.Controls.Add(label95);
            groupBox12.Controls.Add(label96);
            groupBox12.Controls.Add(label97);
            groupBox12.Controls.Add(label98);
            groupBox12.Controls.Add(label99);
            groupBox12.Controls.Add(checkBox24);
            groupBox12.Controls.Add(label100);
            groupBox12.Controls.Add(label101);
            groupBox12.Location = new Point(12, 104);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(361, 364);
            groupBox12.TabIndex = 21;
            groupBox12.TabStop = false;
            groupBox12.Text = "Channel Setup";
            // 
            // comboBox41
            // 
            comboBox41.FormattingEnabled = true;
            comboBox41.Location = new Point(164, 298);
            comboBox41.Name = "comboBox41";
            comboBox41.Size = new Size(185, 28);
            comboBox41.TabIndex = 18;
            // 
            // comboBox42
            // 
            comboBox42.FormattingEnabled = true;
            comboBox42.Location = new Point(164, 263);
            comboBox42.Name = "comboBox42";
            comboBox42.Size = new Size(185, 28);
            comboBox42.TabIndex = 17;
            // 
            // textBox22
            // 
            textBox22.BorderStyle = BorderStyle.FixedSingle;
            textBox22.Location = new Point(164, 205);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(185, 27);
            textBox22.TabIndex = 16;
            // 
            // textBox23
            // 
            textBox23.BorderStyle = BorderStyle.FixedSingle;
            textBox23.Location = new Point(164, 171);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(185, 27);
            textBox23.TabIndex = 15;
            // 
            // textBox24
            // 
            textBox24.BorderStyle = BorderStyle.FixedSingle;
            textBox24.Location = new Point(164, 137);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(185, 27);
            textBox24.TabIndex = 14;
            // 
            // textBox25
            // 
            textBox25.BorderStyle = BorderStyle.FixedSingle;
            textBox25.Location = new Point(164, 103);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(185, 27);
            textBox25.TabIndex = 13;
            // 
            // textBox26
            // 
            textBox26.BorderStyle = BorderStyle.FixedSingle;
            textBox26.Location = new Point(164, 69);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(185, 27);
            textBox26.TabIndex = 12;
            // 
            // textBox27
            // 
            textBox27.BorderStyle = BorderStyle.FixedSingle;
            textBox27.Location = new Point(164, 35);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(185, 27);
            textBox27.TabIndex = 11;
            // 
            // label93
            // 
            label93.AutoSize = true;
            label93.Location = new Point(15, 38);
            label93.Name = "label93";
            label93.Size = new Size(49, 20);
            label93.TabIndex = 1;
            label93.Text = "Name";
            // 
            // label94
            // 
            label94.AutoSize = true;
            label94.Location = new Point(15, 302);
            label94.Name = "label94";
            label94.Size = new Size(67, 20);
            label94.TabIndex = 10;
            label94.Text = "AI Alarm";
            // 
            // label95
            // 
            label95.AutoSize = true;
            label95.Location = new Point(15, 71);
            label95.Name = "label95";
            label95.Size = new Size(36, 20);
            label95.TabIndex = 2;
            label95.Text = "Unit";
            // 
            // label96
            // 
            label96.AutoSize = true;
            label96.Location = new Point(15, 269);
            label96.Name = "label96";
            label96.Size = new Size(58, 20);
            label96.TabIndex = 9;
            label96.Text = "AI Type";
            // 
            // label97
            // 
            label97.AutoSize = true;
            label97.Location = new Point(15, 137);
            label97.Name = "label97";
            label97.Size = new Size(77, 20);
            label97.TabIndex = 3;
            label97.Text = "Max Value";
            // 
            // label98
            // 
            label98.AutoSize = true;
            label98.Location = new Point(15, 236);
            label98.Name = "label98";
            label98.Size = new Size(74, 20);
            label98.TabIndex = 8;
            label98.Text = "Totalaizer";
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Location = new Point(15, 104);
            label99.Name = "label99";
            label99.Size = new Size(74, 20);
            label99.TabIndex = 4;
            label99.Text = "Min Value";
            // 
            // checkBox24
            // 
            checkBox24.AutoSize = true;
            checkBox24.Location = new Point(166, 239);
            checkBox24.Name = "checkBox24";
            checkBox24.Size = new Size(18, 17);
            checkBox24.TabIndex = 7;
            checkBox24.UseVisualStyleBackColor = true;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Location = new Point(15, 203);
            label100.Name = "label100";
            label100.Size = new Size(97, 20);
            label100.TabIndex = 5;
            label100.Text = "Thresold Low";
            // 
            // label101
            // 
            label101.AutoSize = true;
            label101.Location = new Point(15, 170);
            label101.Name = "label101";
            label101.Size = new Size(102, 20);
            label101.TabIndex = 6;
            label101.Text = "Thresold High";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(473, 15);
            label3.Name = "label3";
            label3.Size = new Size(196, 31);
            label3.TabIndex = 0;
            label3.Text = "Modbus Settings";
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(menu);
            pnlMenu.Location = new Point(12, 10);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(306, 822);
            pnlMenu.TabIndex = 0;
            // 
            // menu
            // 
            menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menu.ImageKey = "RootNode.png";
            menu.ImageList = menuImgList;
            menu.Location = new Point(3, 3);
            menu.Name = "menu";
            treeNode11.Name = "GeneralSettings";
            treeNode11.Text = "General Settings";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "DOSettings";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "DO Settings";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "DISettings";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "DI Settings";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "AISettings";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "AI Settings";
            treeNode15.Name = "IOSettings";
            treeNode15.Text = "IO Settings";
            treeNode16.Name = "ModbusSettings";
            treeNode16.Text = "Modbus Settings";
            treeNode17.ImageIndex = 0;
            treeNode17.Name = "PulseSettings";
            treeNode17.SelectedImageIndex = 0;
            treeNode17.Text = "Pulse Settings";
            treeNode18.ImageIndex = 0;
            treeNode18.Name = "User";
            treeNode18.SelectedImageIndex = 0;
            treeNode18.Text = "User";
            treeNode19.ImageIndex = 0;
            treeNode19.Name = "ModbusMaster";
            treeNode19.SelectedImageIndex = 0;
            treeNode19.Text = "Modbus Master";
            treeNode20.ImageIndex = 0;
            treeNode20.Name = "ModbusSlave";
            treeNode20.SelectedImageIndex = 0;
            treeNode20.Text = "Modbus Slave";
            menu.Nodes.AddRange(new TreeNode[] { treeNode11, treeNode15, treeNode16, treeNode17, treeNode18, treeNode19, treeNode20 });
            menu.SelectedImageIndex = 0;
            menu.Size = new Size(300, 813);
            menu.TabIndex = 0;
            // 
            // menuImgList
            // 
            menuImgList.ColorDepth = ColorDepth.Depth8Bit;
            menuImgList.ImageStream = (ImageListStreamer)resources.GetObject("menuImgList.ImageStream");
            menuImgList.TransparentColor = Color.Transparent;
            menuImgList.Images.SetKeyName(0, "RootNode.png");
            menuImgList.Images.SetKeyName(1, "ChildNode.png");
            // 
            // pnlModbusMaster
            // 
            pnlModbusMaster.Controls.Add(label45);
            pnlModbusMaster.Location = new Point(321, 9);
            pnlModbusMaster.Name = "pnlModbusMaster";
            pnlModbusMaster.Size = new Size(1133, 822);
            pnlModbusMaster.TabIndex = 7;
            pnlModbusMaster.Visible = false;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label45.Location = new Point(481, 19);
            label45.Name = "label45";
            label45.Size = new Size(182, 31);
            label45.TabIndex = 1;
            label45.Text = "Modbus Master";
            // 
            // pnlModbusSlave
            // 
            pnlModbusSlave.Controls.Add(label44);
            pnlModbusSlave.Location = new Point(321, 77);
            pnlModbusSlave.Name = "pnlModbusSlave";
            pnlModbusSlave.Size = new Size(1133, 754);
            pnlModbusSlave.TabIndex = 6;
            pnlModbusSlave.Visible = false;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label44.Location = new Point(464, 19);
            label44.Name = "label44";
            label44.Size = new Size(164, 31);
            label44.TabIndex = 1;
            label44.Text = "Modbus Slave";
            // 
            // pnlAISettings
            // 
            pnlAISettings.Controls.Add(btnWriteMemoryAI);
            pnlAISettings.Controls.Add(btnReadMemoryAI);
            pnlAISettings.Controls.Add(groupBox4);
            pnlAISettings.Controls.Add(groupBox3);
            pnlAISettings.Controls.Add(groupBox2);
            pnlAISettings.Controls.Add(cmbSelectChannel);
            pnlAISettings.Controls.Add(label15);
            pnlAISettings.Controls.Add(groupBox1);
            pnlAISettings.Controls.Add(label4);
            pnlAISettings.Location = new Point(321, 9);
            pnlAISettings.Name = "pnlAISettings";
            pnlAISettings.Size = new Size(1133, 822);
            pnlAISettings.TabIndex = 2;
            pnlAISettings.Visible = false;
            // 
            // btnWriteMemoryAI
            // 
            btnWriteMemoryAI.BackColor = Color.Red;
            btnWriteMemoryAI.Cursor = Cursors.Hand;
            btnWriteMemoryAI.ForeColor = Color.White;
            btnWriteMemoryAI.Location = new Point(747, 767);
            btnWriteMemoryAI.Name = "btnWriteMemoryAI";
            btnWriteMemoryAI.Size = new Size(172, 42);
            btnWriteMemoryAI.TabIndex = 40;
            btnWriteMemoryAI.Text = "Write Memory";
            btnWriteMemoryAI.UseVisualStyleBackColor = false;
            btnWriteMemoryAI.Click += btnWriteMemory_Click;
            // 
            // btnReadMemoryAI
            // 
            btnReadMemoryAI.BackColor = Color.DarkKhaki;
            btnReadMemoryAI.Cursor = Cursors.Hand;
            btnReadMemoryAI.ForeColor = Color.White;
            btnReadMemoryAI.Location = new Point(475, 767);
            btnReadMemoryAI.Name = "btnReadMemoryAI";
            btnReadMemoryAI.Size = new Size(190, 42);
            btnReadMemoryAI.TabIndex = 39;
            btnReadMemoryAI.Text = "Read Memory";
            btnReadMemoryAI.UseVisualStyleBackColor = false;
            btnReadMemoryAI.Click += btnReadMemory_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chkUser6);
            groupBox4.Controls.Add(label36);
            groupBox4.Controls.Add(chkUser5);
            groupBox4.Controls.Add(label35);
            groupBox4.Controls.Add(chkUser4);
            groupBox4.Controls.Add(label34);
            groupBox4.Controls.Add(chkUser3);
            groupBox4.Controls.Add(label33);
            groupBox4.Controls.Add(chkUser2);
            groupBox4.Controls.Add(label32);
            groupBox4.Controls.Add(chkUser1);
            groupBox4.Controls.Add(label31);
            groupBox4.Location = new Point(13, 666);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(361, 143);
            groupBox4.TabIndex = 38;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telephone to Alarm";
            // 
            // chkUser6
            // 
            chkUser6.AutoSize = true;
            chkUser6.Location = new Point(317, 108);
            chkUser6.Name = "chkUser6";
            chkUser6.Size = new Size(18, 17);
            chkUser6.TabIndex = 37;
            chkUser6.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(211, 105);
            label36.Name = "label36";
            label36.Size = new Size(58, 20);
            label36.TabIndex = 36;
            label36.Text = "USER-6";
            // 
            // chkUser5
            // 
            chkUser5.AutoSize = true;
            chkUser5.Location = new Point(317, 72);
            chkUser5.Name = "chkUser5";
            chkUser5.Size = new Size(18, 17);
            chkUser5.TabIndex = 35;
            chkUser5.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(211, 69);
            label35.Name = "label35";
            label35.Size = new Size(58, 20);
            label35.TabIndex = 34;
            label35.Text = "USER-5";
            // 
            // chkUser4
            // 
            chkUser4.AutoSize = true;
            chkUser4.Location = new Point(317, 36);
            chkUser4.Name = "chkUser4";
            chkUser4.Size = new Size(18, 17);
            chkUser4.TabIndex = 33;
            chkUser4.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(211, 33);
            label34.Name = "label34";
            label34.Size = new Size(58, 20);
            label34.TabIndex = 32;
            label34.Text = "USER-4";
            // 
            // chkUser3
            // 
            chkUser3.AutoSize = true;
            chkUser3.Location = new Point(119, 105);
            chkUser3.Name = "chkUser3";
            chkUser3.Size = new Size(18, 17);
            chkUser3.TabIndex = 31;
            chkUser3.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(15, 102);
            label33.Name = "label33";
            label33.Size = new Size(58, 20);
            label33.TabIndex = 30;
            label33.Text = "USER-3";
            // 
            // chkUser2
            // 
            chkUser2.AutoSize = true;
            chkUser2.Location = new Point(119, 72);
            chkUser2.Name = "chkUser2";
            chkUser2.Size = new Size(18, 17);
            chkUser2.TabIndex = 29;
            chkUser2.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(15, 69);
            label32.Name = "label32";
            label32.Size = new Size(58, 20);
            label32.TabIndex = 28;
            label32.Text = "USER-2";
            // 
            // chkUser1
            // 
            chkUser1.AutoSize = true;
            chkUser1.Location = new Point(119, 39);
            chkUser1.Name = "chkUser1";
            chkUser1.Size = new Size(18, 17);
            chkUser1.TabIndex = 27;
            chkUser1.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(15, 36);
            label31.Name = "label31";
            label31.Size = new Size(58, 20);
            label31.TabIndex = 26;
            label31.Text = "USER-1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbDO8);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(cmbDO7);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(cmbDO6);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(cmbDO5);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(cmbDO4);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(cmbDO3);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(cmbDO2);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(cmbDO1);
            groupBox3.Controls.Add(label23);
            groupBox3.Location = new Point(757, 126);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(361, 364);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Digital Output";
            // 
            // cmbDO8
            // 
            cmbDO8.FormattingEnabled = true;
            cmbDO8.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDO8.Location = new Point(166, 289);
            cmbDO8.Name = "cmbDO8";
            cmbDO8.Size = new Size(185, 28);
            cmbDO8.TabIndex = 43;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(8, 303);
            label30.Name = "label30";
            label30.Size = new Size(53, 20);
            label30.TabIndex = 42;
            label30.Text = "DO - 8";
            // 
            // cmbDO7
            // 
            cmbDO7.FormattingEnabled = true;
            cmbDO7.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDO7.Location = new Point(166, 252);
            cmbDO7.Name = "cmbDO7";
            cmbDO7.Size = new Size(185, 28);
            cmbDO7.TabIndex = 41;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(6, 265);
            label29.Name = "label29";
            label29.Size = new Size(53, 20);
            label29.TabIndex = 40;
            label29.Text = "DO - 7";
            // 
            // cmbDO6
            // 
            cmbDO6.FormattingEnabled = true;
            cmbDO6.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDO6.Location = new Point(166, 215);
            cmbDO6.Name = "cmbDO6";
            cmbDO6.Size = new Size(185, 28);
            cmbDO6.TabIndex = 39;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(8, 227);
            label28.Name = "label28";
            label28.Size = new Size(53, 20);
            label28.TabIndex = 38;
            label28.Text = "DO - 6";
            // 
            // cmbDO5
            // 
            cmbDO5.FormattingEnabled = true;
            cmbDO5.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDO5.Location = new Point(166, 178);
            cmbDO5.Name = "cmbDO5";
            cmbDO5.Size = new Size(185, 28);
            cmbDO5.TabIndex = 37;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(8, 189);
            label27.Name = "label27";
            label27.Size = new Size(53, 20);
            label27.TabIndex = 36;
            label27.Text = "DO - 5";
            // 
            // cmbDO4
            // 
            cmbDO4.FormattingEnabled = true;
            cmbDO4.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDO4.Location = new Point(166, 141);
            cmbDO4.Name = "cmbDO4";
            cmbDO4.Size = new Size(185, 28);
            cmbDO4.TabIndex = 35;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 151);
            label26.Name = "label26";
            label26.Size = new Size(53, 20);
            label26.TabIndex = 34;
            label26.Text = "DO - 4";
            // 
            // cmbDO3
            // 
            cmbDO3.FormattingEnabled = true;
            cmbDO3.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDO3.Location = new Point(166, 104);
            cmbDO3.Name = "cmbDO3";
            cmbDO3.Size = new Size(185, 28);
            cmbDO3.TabIndex = 33;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 113);
            label25.Name = "label25";
            label25.Size = new Size(53, 20);
            label25.TabIndex = 32;
            label25.Text = "DO - 3";
            // 
            // cmbDO2
            // 
            cmbDO2.FormattingEnabled = true;
            cmbDO2.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDO2.Location = new Point(166, 67);
            cmbDO2.Name = "cmbDO2";
            cmbDO2.Size = new Size(185, 28);
            cmbDO2.TabIndex = 31;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 75);
            label24.Name = "label24";
            label24.Size = new Size(53, 20);
            label24.TabIndex = 30;
            label24.Text = "DO - 2";
            // 
            // cmbDO1
            // 
            cmbDO1.FormattingEnabled = true;
            cmbDO1.Items.AddRange(new object[] { "DISABLE", "STATIC ALARM", "ONE SHOT", "DELAYED ONE SHOT", "ON-OFF CONTINUOUS" });
            cmbDO1.Location = new Point(166, 30);
            cmbDO1.Name = "cmbDO1";
            cmbDO1.Size = new Size(185, 28);
            cmbDO1.TabIndex = 29;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 37);
            label23.Name = "label23";
            label23.Size = new Size(53, 20);
            label23.TabIndex = 28;
            label23.Text = "DO - 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKFactor);
            groupBox2.Controls.Add(chkDataReport);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtTotalizerUnit);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(cmbReportDataType);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(txtDisplayDecimalPoint);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(chkVolatileFlag);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(txtTimebase);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(chkTotalizer);
            groupBox2.Location = new Point(385, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 364);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Totalizer Parameters";
            // 
            // txtKFactor
            // 
            txtKFactor.BorderStyle = BorderStyle.FixedSingle;
            txtKFactor.Enabled = false;
            txtKFactor.Location = new Point(166, 65);
            txtKFactor.Name = "txtKFactor";
            txtKFactor.Size = new Size(184, 27);
            txtKFactor.TabIndex = 32;
            // 
            // chkDataReport
            // 
            chkDataReport.AutoSize = true;
            chkDataReport.Enabled = false;
            chkDataReport.Location = new Point(167, 215);
            chkDataReport.Name = "chkDataReport";
            chkDataReport.Size = new Size(18, 17);
            chkDataReport.TabIndex = 31;
            chkDataReport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 213);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 30;
            label1.Text = "Data Report";
            // 
            // txtTotalizerUnit
            // 
            txtTotalizerUnit.BorderStyle = BorderStyle.FixedSingle;
            txtTotalizerUnit.Enabled = false;
            txtTotalizerUnit.Location = new Point(165, 284);
            txtTotalizerUnit.MaxLength = 10;
            txtTotalizerUnit.Name = "txtTotalizerUnit";
            txtTotalizerUnit.Size = new Size(186, 27);
            txtTotalizerUnit.TabIndex = 29;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(7, 291);
            label22.Name = "label22";
            label22.Size = new Size(97, 20);
            label22.TabIndex = 28;
            label22.Text = "Totalizer Unit";
            // 
            // cmbReportDataType
            // 
            cmbReportDataType.Enabled = false;
            cmbReportDataType.FormattingEnabled = true;
            cmbReportDataType.Items.AddRange(new object[] { "Decimal", "Binary", "Hex" });
            cmbReportDataType.Location = new Point(165, 244);
            cmbReportDataType.Name = "cmbReportDataType";
            cmbReportDataType.Size = new Size(185, 28);
            cmbReportDataType.TabIndex = 27;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(7, 244);
            label21.MaximumSize = new Size(164, 60);
            label21.Name = "label21";
            label21.Size = new Size(163, 40);
            label21.TabIndex = 26;
            label21.Text = "Totalaizer Report Data Type";
            // 
            // txtDisplayDecimalPoint
            // 
            txtDisplayDecimalPoint.BorderStyle = BorderStyle.FixedSingle;
            txtDisplayDecimalPoint.Enabled = false;
            txtDisplayDecimalPoint.Location = new Point(166, 176);
            txtDisplayDecimalPoint.MaxLength = 5;
            txtDisplayDecimalPoint.Name = "txtDisplayDecimalPoint";
            txtDisplayDecimalPoint.Size = new Size(186, 27);
            txtDisplayDecimalPoint.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 177);
            label19.Name = "label19";
            label19.Size = new Size(154, 20);
            label19.TabIndex = 22;
            label19.Text = "Display Decimal Point";
            // 
            // chkVolatileFlag
            // 
            chkVolatileFlag.AutoSize = true;
            chkVolatileFlag.Enabled = false;
            chkVolatileFlag.Location = new Point(166, 147);
            chkVolatileFlag.Name = "chkVolatileFlag";
            chkVolatileFlag.Size = new Size(18, 17);
            chkVolatileFlag.TabIndex = 21;
            chkVolatileFlag.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 141);
            label18.Name = "label18";
            label18.Size = new Size(91, 20);
            label18.TabIndex = 20;
            label18.Text = "Volatile Flag";
            // 
            // txtTimebase
            // 
            txtTimebase.Enabled = false;
            txtTimebase.FormattingEnabled = true;
            txtTimebase.Items.AddRange(new object[] { "sec", "min", "hourly" });
            txtTimebase.Location = new Point(166, 107);
            txtTimebase.Name = "txtTimebase";
            txtTimebase.Size = new Size(185, 28);
            txtTimebase.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 105);
            label17.Name = "label17";
            label17.Size = new Size(77, 20);
            label17.TabIndex = 18;
            label17.Text = "Time Base";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 69);
            label16.Name = "label16";
            label16.Size = new Size(62, 20);
            label16.TabIndex = 12;
            label16.Text = "K Factor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 33);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 8;
            label11.Text = "Totalaizer";
            // 
            // chkTotalizer
            // 
            chkTotalizer.AutoSize = true;
            chkTotalizer.Location = new Point(167, 39);
            chkTotalizer.Name = "chkTotalizer";
            chkTotalizer.Size = new Size(18, 17);
            chkTotalizer.TabIndex = 7;
            chkTotalizer.UseVisualStyleBackColor = true;
            chkTotalizer.CheckedChanged += chkTotalizer_CheckedChanged;
            // 
            // cmbSelectChannel
            // 
            cmbSelectChannel.BackColor = SystemColors.HighlightText;
            cmbSelectChannel.Cursor = Cursors.No;
            cmbSelectChannel.FlatStyle = FlatStyle.Popup;
            cmbSelectChannel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSelectChannel.FormattingEnabled = true;
            cmbSelectChannel.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cmbSelectChannel.Location = new Point(490, 79);
            cmbSelectChannel.Name = "cmbSelectChannel";
            cmbSelectChannel.Size = new Size(224, 28);
            cmbSelectChannel.TabIndex = 35;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(361, 82);
            label15.Name = "label15";
            label15.Size = new Size(110, 20);
            label15.TabIndex = 34;
            label15.Text = "Select Channel";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbAIReportDataType);
            groupBox1.Controls.Add(label39);
            groupBox1.Controls.Add(chkAIDataReport);
            groupBox1.Controls.Add(label38);
            groupBox1.Controls.Add(txtAlarmSmsInterval);
            groupBox1.Controls.Add(label37);
            groupBox1.Controls.Add(txtAlarmConfirmationSec);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(cmbAIAlarm);
            groupBox1.Controls.Add(cmbAIType);
            groupBox1.Controls.Add(txtThresoldLow);
            groupBox1.Controls.Add(txtThresoldHigh);
            groupBox1.Controls.Add(txtMaxValue);
            groupBox1.Controls.Add(txtMinValue);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(13, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 534);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Channel Setup";
            // 
            // cmbAIReportDataType
            // 
            cmbAIReportDataType.FormattingEnabled = true;
            cmbAIReportDataType.Items.AddRange(new object[] { "Decimal", "Binary", "Hex" });
            cmbAIReportDataType.Location = new Point(164, 446);
            cmbAIReportDataType.Name = "cmbAIReportDataType";
            cmbAIReportDataType.Size = new Size(185, 28);
            cmbAIReportDataType.TabIndex = 29;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(14, 449);
            label39.MaximumSize = new Size(164, 60);
            label39.Name = "label39";
            label39.Size = new Size(143, 20);
            label39.TabIndex = 28;
            label39.Text = "AI Report Data Type";
            // 
            // chkAIDataReport
            // 
            chkAIDataReport.AutoSize = true;
            chkAIDataReport.Location = new Point(164, 419);
            chkAIDataReport.Name = "chkAIDataReport";
            chkAIDataReport.Size = new Size(18, 17);
            chkAIDataReport.TabIndex = 24;
            chkAIDataReport.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(14, 416);
            label38.Name = "label38";
            label38.Size = new Size(108, 20);
            label38.TabIndex = 23;
            label38.Text = "AI Data Report";
            // 
            // txtAlarmSmsInterval
            // 
            txtAlarmSmsInterval.BorderStyle = BorderStyle.FixedSingle;
            txtAlarmSmsInterval.Location = new Point(164, 379);
            txtAlarmSmsInterval.MaxLength = 6;
            txtAlarmSmsInterval.Name = "txtAlarmSmsInterval";
            txtAlarmSmsInterval.Size = new Size(185, 27);
            txtAlarmSmsInterval.TabIndex = 22;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(14, 380);
            label37.Name = "label37";
            label37.Size = new Size(131, 20);
            label37.TabIndex = 21;
            label37.Text = "Alarm sms Interval";
            // 
            // txtAlarmConfirmationSec
            // 
            txtAlarmConfirmationSec.BorderStyle = BorderStyle.FixedSingle;
            txtAlarmConfirmationSec.Location = new Point(164, 338);
            txtAlarmConfirmationSec.MaxLength = 6;
            txtAlarmConfirmationSec.Name = "txtAlarmConfirmationSec";
            txtAlarmConfirmationSec.Size = new Size(185, 27);
            txtAlarmConfirmationSec.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(14, 333);
            label20.MaximumSize = new Size(150, 0);
            label20.Name = "label20";
            label20.Size = new Size(144, 40);
            label20.TabIndex = 19;
            label20.Text = "Alarm Confirmation Sec";
            // 
            // cmbAIAlarm
            // 
            cmbAIAlarm.FormattingEnabled = true;
            cmbAIAlarm.Items.AddRange(new object[] { "AQUIRE 4~20mA", "AQUIRE & ALARM ABOVE HIGH THRESHOLD ", "AQUIRE & ALARM AT BELOW  LOW THRESHOLD 0~10 V", "AQUIRE & ALARM AT BOTH THRESHOLD" });
            cmbAIAlarm.Location = new Point(164, 298);
            cmbAIAlarm.Name = "cmbAIAlarm";
            cmbAIAlarm.Size = new Size(185, 28);
            cmbAIAlarm.TabIndex = 18;
            // 
            // cmbAIType
            // 
            cmbAIType.FormattingEnabled = true;
            cmbAIType.Items.AddRange(new object[] { "Ignore - 0", "4~20mA-1", "0~20mA-2", "0~5 V-3", "0~10 V-4" });
            cmbAIType.Location = new Point(164, 260);
            cmbAIType.Name = "cmbAIType";
            cmbAIType.Size = new Size(185, 28);
            cmbAIType.TabIndex = 17;
            // 
            // txtThresoldLow
            // 
            txtThresoldLow.BorderStyle = BorderStyle.FixedSingle;
            txtThresoldLow.Location = new Point(164, 223);
            txtThresoldLow.MaxLength = 6;
            txtThresoldLow.Name = "txtThresoldLow";
            txtThresoldLow.Size = new Size(185, 27);
            txtThresoldLow.TabIndex = 16;
            // 
            // txtThresoldHigh
            // 
            txtThresoldHigh.BorderStyle = BorderStyle.FixedSingle;
            txtThresoldHigh.Location = new Point(164, 186);
            txtThresoldHigh.MaxLength = 6;
            txtThresoldHigh.Name = "txtThresoldHigh";
            txtThresoldHigh.Size = new Size(185, 27);
            txtThresoldHigh.TabIndex = 15;
            // 
            // txtMaxValue
            // 
            txtMaxValue.BorderStyle = BorderStyle.FixedSingle;
            txtMaxValue.Location = new Point(164, 149);
            txtMaxValue.MaxLength = 6;
            txtMaxValue.Name = "txtMaxValue";
            txtMaxValue.Size = new Size(185, 27);
            txtMaxValue.TabIndex = 14;
            // 
            // txtMinValue
            // 
            txtMinValue.BorderStyle = BorderStyle.FixedSingle;
            txtMinValue.Location = new Point(164, 112);
            txtMinValue.MaxLength = 6;
            txtMinValue.Name = "txtMinValue";
            txtMinValue.Size = new Size(185, 27);
            txtMinValue.TabIndex = 13;
            // 
            // txtUnit
            // 
            txtUnit.BorderStyle = BorderStyle.FixedSingle;
            txtUnit.Location = new Point(164, 75);
            txtUnit.MaxLength = 10;
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(185, 27);
            txtUnit.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(164, 38);
            txtName.MaxLength = 10;
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 27);
            txtName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 40);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 1;
            label5.Text = "Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 299);
            label13.Name = "label13";
            label13.Size = new Size(67, 20);
            label13.TabIndex = 10;
            label13.Text = "AI Alarm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 77);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 2;
            label6.Text = "Unit";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 262);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 9;
            label12.Text = "AI Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 151);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 3;
            label7.Text = "Max Value";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 114);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 4;
            label8.Text = "Min Value";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 225);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 5;
            label9.Text = "Thresold Low";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 188);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 6;
            label10.Text = "Thresold High";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(438, 14);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 32;
            label4.Text = "AI Settings";
            // 
            // LoginTimer
            // 
            LoginTimer.Enabled = true;
            LoginTimer.Interval = 1000;
            LoginTimer.Tick += LoginTimer_Tick;
            // 
            // btnConnect
            // 
            btnConnect.BackgroundImage = (Image)resources.GetObject("btnConnect.BackgroundImage");
            btnConnect.BackgroundImageLayout = ImageLayout.Stretch;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(260, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(98, 56);
            btnConnect.TabIndex = 33;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // cmbComPorts
            // 
            cmbComPorts.FormattingEnabled = true;
            cmbComPorts.Location = new Point(77, 7);
            cmbComPorts.Name = "cmbComPorts";
            cmbComPorts.Size = new Size(151, 28);
            cmbComPorts.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 10);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 34;
            label14.Text = "Ports";
            // 
            // pnlConnect
            // 
            pnlConnect.Controls.Add(label133);
            pnlConnect.Controls.Add(lblProgressPercent);
            pnlConnect.Controls.Add(pbProcessing);
            pnlConnect.Controls.Add(cmbComPorts);
            pnlConnect.Controls.Add(label14);
            pnlConnect.Controls.Add(btnConnect);
            pnlConnect.Location = new Point(552, 12);
            pnlConnect.Name = "pnlConnect";
            pnlConnect.Size = new Size(376, 63);
            pnlConnect.TabIndex = 35;
            pnlConnect.Visible = false;
            // 
            // label133
            // 
            label133.AutoSize = true;
            label133.Location = new Point(7, 40);
            label133.Name = "label133";
            label133.Size = new Size(65, 20);
            label133.TabIndex = 39;
            label133.Text = "Progress";
            // 
            // lblProgressPercent
            // 
            lblProgressPercent.AutoSize = true;
            lblProgressPercent.Location = new Point(198, 39);
            lblProgressPercent.Name = "lblProgressPercent";
            lblProgressPercent.Size = new Size(29, 20);
            lblProgressPercent.TabIndex = 38;
            lblProgressPercent.Text = "0%";
            // 
            // pbProcessing
            // 
            pbProcessing.BackColor = SystemColors.Info;
            pbProcessing.Location = new Point(77, 41);
            pbProcessing.Name = "pbProcessing";
            pbProcessing.Size = new Size(120, 19);
            pbProcessing.Style = ProgressBarStyle.Continuous;
            pbProcessing.TabIndex = 37;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 927);
            Controls.Add(pnlConnect);
            Controls.Add(pnlDashboard);
            Controls.Add(lnkLogin);
            MaximizeBox = false;
            MaximumSize = new Size(1519, 1018);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            pnlDashboard.ResumeLayout(false);
            pnlGeneralSettings.ResumeLayout(false);
            pnlGeneralSettings.PerformLayout();
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            groupBox15.ResumeLayout(false);
            groupBox15.PerformLayout();
            pnlDOSettings.ResumeLayout(false);
            pnlDOSettings.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox14.PerformLayout();
            pnlDISettings.ResumeLayout(false);
            pnlDISettings.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            pnlPulseSettings.ResumeLayout(false);
            pnlPulseSettings.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            pnlModbusSettings.ResumeLayout(false);
            pnlModbusSettings.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlModbusMaster.ResumeLayout(false);
            pnlModbusMaster.PerformLayout();
            pnlModbusSlave.ResumeLayout(false);
            pnlModbusSlave.PerformLayout();
            pnlAISettings.ResumeLayout(false);
            pnlAISettings.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlConnect.ResumeLayout(false);
            pnlConnect.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkLogin;
        private Panel pnlDashboard;
        private System.Windows.Forms.Timer LoginTimer;
        private Panel pnlMenu;
        private TreeView menu;
        private ImageList menuImgList;
        private Panel pnlGeneralSettings;
        private Panel pnlModbusSettings;
        private Label label3;
        private Button button5;
        private Button button6;
        private GroupBox groupBox9;
        private CheckBox checkBox16;
        private Label label70;
        private CheckBox checkBox17;
        private Label label71;
        private CheckBox checkBox18;
        private Label label72;
        private CheckBox checkBox19;
        private Label label73;
        private CheckBox checkBox20;
        private Label label74;
        private CheckBox checkBox21;
        private Label label75;
        private GroupBox groupBox10;
        private ComboBox comboBox29;
        private Label label76;
        private ComboBox comboBox30;
        private Label label77;
        private ComboBox comboBox31;
        private Label label78;
        private ComboBox comboBox32;
        private Label label79;
        private ComboBox comboBox33;
        private Label label80;
        private ComboBox comboBox34;
        private Label label81;
        private ComboBox comboBox35;
        private Label label82;
        private ComboBox comboBox36;
        private Label label83;
        private GroupBox groupBox11;
        private TextBox textBox19;
        private Label label84;
        private ComboBox comboBox37;
        private Label label85;
        private CheckBox checkBox22;
        private Label label86;
        private TextBox textBox20;
        private Label label87;
        private CheckBox checkBox23;
        private Label label88;
        private ComboBox comboBox38;
        private Label label89;
        private TextBox textBox21;
        private Label label90;
        private ComboBox comboBox39;
        private Label label91;
        private ComboBox comboBox40;
        private Label label92;
        private GroupBox groupBox12;
        private ComboBox comboBox41;
        private ComboBox comboBox42;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox27;
        private Label label93;
        private Label label94;
        private Label label95;
        private Label label96;
        private Label label97;
        private Label label98;
        private Label label99;
        private CheckBox checkBox24;
        private Label label100;
        private Label label101;
        private Button btnConnect;
        private ComboBox cmbComPorts;
        private Label label14;
        private Label label2;
        private Panel pnlAISettings;
        private Button btnWriteMemoryAI;
        private Button btnReadMemoryAI;
        private GroupBox groupBox4;
        private CheckBox chkUser6;
        private Label label36;
        private CheckBox chkUser5;
        private Label label35;
        private CheckBox chkUser4;
        private Label label34;
        private CheckBox chkUser3;
        private Label label33;
        private CheckBox chkUser2;
        private Label label32;
        private CheckBox chkUser1;
        private Label label31;
        private GroupBox groupBox3;
        private ComboBox cmbDO8;
        private Label label30;
        private ComboBox cmbDO7;
        private Label label29;
        private ComboBox cmbDO6;
        private Label label28;
        private ComboBox cmbDO5;
        private Label label27;
        private ComboBox cmbDO4;
        private Label label26;
        private ComboBox cmbDO3;
        private Label label25;
        private ComboBox cmbDO2;
        private Label label24;
        private ComboBox cmbDO1;
        private Label label23;
        private GroupBox groupBox2;
        private CheckBox chkDataReport;
        private Label label1;
        private TextBox txtTotalizerUnit;
        private Label label22;
        private ComboBox cmbReportDataType;
        private Label label21;
        private TextBox txtDisplayDecimalPoint;
        private Label label19;
        private CheckBox chkVolatileFlag;
        private Label label18;
        private ComboBox txtTimebase;
        private Label label17;
        private Label label16;
        private Label label11;
        private CheckBox chkTotalizer;
        private ComboBox cmbSelectChannel;
        private Label label15;
        private GroupBox groupBox1;
        private ComboBox cmbAIAlarm;
        private ComboBox cmbAIType;
        private TextBox txtThresoldLow;
        private TextBox txtThresoldHigh;
        private TextBox txtMaxValue;
        private TextBox txtMinValue;
        private TextBox txtUnit;
        private TextBox txtName;
        private Label label5;
        private Label label13;
        private Label label6;
        private Label label12;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label4;
        private ComboBox cmbAIReportDataType;
        private Label label39;
        private CheckBox chkAIDataReport;
        private Label label38;
        private TextBox txtAlarmSmsInterval;
        private Label label37;
        private TextBox txtAlarmConfirmationSec;
        private Label label20;
        private TextBox txtKFactor;
        private Panel pnlConnect;
        private ProgressBar pbProcessing;
        private Panel pnlDISettings;
        private Label label41;
        private Panel pnlDOSettings;
        private Label label40;
        private Panel pnlPulseSettings;
        private Label label42;
        private Panel pnlUser;
        private Label label43;
        private Panel pnlModbusSlave;
        private Label label44;
        private Panel pnlModbusMaster;
        private Label label45;
        private Button btnDIWriteMemory;
        private Button btnDIReadMemory;
        private GroupBox groupBox5;
        private CheckBox chkDIUser6;
        private Label label46;
        private CheckBox chkDIUser5;
        private Label label47;
        private CheckBox chkDIUser4;
        private Label label48;
        private CheckBox chkDIUser3;
        private Label label49;
        private CheckBox chkDIUser2;
        private Label label50;
        private CheckBox chkDIUser1;
        private Label label51;
        private GroupBox groupBox6;
        private ComboBox cmbDIDO8;
        private Label label52;
        private ComboBox cmbDIDO7;
        private Label label53;
        private ComboBox cmbDIDO6;
        private Label label54;
        private ComboBox cmbDIDO5;
        private Label label55;
        private ComboBox cmbDIDO4;
        private Label label56;
        private ComboBox cmbDIDO3;
        private Label label57;
        private ComboBox cmbDIDO2;
        private Label label58;
        private ComboBox cmbDIDO1;
        private Label label59;
        private ComboBox cmbDISelectChannel;
        private Label label68;
        private GroupBox groupBox8;
        private Label label69;
        private CheckBox chkDIDataReport;
        private Label label102;
        private TextBox txtDISmsRepeatTime;
        private Label label103;
        private TextBox txtDIAlarmVerifySec;
        private Label label104;
        private ComboBox cmbDIAlarm;
        private ComboBox cmbDIType;
        private TextBox txtDIUnit;
        private TextBox txtDIName;
        private Label label105;
        private Label label106;
        private Label label107;
        private Label label108;
        private TextBox txtDISMSRepeatSec;
        private Button btnDOWriteMemory;
        private Button btnDOReadMemory;
        private ComboBox cmbDOSelectChannel;
        private Label label115;
        private GroupBox groupBox14;
        private Label label121;
        private Label label120;
        private TextBox txtDoOnTime;
        private Label label117;
        private TextBox txtDoOffTime;
        private Label label116;
        private TextBox txtDoRelayDelayTime;
        private Label label118;
        private TextBox txtDoRelayCloseOn;
        private Label label119;
        private ComboBox cmbDOType;
        private Label label114;
        private Button btnPulseWriteMemory;
        private Button btnPulseReadMemory;
        private GroupBox groupBox7;
        private Label label62;
        private TextBox txtPulseKfactor;
        private Label label64;
        private TextBox txtAdjustPulseCount;
        private Label label65;
        private CheckBox chkPulseIsVolatile;
        private Button btnGeneralWriteMemory;
        private Button btnGeneralReadMemory;
        private GroupBox groupBox13;
        private TextBox txtGeneralDataLogSec;
        private Label label63;
        private TextBox txtGeneralSmsLogSec;
        private Label label66;
        private Label label109;
        private Label label110;
        private TextBox txtGeneralUserId;
        private Label label61;
        private Label label60;
        private DateTimePicker dtGeneralSetDate;
        private Label label111;
        private TextBox txtGeneralSetTime;
        private ComboBox cmbUserIndex;
        private Label label128;
        private Button btnUserWriteMemory;
        private Button btnUserReadMemory;
        private GroupBox groupBox15;
        private Label label113;
        private Label label122;
        private CheckBox chkUserSmsOnPowerOn;
        private TextBox txtUserMobileNo;
        private Label label123;
        private Label label124;
        private Label label125;
        private Label label126;
        private Label label127;
        private CheckBox chkUserSmsOnGprsFail;
        private CheckBox chkUserSmsOnLowTower;
        private CheckBox chkUserCanCall;
        private CheckBox chkUserIsAlarm;
        private CheckBox chkUserIsAdmin;
        private Label label129;
        private Label label112;
        private ComboBox cmbUserSelectDo;
        private CheckBox chkUserIsVolatile;
        private Label label130;
        private TextBox txtPulseDurationRef;
        private ComboBox cmbPulseReportDT;
        private Label label131;
        private ComboBox cmbDIReportDt;
        private Label label132;
        private Label lblProgressPercent;
        private Label label133;
        private CheckBox chkUserSmsTimerReport;
        private Label label134;
        private CheckBox chkGeneralRtcDebug;
        private Label label136;
        private CheckBox chkGeneralModbusDebug;
        private Label label135;
        private TextBox txtIemiNo;
    }
}