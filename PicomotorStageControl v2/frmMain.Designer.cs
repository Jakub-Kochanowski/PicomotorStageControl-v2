namespace PicomotorStageControl_v2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox6 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnCalZeroPosition = new Button();
            groupBox8 = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            label26 = new Label();
            lblCalPositionEstMicronPosition = new Label();
            label24 = new Label();
            label23 = new Label();
            lblCalPositionPosSteps = new Label();
            label20 = new Label();
            label19 = new Label();
            lblCalPositionNegSteps = new Label();
            label14 = new Label();
            label13 = new Label();
            lblCalPositionTotalSteps = new Label();
            label8 = new Label();
            groupBox11 = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            label30 = new Label();
            lblCalVelPos = new Label();
            label32 = new Label();
            label33 = new Label();
            lblCalVelNeg = new Label();
            label35 = new Label();
            label36 = new Label();
            lblCalVelRaw = new Label();
            label38 = new Label();
            groupBox13 = new GroupBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            label42 = new Label();
            lblCalAccelPos = new Label();
            label44 = new Label();
            label45 = new Label();
            lblCalAccelNeg = new Label();
            label47 = new Label();
            label48 = new Label();
            lblCalAccelRaw = new Label();
            label50 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            lblCalPosStepSize = new Label();
            label4 = new Label();
            label3 = new Label();
            lblCalNegStepSize = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label16 = new Label();
            lblIndicatorDisplayVelocity = new Label();
            label11 = new Label();
            label10 = new Label();
            lblIndicatorDisplayPosition = new Label();
            label7 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStageConnected = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            statusIndicatorConnected = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            toolStripStatusLabel7 = new ToolStripStatusLabel();
            toolStripStatusLabel8 = new ToolStripStatusLabel();
            toolStripStatusLabel9 = new ToolStripStatusLabel();
            toolStripStatusLabel10 = new ToolStripStatusLabel();
            toolStripStatusLabel11 = new ToolStripStatusLabel();
            toolStripStatusLabel12 = new ToolStripStatusLabel();
            toolStripStatusLabel13 = new ToolStripStatusLabel();
            toolStripStatusLabel14 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            connectToolStripMenuItem = new ToolStripMenuItem();
            stripConnectStage = new ToolStripMenuItem();
            stripConnectIndicator = new ToolStripMenuItem();
            stripSettings = new ToolStripMenuItem();
            stripAbout = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            btnStopAllMotion = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            btnGoTo = new Button();
            tableLayoutPanel15 = new TableLayoutPanel();
            numGoTo = new NumericUpDown();
            label29 = new Label();
            lblGoToUnits = new Label();
            lblGoToEstDistance = new Label();
            groupBox5 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnMoveDistance = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            numMoveDistance = new NumericUpDown();
            lblMoveDistanceUnits = new Label();
            label41 = new Label();
            lblMoveDistanceEstDistance = new Label();
            groupBox7 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            radRefSteps = new RadioButton();
            btnLockReference = new Button();
            radRefIndicator = new RadioButton();
            radRefCalibration = new RadioButton();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnActiveControlsDown = new Button();
            btnActiveControlsUp = new Button();
            groupBox9 = new GroupBox();
            tableLayoutPanel16 = new TableLayoutPanel();
            lblMotorSettingsEstNegAccel = new Label();
            btnMotorSettingsApply = new Button();
            btnMotorSettingsCancel = new Button();
            btnMotorSettingsApplyDefault = new Button();
            lblMotorSettingsAccelerationUnits = new Label();
            lblMotorSettingsEstPosAccel = new Label();
            label57 = new Label();
            numMotorSettingsAcceleration = new NumericUpDown();
            label56 = new Label();
            lblMotorSettingsVelocityUnits = new Label();
            lblMotorSettingsEstPosVel = new Label();
            label52 = new Label();
            numMotorSettingsVelocity = new NumericUpDown();
            label17 = new Label();
            lblMotorSettingsEstNegVel = new Label();
            groupBox10 = new GroupBox();
            groupBox15 = new GroupBox();
            tableLayoutPanel22 = new TableLayoutPanel();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label15 = new Label();
            btnPlotClear = new Button();
            numPlotInterval = new NumericUpDown();
            label9 = new Label();
            groupBox12 = new GroupBox();
            tableLayoutPanel17 = new TableLayoutPanel();
            tableLayoutPanel20 = new TableLayoutPanel();
            btnDataCollect = new Button();
            label62 = new Label();
            label61 = new Label();
            numDataCollectionRate = new NumericUpDown();
            tableLayoutPanel19 = new TableLayoutPanel();
            txtDataFileName = new TextBox();
            label58 = new Label();
            tableLayoutPanel18 = new TableLayoutPanel();
            btnDataSelectDirectory = new Button();
            label53 = new Label();
            txtDataDirectory = new TextBox();
            groupBox14 = new GroupBox();
            tableLayoutPanel21 = new TableLayoutPanel();
            btnOpenSequenceEditor = new Button();
            Plot = new ScottPlot.WinForms.FormsPlot();
            tmrIndicatorDisplayUpdate = new System.Windows.Forms.Timer(components);
            tmrMotorDisplayUpdate = new System.Windows.Forms.Timer(components);
            tmrPlotUpdate = new System.Windows.Forms.Timer(components);
            groupBox6.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox8.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            groupBox11.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            groupBox13.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGoTo).BeginInit();
            groupBox5.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMoveDistance).BeginInit();
            groupBox7.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMotorSettingsAcceleration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMotorSettingsVelocity).BeginInit();
            groupBox10.SuspendLayout();
            groupBox15.SuspendLayout();
            tableLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlotInterval).BeginInit();
            groupBox12.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDataCollectionRate).BeginInit();
            tableLayoutPanel19.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            groupBox14.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tableLayoutPanel6);
            groupBox6.Location = new Point(11, 35);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(443, 683);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Calibration Display";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(btnCalZeroPosition, 0, 4);
            tableLayoutPanel6.Controls.Add(groupBox8, 0, 0);
            tableLayoutPanel6.Controls.Add(groupBox11, 0, 1);
            tableLayoutPanel6.Controls.Add(groupBox13, 0, 2);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel1, 0, 3);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel6.Location = new Point(3, 23);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 37.61697F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 31.1915169F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 31.1915169F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel6.Size = new Size(437, 657);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnCalZeroPosition
            // 
            btnCalZeroPosition.Dock = DockStyle.Fill;
            btnCalZeroPosition.Enabled = false;
            btnCalZeroPosition.Location = new Point(3, 608);
            btnCalZeroPosition.Name = "btnCalZeroPosition";
            btnCalZeroPosition.Size = new Size(431, 46);
            btnCalZeroPosition.TabIndex = 4;
            btnCalZeroPosition.Text = "Zero Position";
            btnCalZeroPosition.UseVisualStyleBackColor = true;
            btnCalZeroPosition.Click += btnCalZeroPosition_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(tableLayoutPanel8);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox8.Location = new Point(3, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(431, 202);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "Position";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 23);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(425, 176);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel10.Controls.Add(label26, 2, 3);
            tableLayoutPanel10.Controls.Add(lblCalPositionEstMicronPosition, 1, 3);
            tableLayoutPanel10.Controls.Add(label24, 0, 3);
            tableLayoutPanel10.Controls.Add(label23, 2, 2);
            tableLayoutPanel10.Controls.Add(lblCalPositionPosSteps, 1, 2);
            tableLayoutPanel10.Controls.Add(label20, 0, 2);
            tableLayoutPanel10.Controls.Add(label19, 2, 1);
            tableLayoutPanel10.Controls.Add(lblCalPositionNegSteps, 1, 1);
            tableLayoutPanel10.Controls.Add(label14, 0, 1);
            tableLayoutPanel10.Controls.Add(label13, 2, 0);
            tableLayoutPanel10.Controls.Add(lblCalPositionTotalSteps, 1, 0);
            tableLayoutPanel10.Controls.Add(label8, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 4;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(419, 170);
            tableLayoutPanel10.TabIndex = 2;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Dock = DockStyle.Fill;
            label26.Font = new Font("Segoe UI", 9F);
            label26.Location = new Point(169, 126);
            label26.Name = "label26";
            label26.Size = new Size(247, 44);
            label26.TabIndex = 13;
            label26.Text = "um";
            label26.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalPositionEstMicronPosition
            // 
            lblCalPositionEstMicronPosition.AutoSize = true;
            lblCalPositionEstMicronPosition.BackColor = Color.Transparent;
            lblCalPositionEstMicronPosition.Dock = DockStyle.Fill;
            lblCalPositionEstMicronPosition.Font = new Font("Segoe UI", 9F);
            lblCalPositionEstMicronPosition.Location = new Point(127, 126);
            lblCalPositionEstMicronPosition.Name = "lblCalPositionEstMicronPosition";
            lblCalPositionEstMicronPosition.Size = new Size(36, 44);
            lblCalPositionEstMicronPosition.TabIndex = 12;
            lblCalPositionEstMicronPosition.Text = "N/A";
            lblCalPositionEstMicronPosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Dock = DockStyle.Fill;
            label24.Font = new Font("Segoe UI", 9F);
            label24.Location = new Point(3, 126);
            label24.Name = "label24";
            label24.Size = new Size(118, 44);
            label24.TabIndex = 11;
            label24.Text = "Est. Cal. Position:";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Dock = DockStyle.Fill;
            label23.Font = new Font("Segoe UI", 9F);
            label23.Location = new Point(169, 84);
            label23.Name = "label23";
            label23.Size = new Size(247, 42);
            label23.TabIndex = 10;
            label23.Text = "steps";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalPositionPosSteps
            // 
            lblCalPositionPosSteps.AutoSize = true;
            lblCalPositionPosSteps.BackColor = Color.Transparent;
            lblCalPositionPosSteps.Dock = DockStyle.Fill;
            lblCalPositionPosSteps.Font = new Font("Segoe UI", 9F);
            lblCalPositionPosSteps.Location = new Point(127, 84);
            lblCalPositionPosSteps.Name = "lblCalPositionPosSteps";
            lblCalPositionPosSteps.Size = new Size(36, 42);
            lblCalPositionPosSteps.TabIndex = 9;
            lblCalPositionPosSteps.Text = "N/A";
            lblCalPositionPosSteps.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Segoe UI", 9F);
            label20.Location = new Point(3, 84);
            label20.Name = "label20";
            label20.Size = new Size(118, 42);
            label20.TabIndex = 8;
            label20.Text = "Positive Steps:";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Segoe UI", 9F);
            label19.Location = new Point(169, 42);
            label19.Name = "label19";
            label19.Size = new Size(247, 42);
            label19.TabIndex = 7;
            label19.Text = "steps";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalPositionNegSteps
            // 
            lblCalPositionNegSteps.AutoSize = true;
            lblCalPositionNegSteps.BackColor = Color.Transparent;
            lblCalPositionNegSteps.Dock = DockStyle.Fill;
            lblCalPositionNegSteps.Font = new Font("Segoe UI", 9F);
            lblCalPositionNegSteps.Location = new Point(127, 42);
            lblCalPositionNegSteps.Name = "lblCalPositionNegSteps";
            lblCalPositionNegSteps.Size = new Size(36, 42);
            lblCalPositionNegSteps.TabIndex = 6;
            lblCalPositionNegSteps.Text = "N/A";
            lblCalPositionNegSteps.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 9F);
            label14.Location = new Point(3, 42);
            label14.Name = "label14";
            label14.Size = new Size(118, 42);
            label14.TabIndex = 5;
            label14.Text = "Negative Steps:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(169, 0);
            label13.Name = "label13";
            label13.Size = new Size(247, 42);
            label13.TabIndex = 4;
            label13.Text = "steps";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalPositionTotalSteps
            // 
            lblCalPositionTotalSteps.AutoSize = true;
            lblCalPositionTotalSteps.BackColor = Color.Transparent;
            lblCalPositionTotalSteps.Dock = DockStyle.Fill;
            lblCalPositionTotalSteps.Font = new Font("Segoe UI", 9F);
            lblCalPositionTotalSteps.Location = new Point(127, 0);
            lblCalPositionTotalSteps.Name = "lblCalPositionTotalSteps";
            lblCalPositionTotalSteps.Size = new Size(36, 42);
            lblCalPositionTotalSteps.TabIndex = 3;
            lblCalPositionTotalSteps.Text = "N/A";
            lblCalPositionTotalSteps.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(118, 42);
            label8.TabIndex = 2;
            label8.Text = "Total Steps:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(tableLayoutPanel11);
            groupBox11.Dock = DockStyle.Fill;
            groupBox11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox11.Location = new Point(3, 211);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(431, 167);
            groupBox11.TabIndex = 1;
            groupBox11.TabStop = false;
            groupBox11.Text = "Velocity";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 23);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(425, 141);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.Controls.Add(label30, 2, 2);
            tableLayoutPanel12.Controls.Add(lblCalVelPos, 1, 2);
            tableLayoutPanel12.Controls.Add(label32, 0, 2);
            tableLayoutPanel12.Controls.Add(label33, 2, 1);
            tableLayoutPanel12.Controls.Add(lblCalVelNeg, 1, 1);
            tableLayoutPanel12.Controls.Add(label35, 0, 1);
            tableLayoutPanel12.Controls.Add(label36, 2, 0);
            tableLayoutPanel12.Controls.Add(lblCalVelRaw, 1, 0);
            tableLayoutPanel12.Controls.Add(label38, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(419, 135);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Dock = DockStyle.Fill;
            label30.Font = new Font("Segoe UI", 9F);
            label30.Location = new Point(147, 90);
            label30.Name = "label30";
            label30.Size = new Size(269, 45);
            label30.TabIndex = 10;
            label30.Text = "um/s";
            label30.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalVelPos
            // 
            lblCalVelPos.AutoSize = true;
            lblCalVelPos.BackColor = Color.Transparent;
            lblCalVelPos.Dock = DockStyle.Fill;
            lblCalVelPos.Font = new Font("Segoe UI", 9F);
            lblCalVelPos.Location = new Point(105, 90);
            lblCalVelPos.Name = "lblCalVelPos";
            lblCalVelPos.Size = new Size(36, 45);
            lblCalVelPos.TabIndex = 9;
            lblCalVelPos.Text = "N/A";
            lblCalVelPos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Transparent;
            label32.Dock = DockStyle.Fill;
            label32.Font = new Font("Segoe UI", 9F);
            label32.Location = new Point(3, 90);
            label32.Name = "label32";
            label32.Size = new Size(96, 45);
            label32.TabIndex = 8;
            label32.Text = "Positive:";
            label32.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = Color.Transparent;
            label33.Dock = DockStyle.Fill;
            label33.Font = new Font("Segoe UI", 9F);
            label33.Location = new Point(147, 45);
            label33.Name = "label33";
            label33.Size = new Size(269, 45);
            label33.TabIndex = 7;
            label33.Text = "um/s";
            label33.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalVelNeg
            // 
            lblCalVelNeg.AutoSize = true;
            lblCalVelNeg.BackColor = Color.Transparent;
            lblCalVelNeg.Dock = DockStyle.Fill;
            lblCalVelNeg.Font = new Font("Segoe UI", 9F);
            lblCalVelNeg.Location = new Point(105, 45);
            lblCalVelNeg.Name = "lblCalVelNeg";
            lblCalVelNeg.Size = new Size(36, 45);
            lblCalVelNeg.TabIndex = 6;
            lblCalVelNeg.Text = "N/A";
            lblCalVelNeg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.Transparent;
            label35.Dock = DockStyle.Fill;
            label35.Font = new Font("Segoe UI", 9F);
            label35.Location = new Point(3, 45);
            label35.Name = "label35";
            label35.Size = new Size(96, 45);
            label35.TabIndex = 5;
            label35.Text = "Negative:";
            label35.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = Color.Transparent;
            label36.Dock = DockStyle.Fill;
            label36.Font = new Font("Segoe UI", 9F);
            label36.Location = new Point(147, 0);
            label36.Name = "label36";
            label36.Size = new Size(269, 45);
            label36.TabIndex = 4;
            label36.Text = "steps/s";
            label36.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalVelRaw
            // 
            lblCalVelRaw.AutoSize = true;
            lblCalVelRaw.BackColor = Color.Transparent;
            lblCalVelRaw.Dock = DockStyle.Fill;
            lblCalVelRaw.Font = new Font("Segoe UI", 9F);
            lblCalVelRaw.Location = new Point(105, 0);
            lblCalVelRaw.Name = "lblCalVelRaw";
            lblCalVelRaw.Size = new Size(36, 45);
            lblCalVelRaw.TabIndex = 3;
            lblCalVelRaw.Text = "N/A";
            lblCalVelRaw.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = Color.Transparent;
            label38.Dock = DockStyle.Fill;
            label38.Font = new Font("Segoe UI", 9F);
            label38.Location = new Point(3, 0);
            label38.Name = "label38";
            label38.Size = new Size(96, 45);
            label38.TabIndex = 2;
            label38.Text = "Raw Velocity:";
            label38.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(tableLayoutPanel13);
            groupBox13.Dock = DockStyle.Fill;
            groupBox13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox13.Location = new Point(3, 384);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(431, 167);
            groupBox13.TabIndex = 2;
            groupBox13.TabStop = false;
            groupBox13.Text = "Acceleration";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(tableLayoutPanel14, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 23);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(425, 141);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel14.Controls.Add(label42, 2, 2);
            tableLayoutPanel14.Controls.Add(lblCalAccelPos, 1, 2);
            tableLayoutPanel14.Controls.Add(label44, 0, 2);
            tableLayoutPanel14.Controls.Add(label45, 2, 1);
            tableLayoutPanel14.Controls.Add(lblCalAccelNeg, 1, 1);
            tableLayoutPanel14.Controls.Add(label47, 0, 1);
            tableLayoutPanel14.Controls.Add(label48, 2, 0);
            tableLayoutPanel14.Controls.Add(lblCalAccelRaw, 1, 0);
            tableLayoutPanel14.Controls.Add(label50, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 3;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.Size = new Size(419, 135);
            tableLayoutPanel14.TabIndex = 3;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = Color.Transparent;
            label42.Dock = DockStyle.Fill;
            label42.Font = new Font("Segoe UI", 9F);
            label42.Location = new Point(178, 90);
            label42.Name = "label42";
            label42.Size = new Size(238, 45);
            label42.TabIndex = 10;
            label42.Text = "um/s^2";
            label42.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalAccelPos
            // 
            lblCalAccelPos.AutoSize = true;
            lblCalAccelPos.BackColor = Color.Transparent;
            lblCalAccelPos.Dock = DockStyle.Fill;
            lblCalAccelPos.Font = new Font("Segoe UI", 9F);
            lblCalAccelPos.Location = new Point(136, 90);
            lblCalAccelPos.Name = "lblCalAccelPos";
            lblCalAccelPos.Size = new Size(36, 45);
            lblCalAccelPos.TabIndex = 9;
            lblCalAccelPos.Text = "N/A";
            lblCalAccelPos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BackColor = Color.Transparent;
            label44.Dock = DockStyle.Fill;
            label44.Font = new Font("Segoe UI", 9F);
            label44.Location = new Point(3, 90);
            label44.Name = "label44";
            label44.Size = new Size(127, 45);
            label44.TabIndex = 8;
            label44.Text = "Positive:";
            label44.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BackColor = Color.Transparent;
            label45.Dock = DockStyle.Fill;
            label45.Font = new Font("Segoe UI", 9F);
            label45.Location = new Point(178, 45);
            label45.Name = "label45";
            label45.Size = new Size(238, 45);
            label45.TabIndex = 7;
            label45.Text = "um/s^2";
            label45.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalAccelNeg
            // 
            lblCalAccelNeg.AutoSize = true;
            lblCalAccelNeg.BackColor = Color.Transparent;
            lblCalAccelNeg.Dock = DockStyle.Fill;
            lblCalAccelNeg.Font = new Font("Segoe UI", 9F);
            lblCalAccelNeg.Location = new Point(136, 45);
            lblCalAccelNeg.Name = "lblCalAccelNeg";
            lblCalAccelNeg.Size = new Size(36, 45);
            lblCalAccelNeg.TabIndex = 6;
            lblCalAccelNeg.Text = "N/A";
            lblCalAccelNeg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.BackColor = Color.Transparent;
            label47.Dock = DockStyle.Fill;
            label47.Font = new Font("Segoe UI", 9F);
            label47.Location = new Point(3, 45);
            label47.Name = "label47";
            label47.Size = new Size(127, 45);
            label47.TabIndex = 5;
            label47.Text = "Negative:";
            label47.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.BackColor = Color.Transparent;
            label48.Dock = DockStyle.Fill;
            label48.Font = new Font("Segoe UI", 9F);
            label48.Location = new Point(178, 0);
            label48.Name = "label48";
            label48.Size = new Size(238, 45);
            label48.TabIndex = 4;
            label48.Text = "steps/s^2";
            label48.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalAccelRaw
            // 
            lblCalAccelRaw.AutoSize = true;
            lblCalAccelRaw.BackColor = Color.Transparent;
            lblCalAccelRaw.Dock = DockStyle.Fill;
            lblCalAccelRaw.Font = new Font("Segoe UI", 9F);
            lblCalAccelRaw.Location = new Point(136, 0);
            lblCalAccelRaw.Name = "lblCalAccelRaw";
            lblCalAccelRaw.Size = new Size(36, 45);
            lblCalAccelRaw.TabIndex = 3;
            lblCalAccelRaw.Text = "N/A";
            lblCalAccelRaw.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.BackColor = Color.Transparent;
            label50.Dock = DockStyle.Fill;
            label50.Font = new Font("Segoe UI", 9F);
            label50.Location = new Point(3, 0);
            label50.Name = "label50";
            label50.Size = new Size(127, 45);
            label50.TabIndex = 2;
            label50.Text = "Raw Acceleration:";
            label50.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label6, 2, 1);
            tableLayoutPanel1.Controls.Add(lblCalPosStepSize, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(lblCalNegStepSize, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 557);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(431, 45);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(188, 22);
            label6.Name = "label6";
            label6.Size = new Size(240, 23);
            label6.TabIndex = 8;
            label6.Text = "um/step";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalPosStepSize
            // 
            lblCalPosStepSize.AutoSize = true;
            lblCalPosStepSize.BackColor = Color.Transparent;
            lblCalPosStepSize.Dock = DockStyle.Fill;
            lblCalPosStepSize.Font = new Font("Segoe UI", 9F);
            lblCalPosStepSize.Location = new Point(146, 22);
            lblCalPosStepSize.Name = "lblCalPosStepSize";
            lblCalPosStepSize.Size = new Size(36, 23);
            lblCalPosStepSize.TabIndex = 7;
            lblCalPosStepSize.Text = "N/A";
            lblCalPosStepSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(3, 22);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 6;
            label4.Text = "Positive Step Size:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(188, 0);
            label3.Name = "label3";
            label3.Size = new Size(240, 22);
            label3.TabIndex = 5;
            label3.Text = "um/step";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalNegStepSize
            // 
            lblCalNegStepSize.AutoSize = true;
            lblCalNegStepSize.BackColor = Color.Transparent;
            lblCalNegStepSize.Dock = DockStyle.Fill;
            lblCalNegStepSize.Font = new Font("Segoe UI", 9F);
            lblCalNegStepSize.Location = new Point(146, 0);
            lblCalNegStepSize.Name = "lblCalNegStepSize";
            lblCalNegStepSize.Size = new Size(36, 22);
            lblCalNegStepSize.TabIndex = 4;
            lblCalNegStepSize.Text = "N/A";
            lblCalNegStepSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 22);
            label1.TabIndex = 3;
            label1.Text = "Negative Step Size:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(462, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 115);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indicator Display";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label16, 2, 1);
            tableLayoutPanel2.Controls.Add(lblIndicatorDisplayVelocity, 1, 1);
            tableLayoutPanel2.Controls.Add(label11, 0, 1);
            tableLayoutPanel2.Controls.Add(label10, 2, 0);
            tableLayoutPanel2.Controls.Add(lblIndicatorDisplayPosition, 1, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(455, 89);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(160, 44);
            label16.Name = "label16";
            label16.Size = new Size(292, 45);
            label16.TabIndex = 8;
            label16.Text = "um/s";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIndicatorDisplayVelocity
            // 
            lblIndicatorDisplayVelocity.AutoSize = true;
            lblIndicatorDisplayVelocity.BackColor = Color.Transparent;
            lblIndicatorDisplayVelocity.Dock = DockStyle.Fill;
            lblIndicatorDisplayVelocity.Font = new Font("Segoe UI", 9F);
            lblIndicatorDisplayVelocity.Location = new Point(118, 44);
            lblIndicatorDisplayVelocity.Name = "lblIndicatorDisplayVelocity";
            lblIndicatorDisplayVelocity.Size = new Size(36, 45);
            lblIndicatorDisplayVelocity.TabIndex = 7;
            lblIndicatorDisplayVelocity.Text = "N/A";
            lblIndicatorDisplayVelocity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(3, 44);
            label11.Name = "label11";
            label11.Size = new Size(109, 45);
            label11.TabIndex = 6;
            label11.Text = "Active Velocity:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(160, 0);
            label10.Name = "label10";
            label10.Size = new Size(292, 44);
            label10.TabIndex = 5;
            label10.Text = "um";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIndicatorDisplayPosition
            // 
            lblIndicatorDisplayPosition.AutoSize = true;
            lblIndicatorDisplayPosition.BackColor = Color.Transparent;
            lblIndicatorDisplayPosition.Dock = DockStyle.Fill;
            lblIndicatorDisplayPosition.Font = new Font("Segoe UI", 9F);
            lblIndicatorDisplayPosition.Location = new Point(118, 0);
            lblIndicatorDisplayPosition.Name = "lblIndicatorDisplayPosition";
            lblIndicatorDisplayPosition.Size = new Size(36, 44);
            lblIndicatorDisplayPosition.TabIndex = 4;
            lblIndicatorDisplayPosition.Text = "N/A";
            lblIndicatorDisplayPosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(109, 44);
            label7.TabIndex = 3;
            label7.Text = "Position:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusStageConnected, toolStripStatusLabel3, toolStripStatusLabel4, statusIndicatorConnected, toolStripStatusLabel6, toolStripStatusLabel7, toolStripStatusLabel8, toolStripStatusLabel9, toolStripStatusLabel10, toolStripStatusLabel11, toolStripStatusLabel12, toolStripStatusLabel13, toolStripStatusLabel14 });
            statusStrip1.Location = new Point(0, 916);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(1522, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(129, 20);
            toolStripStatusLabel1.Text = "Stage Connection:";
            // 
            // statusStageConnected
            // 
            statusStageConnected.ForeColor = Color.Red;
            statusStageConnected.Name = "statusStageConnected";
            statusStageConnected.Size = new Size(99, 20);
            statusStageConnected.Text = "Disconnected";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(13, 20);
            toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(150, 20);
            toolStripStatusLabel4.Text = "Indicator Connection:";
            // 
            // statusIndicatorConnected
            // 
            statusIndicatorConnected.ForeColor = Color.Red;
            statusIndicatorConnected.Name = "statusIndicatorConnected";
            statusIndicatorConnected.Size = new Size(99, 20);
            statusIndicatorConnected.Text = "Disconnected";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(13, 20);
            toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel7
            // 
            toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            toolStripStatusLabel7.Size = new Size(94, 20);
            toolStripStatusLabel7.Text = "Stage Status:";
            // 
            // toolStripStatusLabel8
            // 
            toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            toolStripStatusLabel8.Size = new Size(36, 20);
            toolStripStatusLabel8.Text = "N/A";
            // 
            // toolStripStatusLabel9
            // 
            toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            toolStripStatusLabel9.Size = new Size(17, 20);
            toolStripStatusLabel9.Text = "||";
            // 
            // toolStripStatusLabel10
            // 
            toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            toolStripStatusLabel10.Size = new Size(134, 20);
            toolStripStatusLabel10.Text = "Sequence Running:";
            // 
            // toolStripStatusLabel11
            // 
            toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            toolStripStatusLabel11.Size = new Size(36, 20);
            toolStripStatusLabel11.Text = "N/A";
            // 
            // toolStripStatusLabel12
            // 
            toolStripStatusLabel12.Name = "toolStripStatusLabel12";
            toolStripStatusLabel12.Size = new Size(13, 20);
            toolStripStatusLabel12.Text = "|";
            // 
            // toolStripStatusLabel13
            // 
            toolStripStatusLabel13.Name = "toolStripStatusLabel13";
            toolStripStatusLabel13.Size = new Size(110, 20);
            toolStripStatusLabel13.Text = "Sequence Step:";
            // 
            // toolStripStatusLabel14
            // 
            toolStripStatusLabel14.Name = "toolStripStatusLabel14";
            toolStripStatusLabel14.Size = new Size(36, 20);
            toolStripStatusLabel14.Text = "N/A";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectToolStripMenuItem, stripSettings, stripAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1522, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripConnectStage, stripConnectIndicator });
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(77, 24);
            connectToolStripMenuItem.Text = "Connect";
            // 
            // stripConnectStage
            // 
            stripConnectStage.Name = "stripConnectStage";
            stripConnectStage.Size = new Size(151, 26);
            stripConnectStage.Text = "Stage";
            stripConnectStage.Click += stripConnectStage_Click;
            // 
            // stripConnectIndicator
            // 
            stripConnectIndicator.Name = "stripConnectIndicator";
            stripConnectIndicator.Size = new Size(151, 26);
            stripConnectIndicator.Text = "Indicator";
            stripConnectIndicator.Click += stripConnectIndicator_Click;
            // 
            // stripSettings
            // 
            stripSettings.Name = "stripSettings";
            stripSettings.Size = new Size(76, 24);
            stripSettings.Text = "Settings";
            stripSettings.Click += stripSettings_Click;
            // 
            // stripAbout
            // 
            stripAbout.Name = "stripAbout";
            stripAbout.Size = new Size(64, 24);
            stripAbout.Text = "About";
            stripAbout.Click += stripAbout_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnStopAllMotion);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(462, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(461, 563);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Standard Stage Controls";
            // 
            // btnStopAllMotion
            // 
            btnStopAllMotion.Enabled = false;
            btnStopAllMotion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnStopAllMotion.Location = new Point(305, 36);
            btnStopAllMotion.Name = "btnStopAllMotion";
            btnStopAllMotion.Size = new Size(150, 164);
            btnStopAllMotion.TabIndex = 15;
            btnStopAllMotion.Text = "STOP ALL MOTION";
            btnStopAllMotion.UseVisualStyleBackColor = true;
            btnStopAllMotion.Click += btnStopAllMotion_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel9);
            groupBox4.Location = new Point(6, 381);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(449, 173);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Go To";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(btnGoTo, 0, 2);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel15, 0, 0);
            tableLayoutPanel9.Controls.Add(lblGoToEstDistance, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 23);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.4073257F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1975613F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 44.3951225F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel9.Size = new Size(443, 147);
            tableLayoutPanel9.TabIndex = 13;
            // 
            // btnGoTo
            // 
            btnGoTo.Dock = DockStyle.Fill;
            btnGoTo.Enabled = false;
            btnGoTo.Location = new Point(3, 84);
            btnGoTo.Name = "btnGoTo";
            btnGoTo.Size = new Size(437, 60);
            btnGoTo.TabIndex = 4;
            btnGoTo.Text = "Go!";
            btnGoTo.UseVisualStyleBackColor = true;
            btnGoTo.Click += btnGoTo_Click;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 3;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel15.Controls.Add(numGoTo, 1, 0);
            tableLayoutPanel15.Controls.Add(label29, 0, 0);
            tableLayoutPanel15.Controls.Add(lblGoToUnits, 2, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 3);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.Size = new Size(437, 43);
            tableLayoutPanel15.TabIndex = 0;
            // 
            // numGoTo
            // 
            numGoTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numGoTo.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numGoTo.Location = new Point(73, 8);
            numGoTo.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numGoTo.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numGoTo.Name = "numGoTo";
            numGoTo.Size = new Size(267, 27);
            numGoTo.TabIndex = 5;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Fill;
            label29.Location = new Point(3, 0);
            label29.Name = "label29";
            label29.Size = new Size(64, 43);
            label29.TabIndex = 4;
            label29.Text = "Position:";
            label29.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoToUnits
            // 
            lblGoToUnits.AutoSize = true;
            lblGoToUnits.Dock = DockStyle.Fill;
            lblGoToUnits.Location = new Point(346, 0);
            lblGoToUnits.Name = "lblGoToUnits";
            lblGoToUnits.Size = new Size(88, 43);
            lblGoToUnits.TabIndex = 3;
            lblGoToUnits.Text = "um";
            lblGoToUnits.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoToEstDistance
            // 
            lblGoToEstDistance.AutoSize = true;
            lblGoToEstDistance.Dock = DockStyle.Fill;
            lblGoToEstDistance.Location = new Point(3, 49);
            lblGoToEstDistance.Name = "lblGoToEstDistance";
            lblGoToEstDistance.Size = new Size(437, 32);
            lblGoToEstDistance.TabIndex = 1;
            lblGoToEstDistance.Text = "(Approx. 0 steps)";
            lblGoToEstDistance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel5);
            groupBox5.Location = new Point(6, 205);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(449, 173);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Move Distance";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(btnMoveDistance, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel5.Controls.Add(lblMoveDistanceEstDistance, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 23);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.4073257F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1975613F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 44.3951225F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel5.Size = new Size(443, 147);
            tableLayoutPanel5.TabIndex = 13;
            // 
            // btnMoveDistance
            // 
            btnMoveDistance.Dock = DockStyle.Fill;
            btnMoveDistance.Enabled = false;
            btnMoveDistance.Location = new Point(3, 84);
            btnMoveDistance.Name = "btnMoveDistance";
            btnMoveDistance.Size = new Size(437, 60);
            btnMoveDistance.TabIndex = 4;
            btnMoveDistance.Text = "Go!";
            btnMoveDistance.UseVisualStyleBackColor = true;
            btnMoveDistance.Click += btnMoveDistance_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(numMoveDistance, 1, 0);
            tableLayoutPanel4.Controls.Add(lblMoveDistanceUnits, 2, 0);
            tableLayoutPanel4.Controls.Add(label41, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(437, 43);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // numMoveDistance
            // 
            numMoveDistance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numMoveDistance.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numMoveDistance.Location = new Point(78, 8);
            numMoveDistance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numMoveDistance.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numMoveDistance.Name = "numMoveDistance";
            numMoveDistance.Size = new Size(262, 27);
            numMoveDistance.TabIndex = 6;
            // 
            // lblMoveDistanceUnits
            // 
            lblMoveDistanceUnits.AutoSize = true;
            lblMoveDistanceUnits.Dock = DockStyle.Fill;
            lblMoveDistanceUnits.Location = new Point(346, 0);
            lblMoveDistanceUnits.Name = "lblMoveDistanceUnits";
            lblMoveDistanceUnits.Size = new Size(88, 43);
            lblMoveDistanceUnits.TabIndex = 3;
            lblMoveDistanceUnits.Text = "um";
            lblMoveDistanceUnits.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Dock = DockStyle.Fill;
            label41.Location = new Point(3, 0);
            label41.Name = "label41";
            label41.Size = new Size(69, 43);
            label41.TabIndex = 2;
            label41.Text = "Distance:";
            label41.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMoveDistanceEstDistance
            // 
            lblMoveDistanceEstDistance.AutoSize = true;
            lblMoveDistanceEstDistance.Dock = DockStyle.Fill;
            lblMoveDistanceEstDistance.Location = new Point(3, 49);
            lblMoveDistanceEstDistance.Name = "lblMoveDistanceEstDistance";
            lblMoveDistanceEstDistance.Size = new Size(437, 32);
            lblMoveDistanceEstDistance.TabIndex = 1;
            lblMoveDistanceEstDistance.Text = "(Approx. 0 steps)";
            lblMoveDistanceEstDistance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(tableLayoutPanel7);
            groupBox7.Location = new Point(135, 27);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(165, 173);
            groupBox7.TabIndex = 13;
            groupBox7.TabStop = false;
            groupBox7.Text = "Movement Reference";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(radRefSteps, 0, 2);
            tableLayoutPanel7.Controls.Add(btnLockReference, 0, 3);
            tableLayoutPanel7.Controls.Add(radRefIndicator, 0, 0);
            tableLayoutPanel7.Controls.Add(radRefCalibration, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 23);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 4;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(159, 147);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // radRefSteps
            // 
            radRefSteps.AutoSize = true;
            radRefSteps.Dock = DockStyle.Fill;
            radRefSteps.Location = new Point(3, 63);
            radRefSteps.Name = "radRefSteps";
            radRefSteps.Size = new Size(153, 24);
            radRefSteps.TabIndex = 10;
            radRefSteps.Text = "Steps";
            radRefSteps.UseVisualStyleBackColor = true;
            radRefSteps.CheckedChanged += radRefSteps_CheckedChanged;
            // 
            // btnLockReference
            // 
            btnLockReference.Dock = DockStyle.Fill;
            btnLockReference.Location = new Point(3, 93);
            btnLockReference.Name = "btnLockReference";
            btnLockReference.Size = new Size(153, 51);
            btnLockReference.TabIndex = 7;
            btnLockReference.Text = "Lock";
            btnLockReference.UseVisualStyleBackColor = true;
            btnLockReference.Click += btnLockReference_Click;
            // 
            // radRefIndicator
            // 
            radRefIndicator.AutoSize = true;
            radRefIndicator.Dock = DockStyle.Fill;
            radRefIndicator.Enabled = false;
            radRefIndicator.Location = new Point(3, 3);
            radRefIndicator.Name = "radRefIndicator";
            radRefIndicator.Size = new Size(153, 24);
            radRefIndicator.TabIndex = 8;
            radRefIndicator.Text = "Indicator";
            radRefIndicator.UseVisualStyleBackColor = true;
            radRefIndicator.CheckedChanged += radRefIndicator_CheckedChanged;
            // 
            // radRefCalibration
            // 
            radRefCalibration.AutoSize = true;
            radRefCalibration.Checked = true;
            radRefCalibration.Dock = DockStyle.Fill;
            radRefCalibration.Location = new Point(3, 33);
            radRefCalibration.Name = "radRefCalibration";
            radRefCalibration.Size = new Size(153, 24);
            radRefCalibration.TabIndex = 9;
            radRefCalibration.TabStop = true;
            radRefCalibration.Text = "Calibration";
            radRefCalibration.UseVisualStyleBackColor = true;
            radRefCalibration.CheckedChanged += radRefCalibration_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Location = new Point(6, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(123, 173);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Active Controls";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnActiveControlsDown, 0, 1);
            tableLayoutPanel3.Controls.Add(btnActiveControlsUp, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(117, 147);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnActiveControlsDown
            // 
            btnActiveControlsDown.Dock = DockStyle.Fill;
            btnActiveControlsDown.Enabled = false;
            btnActiveControlsDown.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnActiveControlsDown.Location = new Point(3, 76);
            btnActiveControlsDown.Name = "btnActiveControlsDown";
            btnActiveControlsDown.Size = new Size(111, 68);
            btnActiveControlsDown.TabIndex = 8;
            btnActiveControlsDown.Text = "↓";
            btnActiveControlsDown.UseVisualStyleBackColor = true;
            btnActiveControlsDown.Click += btnActiveControlsDown_Click;
            btnActiveControlsDown.MouseDown += btnActiveControlsDown_MouseDown;
            btnActiveControlsDown.MouseUp += btnActiveControlsDown_MouseUp;
            // 
            // btnActiveControlsUp
            // 
            btnActiveControlsUp.Dock = DockStyle.Fill;
            btnActiveControlsUp.Enabled = false;
            btnActiveControlsUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnActiveControlsUp.Location = new Point(3, 3);
            btnActiveControlsUp.Name = "btnActiveControlsUp";
            btnActiveControlsUp.Size = new Size(111, 67);
            btnActiveControlsUp.TabIndex = 7;
            btnActiveControlsUp.Text = "↑";
            btnActiveControlsUp.UseVisualStyleBackColor = true;
            btnActiveControlsUp.Click += btnActiveControlsUp_Click;
            btnActiveControlsUp.MouseDown += btnActiveControlsUp_MouseDown;
            btnActiveControlsUp.MouseUp += btnActiveControlsUp_MouseUp;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tableLayoutPanel16);
            groupBox9.Location = new Point(11, 724);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(439, 189);
            groupBox9.TabIndex = 7;
            groupBox9.TabStop = false;
            groupBox9.Text = "Motor Settings";
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 3;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.26995F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.6425934F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0874577F));
            tableLayoutPanel16.Controls.Add(lblMotorSettingsEstNegAccel, 0, 3);
            tableLayoutPanel16.Controls.Add(btnMotorSettingsApply, 2, 4);
            tableLayoutPanel16.Controls.Add(btnMotorSettingsCancel, 1, 4);
            tableLayoutPanel16.Controls.Add(btnMotorSettingsApplyDefault, 0, 4);
            tableLayoutPanel16.Controls.Add(lblMotorSettingsAccelerationUnits, 2, 3);
            tableLayoutPanel16.Controls.Add(lblMotorSettingsEstPosAccel, 1, 3);
            tableLayoutPanel16.Controls.Add(label57, 2, 2);
            tableLayoutPanel16.Controls.Add(numMotorSettingsAcceleration, 1, 2);
            tableLayoutPanel16.Controls.Add(label56, 0, 2);
            tableLayoutPanel16.Controls.Add(lblMotorSettingsVelocityUnits, 2, 1);
            tableLayoutPanel16.Controls.Add(lblMotorSettingsEstPosVel, 1, 1);
            tableLayoutPanel16.Controls.Add(label52, 2, 0);
            tableLayoutPanel16.Controls.Add(numMotorSettingsVelocity, 1, 0);
            tableLayoutPanel16.Controls.Add(label17, 0, 0);
            tableLayoutPanel16.Controls.Add(lblMotorSettingsEstNegVel, 0, 1);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 23);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 5;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50.00001F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 49.99999F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel16.Size = new Size(433, 163);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // lblMotorSettingsEstNegAccel
            // 
            lblMotorSettingsEstNegAccel.AutoSize = true;
            lblMotorSettingsEstNegAccel.Dock = DockStyle.Fill;
            lblMotorSettingsEstNegAccel.Location = new Point(3, 91);
            lblMotorSettingsEstNegAccel.Name = "lblMotorSettingsEstNegAccel";
            lblMotorSettingsEstNegAccel.Size = new Size(138, 20);
            lblMotorSettingsEstNegAccel.TabIndex = 22;
            lblMotorSettingsEstNegAccel.Text = "Neg: 0";
            // 
            // btnMotorSettingsApply
            // 
            btnMotorSettingsApply.Dock = DockStyle.Fill;
            btnMotorSettingsApply.Enabled = false;
            btnMotorSettingsApply.Location = new Point(309, 114);
            btnMotorSettingsApply.Name = "btnMotorSettingsApply";
            btnMotorSettingsApply.Size = new Size(121, 46);
            btnMotorSettingsApply.TabIndex = 20;
            btnMotorSettingsApply.Text = "Apply";
            btnMotorSettingsApply.UseVisualStyleBackColor = true;
            btnMotorSettingsApply.Click += btnMotorSettingsApply_Click;
            // 
            // btnMotorSettingsCancel
            // 
            btnMotorSettingsCancel.Dock = DockStyle.Fill;
            btnMotorSettingsCancel.Enabled = false;
            btnMotorSettingsCancel.Location = new Point(147, 114);
            btnMotorSettingsCancel.Name = "btnMotorSettingsCancel";
            btnMotorSettingsCancel.Size = new Size(156, 46);
            btnMotorSettingsCancel.TabIndex = 19;
            btnMotorSettingsCancel.Text = "Cancel";
            btnMotorSettingsCancel.UseVisualStyleBackColor = true;
            // 
            // btnMotorSettingsApplyDefault
            // 
            btnMotorSettingsApplyDefault.Dock = DockStyle.Fill;
            btnMotorSettingsApplyDefault.Enabled = false;
            btnMotorSettingsApplyDefault.Location = new Point(3, 114);
            btnMotorSettingsApplyDefault.Name = "btnMotorSettingsApplyDefault";
            btnMotorSettingsApplyDefault.Size = new Size(138, 46);
            btnMotorSettingsApplyDefault.TabIndex = 18;
            btnMotorSettingsApplyDefault.Text = "Apply Default";
            btnMotorSettingsApplyDefault.UseVisualStyleBackColor = true;
            // 
            // lblMotorSettingsAccelerationUnits
            // 
            lblMotorSettingsAccelerationUnits.AutoSize = true;
            lblMotorSettingsAccelerationUnits.Dock = DockStyle.Fill;
            lblMotorSettingsAccelerationUnits.Location = new Point(309, 91);
            lblMotorSettingsAccelerationUnits.Name = "lblMotorSettingsAccelerationUnits";
            lblMotorSettingsAccelerationUnits.Size = new Size(121, 20);
            lblMotorSettingsAccelerationUnits.TabIndex = 17;
            lblMotorSettingsAccelerationUnits.Text = "um/s^2 (est.)";
            lblMotorSettingsAccelerationUnits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMotorSettingsEstPosAccel
            // 
            lblMotorSettingsEstPosAccel.AutoSize = true;
            lblMotorSettingsEstPosAccel.Dock = DockStyle.Fill;
            lblMotorSettingsEstPosAccel.Location = new Point(147, 91);
            lblMotorSettingsEstPosAccel.Name = "lblMotorSettingsEstPosAccel";
            lblMotorSettingsEstPosAccel.Size = new Size(156, 20);
            lblMotorSettingsEstPosAccel.TabIndex = 16;
            lblMotorSettingsEstPosAccel.Text = "Pos: 0";
            lblMotorSettingsEstPosAccel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Dock = DockStyle.Fill;
            label57.Location = new Point(309, 56);
            label57.Name = "label57";
            label57.Size = new Size(121, 35);
            label57.TabIndex = 14;
            label57.Text = "steps/s";
            label57.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numMotorSettingsAcceleration
            // 
            numMotorSettingsAcceleration.Anchor = AnchorStyles.None;
            numMotorSettingsAcceleration.Location = new Point(147, 60);
            numMotorSettingsAcceleration.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numMotorSettingsAcceleration.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numMotorSettingsAcceleration.Name = "numMotorSettingsAcceleration";
            numMotorSettingsAcceleration.Size = new Size(155, 27);
            numMotorSettingsAcceleration.TabIndex = 13;
            numMotorSettingsAcceleration.ValueChanged += numMotorSettingsAcceleration_ValueChanged;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Dock = DockStyle.Fill;
            label56.Location = new Point(3, 56);
            label56.Name = "label56";
            label56.Size = new Size(138, 35);
            label56.TabIndex = 12;
            label56.Text = "Acceleration:";
            label56.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMotorSettingsVelocityUnits
            // 
            lblMotorSettingsVelocityUnits.AutoSize = true;
            lblMotorSettingsVelocityUnits.Dock = DockStyle.Fill;
            lblMotorSettingsVelocityUnits.Location = new Point(309, 36);
            lblMotorSettingsVelocityUnits.Name = "lblMotorSettingsVelocityUnits";
            lblMotorSettingsVelocityUnits.Size = new Size(121, 20);
            lblMotorSettingsVelocityUnits.TabIndex = 11;
            lblMotorSettingsVelocityUnits.Text = "um/s (est.)";
            lblMotorSettingsVelocityUnits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMotorSettingsEstPosVel
            // 
            lblMotorSettingsEstPosVel.AutoSize = true;
            lblMotorSettingsEstPosVel.Dock = DockStyle.Fill;
            lblMotorSettingsEstPosVel.Location = new Point(147, 36);
            lblMotorSettingsEstPosVel.Name = "lblMotorSettingsEstPosVel";
            lblMotorSettingsEstPosVel.Size = new Size(156, 20);
            lblMotorSettingsEstPosVel.TabIndex = 10;
            lblMotorSettingsEstPosVel.Text = "Pos: 0";
            lblMotorSettingsEstPosVel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Dock = DockStyle.Fill;
            label52.Location = new Point(309, 0);
            label52.Name = "label52";
            label52.Size = new Size(121, 36);
            label52.TabIndex = 8;
            label52.Text = "steps/s";
            label52.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numMotorSettingsVelocity
            // 
            numMotorSettingsVelocity.Anchor = AnchorStyles.None;
            numMotorSettingsVelocity.Location = new Point(147, 4);
            numMotorSettingsVelocity.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numMotorSettingsVelocity.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numMotorSettingsVelocity.Name = "numMotorSettingsVelocity";
            numMotorSettingsVelocity.Size = new Size(155, 27);
            numMotorSettingsVelocity.TabIndex = 7;
            numMotorSettingsVelocity.ValueChanged += numMotorSettingsVelocity_ValueChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(138, 36);
            label17.TabIndex = 0;
            label17.Text = "Velocity:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMotorSettingsEstNegVel
            // 
            lblMotorSettingsEstNegVel.AutoSize = true;
            lblMotorSettingsEstNegVel.Dock = DockStyle.Fill;
            lblMotorSettingsEstNegVel.Location = new Point(3, 36);
            lblMotorSettingsEstNegVel.Name = "lblMotorSettingsEstNegVel";
            lblMotorSettingsEstNegVel.Size = new Size(138, 20);
            lblMotorSettingsEstNegVel.TabIndex = 21;
            lblMotorSettingsEstNegVel.Text = "Neg: 0";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(groupBox15);
            groupBox10.Controls.Add(label15);
            groupBox10.Controls.Add(btnPlotClear);
            groupBox10.Controls.Add(numPlotInterval);
            groupBox10.Controls.Add(label9);
            groupBox10.Location = new Point(930, 38);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(574, 175);
            groupBox10.TabIndex = 9;
            groupBox10.TabStop = false;
            groupBox10.Text = "Plot Settings";
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(tableLayoutPanel22);
            groupBox15.Dock = DockStyle.Left;
            groupBox15.Location = new Point(3, 23);
            groupBox15.Margin = new Padding(3, 4, 3, 4);
            groupBox15.Name = "groupBox15";
            groupBox15.Padding = new Padding(3, 4, 3, 4);
            groupBox15.Size = new Size(198, 149);
            groupBox15.TabIndex = 7;
            groupBox15.TabStop = false;
            groupBox15.Text = "View";
            // 
            // tableLayoutPanel22
            // 
            tableLayoutPanel22.ColumnCount = 1;
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel22.Controls.Add(checkBox3, 0, 2);
            tableLayoutPanel22.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel22.Controls.Add(checkBox2, 0, 1);
            tableLayoutPanel22.Dock = DockStyle.Fill;
            tableLayoutPanel22.Location = new Point(3, 24);
            tableLayoutPanel22.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.RowCount = 3;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel22.Size = new Size(192, 121);
            tableLayoutPanel22.TabIndex = 0;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Dock = DockStyle.Fill;
            checkBox3.Location = new Point(3, 84);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(186, 33);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Indicator (um)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(3, 4);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 32);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Motor Steps (steps)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Dock = DockStyle.Fill;
            checkBox2.Location = new Point(3, 44);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(186, 32);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Motor Calibration (um)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(447, 143);
            label15.Name = "label15";
            label15.Size = new Size(28, 20);
            label15.TabIndex = 3;
            label15.Text = "ms";
            // 
            // btnPlotClear
            // 
            btnPlotClear.Location = new Point(482, 137);
            btnPlotClear.Margin = new Padding(3, 4, 3, 4);
            btnPlotClear.Name = "btnPlotClear";
            btnPlotClear.Size = new Size(86, 31);
            btnPlotClear.TabIndex = 2;
            btnPlotClear.Text = "Clear Plot";
            btnPlotClear.UseVisualStyleBackColor = true;
            // 
            // numPlotInterval
            // 
            numPlotInterval.Location = new Point(304, 141);
            numPlotInterval.Margin = new Padding(3, 4, 3, 4);
            numPlotInterval.Name = "numPlotInterval";
            numPlotInterval.Size = new Size(137, 27);
            numPlotInterval.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(207, 143);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 0;
            label9.Text = "Plot Interval:";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(tableLayoutPanel17);
            groupBox12.Location = new Point(457, 724);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(770, 189);
            groupBox12.TabIndex = 10;
            groupBox12.TabStop = false;
            groupBox12.Text = "Data Collection";
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 1;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Controls.Add(tableLayoutPanel20, 0, 2);
            tableLayoutPanel17.Controls.Add(tableLayoutPanel19, 0, 1);
            tableLayoutPanel17.Controls.Add(tableLayoutPanel18, 0, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(3, 23);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 3;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle());
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel17.Size = new Size(764, 163);
            tableLayoutPanel17.TabIndex = 0;
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 4;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 294F));
            tableLayoutPanel20.Controls.Add(btnDataCollect, 3, 0);
            tableLayoutPanel20.Controls.Add(label62, 2, 0);
            tableLayoutPanel20.Controls.Add(label61, 0, 0);
            tableLayoutPanel20.Controls.Add(numDataCollectionRate, 1, 0);
            tableLayoutPanel20.Dock = DockStyle.Fill;
            tableLayoutPanel20.Location = new Point(3, 104);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 1;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.Size = new Size(758, 56);
            tableLayoutPanel20.TabIndex = 2;
            // 
            // btnDataCollect
            // 
            btnDataCollect.Dock = DockStyle.Fill;
            btnDataCollect.Enabled = false;
            btnDataCollect.Location = new Point(467, 3);
            btnDataCollect.Name = "btnDataCollect";
            btnDataCollect.Size = new Size(288, 50);
            btnDataCollect.TabIndex = 8;
            btnDataCollect.Text = "Collect";
            btnDataCollect.UseVisualStyleBackColor = true;
            btnDataCollect.Click += btnDataCollect_Click;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Dock = DockStyle.Fill;
            label62.Location = new Point(433, 0);
            label62.Name = "label62";
            label62.Size = new Size(28, 56);
            label62.TabIndex = 7;
            label62.Text = "ms";
            label62.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Dock = DockStyle.Fill;
            label61.Location = new Point(3, 0);
            label61.Name = "label61";
            label61.Size = new Size(113, 56);
            label61.TabIndex = 5;
            label61.Text = "Collection Rate:";
            label61.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numDataCollectionRate
            // 
            numDataCollectionRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numDataCollectionRate.Location = new Point(122, 18);
            numDataCollectionRate.Margin = new Padding(3, 11, 3, 3);
            numDataCollectionRate.Name = "numDataCollectionRate";
            numDataCollectionRate.Size = new Size(305, 27);
            numDataCollectionRate.TabIndex = 6;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 2;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.Controls.Add(txtDataFileName, 1, 0);
            tableLayoutPanel19.Controls.Add(label58, 0, 0);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(3, 54);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 1;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.Size = new Size(758, 44);
            tableLayoutPanel19.TabIndex = 1;
            // 
            // txtDataFileName
            // 
            txtDataFileName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDataFileName.Location = new Point(88, 8);
            txtDataFileName.Name = "txtDataFileName";
            txtDataFileName.Size = new Size(667, 27);
            txtDataFileName.TabIndex = 5;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Dock = DockStyle.Fill;
            label58.Location = new Point(3, 0);
            label58.Name = "label58";
            label58.Size = new Size(79, 44);
            label58.TabIndex = 4;
            label58.Text = "File Name:";
            label58.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 3;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel18.Controls.Add(btnDataSelectDirectory, 2, 0);
            tableLayoutPanel18.Controls.Add(label53, 0, 0);
            tableLayoutPanel18.Controls.Add(txtDataDirectory, 1, 0);
            tableLayoutPanel18.Dock = DockStyle.Fill;
            tableLayoutPanel18.Location = new Point(3, 3);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 1;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.Size = new Size(758, 45);
            tableLayoutPanel18.TabIndex = 0;
            // 
            // btnDataSelectDirectory
            // 
            btnDataSelectDirectory.Dock = DockStyle.Fill;
            btnDataSelectDirectory.Location = new Point(716, 3);
            btnDataSelectDirectory.Name = "btnDataSelectDirectory";
            btnDataSelectDirectory.Size = new Size(39, 39);
            btnDataSelectDirectory.TabIndex = 5;
            btnDataSelectDirectory.Text = "...";
            btnDataSelectDirectory.UseVisualStyleBackColor = true;
            btnDataSelectDirectory.Click += btnDataSelectDirectory_Click;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Dock = DockStyle.Fill;
            label53.Location = new Point(3, 0);
            label53.Name = "label53";
            label53.Size = new Size(73, 45);
            label53.TabIndex = 3;
            label53.Text = "Directory:";
            label53.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDataDirectory
            // 
            txtDataDirectory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDataDirectory.Location = new Point(82, 9);
            txtDataDirectory.Name = "txtDataDirectory";
            txtDataDirectory.ReadOnly = true;
            txtDataDirectory.Size = new Size(628, 27);
            txtDataDirectory.TabIndex = 4;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(tableLayoutPanel21);
            groupBox14.Location = new Point(1233, 828);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(277, 85);
            groupBox14.TabIndex = 13;
            groupBox14.TabStop = false;
            groupBox14.Text = "Other Controls";
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.ColumnCount = 1;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanel21.Controls.Add(btnOpenSequenceEditor, 0, 0);
            tableLayoutPanel21.Dock = DockStyle.Fill;
            tableLayoutPanel21.Location = new Point(3, 23);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.RowCount = 1;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel21.Size = new Size(271, 59);
            tableLayoutPanel21.TabIndex = 0;
            // 
            // btnOpenSequenceEditor
            // 
            btnOpenSequenceEditor.Dock = DockStyle.Fill;
            btnOpenSequenceEditor.Location = new Point(3, 3);
            btnOpenSequenceEditor.Name = "btnOpenSequenceEditor";
            btnOpenSequenceEditor.Size = new Size(265, 53);
            btnOpenSequenceEditor.TabIndex = 11;
            btnOpenSequenceEditor.Text = "Open Sequence Editor";
            btnOpenSequenceEditor.UseVisualStyleBackColor = true;
            btnOpenSequenceEditor.Click += btnOpenSequenceEditor_Click;
            // 
            // Plot
            // 
            Plot.DisplayScale = 1.25F;
            Plot.Location = new Point(929, 216);
            Plot.Name = "Plot";
            Plot.Size = new Size(581, 501);
            Plot.TabIndex = 14;
            // 
            // tmrIndicatorDisplayUpdate
            // 
            tmrIndicatorDisplayUpdate.Interval = 1;
            tmrIndicatorDisplayUpdate.Tick += tmrIndicatorDisplayUpdate_Tick;
            // 
            // tmrMotorDisplayUpdate
            // 
            tmrMotorDisplayUpdate.Interval = 1;
            tmrMotorDisplayUpdate.Tick += tmrMotorDisplayUpdate_Tick;
            // 
            // tmrPlotUpdate
            // 
            tmrPlotUpdate.Tick += tmrPlotUpdate_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 942);
            Controls.Add(Plot);
            Controls.Add(groupBox14);
            Controls.Add(groupBox12);
            Controls.Add(groupBox10);
            Controls.Add(groupBox9);
            Controls.Add(groupBox2);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox6);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Picomotor Stage Control";
            Load += frmMain_Load;
            groupBox6.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            groupBox11.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            groupBox13.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGoTo).EndInit();
            groupBox5.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMoveDistance).EndInit();
            groupBox7.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMotorSettingsAcceleration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMotorSettingsVelocity).EndInit();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox15.ResumeLayout(false);
            tableLayoutPanel22.ResumeLayout(false);
            tableLayoutPanel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPlotInterval).EndInit();
            groupBox12.ResumeLayout(false);
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDataCollectionRate).EndInit();
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel19.PerformLayout();
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            groupBox14.ResumeLayout(false);
            tableLayoutPanel21.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox6;
        private TableLayoutPanel tableLayoutPanel6;
        private GroupBox groupBox8;
        private TableLayoutPanel tableLayoutPanel8;
        private GroupBox groupBox11;
        private TableLayoutPanel tableLayoutPanel11;
        private GroupBox groupBox13;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label26;
        private Label lblCalPositionEstMicronPosition;
        private Label label24;
        private Label label23;
        private Label lblCalPositionPosSteps;
        private Label label20;
        private Label label19;
        private Label lblCalPositionNegSteps;
        private Label label14;
        private Label label13;
        private Label lblCalPositionTotalSteps;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label30;
        private Label lblCalVelPos;
        private Label label32;
        private Label label33;
        private Label lblCalVelNeg;
        private Label label35;
        private Label label36;
        private Label lblCalVelRaw;
        private Label label38;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label42;
        private Label lblCalAccelPos;
        private Label label44;
        private Label label45;
        private Label lblCalAccelNeg;
        private Label label47;
        private Label label48;
        private Label lblCalAccelRaw;
        private Label label50;
        private Button btnCalZeroPosition;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label lblCalPosStepSize;
        private Label label4;
        private Label label3;
        private Label lblCalNegStepSize;
        private Label label1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label16;
        private Label lblIndicatorDisplayVelocity;
        private Label label11;
        private Label label10;
        private Label lblIndicatorDisplayPosition;
        private Label label7;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusStageConnected;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel statusIndicatorConnected;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabel7;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripSettings;
        private ToolStripMenuItem stripAbout;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnActiveControlsDown;
        private Button btnActiveControlsUp;
        private Button btnLockReference;
        private RadioButton radRefIndicator;
        private RadioButton radRefCalibration;
        private RadioButton radRefSteps;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblMoveDistanceEstDistance;
        private Button btnStopAllMotion;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnGoTo;
        private TableLayoutPanel tableLayoutPanel15;
        private NumericUpDown numGoTo;
        private Label label29;
        private Label lblGoToUnits;
        private Label lblGoToEstDistance;
        private Button btnMoveDistance;
        private NumericUpDown numMoveDistance;
        private Label lblMoveDistanceUnits;
        private Label label41;
        private GroupBox groupBox9;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label52;
        private NumericUpDown numMotorSettingsVelocity;
        private Label label17;
        private Button btnMotorSettingsApply;
        private Button btnMotorSettingsCancel;
        private Button btnMotorSettingsApplyDefault;
        private Label lblMotorSettingsAccelerationUnits;
        private Label lblMotorSettingsEstPosAccel;
        private Label label57;
        private NumericUpDown numMotorSettingsAcceleration;
        private Label label56;
        private Label lblMotorSettingsVelocityUnits;
        private Label lblMotorSettingsEstPosVel;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private GroupBox groupBox10;
        private GroupBox groupBox12;
        private TableLayoutPanel tableLayoutPanel17;
        private TableLayoutPanel tableLayoutPanel20;
        private Label label61;
        private TableLayoutPanel tableLayoutPanel19;
        private TextBox txtDataFileName;
        private Label label58;
        private TableLayoutPanel tableLayoutPanel18;
        private Button btnDataSelectDirectory;
        private Label label53;
        private TextBox txtDataDirectory;
        private ToolStripStatusLabel toolStripStatusLabel9;
        private ToolStripStatusLabel toolStripStatusLabel10;
        private ToolStripStatusLabel toolStripStatusLabel11;
        private ToolStripStatusLabel toolStripStatusLabel12;
        private ToolStripStatusLabel toolStripStatusLabel13;
        private ToolStripStatusLabel toolStripStatusLabel14;
        private Button btnDataCollect;
        private Label label62;
        private NumericUpDown numDataCollectionRate;
        private GroupBox groupBox14;
        private TableLayoutPanel tableLayoutPanel21;
        private Button btnOpenSequenceEditor;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem stripConnectStage;
        private ToolStripMenuItem stripConnectIndicator;
        private ScottPlot.WinForms.FormsPlot Plot;
        private System.Windows.Forms.Timer tmrIndicatorDisplayUpdate;
        private Label label15;
        private Button btnPlotClear;
        private NumericUpDown numPlotInterval;
        private Label label9;
        private GroupBox groupBox15;
        private TableLayoutPanel tableLayoutPanel22;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private System.Windows.Forms.Timer tmrMotorDisplayUpdate;
        private Label lblMotorSettingsEstNegAccel;
        private Label lblMotorSettingsEstNegVel;
        private System.Windows.Forms.Timer tmrPlotUpdate;
    }
}
