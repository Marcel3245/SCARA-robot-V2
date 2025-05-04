namespace SCARA_robot
{
    partial class MainForm
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
            this.treeViewConnect = new System.Windows.Forms.TreeView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPageS = new System.Windows.Forms.TabPage();
            this.btnSToggleAutoscroll = new System.Windows.Forms.Button();
            this.btnSClearSerialMonitor = new System.Windows.Forms.Button();
            this.btnSEStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSBaudRate = new System.Windows.Forms.ComboBox();
            this.btnSHomePosition = new System.Windows.Forms.Button();
            this.btnSDisconnect = new System.Windows.Forms.Button();
            this.panelS_Online = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSDeviceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageM = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnMCAdd = new System.Windows.Forms.Button();
            this.panelMCRPM = new System.Windows.Forms.Panel();
            this.textBoxMCRPM = new System.Windows.Forms.TextBox();
            this.panelMCAcceleration = new System.Windows.Forms.Panel();
            this.textBoxMCAcceleration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelMC_Online = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMCEStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMCJoint2R = new System.Windows.Forms.Button();
            this.btnMCJoint1R = new System.Windows.Forms.Button();
            this.btnMCJoint3R = new System.Windows.Forms.Button();
            this.btnMCJoint4R = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMCJoint2L = new System.Windows.Forms.Button();
            this.btnMCJoint1L = new System.Windows.Forms.Button();
            this.btnMCJoint3L = new System.Windows.Forms.Button();
            this.btnMCJoint4L = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMCFlangeC = new System.Windows.Forms.Button();
            this.textBoxMCWidthFlange = new System.Windows.Forms.TextBox();
            this.textBoxMCAngle4 = new System.Windows.Forms.TextBox();
            this.textBoxMCAngle3 = new System.Windows.Forms.TextBox();
            this.textBoxMCHeight = new System.Windows.Forms.TextBox();
            this.textBoxMCAngle1 = new System.Windows.Forms.TextBox();
            this.btnMCFlangeO = new System.Windows.Forms.Button();
            this.tabPageCC = new System.Windows.Forms.TabPage();
            this.btnCCHint = new System.Windows.Forms.Button();
            this.panelCC_Online = new System.Windows.Forms.Panel();
            this.btnCCExecute = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnCCPath = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panelCCRPM = new System.Windows.Forms.Panel();
            this.textBoxCCRPM = new System.Windows.Forms.TextBox();
            this.panelCCAcceleration = new System.Windows.Forms.Panel();
            this.textBoxCCAcceleration = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxCCParallel = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelCCFspread = new System.Windows.Forms.Panel();
            this.textBoxCCFWidth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelCCQangle = new System.Windows.Forms.Panel();
            this.textBoxCCQangle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelCCZaxis = new System.Windows.Forms.Panel();
            this.textBoxCCZaxis = new System.Windows.Forms.TextBox();
            this.panelCCXaxis = new System.Windows.Forms.Panel();
            this.textBoxCCXaxis = new System.Windows.Forms.TextBox();
            this.panelCCYaxis = new System.Windows.Forms.Panel();
            this.textBoxCCYaxis = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCCEStop = new System.Windows.Forms.Button();
            this.tabPageDT = new System.Windows.Forms.TabPage();
            this.groupBoxCommunication = new System.Windows.Forms.GroupBox();
            this.textBoxOutputMessage = new System.Windows.Forms.TextBox();
            this.timerCheckConnection = new System.Windows.Forms.Timer(this.components);
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPageS.SuspendLayout();
            this.tabPageM.SuspendLayout();
            this.panelMCRPM.SuspendLayout();
            this.panelMCAcceleration.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageCC.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panelCCRPM.SuspendLayout();
            this.panelCCAcceleration.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelCCFspread.SuspendLayout();
            this.panelCCQangle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelCCZaxis.SuspendLayout();
            this.panelCCXaxis.SuspendLayout();
            this.panelCCYaxis.SuspendLayout();
            this.groupBoxCommunication.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewConnect
            // 
            this.treeViewConnect.Location = new System.Drawing.Point(6, 21);
            this.treeViewConnect.Name = "treeViewConnect";
            this.treeViewConnect.Size = new System.Drawing.Size(228, 217);
            this.treeViewConnect.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 244);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(228, 52);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 302);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(228, 59);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.treeViewConnect);
            this.groupBoxConnect.Controls.Add(this.btnRefresh);
            this.groupBoxConnect.Controls.Add(this.btnConnect);
            this.groupBoxConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxConnect.Location = new System.Drawing.Point(10, 10);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(240, 370);
            this.groupBoxConnect.TabIndex = 3;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connect";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.tabs);
            this.groupBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxMenu.Location = new System.Drawing.Point(256, 10);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxMenu.Size = new System.Drawing.Size(516, 370);
            this.groupBoxMenu.TabIndex = 4;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPageS);
            this.tabs.Controls.Add(this.tabPageM);
            this.tabs.Controls.Add(this.tabPageCC);
            this.tabs.Controls.Add(this.tabPageDT);
            this.tabs.Location = new System.Drawing.Point(6, 21);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(504, 349);
            this.tabs.TabIndex = 0;
            // 
            // tabPageS
            // 
            this.tabPageS.Controls.Add(this.btnSToggleAutoscroll);
            this.tabPageS.Controls.Add(this.btnSClearSerialMonitor);
            this.tabPageS.Controls.Add(this.btnSEStop);
            this.tabPageS.Controls.Add(this.label4);
            this.tabPageS.Controls.Add(this.textBoxSCommand);
            this.tabPageS.Controls.Add(this.label2);
            this.tabPageS.Controls.Add(this.comboBoxSBaudRate);
            this.tabPageS.Controls.Add(this.btnSHomePosition);
            this.tabPageS.Controls.Add(this.btnSDisconnect);
            this.tabPageS.Controls.Add(this.panelS_Online);
            this.tabPageS.Controls.Add(this.label3);
            this.tabPageS.Controls.Add(this.textBoxSDeviceName);
            this.tabPageS.Controls.Add(this.label1);
            this.tabPageS.Location = new System.Drawing.Point(4, 25);
            this.tabPageS.Name = "tabPageS";
            this.tabPageS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageS.Size = new System.Drawing.Size(496, 320);
            this.tabPageS.TabIndex = 3;
            this.tabPageS.Text = "Settings";
            this.tabPageS.UseVisualStyleBackColor = true;
            // 
            // btnSToggleAutoscroll
            // 
            this.btnSToggleAutoscroll.Location = new System.Drawing.Point(155, 264);
            this.btnSToggleAutoscroll.Name = "btnSToggleAutoscroll";
            this.btnSToggleAutoscroll.Size = new System.Drawing.Size(128, 43);
            this.btnSToggleAutoscroll.TabIndex = 17;
            this.btnSToggleAutoscroll.Text = "Toggle Autoscroll";
            this.btnSToggleAutoscroll.UseVisualStyleBackColor = true;
            this.btnSToggleAutoscroll.Click += new System.EventHandler(this.btnToggleAutoscroll_Click);
            // 
            // btnSClearSerialMonitor
            // 
            this.btnSClearSerialMonitor.Location = new System.Drawing.Point(155, 212);
            this.btnSClearSerialMonitor.Name = "btnSClearSerialMonitor";
            this.btnSClearSerialMonitor.Size = new System.Drawing.Size(128, 43);
            this.btnSClearSerialMonitor.TabIndex = 16;
            this.btnSClearSerialMonitor.Text = "Clear Serial Monitor";
            this.btnSClearSerialMonitor.UseVisualStyleBackColor = true;
            // 
            // btnSEStop
            // 
            this.btnSEStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnSEStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSEStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSEStop.Location = new System.Drawing.Point(312, 38);
            this.btnSEStop.Name = "btnSEStop";
            this.btnSEStop.Size = new System.Drawing.Size(157, 118);
            this.btnSEStop.TabIndex = 15;
            this.btnSEStop.Text = "E-stop";
            this.btnSEStop.UseVisualStyleBackColor = false;
            this.btnSEStop.Click += new System.EventHandler(this.btnSEStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Command:";
            // 
            // textBoxSCommand
            // 
            this.textBoxSCommand.AcceptsReturn = true;
            this.textBoxSCommand.AcceptsTab = true;
            this.textBoxSCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBoxSCommand.Location = new System.Drawing.Point(21, 184);
            this.textBoxSCommand.Name = "textBoxSCommand";
            this.textBoxSCommand.Size = new System.Drawing.Size(448, 22);
            this.textBoxSCommand.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Baudrate:";
            // 
            // comboBoxSBaudRate
            // 
            this.comboBoxSBaudRate.FormattingEnabled = true;
            this.comboBoxSBaudRate.Location = new System.Drawing.Point(130, 107);
            this.comboBoxSBaudRate.Name = "comboBoxSBaudRate";
            this.comboBoxSBaudRate.Size = new System.Drawing.Size(153, 24);
            this.comboBoxSBaudRate.TabIndex = 10;
            // 
            // btnSHomePosition
            // 
            this.btnSHomePosition.Location = new System.Drawing.Point(21, 231);
            this.btnSHomePosition.Name = "btnSHomePosition";
            this.btnSHomePosition.Size = new System.Drawing.Size(128, 43);
            this.btnSHomePosition.TabIndex = 7;
            this.btnSHomePosition.Text = "Home Position";
            this.btnSHomePosition.UseVisualStyleBackColor = true;
            this.btnSHomePosition.Click += new System.EventHandler(this.btnSHomePosition_Click);
            // 
            // btnSDisconnect
            // 
            this.btnSDisconnect.Location = new System.Drawing.Point(312, 231);
            this.btnSDisconnect.Name = "btnSDisconnect";
            this.btnSDisconnect.Size = new System.Drawing.Size(157, 43);
            this.btnSDisconnect.TabIndex = 6;
            this.btnSDisconnect.Text = "Disconnect";
            this.btnSDisconnect.UseVisualStyleBackColor = true;
            this.btnSDisconnect.Click += new System.EventHandler(this.buttonDisconnectSettings_Click);
            // 
            // panelS_Online
            // 
            this.panelS_Online.BackColor = System.Drawing.Color.Red;
            this.panelS_Online.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelS_Online.Location = new System.Drawing.Point(471, 9);
            this.panelS_Online.Name = "panelS_Online";
            this.panelS_Online.Size = new System.Drawing.Size(10, 10);
            this.panelS_Online.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Online";
            // 
            // textBoxSDeviceName
            // 
            this.textBoxSDeviceName.Location = new System.Drawing.Point(130, 77);
            this.textBoxSDeviceName.Name = "textBoxSDeviceName";
            this.textBoxSDeviceName.ReadOnly = true;
            this.textBoxSDeviceName.Size = new System.Drawing.Size(153, 22);
            this.textBoxSDeviceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Name:";
            // 
            // tabPageM
            // 
            this.tabPageM.Controls.Add(this.label26);
            this.tabPageM.Controls.Add(this.label25);
            this.tabPageM.Controls.Add(this.label24);
            this.tabPageM.Controls.Add(this.btnMCAdd);
            this.tabPageM.Controls.Add(this.panelMCRPM);
            this.tabPageM.Controls.Add(this.panelMCAcceleration);
            this.tabPageM.Controls.Add(this.label6);
            this.tabPageM.Controls.Add(this.panelMC_Online);
            this.tabPageM.Controls.Add(this.label5);
            this.tabPageM.Controls.Add(this.btnMCEStop);
            this.tabPageM.Controls.Add(this.groupBox2);
            this.tabPageM.Controls.Add(this.groupBox1);
            this.tabPageM.Controls.Add(this.label11);
            this.tabPageM.Controls.Add(this.label10);
            this.tabPageM.Controls.Add(this.label9);
            this.tabPageM.Controls.Add(this.label8);
            this.tabPageM.Controls.Add(this.label7);
            this.tabPageM.Controls.Add(this.btnMCFlangeC);
            this.tabPageM.Controls.Add(this.textBoxMCWidthFlange);
            this.tabPageM.Controls.Add(this.textBoxMCAngle4);
            this.tabPageM.Controls.Add(this.textBoxMCAngle3);
            this.tabPageM.Controls.Add(this.textBoxMCHeight);
            this.tabPageM.Controls.Add(this.textBoxMCAngle1);
            this.tabPageM.Controls.Add(this.btnMCFlangeO);
            this.tabPageM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageM.Location = new System.Drawing.Point(4, 25);
            this.tabPageM.Name = "tabPageM";
            this.tabPageM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageM.Size = new System.Drawing.Size(496, 320);
            this.tabPageM.TabIndex = 0;
            this.tabPageM.Text = "Manual Control";
            this.tabPageM.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(122, 201);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 16);
            this.label26.TabIndex = 47;
            this.label26.Text = "Angle[°]";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(122, 143);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 16);
            this.label25.TabIndex = 46;
            this.label25.Text = "Height[mm]";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(122, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 16);
            this.label24.TabIndex = 45;
            this.label24.Text = "Angle[°]";
            // 
            // btnMCAdd
            // 
            this.btnMCAdd.Location = new System.Drawing.Point(342, 162);
            this.btnMCAdd.Name = "btnMCAdd";
            this.btnMCAdd.Size = new System.Drawing.Size(131, 43);
            this.btnMCAdd.TabIndex = 44;
            this.btnMCAdd.Text = "Add To Path";
            this.btnMCAdd.UseVisualStyleBackColor = true;
            this.btnMCAdd.Click += new System.EventHandler(this.btnMCAdd_Click);
            // 
            // panelMCRPM
            // 
            this.panelMCRPM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMCRPM.Controls.Add(this.textBoxMCRPM);
            this.panelMCRPM.Location = new System.Drawing.Point(333, 107);
            this.panelMCRPM.Name = "panelMCRPM";
            this.panelMCRPM.Size = new System.Drawing.Size(109, 33);
            this.panelMCRPM.TabIndex = 43;
            // 
            // textBoxMCRPM
            // 
            this.textBoxMCRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMCRPM.Location = new System.Drawing.Point(9, 0);
            this.textBoxMCRPM.Name = "textBoxMCRPM";
            this.textBoxMCRPM.Size = new System.Drawing.Size(100, 22);
            this.textBoxMCRPM.TabIndex = 31;
            this.textBoxMCRPM.Text = "1-200";
            this.textBoxMCRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMCRPM.TextChanged += new System.EventHandler(this.textBoxMCVelocity_TextChanged);
            // 
            // panelMCAcceleration
            // 
            this.panelMCAcceleration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMCAcceleration.Controls.Add(this.textBoxMCAcceleration);
            this.panelMCAcceleration.Location = new System.Drawing.Point(333, 52);
            this.panelMCAcceleration.Name = "panelMCAcceleration";
            this.panelMCAcceleration.Size = new System.Drawing.Size(109, 33);
            this.panelMCAcceleration.TabIndex = 42;
            // 
            // textBoxMCAcceleration
            // 
            this.textBoxMCAcceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMCAcceleration.Location = new System.Drawing.Point(9, 0);
            this.textBoxMCAcceleration.Name = "textBoxMCAcceleration";
            this.textBoxMCAcceleration.Size = new System.Drawing.Size(100, 22);
            this.textBoxMCAcceleration.TabIndex = 30;
            this.textBoxMCAcceleration.Text = "1-100";
            this.textBoxMCAcceleration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(122, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Width[mm]";
            // 
            // panelMC_Online
            // 
            this.panelMC_Online.BackColor = System.Drawing.Color.Red;
            this.panelMC_Online.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMC_Online.Location = new System.Drawing.Point(477, 9);
            this.panelMC_Online.Name = "panelMC_Online";
            this.panelMC_Online.Size = new System.Drawing.Size(10, 10);
            this.panelMC_Online.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(429, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Online";
            // 
            // btnMCEStop
            // 
            this.btnMCEStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnMCEStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCEStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMCEStop.Location = new System.Drawing.Point(342, 220);
            this.btnMCEStop.Name = "btnMCEStop";
            this.btnMCEStop.Size = new System.Drawing.Size(131, 87);
            this.btnMCEStop.TabIndex = 38;
            this.btnMCEStop.Text = "E-stop";
            this.btnMCEStop.UseVisualStyleBackColor = false;
            this.btnMCEStop.Click += new System.EventHandler(this.btnMCEStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMCJoint2R);
            this.groupBox2.Controls.Add(this.btnMCJoint1R);
            this.groupBox2.Controls.Add(this.btnMCJoint3R);
            this.groupBox2.Controls.Add(this.btnMCJoint4R);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(220, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 254);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Right";
            // 
            // btnMCJoint2R
            // 
            this.btnMCJoint2R.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCJoint2R.Location = new System.Drawing.Point(6, 137);
            this.btnMCJoint2R.Name = "btnMCJoint2R";
            this.btnMCJoint2R.Size = new System.Drawing.Size(95, 49);
            this.btnMCJoint2R.TabIndex = 6;
            this.btnMCJoint2R.Text = "Joint2\r\nColumn";
            this.btnMCJoint2R.UseVisualStyleBackColor = true;
            // 
            // btnMCJoint1R
            // 
            this.btnMCJoint1R.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCJoint1R.Location = new System.Drawing.Point(6, 195);
            this.btnMCJoint1R.Name = "btnMCJoint1R";
            this.btnMCJoint1R.Size = new System.Drawing.Size(95, 49);
            this.btnMCJoint1R.TabIndex = 5;
            this.btnMCJoint1R.Text = "Joint1\r\nBase";
            this.btnMCJoint1R.UseVisualStyleBackColor = true;
            // 
            // btnMCJoint3R
            // 
            this.btnMCJoint3R.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCJoint3R.Location = new System.Drawing.Point(6, 82);
            this.btnMCJoint3R.Name = "btnMCJoint3R";
            this.btnMCJoint3R.Size = new System.Drawing.Size(95, 49);
            this.btnMCJoint3R.TabIndex = 7;
            this.btnMCJoint3R.Text = "Joint3\r\nOuter Link";
            this.btnMCJoint3R.UseVisualStyleBackColor = true;
            // 
            // btnMCJoint4R
            // 
            this.btnMCJoint4R.BackColor = System.Drawing.Color.Transparent;
            this.btnMCJoint4R.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCJoint4R.Location = new System.Drawing.Point(6, 27);
            this.btnMCJoint4R.Name = "btnMCJoint4R";
            this.btnMCJoint4R.Size = new System.Drawing.Size(95, 49);
            this.btnMCJoint4R.TabIndex = 8;
            this.btnMCJoint4R.Text = "Joint4\r\nQuill";
            this.btnMCJoint4R.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMCJoint2L);
            this.groupBox1.Controls.Add(this.btnMCJoint1L);
            this.groupBox1.Controls.Add(this.btnMCJoint3L);
            this.groupBox1.Controls.Add(this.btnMCJoint4L);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 254);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left";
            // 
            // btnMCJoint2L
            // 
            this.btnMCJoint2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCJoint2L.Location = new System.Drawing.Point(6, 137);
            this.btnMCJoint2L.Name = "btnMCJoint2L";
            this.btnMCJoint2L.Size = new System.Drawing.Size(95, 49);
            this.btnMCJoint2L.TabIndex = 6;
            this.btnMCJoint2L.Text = "Joint2\r\nColumn";
            this.btnMCJoint2L.UseVisualStyleBackColor = true;
            // 
            // btnMCJoint1L
            // 
            this.btnMCJoint1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCJoint1L.Location = new System.Drawing.Point(6, 195);
            this.btnMCJoint1L.Name = "btnMCJoint1L";
            this.btnMCJoint1L.Size = new System.Drawing.Size(95, 49);
            this.btnMCJoint1L.TabIndex = 5;
            this.btnMCJoint1L.Text = "Joint1\r\nBase";
            this.btnMCJoint1L.UseVisualStyleBackColor = true;
            // 
            // btnMCJoint3L
            // 
            this.btnMCJoint3L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCJoint3L.Location = new System.Drawing.Point(6, 82);
            this.btnMCJoint3L.Name = "btnMCJoint3L";
            this.btnMCJoint3L.Size = new System.Drawing.Size(95, 49);
            this.btnMCJoint3L.TabIndex = 7;
            this.btnMCJoint3L.Text = "Joint3\r\nOuter Link";
            this.btnMCJoint3L.UseVisualStyleBackColor = true;
            // 
            // btnMCJoint4L
            // 
            this.btnMCJoint4L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCJoint4L.Location = new System.Drawing.Point(6, 27);
            this.btnMCJoint4L.Name = "btnMCJoint4L";
            this.btnMCJoint4L.Size = new System.Drawing.Size(95, 49);
            this.btnMCJoint4L.TabIndex = 8;
            this.btnMCJoint4L.Text = "Joint4\r\nQuill";
            this.btnMCJoint4L.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(339, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "RPM";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(339, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "Ramp Length";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(445, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "r/min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(445, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "steps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(122, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Angle[°]";
            // 
            // btnMCFlangeC
            // 
            this.btnMCFlangeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCFlangeC.Location = new System.Drawing.Point(16, 266);
            this.btnMCFlangeC.Name = "btnMCFlangeC";
            this.btnMCFlangeC.Size = new System.Drawing.Size(97, 49);
            this.btnMCFlangeC.TabIndex = 26;
            this.btnMCFlangeC.Text = "User Flange\r\nClose";
            this.btnMCFlangeC.UseVisualStyleBackColor = true;
            // 
            // textBoxMCWidthFlange
            // 
            this.textBoxMCWidthFlange.Location = new System.Drawing.Point(125, 279);
            this.textBoxMCWidthFlange.Name = "textBoxMCWidthFlange";
            this.textBoxMCWidthFlange.ReadOnly = true;
            this.textBoxMCWidthFlange.Size = new System.Drawing.Size(89, 22);
            this.textBoxMCWidthFlange.TabIndex = 21;
            // 
            // textBoxMCAngle4
            // 
            this.textBoxMCAngle4.Location = new System.Drawing.Point(125, 52);
            this.textBoxMCAngle4.Name = "textBoxMCAngle4";
            this.textBoxMCAngle4.ReadOnly = true;
            this.textBoxMCAngle4.Size = new System.Drawing.Size(89, 22);
            this.textBoxMCAngle4.TabIndex = 20;
            // 
            // textBoxMCAngle3
            // 
            this.textBoxMCAngle3.Location = new System.Drawing.Point(125, 107);
            this.textBoxMCAngle3.Name = "textBoxMCAngle3";
            this.textBoxMCAngle3.ReadOnly = true;
            this.textBoxMCAngle3.Size = new System.Drawing.Size(89, 22);
            this.textBoxMCAngle3.TabIndex = 19;
            // 
            // textBoxMCHeight
            // 
            this.textBoxMCHeight.Location = new System.Drawing.Point(125, 162);
            this.textBoxMCHeight.Name = "textBoxMCHeight";
            this.textBoxMCHeight.ReadOnly = true;
            this.textBoxMCHeight.Size = new System.Drawing.Size(89, 22);
            this.textBoxMCHeight.TabIndex = 18;
            // 
            // textBoxMCAngle1
            // 
            this.textBoxMCAngle1.Location = new System.Drawing.Point(125, 220);
            this.textBoxMCAngle1.Name = "textBoxMCAngle1";
            this.textBoxMCAngle1.ReadOnly = true;
            this.textBoxMCAngle1.Size = new System.Drawing.Size(89, 22);
            this.textBoxMCAngle1.TabIndex = 17;
            // 
            // btnMCFlangeO
            // 
            this.btnMCFlangeO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMCFlangeO.Location = new System.Drawing.Point(220, 266);
            this.btnMCFlangeO.Name = "btnMCFlangeO";
            this.btnMCFlangeO.Size = new System.Drawing.Size(97, 49);
            this.btnMCFlangeO.TabIndex = 9;
            this.btnMCFlangeO.Text = "User Flange\r\nOpen";
            this.btnMCFlangeO.UseVisualStyleBackColor = true;
            // 
            // tabPageCC
            // 
            this.tabPageCC.Controls.Add(this.btnCCHint);
            this.tabPageCC.Controls.Add(this.panelCC_Online);
            this.tabPageCC.Controls.Add(this.btnCCExecute);
            this.tabPageCC.Controls.Add(this.label23);
            this.tabPageCC.Controls.Add(this.btnCCPath);
            this.tabPageCC.Controls.Add(this.groupBox5);
            this.tabPageCC.Controls.Add(this.groupBox4);
            this.tabPageCC.Controls.Add(this.groupBox3);
            this.tabPageCC.Controls.Add(this.btnCCEStop);
            this.tabPageCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageCC.Location = new System.Drawing.Point(4, 25);
            this.tabPageCC.Name = "tabPageCC";
            this.tabPageCC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCC.Size = new System.Drawing.Size(496, 320);
            this.tabPageCC.TabIndex = 1;
            this.tabPageCC.Text = "Coordinate Control";
            this.tabPageCC.UseVisualStyleBackColor = true;
            // 
            // btnCCHint
            // 
            this.btnCCHint.Location = new System.Drawing.Point(305, 206);
            this.btnCCHint.Name = "btnCCHint";
            this.btnCCHint.Size = new System.Drawing.Size(25, 25);
            this.btnCCHint.TabIndex = 44;
            this.btnCCHint.Text = "?";
            this.btnCCHint.UseVisualStyleBackColor = true;
            this.btnCCHint.Click += new System.EventHandler(this.btnCCHint_Click);
            // 
            // panelCC_Online
            // 
            this.panelCC_Online.BackColor = System.Drawing.Color.Red;
            this.panelCC_Online.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCC_Online.Location = new System.Drawing.Point(480, 6);
            this.panelCC_Online.Name = "panelCC_Online";
            this.panelCC_Online.Size = new System.Drawing.Size(10, 10);
            this.panelCC_Online.TabIndex = 48;
            // 
            // btnCCExecute
            // 
            this.btnCCExecute.BackColor = System.Drawing.Color.Transparent;
            this.btnCCExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCCExecute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCCExecute.Location = new System.Drawing.Point(52, 249);
            this.btnCCExecute.Name = "btnCCExecute";
            this.btnCCExecute.Size = new System.Drawing.Size(239, 54);
            this.btnCCExecute.TabIndex = 46;
            this.btnCCExecute.Text = "Execute";
            this.btnCCExecute.UseVisualStyleBackColor = false;
            this.btnCCExecute.Click += new System.EventHandler(this.btnCCExecute_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(432, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 16);
            this.label23.TabIndex = 47;
            this.label23.Text = "Online";
            // 
            // btnCCPath
            // 
            this.btnCCPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCCPath.Location = new System.Drawing.Point(52, 206);
            this.btnCCPath.Name = "btnCCPath";
            this.btnCCPath.Size = new System.Drawing.Size(239, 37);
            this.btnCCPath.TabIndex = 45;
            this.btnCCPath.Text = "Create path";
            this.btnCCPath.UseVisualStyleBackColor = true;
            this.btnCCPath.Click += new System.EventHandler(this.btnCCPath_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.panelCCRPM);
            this.groupBox5.Controls.Add(this.panelCCAcceleration);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(6, 114);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 78);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motion Parameters";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(119, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 16);
            this.label22.TabIndex = 45;
            this.label22.Text = "r/min";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(275, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "steps";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(168, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 18);
            this.label20.TabIndex = 42;
            this.label20.Text = "Ramp Length";
            // 
            // panelCCRPM
            // 
            this.panelCCRPM.Controls.Add(this.textBoxCCRPM);
            this.panelCCRPM.Location = new System.Drawing.Point(6, 46);
            this.panelCCRPM.Name = "panelCCRPM";
            this.panelCCRPM.Size = new System.Drawing.Size(107, 26);
            this.panelCCRPM.TabIndex = 41;
            // 
            // textBoxCCRPM
            // 
            this.textBoxCCRPM.Location = new System.Drawing.Point(7, 0);
            this.textBoxCCRPM.Name = "textBoxCCRPM";
            this.textBoxCCRPM.Size = new System.Drawing.Size(100, 24);
            this.textBoxCCRPM.TabIndex = 0;
            this.textBoxCCRPM.Text = "1-200";
            // 
            // panelCCAcceleration
            // 
            this.panelCCAcceleration.Controls.Add(this.textBoxCCAcceleration);
            this.panelCCAcceleration.Location = new System.Drawing.Point(164, 46);
            this.panelCCAcceleration.Name = "panelCCAcceleration";
            this.panelCCAcceleration.Size = new System.Drawing.Size(105, 26);
            this.panelCCAcceleration.TabIndex = 43;
            // 
            // textBoxCCAcceleration
            // 
            this.textBoxCCAcceleration.Location = new System.Drawing.Point(7, 0);
            this.textBoxCCAcceleration.Name = "textBoxCCAcceleration";
            this.textBoxCCAcceleration.Size = new System.Drawing.Size(98, 24);
            this.textBoxCCAcceleration.TabIndex = 0;
            this.textBoxCCAcceleration.Text = "1-100";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(10, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 18);
            this.label21.TabIndex = 3;
            this.label21.Text = "RPM";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxCCParallel);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.panelCCFspread);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.panelCCQangle);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(348, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 172);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tool";
            // 
            // checkBoxCCParallel
            // 
            this.checkBoxCCParallel.AutoSize = true;
            this.checkBoxCCParallel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCCParallel.Location = new System.Drawing.Point(39, 78);
            this.checkBoxCCParallel.Name = "checkBoxCCParallel";
            this.checkBoxCCParallel.Size = new System.Drawing.Size(83, 22);
            this.checkBoxCCParallel.TabIndex = 47;
            this.checkBoxCCParallel.Text = "Parallel: ";
            this.checkBoxCCParallel.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(98, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 18);
            this.label18.TabIndex = 45;
            this.label18.Text = "mm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(102, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 18);
            this.label17.TabIndex = 44;
            this.label17.Text = "°";
            // 
            // panelCCFspread
            // 
            this.panelCCFspread.Controls.Add(this.textBoxCCFWidth);
            this.panelCCFspread.Location = new System.Drawing.Point(6, 138);
            this.panelCCFspread.Name = "panelCCFspread";
            this.panelCCFspread.Size = new System.Drawing.Size(90, 26);
            this.panelCCFspread.TabIndex = 43;
            // 
            // textBoxCCFWidth
            // 
            this.textBoxCCFWidth.Location = new System.Drawing.Point(7, 0);
            this.textBoxCCFWidth.Name = "textBoxCCFWidth";
            this.textBoxCCFWidth.Size = new System.Drawing.Size(83, 24);
            this.textBoxCCFWidth.TabIndex = 0;
            this.textBoxCCFWidth.Text = "45";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(6, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 18);
            this.label16.TabIndex = 42;
            this.label16.Text = "Flange Width";
            // 
            // panelCCQangle
            // 
            this.panelCCQangle.Controls.Add(this.textBoxCCQangle);
            this.panelCCQangle.Location = new System.Drawing.Point(6, 46);
            this.panelCCQangle.Name = "panelCCQangle";
            this.panelCCQangle.Size = new System.Drawing.Size(90, 26);
            this.panelCCQangle.TabIndex = 43;
            // 
            // textBoxCCQangle
            // 
            this.textBoxCCQangle.Location = new System.Drawing.Point(7, 0);
            this.textBoxCCQangle.Name = "textBoxCCQangle";
            this.textBoxCCQangle.Size = new System.Drawing.Size(83, 24);
            this.textBoxCCQangle.TabIndex = 0;
            this.textBoxCCQangle.Text = "-90";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(10, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 18);
            this.label15.TabIndex = 42;
            this.label15.Text = "Quill Angle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.panelCCZaxis);
            this.groupBox3.Controls.Add(this.panelCCXaxis);
            this.groupBox3.Controls.Add(this.panelCCYaxis);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 78);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coordinates [mm]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(232, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 42;
            this.label14.Text = "z-axis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(122, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 18);
            this.label13.TabIndex = 42;
            this.label13.Text = "y-axis";
            // 
            // panelCCZaxis
            // 
            this.panelCCZaxis.Controls.Add(this.textBoxCCZaxis);
            this.panelCCZaxis.Location = new System.Drawing.Point(228, 46);
            this.panelCCZaxis.Name = "panelCCZaxis";
            this.panelCCZaxis.Size = new System.Drawing.Size(90, 26);
            this.panelCCZaxis.TabIndex = 43;
            // 
            // textBoxCCZaxis
            // 
            this.textBoxCCZaxis.Location = new System.Drawing.Point(7, 0);
            this.textBoxCCZaxis.Name = "textBoxCCZaxis";
            this.textBoxCCZaxis.Size = new System.Drawing.Size(83, 24);
            this.textBoxCCZaxis.TabIndex = 0;
            this.textBoxCCZaxis.Text = "z";
            // 
            // panelCCXaxis
            // 
            this.panelCCXaxis.Controls.Add(this.textBoxCCXaxis);
            this.panelCCXaxis.Location = new System.Drawing.Point(6, 46);
            this.panelCCXaxis.Name = "panelCCXaxis";
            this.panelCCXaxis.Size = new System.Drawing.Size(90, 26);
            this.panelCCXaxis.TabIndex = 41;
            // 
            // textBoxCCXaxis
            // 
            this.textBoxCCXaxis.Location = new System.Drawing.Point(7, 0);
            this.textBoxCCXaxis.Name = "textBoxCCXaxis";
            this.textBoxCCXaxis.Size = new System.Drawing.Size(83, 24);
            this.textBoxCCXaxis.TabIndex = 0;
            this.textBoxCCXaxis.Text = "x";
            // 
            // panelCCYaxis
            // 
            this.panelCCYaxis.Controls.Add(this.textBoxCCYaxis);
            this.panelCCYaxis.Location = new System.Drawing.Point(118, 46);
            this.panelCCYaxis.Name = "panelCCYaxis";
            this.panelCCYaxis.Size = new System.Drawing.Size(90, 26);
            this.panelCCYaxis.TabIndex = 43;
            // 
            // textBoxCCYaxis
            // 
            this.textBoxCCYaxis.Location = new System.Drawing.Point(7, 0);
            this.textBoxCCYaxis.Name = "textBoxCCYaxis";
            this.textBoxCCYaxis.Size = new System.Drawing.Size(83, 24);
            this.textBoxCCYaxis.TabIndex = 0;
            this.textBoxCCYaxis.Text = "y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(10, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "x-axis";
            // 
            // btnCCEStop
            // 
            this.btnCCEStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnCCEStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCCEStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCCEStop.Location = new System.Drawing.Point(350, 216);
            this.btnCCEStop.Name = "btnCCEStop";
            this.btnCCEStop.Size = new System.Drawing.Size(131, 87);
            this.btnCCEStop.TabIndex = 39;
            this.btnCCEStop.Text = "E-stop";
            this.btnCCEStop.UseVisualStyleBackColor = false;
            this.btnCCEStop.Click += new System.EventHandler(this.btnCCEStop_Click);
            // 
            // tabPageDT
            // 
            this.tabPageDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageDT.Location = new System.Drawing.Point(4, 25);
            this.tabPageDT.Name = "tabPageDT";
            this.tabPageDT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDT.Size = new System.Drawing.Size(496, 320);
            this.tabPageDT.TabIndex = 2;
            this.tabPageDT.Text = "Digital Twin";
            this.tabPageDT.UseVisualStyleBackColor = true;
            // 
            // groupBoxCommunication
            // 
            this.groupBoxCommunication.Controls.Add(this.textBoxOutputMessage);
            this.groupBoxCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxCommunication.Location = new System.Drawing.Point(10, 382);
            this.groupBoxCommunication.Name = "groupBoxCommunication";
            this.groupBoxCommunication.Size = new System.Drawing.Size(762, 167);
            this.groupBoxCommunication.TabIndex = 5;
            this.groupBoxCommunication.TabStop = false;
            this.groupBoxCommunication.Text = "Communication";
            // 
            // textBoxOutputMessage
            // 
            this.textBoxOutputMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxOutputMessage.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutputMessage.Multiline = true;
            this.textBoxOutputMessage.Name = "textBoxOutputMessage";
            this.textBoxOutputMessage.ReadOnly = true;
            this.textBoxOutputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputMessage.Size = new System.Drawing.Size(746, 140);
            this.textBoxOutputMessage.TabIndex = 0;
            // 
            // timerCheckConnection
            // 
            this.timerCheckConnection.Interval = 800;
            this.timerCheckConnection.Tick += new System.EventHandler(this.timerCheckConnection_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxCommunication);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "SCARA robot";
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxMenu.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabPageS.ResumeLayout(false);
            this.tabPageS.PerformLayout();
            this.tabPageM.ResumeLayout(false);
            this.tabPageM.PerformLayout();
            this.panelMCRPM.ResumeLayout(false);
            this.panelMCRPM.PerformLayout();
            this.panelMCAcceleration.ResumeLayout(false);
            this.panelMCAcceleration.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageCC.ResumeLayout(false);
            this.tabPageCC.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panelCCRPM.ResumeLayout(false);
            this.panelCCRPM.PerformLayout();
            this.panelCCAcceleration.ResumeLayout(false);
            this.panelCCAcceleration.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelCCFspread.ResumeLayout(false);
            this.panelCCFspread.PerformLayout();
            this.panelCCQangle.ResumeLayout(false);
            this.panelCCQangle.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelCCZaxis.ResumeLayout(false);
            this.panelCCZaxis.PerformLayout();
            this.panelCCXaxis.ResumeLayout(false);
            this.panelCCXaxis.PerformLayout();
            this.panelCCYaxis.ResumeLayout(false);
            this.panelCCYaxis.PerformLayout();
            this.groupBoxCommunication.ResumeLayout(false);
            this.groupBoxCommunication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxCommunication;
        private System.Windows.Forms.TextBox textBoxOutputMessage;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPageS;
        private System.Windows.Forms.TabPage tabPageM;
        private System.Windows.Forms.TabPage tabPageCC;
        private System.Windows.Forms.TabPage tabPageDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSDeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelS_Online;
        private System.Windows.Forms.Button btnSHomePosition;
        private System.Windows.Forms.Button btnSDisconnect;
        private System.Windows.Forms.ComboBox comboBoxSBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSEStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSCommand;
        private System.Windows.Forms.Timer timerCheckConnection;
        private System.Windows.Forms.Button btnMCFlangeO;
        private System.Windows.Forms.Button btnMCJoint4L;
        private System.Windows.Forms.Button btnMCJoint3L;
        private System.Windows.Forms.Button btnMCJoint2L;
        private System.Windows.Forms.Button btnMCJoint1L;
        private System.Windows.Forms.TextBox textBoxMCWidthFlange;
        private System.Windows.Forms.TextBox textBoxMCAngle4;
        private System.Windows.Forms.TextBox textBoxMCAngle3;
        private System.Windows.Forms.TextBox textBoxMCHeight;
        private System.Windows.Forms.TextBox textBoxMCAngle1;
        private System.Windows.Forms.Button btnMCFlangeC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMCRPM;
        private System.Windows.Forms.TextBox textBoxMCAcceleration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMCJoint2R;
        private System.Windows.Forms.Button btnMCJoint1R;
        private System.Windows.Forms.Button btnMCJoint3R;
        private System.Windows.Forms.Button btnMCJoint4R;
        private System.Windows.Forms.Button btnSClearSerialMonitor;
        private System.Windows.Forms.Button btnMCEStop;
        private System.Windows.Forms.Panel panelMC_Online;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelMCAcceleration;
        private System.Windows.Forms.Panel panelMCRPM;
        private System.Windows.Forms.Button btnSToggleAutoscroll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCCXaxis;
        private System.Windows.Forms.Button btnCCEStop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panelCCFspread;
        private System.Windows.Forms.TextBox textBoxCCFWidth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelCCQangle;
        private System.Windows.Forms.TextBox textBoxCCQangle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelCCZaxis;
        private System.Windows.Forms.TextBox textBoxCCZaxis;
        private System.Windows.Forms.Panel panelCCXaxis;
        private System.Windows.Forms.Panel panelCCYaxis;
        private System.Windows.Forms.TextBox textBoxCCYaxis;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panelCCRPM;
        private System.Windows.Forms.TextBox textBoxCCRPM;
        private System.Windows.Forms.Panel panelCCAcceleration;
        private System.Windows.Forms.TextBox textBoxCCAcceleration;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCCPath;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCCExecute;
        private System.Windows.Forms.Panel panelCC_Online;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox checkBoxCCParallel;
        private System.Windows.Forms.Button btnCCHint;
        private System.Windows.Forms.Button btnMCAdd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
    }
}

