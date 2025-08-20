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
            stripConnectMicroscopeStage = new ToolStripMenuItem();
            stripConnectIndenter = new ToolStripMenuItem();
            allToolStripMenuItem = new ToolStripMenuItem();
            stripSettings = new ToolStripMenuItem();
            openSequenceEditorToolStripMenuItem = new ToolStripMenuItem();
            openPlotToolStripMenuItem = new ToolStripMenuItem();
            openIndenterControlToolStripMenuItem = new ToolStripMenuItem();
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
            tmrIndicatorDisplayUpdate = new System.Windows.Forms.Timer(components);
            tmrMotorDisplayUpdate = new System.Windows.Forms.Timer(components);
            tmrPlotUpdate = new System.Windows.Forms.Timer(components);
            groupBox16 = new GroupBox();
            tableLayoutPanel23 = new TableLayoutPanel();
            label2 = new Label();
            lblIndenterDisplayForceN = new Label();
            label12 = new Label();
            label18 = new Label();
            lblIndenterDisplayForcemg = new Label();
            label22 = new Label();
            groupBox17 = new GroupBox();
            label64 = new Label();
            btnStageCtrlSetSpeed = new Button();
            numStageCtrlSpeed_um_s = new NumericUpDown();
            label60 = new Label();
            groupBox19 = new GroupBox();
            radStageCtrlAbsolute = new RadioButton();
            radStageCtrlRelative = new RadioButton();
            numStageCtrlAllGo = new Button();
            numStageCtrlZGo = new Button();
            label21 = new Label();
            label28 = new Label();
            numStageCtrlYGo = new Button();
            label34 = new Label();
            label37 = new Label();
            numStageCtrlXGo = new Button();
            numStageCtrlAbsRelZum = new NumericUpDown();
            label39 = new Label();
            numStageCtrlAbsRelYum = new NumericUpDown();
            label40 = new Label();
            numStageCtrlAbsRelXum = new NumericUpDown();
            btnMicroscopeStageHome = new Button();
            btnMicroscopeStageHalt = new Button();
            groupBox20 = new GroupBox();
            tableLayoutPanel25 = new TableLayoutPanel();
            btnStageCtrlRunZUp = new Button();
            btnStageCtrlRunZDown = new Button();
            btnStageCtrlRunXRightYDown = new Button();
            btnStageCtrlRunXRightYUp = new Button();
            btnStageCtrlRunXLeftYDown = new Button();
            btnStageCtrlRunXLeftYUp = new Button();
            btnStageCtrlRunYDown = new Button();
            btnStageCtrlRunYUp = new Button();
            btnStageCtrlRunXRight = new Button();
            btnStageCtrlRunXLeft = new Button();
            groupBox18 = new GroupBox();
            tableLayoutPanel24 = new TableLayoutPanel();
            btnIndenterCalWithProbe = new Button();
            label54 = new Label();
            numIndenterSettingsCalProbeWeight = new NumericUpDown();
            label46 = new Label();
            numIndenterSettingsCalNoProbe = new NumericUpDown();
            numIndenterSettingsCalWithProbe = new NumericUpDown();
            label5 = new Label();
            label25 = new Label();
            label27 = new Label();
            label31 = new Label();
            btnIndenterSettingsCalNoProbe = new Button();
            btnIndenterSettingsCalibrate = new Button();
            label91 = new Label();
            numIndenterSettingsProbeDiameter_um = new NumericUpDown();
            label92 = new Label();
            label93 = new Label();
            numIndenterSettingsSpringConstant_N_m = new NumericUpDown();
            label94 = new Label();
            groupBox21 = new GroupBox();
            tableLayoutPanel26 = new TableLayoutPanel();
            label59 = new Label();
            lblMicroscopeStageDisplayZ_mm = new Label();
            label63 = new Label();
            label43 = new Label();
            lblMicroscopeStageDisplayY_mm = new Label();
            label49 = new Label();
            label51 = new Label();
            lblMicroscopeStageDisplayX_mm = new Label();
            label55 = new Label();
            tmrMicroscopeDisplayUpdate = new System.Windows.Forms.Timer(components);
            tmrIndenterDisplayUpdate = new System.Windows.Forms.Timer(components);
            tmrAverageIndenterValues = new System.Windows.Forms.Timer(components);
            groupBox10 = new GroupBox();
            lblSpringConstFlatModulus = new Label();
            lblSpringConstFlat = new Label();
            groupBox14 = new GroupBox();
            label70 = new Label();
            numIndentationCtrlSpringConstByPointsDelay_ms = new NumericUpDown();
            label71 = new Label();
            label69 = new Label();
            chkIndentationCtrlSpringConstByPointsCreepUp = new CheckBox();
            label67 = new Label();
            numIndentationCtrlSpringConstByPointsAccel_steps = new NumericUpDown();
            label68 = new Label();
            label66 = new Label();
            numIndentationCtrlSpringConstByPointsVel_steps = new NumericUpDown();
            label65 = new Label();
            label15 = new Label();
            label9 = new Label();
            numIndentationCtrlSpringConstByPointsDistance_um = new NumericUpDown();
            numIndentationCtrlSpringConstByPointsPoints = new NumericUpDown();
            btnFindSpringConstByPoints = new Button();
            groupBox22 = new GroupBox();
            label85 = new Label();
            btnFindSpringConstByForce = new Button();
            label79 = new Label();
            numIndentationCtrlSpringConstByForceAccel_steps = new NumericUpDown();
            label80 = new Label();
            label81 = new Label();
            numIndentationCtrlSpringConstByForceVel_steps = new NumericUpDown();
            label82 = new Label();
            numIndentationCtrlSpringConstByForceEndForce_mg = new NumericUpDown();
            label83 = new Label();
            groupBox15 = new GroupBox();
            label84 = new Label();
            btnFindSpringConstByDistance = new Button();
            chkIndentationCtrlSpringConstByDistanceCreepUp = new CheckBox();
            label73 = new Label();
            numIndentationCtrlSpringConstByDistanceAccel_steps = new NumericUpDown();
            label74 = new Label();
            label75 = new Label();
            numIndentationCtrlSpringConstByDistanceVel_steps = new NumericUpDown();
            label76 = new Label();
            numIndentationCtrlSpringConstByDistanceDistance_um = new NumericUpDown();
            label72 = new Label();
            groupBox23 = new GroupBox();
            chkSampleDetailsShowPlot = new CheckBox();
            label78 = new Label();
            label77 = new Label();
            numSampleDetailsStressRelaxationTime_ms = new NumericUpDown();
            chkSampleDetailsCollectStressRelaxation = new CheckBox();
            btnSampleDetailsSaveCollectedData = new Button();
            btnSampleDetailsSet = new Button();
            label88 = new Label();
            label87 = new Label();
            label86 = new Label();
            txtSampleDetailsMeasurement = new TextBox();
            txtSampleDetailsLocation = new TextBox();
            txtSampleDetailsSampleName = new TextBox();
            groupBox24 = new GroupBox();
            tableLayoutPanel21 = new TableLayoutPanel();
            btnHolderStageRunXRightYDown = new Button();
            btnHolderStageRunXRightYUp = new Button();
            btnHolderStageRunXLeftYDown = new Button();
            btnHolderStageRunXLeftYUp = new Button();
            btnHolderStageRunYDown = new Button();
            btnHolderStageRunYUp = new Button();
            btnHolderStageRunXRight = new Button();
            btnHolderStageRunXLeft = new Button();
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
            groupBox12.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDataCollectionRate).BeginInit();
            tableLayoutPanel19.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            groupBox16.SuspendLayout();
            tableLayoutPanel23.SuspendLayout();
            groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlSpeed_um_s).BeginInit();
            groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelZum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelYum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelXum).BeginInit();
            groupBox20.SuspendLayout();
            tableLayoutPanel25.SuspendLayout();
            groupBox18.SuspendLayout();
            tableLayoutPanel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsCalProbeWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsCalNoProbe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsCalWithProbe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsProbeDiameter_um).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsSpringConstant_N_m).BeginInit();
            groupBox21.SuspendLayout();
            tableLayoutPanel26.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsDelay_ms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsAccel_steps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsVel_steps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsDistance_um).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsPoints).BeginInit();
            groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByForceAccel_steps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByForceVel_steps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByForceEndForce_mg).BeginInit();
            groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByDistanceAccel_steps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByDistanceVel_steps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByDistanceDistance_um).BeginInit();
            groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSampleDetailsStressRelaxationTime_ms).BeginInit();
            groupBox24.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tableLayoutPanel6);
            groupBox6.Location = new Point(10, 26);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(388, 512);
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
            tableLayoutPanel6.Location = new Point(3, 18);
            tableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 37.61697F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 31.1915169F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 31.1915169F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel6.Size = new Size(382, 492);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnCalZeroPosition
            // 
            btnCalZeroPosition.Dock = DockStyle.Fill;
            btnCalZeroPosition.Enabled = false;
            btnCalZeroPosition.Location = new Point(3, 454);
            btnCalZeroPosition.Margin = new Padding(3, 2, 3, 2);
            btnCalZeroPosition.Name = "btnCalZeroPosition";
            btnCalZeroPosition.Size = new Size(376, 36);
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
            groupBox8.Location = new Point(3, 2);
            groupBox8.Margin = new Padding(3, 2, 3, 2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 2, 3, 2);
            groupBox8.Size = new Size(376, 152);
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
            tableLayoutPanel8.Location = new Point(3, 18);
            tableLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(370, 132);
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
            tableLayoutPanel10.Location = new Point(3, 2);
            tableLayoutPanel10.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 4;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel10.Size = new Size(364, 128);
            tableLayoutPanel10.TabIndex = 2;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Dock = DockStyle.Fill;
            label26.Font = new Font("Segoe UI", 9F);
            label26.Location = new Point(141, 96);
            label26.Name = "label26";
            label26.Size = new Size(220, 32);
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
            lblCalPositionEstMicronPosition.Location = new Point(106, 96);
            lblCalPositionEstMicronPosition.Name = "lblCalPositionEstMicronPosition";
            lblCalPositionEstMicronPosition.Size = new Size(29, 32);
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
            label24.Location = new Point(3, 96);
            label24.Name = "label24";
            label24.Size = new Size(97, 32);
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
            label23.Location = new Point(141, 64);
            label23.Name = "label23";
            label23.Size = new Size(220, 32);
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
            lblCalPositionPosSteps.Location = new Point(106, 64);
            lblCalPositionPosSteps.Name = "lblCalPositionPosSteps";
            lblCalPositionPosSteps.Size = new Size(29, 32);
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
            label20.Location = new Point(3, 64);
            label20.Name = "label20";
            label20.Size = new Size(97, 32);
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
            label19.Location = new Point(141, 32);
            label19.Name = "label19";
            label19.Size = new Size(220, 32);
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
            lblCalPositionNegSteps.Location = new Point(106, 32);
            lblCalPositionNegSteps.Name = "lblCalPositionNegSteps";
            lblCalPositionNegSteps.Size = new Size(29, 32);
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
            label14.Location = new Point(3, 32);
            label14.Name = "label14";
            label14.Size = new Size(97, 32);
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
            label13.Location = new Point(141, 0);
            label13.Name = "label13";
            label13.Size = new Size(220, 32);
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
            lblCalPositionTotalSteps.Location = new Point(106, 0);
            lblCalPositionTotalSteps.Name = "lblCalPositionTotalSteps";
            lblCalPositionTotalSteps.Size = new Size(29, 32);
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
            label8.Size = new Size(97, 32);
            label8.TabIndex = 2;
            label8.Text = "Total Steps:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(tableLayoutPanel11);
            groupBox11.Dock = DockStyle.Fill;
            groupBox11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox11.Location = new Point(3, 158);
            groupBox11.Margin = new Padding(3, 2, 3, 2);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(3, 2, 3, 2);
            groupBox11.Size = new Size(376, 125);
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
            tableLayoutPanel11.Location = new Point(3, 18);
            tableLayoutPanel11.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(370, 105);
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
            tableLayoutPanel12.Location = new Point(3, 2);
            tableLayoutPanel12.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel12.Size = new Size(364, 101);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Dock = DockStyle.Fill;
            label30.Font = new Font("Segoe UI", 9F);
            label30.Location = new Point(120, 66);
            label30.Name = "label30";
            label30.Size = new Size(241, 35);
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
            lblCalVelPos.Location = new Point(85, 66);
            lblCalVelPos.Name = "lblCalVelPos";
            lblCalVelPos.Size = new Size(29, 35);
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
            label32.Location = new Point(3, 66);
            label32.Name = "label32";
            label32.Size = new Size(76, 35);
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
            label33.Location = new Point(120, 33);
            label33.Name = "label33";
            label33.Size = new Size(241, 33);
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
            lblCalVelNeg.Location = new Point(85, 33);
            lblCalVelNeg.Name = "lblCalVelNeg";
            lblCalVelNeg.Size = new Size(29, 33);
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
            label35.Location = new Point(3, 33);
            label35.Name = "label35";
            label35.Size = new Size(76, 33);
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
            label36.Location = new Point(120, 0);
            label36.Name = "label36";
            label36.Size = new Size(241, 33);
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
            lblCalVelRaw.Location = new Point(85, 0);
            lblCalVelRaw.Name = "lblCalVelRaw";
            lblCalVelRaw.Size = new Size(29, 33);
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
            label38.Size = new Size(76, 33);
            label38.TabIndex = 2;
            label38.Text = "Raw Velocity:";
            label38.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(tableLayoutPanel13);
            groupBox13.Dock = DockStyle.Fill;
            groupBox13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox13.Location = new Point(3, 287);
            groupBox13.Margin = new Padding(3, 2, 3, 2);
            groupBox13.Name = "groupBox13";
            groupBox13.Padding = new Padding(3, 2, 3, 2);
            groupBox13.Size = new Size(376, 125);
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
            tableLayoutPanel13.Location = new Point(3, 18);
            tableLayoutPanel13.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(370, 105);
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
            tableLayoutPanel14.Location = new Point(3, 2);
            tableLayoutPanel14.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 3;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.Size = new Size(364, 101);
            tableLayoutPanel14.TabIndex = 3;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = Color.Transparent;
            label42.Dock = DockStyle.Fill;
            label42.Font = new Font("Segoe UI", 9F);
            label42.Location = new Point(145, 66);
            label42.Name = "label42";
            label42.Size = new Size(216, 35);
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
            lblCalAccelPos.Location = new Point(110, 66);
            lblCalAccelPos.Name = "lblCalAccelPos";
            lblCalAccelPos.Size = new Size(29, 35);
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
            label44.Location = new Point(3, 66);
            label44.Name = "label44";
            label44.Size = new Size(101, 35);
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
            label45.Location = new Point(145, 33);
            label45.Name = "label45";
            label45.Size = new Size(216, 33);
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
            lblCalAccelNeg.Location = new Point(110, 33);
            lblCalAccelNeg.Name = "lblCalAccelNeg";
            lblCalAccelNeg.Size = new Size(29, 33);
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
            label47.Location = new Point(3, 33);
            label47.Name = "label47";
            label47.Size = new Size(101, 33);
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
            label48.Location = new Point(145, 0);
            label48.Name = "label48";
            label48.Size = new Size(216, 33);
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
            lblCalAccelRaw.Location = new Point(110, 0);
            lblCalAccelRaw.Name = "lblCalAccelRaw";
            lblCalAccelRaw.Size = new Size(29, 33);
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
            label50.Size = new Size(101, 33);
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
            tableLayoutPanel1.Location = new Point(3, 416);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(376, 34);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(150, 17);
            label6.Name = "label6";
            label6.Size = new Size(223, 17);
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
            lblCalPosStepSize.Location = new Point(115, 17);
            lblCalPosStepSize.Name = "lblCalPosStepSize";
            lblCalPosStepSize.Size = new Size(29, 17);
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
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
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
            label3.Location = new Point(150, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 17);
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
            lblCalNegStepSize.Location = new Point(115, 0);
            lblCalNegStepSize.Name = "lblCalNegStepSize";
            lblCalNegStepSize.Size = new Size(29, 17);
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
            label1.Size = new Size(106, 17);
            label1.TabIndex = 3;
            label1.Text = "Negative Step Size:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(404, 26);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(403, 86);
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
            tableLayoutPanel2.Location = new Point(3, 18);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(397, 66);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(131, 33);
            label16.Name = "label16";
            label16.Size = new Size(263, 33);
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
            lblIndicatorDisplayVelocity.Location = new Point(96, 33);
            lblIndicatorDisplayVelocity.Name = "lblIndicatorDisplayVelocity";
            lblIndicatorDisplayVelocity.Size = new Size(29, 33);
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
            label11.Location = new Point(3, 33);
            label11.Name = "label11";
            label11.Size = new Size(87, 33);
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
            label10.Location = new Point(131, 0);
            label10.Name = "label10";
            label10.Size = new Size(263, 33);
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
            lblIndicatorDisplayPosition.Location = new Point(96, 0);
            lblIndicatorDisplayPosition.Name = "lblIndicatorDisplayPosition";
            lblIndicatorDisplayPosition.Size = new Size(29, 33);
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
            label7.Size = new Size(87, 33);
            label7.TabIndex = 3;
            label7.Text = "Position:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusStageConnected, toolStripStatusLabel3, toolStripStatusLabel4, statusIndicatorConnected, toolStripStatusLabel6, toolStripStatusLabel7, toolStripStatusLabel8, toolStripStatusLabel9, toolStripStatusLabel10, toolStripStatusLabel11, toolStripStatusLabel12, toolStripStatusLabel13, toolStripStatusLabel14 });
            statusStrip1.Location = new Point(0, 843);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(1600, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(104, 17);
            toolStripStatusLabel1.Text = "Stage Connection:";
            // 
            // statusStageConnected
            // 
            statusStageConnected.ForeColor = Color.Red;
            statusStageConnected.Name = "statusStageConnected";
            statusStageConnected.Size = new Size(79, 17);
            statusStageConnected.Text = "Disconnected";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(10, 17);
            toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(122, 17);
            toolStripStatusLabel4.Text = "Indicator Connection:";
            // 
            // statusIndicatorConnected
            // 
            statusIndicatorConnected.ForeColor = Color.Red;
            statusIndicatorConnected.Name = "statusIndicatorConnected";
            statusIndicatorConnected.Size = new Size(79, 17);
            statusIndicatorConnected.Text = "Disconnected";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(10, 17);
            toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel7
            // 
            toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            toolStripStatusLabel7.Size = new Size(74, 17);
            toolStripStatusLabel7.Text = "Stage Status:";
            // 
            // toolStripStatusLabel8
            // 
            toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            toolStripStatusLabel8.Size = new Size(29, 17);
            toolStripStatusLabel8.Text = "N/A";
            // 
            // toolStripStatusLabel9
            // 
            toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            toolStripStatusLabel9.Size = new Size(13, 17);
            toolStripStatusLabel9.Text = "||";
            // 
            // toolStripStatusLabel10
            // 
            toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            toolStripStatusLabel10.Size = new Size(109, 17);
            toolStripStatusLabel10.Text = "Sequence Running:";
            // 
            // toolStripStatusLabel11
            // 
            toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            toolStripStatusLabel11.Size = new Size(29, 17);
            toolStripStatusLabel11.Text = "N/A";
            // 
            // toolStripStatusLabel12
            // 
            toolStripStatusLabel12.Name = "toolStripStatusLabel12";
            toolStripStatusLabel12.Size = new Size(10, 17);
            toolStripStatusLabel12.Text = "|";
            // 
            // toolStripStatusLabel13
            // 
            toolStripStatusLabel13.Name = "toolStripStatusLabel13";
            toolStripStatusLabel13.Size = new Size(87, 17);
            toolStripStatusLabel13.Text = "Sequence Step:";
            // 
            // toolStripStatusLabel14
            // 
            toolStripStatusLabel14.Name = "toolStripStatusLabel14";
            toolStripStatusLabel14.Size = new Size(29, 17);
            toolStripStatusLabel14.Text = "N/A";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectToolStripMenuItem, stripSettings, openSequenceEditorToolStripMenuItem, openPlotToolStripMenuItem, openIndenterControlToolStripMenuItem, stripAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1600, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripConnectStage, stripConnectIndicator, stripConnectMicroscopeStage, stripConnectIndenter, allToolStripMenuItem });
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(64, 20);
            connectToolStripMenuItem.Text = "Connect";
            // 
            // stripConnectStage
            // 
            stripConnectStage.Name = "stripConnectStage";
            stripConnectStage.Size = new Size(168, 22);
            stripConnectStage.Text = "Holder Stage";
            stripConnectStage.Click += stripConnectStage_Click;
            // 
            // stripConnectIndicator
            // 
            stripConnectIndicator.Name = "stripConnectIndicator";
            stripConnectIndicator.Size = new Size(168, 22);
            stripConnectIndicator.Text = "Indicator";
            stripConnectIndicator.Click += stripConnectIndicator_Click;
            // 
            // stripConnectMicroscopeStage
            // 
            stripConnectMicroscopeStage.Name = "stripConnectMicroscopeStage";
            stripConnectMicroscopeStage.Size = new Size(168, 22);
            stripConnectMicroscopeStage.Text = "Microscope Stage";
            stripConnectMicroscopeStage.Click += stripConnectMicroscopeStage_Click;
            // 
            // stripConnectIndenter
            // 
            stripConnectIndenter.Name = "stripConnectIndenter";
            stripConnectIndenter.Size = new Size(168, 22);
            stripConnectIndenter.Text = "Indenter";
            stripConnectIndenter.Click += stripConnectIndenter_Click;
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(168, 22);
            allToolStripMenuItem.Text = "(All)";
            // 
            // stripSettings
            // 
            stripSettings.Name = "stripSettings";
            stripSettings.Size = new Size(61, 20);
            stripSettings.Text = "Settings";
            stripSettings.Click += stripSettings_Click;
            // 
            // openSequenceEditorToolStripMenuItem
            // 
            openSequenceEditorToolStripMenuItem.Name = "openSequenceEditorToolStripMenuItem";
            openSequenceEditorToolStripMenuItem.Size = new Size(136, 20);
            openSequenceEditorToolStripMenuItem.Text = "Open Sequence Editor";
            openSequenceEditorToolStripMenuItem.Click += openSequenceEditorToolStripMenuItem_Click;
            // 
            // openPlotToolStripMenuItem
            // 
            openPlotToolStripMenuItem.Name = "openPlotToolStripMenuItem";
            openPlotToolStripMenuItem.Size = new Size(72, 20);
            openPlotToolStripMenuItem.Text = "Open Plot";
            // 
            // openIndenterControlToolStripMenuItem
            // 
            openIndenterControlToolStripMenuItem.Name = "openIndenterControlToolStripMenuItem";
            openIndenterControlToolStripMenuItem.Size = new Size(138, 20);
            openIndenterControlToolStripMenuItem.Text = "Open Indenter Control";
            // 
            // stripAbout
            // 
            stripAbout.Name = "stripAbout";
            stripAbout.Size = new Size(52, 20);
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
            groupBox2.Location = new Point(404, 117);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(403, 422);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Holder Stage Controls";
            // 
            // btnStopAllMotion
            // 
            btnStopAllMotion.Enabled = false;
            btnStopAllMotion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStopAllMotion.Location = new Point(267, 27);
            btnStopAllMotion.Margin = new Padding(3, 2, 3, 2);
            btnStopAllMotion.Name = "btnStopAllMotion";
            btnStopAllMotion.Size = new Size(131, 123);
            btnStopAllMotion.TabIndex = 15;
            btnStopAllMotion.Text = "STOP HOLDER STAGE MOTION";
            btnStopAllMotion.UseVisualStyleBackColor = true;
            btnStopAllMotion.Click += btnStopAllMotion_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel9);
            groupBox4.Location = new Point(5, 286);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(393, 130);
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
            tableLayoutPanel9.Location = new Point(3, 18);
            tableLayoutPanel9.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.4073257F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1975613F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 44.3951225F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(387, 110);
            tableLayoutPanel9.TabIndex = 13;
            // 
            // btnGoTo
            // 
            btnGoTo.Dock = DockStyle.Fill;
            btnGoTo.Enabled = false;
            btnGoTo.Location = new Point(3, 62);
            btnGoTo.Margin = new Padding(3, 2, 3, 2);
            btnGoTo.Name = "btnGoTo";
            btnGoTo.Size = new Size(381, 46);
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
            tableLayoutPanel15.Location = new Point(3, 2);
            tableLayoutPanel15.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.Size = new Size(381, 32);
            tableLayoutPanel15.TabIndex = 0;
            // 
            // numGoTo
            // 
            numGoTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numGoTo.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numGoTo.Location = new Point(62, 4);
            numGoTo.Margin = new Padding(3, 2, 3, 2);
            numGoTo.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numGoTo.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numGoTo.Name = "numGoTo";
            numGoTo.Size = new Size(234, 23);
            numGoTo.TabIndex = 5;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Fill;
            label29.Location = new Point(3, 0);
            label29.Name = "label29";
            label29.Size = new Size(53, 32);
            label29.TabIndex = 4;
            label29.Text = "Position:";
            label29.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoToUnits
            // 
            lblGoToUnits.AutoSize = true;
            lblGoToUnits.Dock = DockStyle.Fill;
            lblGoToUnits.Location = new Point(302, 0);
            lblGoToUnits.Name = "lblGoToUnits";
            lblGoToUnits.Size = new Size(76, 32);
            lblGoToUnits.TabIndex = 3;
            lblGoToUnits.Text = "um";
            lblGoToUnits.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoToEstDistance
            // 
            lblGoToEstDistance.AutoSize = true;
            lblGoToEstDistance.Dock = DockStyle.Fill;
            lblGoToEstDistance.Location = new Point(3, 36);
            lblGoToEstDistance.Name = "lblGoToEstDistance";
            lblGoToEstDistance.Size = new Size(381, 24);
            lblGoToEstDistance.TabIndex = 1;
            lblGoToEstDistance.Text = "(Approx. 0 steps)";
            lblGoToEstDistance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel5);
            groupBox5.Location = new Point(5, 154);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(393, 130);
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
            tableLayoutPanel5.Location = new Point(3, 18);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.4073257F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1975613F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 44.3951225F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(387, 110);
            tableLayoutPanel5.TabIndex = 13;
            // 
            // btnMoveDistance
            // 
            btnMoveDistance.Dock = DockStyle.Fill;
            btnMoveDistance.Enabled = false;
            btnMoveDistance.Location = new Point(3, 62);
            btnMoveDistance.Margin = new Padding(3, 2, 3, 2);
            btnMoveDistance.Name = "btnMoveDistance";
            btnMoveDistance.Size = new Size(381, 46);
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
            tableLayoutPanel4.Location = new Point(3, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(381, 32);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // numMoveDistance
            // 
            numMoveDistance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numMoveDistance.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numMoveDistance.Location = new Point(64, 4);
            numMoveDistance.Margin = new Padding(3, 2, 3, 2);
            numMoveDistance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numMoveDistance.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numMoveDistance.Name = "numMoveDistance";
            numMoveDistance.Size = new Size(229, 23);
            numMoveDistance.TabIndex = 6;
            // 
            // lblMoveDistanceUnits
            // 
            lblMoveDistanceUnits.AutoSize = true;
            lblMoveDistanceUnits.Dock = DockStyle.Fill;
            lblMoveDistanceUnits.Location = new Point(299, 0);
            lblMoveDistanceUnits.Name = "lblMoveDistanceUnits";
            lblMoveDistanceUnits.Size = new Size(79, 32);
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
            label41.Size = new Size(55, 32);
            label41.TabIndex = 2;
            label41.Text = "Distance:";
            label41.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMoveDistanceEstDistance
            // 
            lblMoveDistanceEstDistance.AutoSize = true;
            lblMoveDistanceEstDistance.Dock = DockStyle.Fill;
            lblMoveDistanceEstDistance.Location = new Point(3, 36);
            lblMoveDistanceEstDistance.Name = "lblMoveDistanceEstDistance";
            lblMoveDistanceEstDistance.Size = new Size(381, 24);
            lblMoveDistanceEstDistance.TabIndex = 1;
            lblMoveDistanceEstDistance.Text = "(Approx. 0 steps)";
            lblMoveDistanceEstDistance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(tableLayoutPanel7);
            groupBox7.Location = new Point(118, 20);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(144, 130);
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
            tableLayoutPanel7.Location = new Point(3, 18);
            tableLayoutPanel7.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 4;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(138, 110);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // radRefSteps
            // 
            radRefSteps.AutoSize = true;
            radRefSteps.Dock = DockStyle.Fill;
            radRefSteps.Location = new Point(3, 48);
            radRefSteps.Margin = new Padding(3, 2, 3, 2);
            radRefSteps.Name = "radRefSteps";
            radRefSteps.Size = new Size(132, 19);
            radRefSteps.TabIndex = 10;
            radRefSteps.Text = "Steps";
            radRefSteps.UseVisualStyleBackColor = true;
            radRefSteps.CheckedChanged += radRefSteps_CheckedChanged;
            // 
            // btnLockReference
            // 
            btnLockReference.Dock = DockStyle.Fill;
            btnLockReference.Location = new Point(3, 71);
            btnLockReference.Margin = new Padding(3, 2, 3, 2);
            btnLockReference.Name = "btnLockReference";
            btnLockReference.Size = new Size(132, 37);
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
            radRefIndicator.Location = new Point(3, 2);
            radRefIndicator.Margin = new Padding(3, 2, 3, 2);
            radRefIndicator.Name = "radRefIndicator";
            radRefIndicator.Size = new Size(132, 19);
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
            radRefCalibration.Location = new Point(3, 25);
            radRefCalibration.Margin = new Padding(3, 2, 3, 2);
            radRefCalibration.Name = "radRefCalibration";
            radRefCalibration.Size = new Size(132, 19);
            radRefCalibration.TabIndex = 9;
            radRefCalibration.TabStop = true;
            radRefCalibration.Text = "Calibration";
            radRefCalibration.UseVisualStyleBackColor = true;
            radRefCalibration.CheckedChanged += radRefCalibration_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Location = new Point(5, 20);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(108, 130);
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
            tableLayoutPanel3.Location = new Point(3, 18);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(102, 110);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnActiveControlsDown
            // 
            btnActiveControlsDown.Dock = DockStyle.Fill;
            btnActiveControlsDown.Enabled = false;
            btnActiveControlsDown.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnActiveControlsDown.Location = new Point(3, 57);
            btnActiveControlsDown.Margin = new Padding(3, 2, 3, 2);
            btnActiveControlsDown.Name = "btnActiveControlsDown";
            btnActiveControlsDown.Size = new Size(96, 51);
            btnActiveControlsDown.TabIndex = 8;
            btnActiveControlsDown.Text = "↓";
            btnActiveControlsDown.UseVisualStyleBackColor = true;
            btnActiveControlsDown.MouseDown += btnActiveControlsDown_MouseDown;
            btnActiveControlsDown.MouseUp += btnActiveControlsDown_MouseUp;
            // 
            // btnActiveControlsUp
            // 
            btnActiveControlsUp.Dock = DockStyle.Fill;
            btnActiveControlsUp.Enabled = false;
            btnActiveControlsUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnActiveControlsUp.Location = new Point(3, 2);
            btnActiveControlsUp.Margin = new Padding(3, 2, 3, 2);
            btnActiveControlsUp.Name = "btnActiveControlsUp";
            btnActiveControlsUp.Size = new Size(96, 51);
            btnActiveControlsUp.TabIndex = 7;
            btnActiveControlsUp.Text = "↑";
            btnActiveControlsUp.UseVisualStyleBackColor = true;
            btnActiveControlsUp.MouseDown += btnActiveControlsUp_MouseDown;
            btnActiveControlsUp.MouseUp += btnActiveControlsUp_MouseUp;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tableLayoutPanel16);
            groupBox9.Location = new Point(10, 543);
            groupBox9.Margin = new Padding(3, 2, 3, 2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 2, 3, 2);
            groupBox9.Size = new Size(388, 142);
            groupBox9.TabIndex = 7;
            groupBox9.TabStop = false;
            groupBox9.Text = "MotorZ Settings";
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
            tableLayoutPanel16.Location = new Point(3, 18);
            tableLayoutPanel16.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 5;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50.00001F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 49.99999F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel16.Size = new Size(382, 122);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // lblMotorSettingsEstNegAccel
            // 
            lblMotorSettingsEstNegAccel.AutoSize = true;
            lblMotorSettingsEstNegAccel.Dock = DockStyle.Fill;
            lblMotorSettingsEstNegAccel.Location = new Point(3, 68);
            lblMotorSettingsEstNegAccel.Name = "lblMotorSettingsEstNegAccel";
            lblMotorSettingsEstNegAccel.Size = new Size(121, 15);
            lblMotorSettingsEstNegAccel.TabIndex = 22;
            lblMotorSettingsEstNegAccel.Text = "Neg: 0";
            // 
            // btnMotorSettingsApply
            // 
            btnMotorSettingsApply.Dock = DockStyle.Fill;
            btnMotorSettingsApply.Enabled = false;
            btnMotorSettingsApply.Location = new Point(273, 85);
            btnMotorSettingsApply.Margin = new Padding(3, 2, 3, 2);
            btnMotorSettingsApply.Name = "btnMotorSettingsApply";
            btnMotorSettingsApply.Size = new Size(106, 35);
            btnMotorSettingsApply.TabIndex = 20;
            btnMotorSettingsApply.Text = "Apply";
            btnMotorSettingsApply.UseVisualStyleBackColor = true;
            btnMotorSettingsApply.Click += btnMotorSettingsApply_Click;
            // 
            // btnMotorSettingsCancel
            // 
            btnMotorSettingsCancel.Dock = DockStyle.Fill;
            btnMotorSettingsCancel.Enabled = false;
            btnMotorSettingsCancel.Location = new Point(130, 85);
            btnMotorSettingsCancel.Margin = new Padding(3, 2, 3, 2);
            btnMotorSettingsCancel.Name = "btnMotorSettingsCancel";
            btnMotorSettingsCancel.Size = new Size(137, 35);
            btnMotorSettingsCancel.TabIndex = 19;
            btnMotorSettingsCancel.Text = "Cancel";
            btnMotorSettingsCancel.UseVisualStyleBackColor = true;
            // 
            // btnMotorSettingsApplyDefault
            // 
            btnMotorSettingsApplyDefault.Dock = DockStyle.Fill;
            btnMotorSettingsApplyDefault.Enabled = false;
            btnMotorSettingsApplyDefault.Location = new Point(3, 85);
            btnMotorSettingsApplyDefault.Margin = new Padding(3, 2, 3, 2);
            btnMotorSettingsApplyDefault.Name = "btnMotorSettingsApplyDefault";
            btnMotorSettingsApplyDefault.Size = new Size(121, 35);
            btnMotorSettingsApplyDefault.TabIndex = 18;
            btnMotorSettingsApplyDefault.Text = "Apply Default";
            btnMotorSettingsApplyDefault.UseVisualStyleBackColor = true;
            btnMotorSettingsApplyDefault.Click += btnMotorSettingsApplyDefault_Click;
            // 
            // lblMotorSettingsAccelerationUnits
            // 
            lblMotorSettingsAccelerationUnits.AutoSize = true;
            lblMotorSettingsAccelerationUnits.Dock = DockStyle.Fill;
            lblMotorSettingsAccelerationUnits.Location = new Point(273, 68);
            lblMotorSettingsAccelerationUnits.Name = "lblMotorSettingsAccelerationUnits";
            lblMotorSettingsAccelerationUnits.Size = new Size(106, 15);
            lblMotorSettingsAccelerationUnits.TabIndex = 17;
            lblMotorSettingsAccelerationUnits.Text = "um/s^2 (est.)";
            lblMotorSettingsAccelerationUnits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMotorSettingsEstPosAccel
            // 
            lblMotorSettingsEstPosAccel.AutoSize = true;
            lblMotorSettingsEstPosAccel.Dock = DockStyle.Fill;
            lblMotorSettingsEstPosAccel.Location = new Point(130, 68);
            lblMotorSettingsEstPosAccel.Name = "lblMotorSettingsEstPosAccel";
            lblMotorSettingsEstPosAccel.Size = new Size(137, 15);
            lblMotorSettingsEstPosAccel.TabIndex = 16;
            lblMotorSettingsEstPosAccel.Text = "Pos: 0";
            lblMotorSettingsEstPosAccel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Dock = DockStyle.Fill;
            label57.Location = new Point(273, 42);
            label57.Name = "label57";
            label57.Size = new Size(106, 26);
            label57.TabIndex = 14;
            label57.Text = "steps/s";
            label57.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numMotorSettingsAcceleration
            // 
            numMotorSettingsAcceleration.Anchor = AnchorStyles.None;
            numMotorSettingsAcceleration.Location = new Point(130, 44);
            numMotorSettingsAcceleration.Margin = new Padding(3, 2, 3, 2);
            numMotorSettingsAcceleration.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            numMotorSettingsAcceleration.Name = "numMotorSettingsAcceleration";
            numMotorSettingsAcceleration.Size = new Size(136, 23);
            numMotorSettingsAcceleration.TabIndex = 13;
            numMotorSettingsAcceleration.ValueChanged += numMotorSettingsAcceleration_ValueChanged;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Dock = DockStyle.Fill;
            label56.Location = new Point(3, 42);
            label56.Name = "label56";
            label56.Size = new Size(121, 26);
            label56.TabIndex = 12;
            label56.Text = "Acceleration:";
            label56.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMotorSettingsVelocityUnits
            // 
            lblMotorSettingsVelocityUnits.AutoSize = true;
            lblMotorSettingsVelocityUnits.Dock = DockStyle.Fill;
            lblMotorSettingsVelocityUnits.Location = new Point(273, 27);
            lblMotorSettingsVelocityUnits.Name = "lblMotorSettingsVelocityUnits";
            lblMotorSettingsVelocityUnits.Size = new Size(106, 15);
            lblMotorSettingsVelocityUnits.TabIndex = 11;
            lblMotorSettingsVelocityUnits.Text = "um/s (est.)";
            lblMotorSettingsVelocityUnits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMotorSettingsEstPosVel
            // 
            lblMotorSettingsEstPosVel.AutoSize = true;
            lblMotorSettingsEstPosVel.Dock = DockStyle.Fill;
            lblMotorSettingsEstPosVel.Location = new Point(130, 27);
            lblMotorSettingsEstPosVel.Name = "lblMotorSettingsEstPosVel";
            lblMotorSettingsEstPosVel.Size = new Size(137, 15);
            lblMotorSettingsEstPosVel.TabIndex = 10;
            lblMotorSettingsEstPosVel.Text = "Pos: 0";
            lblMotorSettingsEstPosVel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Dock = DockStyle.Fill;
            label52.Location = new Point(273, 0);
            label52.Name = "label52";
            label52.Size = new Size(106, 27);
            label52.TabIndex = 8;
            label52.Text = "steps/s";
            label52.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numMotorSettingsVelocity
            // 
            numMotorSettingsVelocity.Anchor = AnchorStyles.None;
            numMotorSettingsVelocity.Location = new Point(130, 2);
            numMotorSettingsVelocity.Margin = new Padding(3, 2, 3, 2);
            numMotorSettingsVelocity.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numMotorSettingsVelocity.Name = "numMotorSettingsVelocity";
            numMotorSettingsVelocity.Size = new Size(136, 23);
            numMotorSettingsVelocity.TabIndex = 7;
            numMotorSettingsVelocity.ValueChanged += numMotorSettingsVelocity_ValueChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(121, 27);
            label17.TabIndex = 0;
            label17.Text = "Velocity:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMotorSettingsEstNegVel
            // 
            lblMotorSettingsEstNegVel.AutoSize = true;
            lblMotorSettingsEstNegVel.Dock = DockStyle.Fill;
            lblMotorSettingsEstNegVel.Location = new Point(3, 27);
            lblMotorSettingsEstNegVel.Name = "lblMotorSettingsEstNegVel";
            lblMotorSettingsEstNegVel.Size = new Size(121, 15);
            lblMotorSettingsEstNegVel.TabIndex = 21;
            lblMotorSettingsEstNegVel.Text = "Neg: 0";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(tableLayoutPanel17);
            groupBox12.Location = new Point(403, 544);
            groupBox12.Margin = new Padding(3, 2, 3, 2);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(3, 2, 3, 2);
            groupBox12.Size = new Size(404, 141);
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
            tableLayoutPanel17.Location = new Point(3, 18);
            tableLayoutPanel17.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 3;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle());
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel17.Size = new Size(398, 121);
            tableLayoutPanel17.TabIndex = 0;
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 4;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.88889F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel20.Controls.Add(btnDataCollect, 3, 0);
            tableLayoutPanel20.Controls.Add(label62, 2, 0);
            tableLayoutPanel20.Controls.Add(label61, 0, 0);
            tableLayoutPanel20.Controls.Add(numDataCollectionRate, 1, 0);
            tableLayoutPanel20.Dock = DockStyle.Fill;
            tableLayoutPanel20.Location = new Point(3, 77);
            tableLayoutPanel20.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 1;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.Size = new Size(392, 42);
            tableLayoutPanel20.TabIndex = 2;
            // 
            // btnDataCollect
            // 
            btnDataCollect.Dock = DockStyle.Fill;
            btnDataCollect.Enabled = false;
            btnDataCollect.Location = new Point(328, 2);
            btnDataCollect.Margin = new Padding(3, 2, 3, 2);
            btnDataCollect.Name = "btnDataCollect";
            btnDataCollect.Size = new Size(61, 38);
            btnDataCollect.TabIndex = 8;
            btnDataCollect.Text = "Collect";
            btnDataCollect.UseVisualStyleBackColor = true;
            btnDataCollect.Click += btnDataCollect_Click;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Dock = DockStyle.Fill;
            label62.Location = new Point(285, 0);
            label62.Name = "label62";
            label62.Size = new Size(37, 42);
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
            label61.Size = new Size(124, 42);
            label61.TabIndex = 5;
            label61.Text = "Collection Rate:";
            label61.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numDataCollectionRate
            // 
            numDataCollectionRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numDataCollectionRate.Location = new Point(133, 12);
            numDataCollectionRate.Margin = new Padding(3, 8, 3, 2);
            numDataCollectionRate.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numDataCollectionRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDataCollectionRate.Name = "numDataCollectionRate";
            numDataCollectionRate.Size = new Size(146, 23);
            numDataCollectionRate.TabIndex = 6;
            numDataCollectionRate.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 2;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.Controls.Add(txtDataFileName, 1, 0);
            tableLayoutPanel19.Controls.Add(label58, 0, 0);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(3, 40);
            tableLayoutPanel19.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 1;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.Size = new Size(392, 33);
            tableLayoutPanel19.TabIndex = 1;
            // 
            // txtDataFileName
            // 
            txtDataFileName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDataFileName.Location = new Point(72, 5);
            txtDataFileName.Margin = new Padding(3, 2, 3, 2);
            txtDataFileName.Name = "txtDataFileName";
            txtDataFileName.Size = new Size(317, 23);
            txtDataFileName.TabIndex = 5;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Dock = DockStyle.Fill;
            label58.Location = new Point(3, 0);
            label58.Name = "label58";
            label58.Size = new Size(63, 33);
            label58.TabIndex = 4;
            label58.Text = "File Name:";
            label58.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 3;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel18.Controls.Add(btnDataSelectDirectory, 2, 0);
            tableLayoutPanel18.Controls.Add(label53, 0, 0);
            tableLayoutPanel18.Controls.Add(txtDataDirectory, 1, 0);
            tableLayoutPanel18.Dock = DockStyle.Fill;
            tableLayoutPanel18.Location = new Point(3, 2);
            tableLayoutPanel18.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 1;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.Size = new Size(392, 34);
            tableLayoutPanel18.TabIndex = 0;
            // 
            // btnDataSelectDirectory
            // 
            btnDataSelectDirectory.Dock = DockStyle.Fill;
            btnDataSelectDirectory.Location = new Point(356, 2);
            btnDataSelectDirectory.Margin = new Padding(3, 2, 3, 2);
            btnDataSelectDirectory.Name = "btnDataSelectDirectory";
            btnDataSelectDirectory.Size = new Size(33, 30);
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
            label53.Size = new Size(58, 34);
            label53.TabIndex = 3;
            label53.Text = "Directory:";
            label53.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDataDirectory
            // 
            txtDataDirectory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDataDirectory.Location = new Point(67, 5);
            txtDataDirectory.Margin = new Padding(3, 2, 3, 2);
            txtDataDirectory.Name = "txtDataDirectory";
            txtDataDirectory.ReadOnly = true;
            txtDataDirectory.Size = new Size(283, 23);
            txtDataDirectory.TabIndex = 4;
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
            tmrPlotUpdate.Interval = 10;
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(tableLayoutPanel23);
            groupBox16.Location = new Point(813, 26);
            groupBox16.Margin = new Padding(3, 2, 3, 2);
            groupBox16.Name = "groupBox16";
            groupBox16.Padding = new Padding(3, 2, 3, 2);
            groupBox16.Size = new Size(443, 86);
            groupBox16.TabIndex = 15;
            groupBox16.TabStop = false;
            groupBox16.Text = "Indenter Display";
            // 
            // tableLayoutPanel23
            // 
            tableLayoutPanel23.ColumnCount = 3;
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel23.Controls.Add(label2, 2, 1);
            tableLayoutPanel23.Controls.Add(lblIndenterDisplayForceN, 1, 1);
            tableLayoutPanel23.Controls.Add(label12, 0, 1);
            tableLayoutPanel23.Controls.Add(label18, 2, 0);
            tableLayoutPanel23.Controls.Add(lblIndenterDisplayForcemg, 1, 0);
            tableLayoutPanel23.Controls.Add(label22, 0, 0);
            tableLayoutPanel23.Dock = DockStyle.Fill;
            tableLayoutPanel23.Location = new Point(3, 18);
            tableLayoutPanel23.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel23.Name = "tableLayoutPanel23";
            tableLayoutPanel23.RowCount = 2;
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel23.Size = new Size(437, 66);
            tableLayoutPanel23.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(83, 33);
            label2.Name = "label2";
            label2.Size = new Size(351, 33);
            label2.TabIndex = 8;
            label2.Text = "N";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIndenterDisplayForceN
            // 
            lblIndenterDisplayForceN.AutoSize = true;
            lblIndenterDisplayForceN.BackColor = Color.Transparent;
            lblIndenterDisplayForceN.Dock = DockStyle.Fill;
            lblIndenterDisplayForceN.Font = new Font("Segoe UI", 9F);
            lblIndenterDisplayForceN.Location = new Point(48, 33);
            lblIndenterDisplayForceN.Name = "lblIndenterDisplayForceN";
            lblIndenterDisplayForceN.Size = new Size(29, 33);
            lblIndenterDisplayForceN.TabIndex = 7;
            lblIndenterDisplayForceN.Text = "N/A";
            lblIndenterDisplayForceN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(3, 33);
            label12.Name = "label12";
            label12.Size = new Size(39, 33);
            label12.TabIndex = 6;
            label12.Text = "Force:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(83, 0);
            label18.Name = "label18";
            label18.Size = new Size(351, 33);
            label18.TabIndex = 5;
            label18.Text = "mg";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIndenterDisplayForcemg
            // 
            lblIndenterDisplayForcemg.AutoSize = true;
            lblIndenterDisplayForcemg.BackColor = Color.Transparent;
            lblIndenterDisplayForcemg.Dock = DockStyle.Fill;
            lblIndenterDisplayForcemg.Font = new Font("Segoe UI", 9F);
            lblIndenterDisplayForcemg.Location = new Point(48, 0);
            lblIndenterDisplayForcemg.Name = "lblIndenterDisplayForcemg";
            lblIndenterDisplayForcemg.Size = new Size(29, 33);
            lblIndenterDisplayForcemg.TabIndex = 4;
            lblIndenterDisplayForcemg.Text = "N/A";
            lblIndenterDisplayForcemg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 9F);
            label22.Location = new Point(3, 0);
            label22.Name = "label22";
            label22.Size = new Size(39, 33);
            label22.TabIndex = 3;
            label22.Text = "Force:";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(label64);
            groupBox17.Controls.Add(btnStageCtrlSetSpeed);
            groupBox17.Controls.Add(numStageCtrlSpeed_um_s);
            groupBox17.Controls.Add(label60);
            groupBox17.Controls.Add(groupBox19);
            groupBox17.Controls.Add(btnMicroscopeStageHome);
            groupBox17.Controls.Add(btnMicroscopeStageHalt);
            groupBox17.Controls.Add(groupBox20);
            groupBox17.Location = new Point(813, 451);
            groupBox17.Margin = new Padding(3, 2, 3, 2);
            groupBox17.Name = "groupBox17";
            groupBox17.Padding = new Padding(3, 2, 3, 2);
            groupBox17.Size = new Size(443, 296);
            groupBox17.TabIndex = 16;
            groupBox17.TabStop = false;
            groupBox17.Text = "Microscope Stage Controls";
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new Point(212, 174);
            label64.Name = "label64";
            label64.Size = new Size(35, 15);
            label64.TabIndex = 20;
            label64.Text = "um/s";
            // 
            // btnStageCtrlSetSpeed
            // 
            btnStageCtrlSetSpeed.Location = new Point(254, 172);
            btnStageCtrlSetSpeed.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlSetSpeed.Name = "btnStageCtrlSetSpeed";
            btnStageCtrlSetSpeed.Size = new Size(43, 21);
            btnStageCtrlSetSpeed.TabIndex = 21;
            btnStageCtrlSetSpeed.Text = "Set";
            btnStageCtrlSetSpeed.UseVisualStyleBackColor = true;
            btnStageCtrlSetSpeed.Click += btnStageCtrlSetSpeed_Click;
            // 
            // numStageCtrlSpeed_um_s
            // 
            numStageCtrlSpeed_um_s.DecimalPlaces = 3;
            numStageCtrlSpeed_um_s.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numStageCtrlSpeed_um_s.Location = new Point(58, 172);
            numStageCtrlSpeed_um_s.Margin = new Padding(3, 2, 3, 2);
            numStageCtrlSpeed_um_s.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numStageCtrlSpeed_um_s.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            numStageCtrlSpeed_um_s.Name = "numStageCtrlSpeed_um_s";
            numStageCtrlSpeed_um_s.Size = new Size(149, 23);
            numStageCtrlSpeed_um_s.TabIndex = 20;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(5, 174);
            label60.Name = "label60";
            label60.Size = new Size(42, 15);
            label60.TabIndex = 19;
            label60.Text = "Speed:";
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(radStageCtrlAbsolute);
            groupBox19.Controls.Add(radStageCtrlRelative);
            groupBox19.Controls.Add(numStageCtrlAllGo);
            groupBox19.Controls.Add(numStageCtrlZGo);
            groupBox19.Controls.Add(label21);
            groupBox19.Controls.Add(label28);
            groupBox19.Controls.Add(numStageCtrlYGo);
            groupBox19.Controls.Add(label34);
            groupBox19.Controls.Add(label37);
            groupBox19.Controls.Add(numStageCtrlXGo);
            groupBox19.Controls.Add(numStageCtrlAbsRelZum);
            groupBox19.Controls.Add(label39);
            groupBox19.Controls.Add(numStageCtrlAbsRelYum);
            groupBox19.Controls.Add(label40);
            groupBox19.Controls.Add(numStageCtrlAbsRelXum);
            groupBox19.Location = new Point(5, 195);
            groupBox19.Margin = new Padding(3, 2, 3, 2);
            groupBox19.Name = "groupBox19";
            groupBox19.Padding = new Padding(3, 2, 3, 2);
            groupBox19.Size = new Size(432, 94);
            groupBox19.TabIndex = 18;
            groupBox19.TabStop = false;
            groupBox19.Text = "Absolute/Relative";
            // 
            // radStageCtrlAbsolute
            // 
            radStageCtrlAbsolute.AutoSize = true;
            radStageCtrlAbsolute.Location = new Point(337, 56);
            radStageCtrlAbsolute.Margin = new Padding(3, 2, 3, 2);
            radStageCtrlAbsolute.Name = "radStageCtrlAbsolute";
            radStageCtrlAbsolute.Size = new Size(72, 19);
            radStageCtrlAbsolute.TabIndex = 15;
            radStageCtrlAbsolute.Text = "Absolute";
            radStageCtrlAbsolute.UseVisualStyleBackColor = true;
            // 
            // radStageCtrlRelative
            // 
            radStageCtrlRelative.AutoSize = true;
            radStageCtrlRelative.Checked = true;
            radStageCtrlRelative.Location = new Point(337, 33);
            radStageCtrlRelative.Margin = new Padding(3, 2, 3, 2);
            radStageCtrlRelative.Name = "radStageCtrlRelative";
            radStageCtrlRelative.Size = new Size(66, 19);
            radStageCtrlRelative.TabIndex = 14;
            radStageCtrlRelative.TabStop = true;
            radStageCtrlRelative.Text = "Relative";
            radStageCtrlRelative.UseVisualStyleBackColor = true;
            // 
            // numStageCtrlAllGo
            // 
            numStageCtrlAllGo.Location = new Point(265, 18);
            numStageCtrlAllGo.Margin = new Padding(3, 2, 3, 2);
            numStageCtrlAllGo.Name = "numStageCtrlAllGo";
            numStageCtrlAllGo.Size = new Size(61, 70);
            numStageCtrlAllGo.TabIndex = 13;
            numStageCtrlAllGo.Text = "Go";
            numStageCtrlAllGo.UseVisualStyleBackColor = true;
            numStageCtrlAllGo.Click += numStageCtrlAllGo_Click;
            // 
            // numStageCtrlZGo
            // 
            numStageCtrlZGo.Location = new Point(222, 67);
            numStageCtrlZGo.Margin = new Padding(3, 2, 3, 2);
            numStageCtrlZGo.Name = "numStageCtrlZGo";
            numStageCtrlZGo.Size = new Size(38, 22);
            numStageCtrlZGo.TabIndex = 12;
            numStageCtrlZGo.Text = "Go";
            numStageCtrlZGo.UseVisualStyleBackColor = true;
            numStageCtrlZGo.Click += numStageCtrlZGo_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(191, 70);
            label21.Name = "label21";
            label21.Size = new Size(25, 15);
            label21.TabIndex = 7;
            label21.Text = "um";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(191, 46);
            label28.Name = "label28";
            label28.Size = new Size(25, 15);
            label28.TabIndex = 6;
            label28.Text = "um";
            // 
            // numStageCtrlYGo
            // 
            numStageCtrlYGo.Location = new Point(222, 43);
            numStageCtrlYGo.Margin = new Padding(3, 2, 3, 2);
            numStageCtrlYGo.Name = "numStageCtrlYGo";
            numStageCtrlYGo.Size = new Size(38, 22);
            numStageCtrlYGo.TabIndex = 11;
            numStageCtrlYGo.Text = "Go";
            numStageCtrlYGo.UseVisualStyleBackColor = true;
            numStageCtrlYGo.Click += numStageCtrlYGo_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(191, 21);
            label34.Name = "label34";
            label34.Size = new Size(25, 15);
            label34.TabIndex = 0;
            label34.Text = "um";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(5, 70);
            label37.Name = "label37";
            label37.Size = new Size(17, 15);
            label37.TabIndex = 5;
            label37.Text = "Z:";
            // 
            // numStageCtrlXGo
            // 
            numStageCtrlXGo.Location = new Point(222, 18);
            numStageCtrlXGo.Margin = new Padding(3, 2, 3, 2);
            numStageCtrlXGo.Name = "numStageCtrlXGo";
            numStageCtrlXGo.Size = new Size(38, 22);
            numStageCtrlXGo.TabIndex = 10;
            numStageCtrlXGo.Text = "Go";
            numStageCtrlXGo.UseVisualStyleBackColor = true;
            numStageCtrlXGo.Click += numStageCtrlXGo_Click;
            // 
            // numStageCtrlAbsRelZum
            // 
            numStageCtrlAbsRelZum.DecimalPlaces = 2;
            numStageCtrlAbsRelZum.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numStageCtrlAbsRelZum.Location = new Point(29, 68);
            numStageCtrlAbsRelZum.Margin = new Padding(3, 2, 3, 2);
            numStageCtrlAbsRelZum.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numStageCtrlAbsRelZum.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            numStageCtrlAbsRelZum.Name = "numStageCtrlAbsRelZum";
            numStageCtrlAbsRelZum.Size = new Size(157, 23);
            numStageCtrlAbsRelZum.TabIndex = 4;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(5, 46);
            label39.Name = "label39";
            label39.Size = new Size(17, 15);
            label39.TabIndex = 3;
            label39.Text = "Y:";
            // 
            // numStageCtrlAbsRelYum
            // 
            numStageCtrlAbsRelYum.DecimalPlaces = 2;
            numStageCtrlAbsRelYum.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numStageCtrlAbsRelYum.Location = new Point(29, 44);
            numStageCtrlAbsRelYum.Margin = new Padding(3, 2, 3, 2);
            numStageCtrlAbsRelYum.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numStageCtrlAbsRelYum.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            numStageCtrlAbsRelYum.Name = "numStageCtrlAbsRelYum";
            numStageCtrlAbsRelYum.Size = new Size(157, 23);
            numStageCtrlAbsRelYum.TabIndex = 2;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(5, 21);
            label40.Name = "label40";
            label40.Size = new Size(17, 15);
            label40.TabIndex = 1;
            label40.Text = "X:";
            // 
            // numStageCtrlAbsRelXum
            // 
            numStageCtrlAbsRelXum.DecimalPlaces = 2;
            numStageCtrlAbsRelXum.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numStageCtrlAbsRelXum.Location = new Point(29, 20);
            numStageCtrlAbsRelXum.Margin = new Padding(3, 2, 3, 2);
            numStageCtrlAbsRelXum.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numStageCtrlAbsRelXum.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            numStageCtrlAbsRelXum.Name = "numStageCtrlAbsRelXum";
            numStageCtrlAbsRelXum.Size = new Size(157, 23);
            numStageCtrlAbsRelXum.TabIndex = 0;
            // 
            // btnMicroscopeStageHome
            // 
            btnMicroscopeStageHome.Location = new Point(212, 116);
            btnMicroscopeStageHome.Margin = new Padding(3, 2, 3, 2);
            btnMicroscopeStageHome.Name = "btnMicroscopeStageHome";
            btnMicroscopeStageHome.Size = new Size(226, 50);
            btnMicroscopeStageHome.TabIndex = 17;
            btnMicroscopeStageHome.Text = "Move Home";
            btnMicroscopeStageHome.UseVisualStyleBackColor = true;
            btnMicroscopeStageHome.Click += btnMicroscopeStageHome_Click;
            // 
            // btnMicroscopeStageHalt
            // 
            btnMicroscopeStageHalt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMicroscopeStageHalt.Location = new Point(212, 26);
            btnMicroscopeStageHalt.Margin = new Padding(3, 2, 3, 2);
            btnMicroscopeStageHalt.Name = "btnMicroscopeStageHalt";
            btnMicroscopeStageHalt.Size = new Size(226, 86);
            btnMicroscopeStageHalt.TabIndex = 16;
            btnMicroscopeStageHalt.Text = "STOP MICROSCOPE STAGE MOTION";
            btnMicroscopeStageHalt.UseVisualStyleBackColor = true;
            btnMicroscopeStageHalt.Click += btnMicroscopeStageHalt_Click;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(tableLayoutPanel25);
            groupBox20.Location = new Point(5, 20);
            groupBox20.Margin = new Padding(3, 2, 3, 2);
            groupBox20.Name = "groupBox20";
            groupBox20.Padding = new Padding(3, 2, 3, 2);
            groupBox20.Size = new Size(201, 146);
            groupBox20.TabIndex = 2;
            groupBox20.TabStop = false;
            groupBox20.Text = "Run";
            // 
            // tableLayoutPanel25
            // 
            tableLayoutPanel25.ColumnCount = 4;
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunZUp, 3, 0);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunZDown, 3, 2);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunXRightYDown, 2, 2);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunXRightYUp, 2, 0);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunXLeftYDown, 0, 2);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunXLeftYUp, 0, 0);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunYDown, 1, 2);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunYUp, 1, 0);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunXRight, 2, 1);
            tableLayoutPanel25.Controls.Add(btnStageCtrlRunXLeft, 0, 1);
            tableLayoutPanel25.Dock = DockStyle.Fill;
            tableLayoutPanel25.Location = new Point(3, 18);
            tableLayoutPanel25.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel25.Name = "tableLayoutPanel25";
            tableLayoutPanel25.RowCount = 3;
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel25.Size = new Size(195, 126);
            tableLayoutPanel25.TabIndex = 0;
            // 
            // btnStageCtrlRunZUp
            // 
            btnStageCtrlRunZUp.Location = new Point(147, 2);
            btnStageCtrlRunZUp.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunZUp.Name = "btnStageCtrlRunZUp";
            btnStageCtrlRunZUp.Size = new Size(44, 38);
            btnStageCtrlRunZUp.TabIndex = 6;
            btnStageCtrlRunZUp.Text = "↑";
            btnStageCtrlRunZUp.UseVisualStyleBackColor = true;
            btnStageCtrlRunZUp.MouseDown += btnStageCtrlRunZUp_MouseDown;
            btnStageCtrlRunZUp.MouseUp += btnStageCtrlRunZUp_MouseUp;
            // 
            // btnStageCtrlRunZDown
            // 
            btnStageCtrlRunZDown.Location = new Point(147, 86);
            btnStageCtrlRunZDown.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunZDown.Name = "btnStageCtrlRunZDown";
            btnStageCtrlRunZDown.Size = new Size(44, 38);
            btnStageCtrlRunZDown.TabIndex = 7;
            btnStageCtrlRunZDown.Text = "↓";
            btnStageCtrlRunZDown.UseVisualStyleBackColor = true;
            btnStageCtrlRunZDown.MouseDown += btnStageCtrlRunZDown_MouseDown;
            btnStageCtrlRunZDown.MouseUp += btnStageCtrlRunZDown_MouseUp;
            // 
            // btnStageCtrlRunXRightYDown
            // 
            btnStageCtrlRunXRightYDown.Location = new Point(99, 86);
            btnStageCtrlRunXRightYDown.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunXRightYDown.Name = "btnStageCtrlRunXRightYDown";
            btnStageCtrlRunXRightYDown.Size = new Size(42, 38);
            btnStageCtrlRunXRightYDown.TabIndex = 10;
            btnStageCtrlRunXRightYDown.Text = "↘";
            btnStageCtrlRunXRightYDown.UseVisualStyleBackColor = true;
            btnStageCtrlRunXRightYDown.MouseDown += btnStageCtrlRunXRightYDown_MouseDown;
            btnStageCtrlRunXRightYDown.MouseUp += btnStageCtrlRunXRightYDown_MouseUp;
            // 
            // btnStageCtrlRunXRightYUp
            // 
            btnStageCtrlRunXRightYUp.Location = new Point(99, 2);
            btnStageCtrlRunXRightYUp.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunXRightYUp.Name = "btnStageCtrlRunXRightYUp";
            btnStageCtrlRunXRightYUp.Size = new Size(42, 38);
            btnStageCtrlRunXRightYUp.TabIndex = 11;
            btnStageCtrlRunXRightYUp.Text = "↗";
            btnStageCtrlRunXRightYUp.UseVisualStyleBackColor = true;
            btnStageCtrlRunXRightYUp.MouseDown += btnStageCtrlRunXRightYUp_MouseDown;
            btnStageCtrlRunXRightYUp.MouseUp += btnStageCtrlRunXRightYUp_MouseUp;
            // 
            // btnStageCtrlRunXLeftYDown
            // 
            btnStageCtrlRunXLeftYDown.Location = new Point(3, 86);
            btnStageCtrlRunXLeftYDown.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunXLeftYDown.Name = "btnStageCtrlRunXLeftYDown";
            btnStageCtrlRunXLeftYDown.Size = new Size(42, 38);
            btnStageCtrlRunXLeftYDown.TabIndex = 9;
            btnStageCtrlRunXLeftYDown.Text = "↙";
            btnStageCtrlRunXLeftYDown.UseVisualStyleBackColor = true;
            btnStageCtrlRunXLeftYDown.MouseDown += btnStageCtrlRunXLeftYDown_MouseDown;
            btnStageCtrlRunXLeftYDown.MouseUp += btnStageCtrlRunXLeftYDown_MouseUp;
            // 
            // btnStageCtrlRunXLeftYUp
            // 
            btnStageCtrlRunXLeftYUp.Location = new Point(3, 2);
            btnStageCtrlRunXLeftYUp.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunXLeftYUp.Name = "btnStageCtrlRunXLeftYUp";
            btnStageCtrlRunXLeftYUp.Size = new Size(42, 38);
            btnStageCtrlRunXLeftYUp.TabIndex = 8;
            btnStageCtrlRunXLeftYUp.Text = "↖";
            btnStageCtrlRunXLeftYUp.UseVisualStyleBackColor = true;
            btnStageCtrlRunXLeftYUp.MouseDown += btnStageCtrlRunXLeftYUp_MouseDown;
            btnStageCtrlRunXLeftYUp.MouseUp += btnStageCtrlRunXLeftYUp_MouseUp;
            // 
            // btnStageCtrlRunYDown
            // 
            btnStageCtrlRunYDown.Location = new Point(51, 86);
            btnStageCtrlRunYDown.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunYDown.Name = "btnStageCtrlRunYDown";
            btnStageCtrlRunYDown.Size = new Size(42, 38);
            btnStageCtrlRunYDown.TabIndex = 4;
            btnStageCtrlRunYDown.Text = "↓";
            btnStageCtrlRunYDown.UseVisualStyleBackColor = true;
            btnStageCtrlRunYDown.MouseDown += btnStageCtrlRunYDown_MouseDown;
            btnStageCtrlRunYDown.MouseUp += btnStageCtrlRunYDown_MouseUp;
            // 
            // btnStageCtrlRunYUp
            // 
            btnStageCtrlRunYUp.Location = new Point(51, 2);
            btnStageCtrlRunYUp.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunYUp.Name = "btnStageCtrlRunYUp";
            btnStageCtrlRunYUp.Size = new Size(42, 38);
            btnStageCtrlRunYUp.TabIndex = 0;
            btnStageCtrlRunYUp.Text = "↑";
            btnStageCtrlRunYUp.UseVisualStyleBackColor = true;
            btnStageCtrlRunYUp.MouseDown += btnStageCtrlRunYUp_MouseDown;
            btnStageCtrlRunYUp.MouseUp += btnStageCtrlRunYUp_MouseUp;
            // 
            // btnStageCtrlRunXRight
            // 
            btnStageCtrlRunXRight.Location = new Point(99, 44);
            btnStageCtrlRunXRight.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunXRight.Name = "btnStageCtrlRunXRight";
            btnStageCtrlRunXRight.Size = new Size(42, 38);
            btnStageCtrlRunXRight.TabIndex = 3;
            btnStageCtrlRunXRight.Text = "→";
            btnStageCtrlRunXRight.UseVisualStyleBackColor = true;
            btnStageCtrlRunXRight.MouseDown += btnStageCtrlRunXRight_MouseDown;
            btnStageCtrlRunXRight.MouseUp += btnStageCtrlRunXRight_MouseUp;
            // 
            // btnStageCtrlRunXLeft
            // 
            btnStageCtrlRunXLeft.Location = new Point(3, 44);
            btnStageCtrlRunXLeft.Margin = new Padding(3, 2, 3, 2);
            btnStageCtrlRunXLeft.Name = "btnStageCtrlRunXLeft";
            btnStageCtrlRunXLeft.Size = new Size(42, 38);
            btnStageCtrlRunXLeft.TabIndex = 2;
            btnStageCtrlRunXLeft.Text = "←";
            btnStageCtrlRunXLeft.UseVisualStyleBackColor = true;
            btnStageCtrlRunXLeft.MouseDown += btnStageCtrlRunXLeft_MouseDown;
            btnStageCtrlRunXLeft.MouseUp += btnStageCtrlRunXLeft_MouseUp;
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(tableLayoutPanel24);
            groupBox18.Location = new Point(813, 243);
            groupBox18.Margin = new Padding(3, 2, 3, 2);
            groupBox18.Name = "groupBox18";
            groupBox18.Padding = new Padding(3, 2, 3, 2);
            groupBox18.Size = new Size(443, 206);
            groupBox18.TabIndex = 17;
            groupBox18.TabStop = false;
            groupBox18.Text = "Indenter Settings";
            // 
            // tableLayoutPanel24
            // 
            tableLayoutPanel24.ColumnCount = 4;
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel24.Controls.Add(btnIndenterCalWithProbe, 3, 1);
            tableLayoutPanel24.Controls.Add(label54, 2, 2);
            tableLayoutPanel24.Controls.Add(numIndenterSettingsCalProbeWeight, 1, 2);
            tableLayoutPanel24.Controls.Add(label46, 0, 2);
            tableLayoutPanel24.Controls.Add(numIndenterSettingsCalNoProbe, 1, 0);
            tableLayoutPanel24.Controls.Add(numIndenterSettingsCalWithProbe, 1, 1);
            tableLayoutPanel24.Controls.Add(label5, 2, 1);
            tableLayoutPanel24.Controls.Add(label25, 0, 1);
            tableLayoutPanel24.Controls.Add(label27, 2, 0);
            tableLayoutPanel24.Controls.Add(label31, 0, 0);
            tableLayoutPanel24.Controls.Add(btnIndenterSettingsCalNoProbe, 3, 0);
            tableLayoutPanel24.Controls.Add(btnIndenterSettingsCalibrate, 1, 5);
            tableLayoutPanel24.Controls.Add(label91, 2, 3);
            tableLayoutPanel24.Controls.Add(numIndenterSettingsProbeDiameter_um, 1, 3);
            tableLayoutPanel24.Controls.Add(label92, 0, 3);
            tableLayoutPanel24.Controls.Add(label93, 0, 4);
            tableLayoutPanel24.Controls.Add(numIndenterSettingsSpringConstant_N_m, 1, 4);
            tableLayoutPanel24.Controls.Add(label94, 2, 4);
            tableLayoutPanel24.Dock = DockStyle.Fill;
            tableLayoutPanel24.Location = new Point(3, 18);
            tableLayoutPanel24.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel24.Name = "tableLayoutPanel24";
            tableLayoutPanel24.RowCount = 6;
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel24.Size = new Size(437, 186);
            tableLayoutPanel24.TabIndex = 0;
            // 
            // btnIndenterCalWithProbe
            // 
            btnIndenterCalWithProbe.Dock = DockStyle.Fill;
            btnIndenterCalWithProbe.Enabled = false;
            btnIndenterCalWithProbe.Location = new Point(352, 33);
            btnIndenterCalWithProbe.Margin = new Padding(3, 2, 3, 2);
            btnIndenterCalWithProbe.Name = "btnIndenterCalWithProbe";
            btnIndenterCalWithProbe.Size = new Size(82, 27);
            btnIndenterCalWithProbe.TabIndex = 16;
            btnIndenterCalWithProbe.Text = "Get";
            btnIndenterCalWithProbe.UseVisualStyleBackColor = true;
            btnIndenterCalWithProbe.Click += btnIndenterCalWithProbe_Click;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.BackColor = Color.Transparent;
            label54.Dock = DockStyle.Fill;
            label54.Font = new Font("Segoe UI", 9F);
            label54.Location = new Point(314, 62);
            label54.Name = "label54";
            label54.Size = new Size(32, 31);
            label54.TabIndex = 13;
            label54.Text = "mg";
            label54.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numIndenterSettingsCalProbeWeight
            // 
            numIndenterSettingsCalProbeWeight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numIndenterSettingsCalProbeWeight.DecimalPlaces = 4;
            numIndenterSettingsCalProbeWeight.Enabled = false;
            numIndenterSettingsCalProbeWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numIndenterSettingsCalProbeWeight.Location = new Point(104, 66);
            numIndenterSettingsCalProbeWeight.Margin = new Padding(3, 2, 3, 2);
            numIndenterSettingsCalProbeWeight.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numIndenterSettingsCalProbeWeight.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numIndenterSettingsCalProbeWeight.Name = "numIndenterSettingsCalProbeWeight";
            numIndenterSettingsCalProbeWeight.Size = new Size(204, 23);
            numIndenterSettingsCalProbeWeight.TabIndex = 12;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = Color.Transparent;
            label46.Dock = DockStyle.Fill;
            label46.Font = new Font("Segoe UI", 9F);
            label46.Location = new Point(3, 62);
            label46.Name = "label46";
            label46.Size = new Size(95, 31);
            label46.TabIndex = 11;
            label46.Text = "Probe Weight:";
            label46.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numIndenterSettingsCalNoProbe
            // 
            numIndenterSettingsCalNoProbe.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numIndenterSettingsCalNoProbe.DecimalPlaces = 4;
            numIndenterSettingsCalNoProbe.Enabled = false;
            numIndenterSettingsCalNoProbe.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numIndenterSettingsCalNoProbe.Location = new Point(104, 4);
            numIndenterSettingsCalNoProbe.Margin = new Padding(3, 2, 3, 2);
            numIndenterSettingsCalNoProbe.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numIndenterSettingsCalNoProbe.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numIndenterSettingsCalNoProbe.Name = "numIndenterSettingsCalNoProbe";
            numIndenterSettingsCalNoProbe.Size = new Size(204, 23);
            numIndenterSettingsCalNoProbe.TabIndex = 10;
            // 
            // numIndenterSettingsCalWithProbe
            // 
            numIndenterSettingsCalWithProbe.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numIndenterSettingsCalWithProbe.DecimalPlaces = 4;
            numIndenterSettingsCalWithProbe.Enabled = false;
            numIndenterSettingsCalWithProbe.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numIndenterSettingsCalWithProbe.Location = new Point(104, 35);
            numIndenterSettingsCalWithProbe.Margin = new Padding(3, 2, 3, 2);
            numIndenterSettingsCalWithProbe.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numIndenterSettingsCalWithProbe.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numIndenterSettingsCalWithProbe.Name = "numIndenterSettingsCalWithProbe";
            numIndenterSettingsCalWithProbe.Size = new Size(204, 23);
            numIndenterSettingsCalWithProbe.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(314, 31);
            label5.Name = "label5";
            label5.Size = new Size(32, 31);
            label5.TabIndex = 8;
            label5.Text = "mg";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Dock = DockStyle.Fill;
            label25.Font = new Font("Segoe UI", 9F);
            label25.Location = new Point(3, 31);
            label25.Name = "label25";
            label25.Size = new Size(95, 31);
            label25.TabIndex = 6;
            label25.Text = "Raw with Probe:";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Dock = DockStyle.Fill;
            label27.Font = new Font("Segoe UI", 9F);
            label27.Location = new Point(314, 0);
            label27.Name = "label27";
            label27.Size = new Size(32, 31);
            label27.TabIndex = 5;
            label27.Text = "mg";
            label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Dock = DockStyle.Fill;
            label31.Font = new Font("Segoe UI", 9F);
            label31.Location = new Point(3, 0);
            label31.Name = "label31";
            label31.Size = new Size(95, 31);
            label31.TabIndex = 3;
            label31.Text = "Raw w/o Probe:";
            label31.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnIndenterSettingsCalNoProbe
            // 
            btnIndenterSettingsCalNoProbe.Dock = DockStyle.Fill;
            btnIndenterSettingsCalNoProbe.Enabled = false;
            btnIndenterSettingsCalNoProbe.Location = new Point(352, 2);
            btnIndenterSettingsCalNoProbe.Margin = new Padding(3, 2, 3, 2);
            btnIndenterSettingsCalNoProbe.Name = "btnIndenterSettingsCalNoProbe";
            btnIndenterSettingsCalNoProbe.Size = new Size(82, 27);
            btnIndenterSettingsCalNoProbe.TabIndex = 15;
            btnIndenterSettingsCalNoProbe.Text = "Get";
            btnIndenterSettingsCalNoProbe.UseVisualStyleBackColor = true;
            btnIndenterSettingsCalNoProbe.Click += btnIndenterSettingsCalNoProbe_Click;
            // 
            // btnIndenterSettingsCalibrate
            // 
            btnIndenterSettingsCalibrate.Dock = DockStyle.Fill;
            btnIndenterSettingsCalibrate.Enabled = false;
            btnIndenterSettingsCalibrate.Location = new Point(104, 157);
            btnIndenterSettingsCalibrate.Margin = new Padding(3, 2, 3, 2);
            btnIndenterSettingsCalibrate.Name = "btnIndenterSettingsCalibrate";
            btnIndenterSettingsCalibrate.Size = new Size(204, 27);
            btnIndenterSettingsCalibrate.TabIndex = 14;
            btnIndenterSettingsCalibrate.Text = "Calibrate";
            btnIndenterSettingsCalibrate.UseVisualStyleBackColor = true;
            btnIndenterSettingsCalibrate.Click += btnIndenterSettingsCalibrate_Click;
            // 
            // label91
            // 
            label91.AutoSize = true;
            label91.BackColor = Color.Transparent;
            label91.Dock = DockStyle.Fill;
            label91.Font = new Font("Segoe UI", 9F);
            label91.Location = new Point(314, 93);
            label91.Name = "label91";
            label91.Size = new Size(32, 31);
            label91.TabIndex = 17;
            label91.Text = "um";
            label91.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numIndenterSettingsProbeDiameter_um
            // 
            numIndenterSettingsProbeDiameter_um.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numIndenterSettingsProbeDiameter_um.DecimalPlaces = 4;
            numIndenterSettingsProbeDiameter_um.Enabled = false;
            numIndenterSettingsProbeDiameter_um.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numIndenterSettingsProbeDiameter_um.Location = new Point(104, 97);
            numIndenterSettingsProbeDiameter_um.Margin = new Padding(3, 2, 3, 2);
            numIndenterSettingsProbeDiameter_um.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numIndenterSettingsProbeDiameter_um.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numIndenterSettingsProbeDiameter_um.Name = "numIndenterSettingsProbeDiameter_um";
            numIndenterSettingsProbeDiameter_um.Size = new Size(204, 23);
            numIndenterSettingsProbeDiameter_um.TabIndex = 18;
            // 
            // label92
            // 
            label92.AutoSize = true;
            label92.BackColor = Color.Transparent;
            label92.Dock = DockStyle.Fill;
            label92.Font = new Font("Segoe UI", 9F);
            label92.Location = new Point(3, 93);
            label92.Name = "label92";
            label92.Size = new Size(95, 31);
            label92.TabIndex = 19;
            label92.Text = "Probe Diameter:";
            label92.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label93
            // 
            label93.AutoSize = true;
            label93.BackColor = Color.Transparent;
            label93.Dock = DockStyle.Fill;
            label93.Font = new Font("Segoe UI", 9F);
            label93.Location = new Point(3, 124);
            label93.Name = "label93";
            label93.Size = new Size(95, 31);
            label93.TabIndex = 20;
            label93.Text = "Spring Constant:";
            label93.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numIndenterSettingsSpringConstant_N_m
            // 
            numIndenterSettingsSpringConstant_N_m.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numIndenterSettingsSpringConstant_N_m.DecimalPlaces = 4;
            numIndenterSettingsSpringConstant_N_m.Enabled = false;
            numIndenterSettingsSpringConstant_N_m.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numIndenterSettingsSpringConstant_N_m.Location = new Point(104, 128);
            numIndenterSettingsSpringConstant_N_m.Margin = new Padding(3, 2, 3, 2);
            numIndenterSettingsSpringConstant_N_m.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numIndenterSettingsSpringConstant_N_m.Minimum = new decimal(new int[] { -1, 0, 0, int.MinValue });
            numIndenterSettingsSpringConstant_N_m.Name = "numIndenterSettingsSpringConstant_N_m";
            numIndenterSettingsSpringConstant_N_m.Size = new Size(204, 23);
            numIndenterSettingsSpringConstant_N_m.TabIndex = 21;
            // 
            // label94
            // 
            label94.AutoSize = true;
            label94.BackColor = Color.Transparent;
            label94.Dock = DockStyle.Fill;
            label94.Font = new Font("Segoe UI", 9F);
            label94.Location = new Point(314, 124);
            label94.Name = "label94";
            label94.Size = new Size(32, 31);
            label94.TabIndex = 22;
            label94.Text = "N/m";
            label94.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox21
            // 
            groupBox21.Controls.Add(tableLayoutPanel26);
            groupBox21.Location = new Point(813, 117);
            groupBox21.Margin = new Padding(3, 2, 3, 2);
            groupBox21.Name = "groupBox21";
            groupBox21.Padding = new Padding(3, 2, 3, 2);
            groupBox21.Size = new Size(443, 122);
            groupBox21.TabIndex = 18;
            groupBox21.TabStop = false;
            groupBox21.Text = "Microscope Stage Dispaly";
            // 
            // tableLayoutPanel26
            // 
            tableLayoutPanel26.ColumnCount = 3;
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel26.Controls.Add(label59, 0, 2);
            tableLayoutPanel26.Controls.Add(lblMicroscopeStageDisplayZ_mm, 1, 2);
            tableLayoutPanel26.Controls.Add(label63, 2, 2);
            tableLayoutPanel26.Controls.Add(label43, 2, 1);
            tableLayoutPanel26.Controls.Add(lblMicroscopeStageDisplayY_mm, 1, 1);
            tableLayoutPanel26.Controls.Add(label49, 0, 1);
            tableLayoutPanel26.Controls.Add(label51, 2, 0);
            tableLayoutPanel26.Controls.Add(lblMicroscopeStageDisplayX_mm, 1, 0);
            tableLayoutPanel26.Controls.Add(label55, 0, 0);
            tableLayoutPanel26.Dock = DockStyle.Fill;
            tableLayoutPanel26.Location = new Point(3, 18);
            tableLayoutPanel26.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel26.Name = "tableLayoutPanel26";
            tableLayoutPanel26.RowCount = 3;
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel26.Size = new Size(437, 102);
            tableLayoutPanel26.TabIndex = 0;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.BackColor = Color.Transparent;
            label59.Dock = DockStyle.Fill;
            label59.Font = new Font("Segoe UI", 9F);
            label59.Location = new Point(3, 66);
            label59.Name = "label59";
            label59.Size = new Size(17, 36);
            label59.TabIndex = 11;
            label59.Text = "Z:";
            label59.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMicroscopeStageDisplayZ_mm
            // 
            lblMicroscopeStageDisplayZ_mm.AutoSize = true;
            lblMicroscopeStageDisplayZ_mm.BackColor = Color.Transparent;
            lblMicroscopeStageDisplayZ_mm.Dock = DockStyle.Fill;
            lblMicroscopeStageDisplayZ_mm.Font = new Font("Segoe UI", 9F);
            lblMicroscopeStageDisplayZ_mm.Location = new Point(26, 66);
            lblMicroscopeStageDisplayZ_mm.Name = "lblMicroscopeStageDisplayZ_mm";
            lblMicroscopeStageDisplayZ_mm.Size = new Size(29, 36);
            lblMicroscopeStageDisplayZ_mm.TabIndex = 10;
            lblMicroscopeStageDisplayZ_mm.Text = "N/A";
            lblMicroscopeStageDisplayZ_mm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.BackColor = Color.Transparent;
            label63.Dock = DockStyle.Fill;
            label63.Font = new Font("Segoe UI", 9F);
            label63.Location = new Point(61, 66);
            label63.Name = "label63";
            label63.Size = new Size(373, 36);
            label63.TabIndex = 9;
            label63.Text = "mm";
            label63.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.BackColor = Color.Transparent;
            label43.Dock = DockStyle.Fill;
            label43.Font = new Font("Segoe UI", 9F);
            label43.Location = new Point(61, 33);
            label43.Name = "label43";
            label43.Size = new Size(373, 33);
            label43.TabIndex = 8;
            label43.Text = "mm";
            label43.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMicroscopeStageDisplayY_mm
            // 
            lblMicroscopeStageDisplayY_mm.AutoSize = true;
            lblMicroscopeStageDisplayY_mm.BackColor = Color.Transparent;
            lblMicroscopeStageDisplayY_mm.Dock = DockStyle.Fill;
            lblMicroscopeStageDisplayY_mm.Font = new Font("Segoe UI", 9F);
            lblMicroscopeStageDisplayY_mm.Location = new Point(26, 33);
            lblMicroscopeStageDisplayY_mm.Name = "lblMicroscopeStageDisplayY_mm";
            lblMicroscopeStageDisplayY_mm.Size = new Size(29, 33);
            lblMicroscopeStageDisplayY_mm.TabIndex = 7;
            lblMicroscopeStageDisplayY_mm.Text = "N/A";
            lblMicroscopeStageDisplayY_mm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.BackColor = Color.Transparent;
            label49.Dock = DockStyle.Fill;
            label49.Font = new Font("Segoe UI", 9F);
            label49.Location = new Point(3, 33);
            label49.Name = "label49";
            label49.Size = new Size(17, 33);
            label49.TabIndex = 6;
            label49.Text = "Y:";
            label49.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.BackColor = Color.Transparent;
            label51.Dock = DockStyle.Fill;
            label51.Font = new Font("Segoe UI", 9F);
            label51.Location = new Point(61, 0);
            label51.Name = "label51";
            label51.Size = new Size(373, 33);
            label51.TabIndex = 5;
            label51.Text = "mm";
            label51.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMicroscopeStageDisplayX_mm
            // 
            lblMicroscopeStageDisplayX_mm.AutoSize = true;
            lblMicroscopeStageDisplayX_mm.BackColor = Color.Transparent;
            lblMicroscopeStageDisplayX_mm.Dock = DockStyle.Fill;
            lblMicroscopeStageDisplayX_mm.Font = new Font("Segoe UI", 9F);
            lblMicroscopeStageDisplayX_mm.Location = new Point(26, 0);
            lblMicroscopeStageDisplayX_mm.Name = "lblMicroscopeStageDisplayX_mm";
            lblMicroscopeStageDisplayX_mm.Size = new Size(29, 33);
            lblMicroscopeStageDisplayX_mm.TabIndex = 4;
            lblMicroscopeStageDisplayX_mm.Text = "N/A";
            lblMicroscopeStageDisplayX_mm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.BackColor = Color.Transparent;
            label55.Dock = DockStyle.Fill;
            label55.Font = new Font("Segoe UI", 9F);
            label55.Location = new Point(3, 0);
            label55.Name = "label55";
            label55.Size = new Size(17, 33);
            label55.TabIndex = 3;
            label55.Text = "X:";
            label55.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tmrMicroscopeDisplayUpdate
            // 
            tmrMicroscopeDisplayUpdate.Interval = 1;
            tmrMicroscopeDisplayUpdate.Tick += tmrMicroscopeDisplayUpdate_Tick;
            // 
            // tmrIndenterDisplayUpdate
            // 
            tmrIndenterDisplayUpdate.Interval = 1;
            tmrIndenterDisplayUpdate.Tick += tmrIndenterDisplayUpdate_Tick;
            // 
            // tmrAverageIndenterValues
            // 
            tmrAverageIndenterValues.Interval = 10;
            tmrAverageIndenterValues.Tick += tmrAverageIndenterValues_Tick;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(lblSpringConstFlatModulus);
            groupBox10.Controls.Add(lblSpringConstFlat);
            groupBox10.Controls.Add(groupBox14);
            groupBox10.Controls.Add(groupBox22);
            groupBox10.Controls.Add(groupBox15);
            groupBox10.Location = new Point(1261, 26);
            groupBox10.Margin = new Padding(3, 2, 3, 2);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 2, 3, 2);
            groupBox10.Size = new Size(326, 533);
            groupBox10.TabIndex = 45;
            groupBox10.TabStop = false;
            groupBox10.Text = "Find Spring Constant on Flat Surface";
            // 
            // lblSpringConstFlatModulus
            // 
            lblSpringConstFlatModulus.AutoSize = true;
            lblSpringConstFlatModulus.Location = new Point(5, 37);
            lblSpringConstFlatModulus.Name = "lblSpringConstFlatModulus";
            lblSpringConstFlatModulus.Size = new Size(93, 15);
            lblSpringConstFlatModulus.TabIndex = 44;
            lblSpringConstFlatModulus.Text = "Elastic Modulus:";
            // 
            // lblSpringConstFlat
            // 
            lblSpringConstFlat.AutoSize = true;
            lblSpringConstFlat.Location = new Point(5, 17);
            lblSpringConstFlat.Name = "lblSpringConstFlat";
            lblSpringConstFlat.Size = new Size(129, 15);
            lblSpringConstFlat.TabIndex = 43;
            lblSpringConstFlat.Text = "Latest Spring Constant:";
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(label70);
            groupBox14.Controls.Add(numIndentationCtrlSpringConstByPointsDelay_ms);
            groupBox14.Controls.Add(label71);
            groupBox14.Controls.Add(label69);
            groupBox14.Controls.Add(chkIndentationCtrlSpringConstByPointsCreepUp);
            groupBox14.Controls.Add(label67);
            groupBox14.Controls.Add(numIndentationCtrlSpringConstByPointsAccel_steps);
            groupBox14.Controls.Add(label68);
            groupBox14.Controls.Add(label66);
            groupBox14.Controls.Add(numIndentationCtrlSpringConstByPointsVel_steps);
            groupBox14.Controls.Add(label65);
            groupBox14.Controls.Add(label15);
            groupBox14.Controls.Add(label9);
            groupBox14.Controls.Add(numIndentationCtrlSpringConstByPointsDistance_um);
            groupBox14.Controls.Add(numIndentationCtrlSpringConstByPointsPoints);
            groupBox14.Controls.Add(btnFindSpringConstByPoints);
            groupBox14.Location = new Point(5, 54);
            groupBox14.Margin = new Padding(3, 2, 3, 2);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(3, 2, 3, 2);
            groupBox14.Size = new Size(316, 196);
            groupBox14.TabIndex = 40;
            groupBox14.TabStop = false;
            groupBox14.Text = "By Points";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(284, 70);
            label70.Name = "label70";
            label70.Size = new Size(23, 15);
            label70.TabIndex = 36;
            label70.Text = "ms";
            // 
            // numIndentationCtrlSpringConstByPointsDelay_ms
            // 
            numIndentationCtrlSpringConstByPointsDelay_ms.Location = new Point(125, 69);
            numIndentationCtrlSpringConstByPointsDelay_ms.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByPointsDelay_ms.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numIndentationCtrlSpringConstByPointsDelay_ms.Name = "numIndentationCtrlSpringConstByPointsDelay_ms";
            numIndentationCtrlSpringConstByPointsDelay_ms.Size = new Size(154, 23);
            numIndentationCtrlSpringConstByPointsDelay_ms.TabIndex = 35;
            numIndentationCtrlSpringConstByPointsDelay_ms.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new Point(5, 70);
            label71.Name = "label71";
            label71.Size = new Size(101, 15);
            label71.TabIndex = 34;
            label71.Text = "Delay Btw. Points:";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Location = new Point(284, 47);
            label69.Name = "label69";
            label69.Size = new Size(25, 15);
            label69.TabIndex = 33;
            label69.Text = "um";
            // 
            // chkIndentationCtrlSpringConstByPointsCreepUp
            // 
            chkIndentationCtrlSpringConstByPointsCreepUp.AutoSize = true;
            chkIndentationCtrlSpringConstByPointsCreepUp.Checked = true;
            chkIndentationCtrlSpringConstByPointsCreepUp.CheckState = CheckState.Checked;
            chkIndentationCtrlSpringConstByPointsCreepUp.Location = new Point(8, 146);
            chkIndentationCtrlSpringConstByPointsCreepUp.Margin = new Padding(3, 2, 3, 2);
            chkIndentationCtrlSpringConstByPointsCreepUp.Name = "chkIndentationCtrlSpringConstByPointsCreepUp";
            chkIndentationCtrlSpringConstByPointsCreepUp.Size = new Size(119, 19);
            chkIndentationCtrlSpringConstByPointsCreepUp.TabIndex = 32;
            chkIndentationCtrlSpringConstByPointsCreepUp.Text = "Creep up to point";
            chkIndentationCtrlSpringConstByPointsCreepUp.UseVisualStyleBackColor = true;
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Location = new Point(247, 122);
            label67.Name = "label67";
            label67.Size = new Size(58, 15);
            label67.TabIndex = 31;
            label67.Text = "steps/s^2";
            // 
            // numIndentationCtrlSpringConstByPointsAccel_steps
            // 
            numIndentationCtrlSpringConstByPointsAccel_steps.Location = new Point(125, 121);
            numIndentationCtrlSpringConstByPointsAccel_steps.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByPointsAccel_steps.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            numIndentationCtrlSpringConstByPointsAccel_steps.Name = "numIndentationCtrlSpringConstByPointsAccel_steps";
            numIndentationCtrlSpringConstByPointsAccel_steps.Size = new Size(116, 23);
            numIndentationCtrlSpringConstByPointsAccel_steps.TabIndex = 30;
            numIndentationCtrlSpringConstByPointsAccel_steps.Value = new decimal(new int[] { 200000, 0, 0, 0 });
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Location = new Point(5, 122);
            label68.Name = "label68";
            label68.Size = new Size(76, 15);
            label68.TabIndex = 29;
            label68.Text = "Acceleration:";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new Point(262, 95);
            label66.Name = "label66";
            label66.Size = new Size(44, 15);
            label66.TabIndex = 28;
            label66.Text = "steps/s";
            // 
            // numIndentationCtrlSpringConstByPointsVel_steps
            // 
            numIndentationCtrlSpringConstByPointsVel_steps.Location = new Point(125, 94);
            numIndentationCtrlSpringConstByPointsVel_steps.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByPointsVel_steps.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numIndentationCtrlSpringConstByPointsVel_steps.Name = "numIndentationCtrlSpringConstByPointsVel_steps";
            numIndentationCtrlSpringConstByPointsVel_steps.Size = new Size(132, 23);
            numIndentationCtrlSpringConstByPointsVel_steps.TabIndex = 28;
            numIndentationCtrlSpringConstByPointsVel_steps.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Location = new Point(5, 95);
            label65.Name = "label65";
            label65.Size = new Size(51, 15);
            label65.TabIndex = 27;
            label65.Text = "Velocity:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 46);
            label15.Name = "label15";
            label15.Size = new Size(86, 15);
            label15.TabIndex = 26;
            label15.Text = "Point Distance:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 21);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 25;
            label9.Text = "Indentation Points:";
            // 
            // numIndentationCtrlSpringConstByPointsDistance_um
            // 
            numIndentationCtrlSpringConstByPointsDistance_um.DecimalPlaces = 1;
            numIndentationCtrlSpringConstByPointsDistance_um.Location = new Point(125, 44);
            numIndentationCtrlSpringConstByPointsDistance_um.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByPointsDistance_um.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numIndentationCtrlSpringConstByPointsDistance_um.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numIndentationCtrlSpringConstByPointsDistance_um.Name = "numIndentationCtrlSpringConstByPointsDistance_um";
            numIndentationCtrlSpringConstByPointsDistance_um.Size = new Size(154, 23);
            numIndentationCtrlSpringConstByPointsDistance_um.TabIndex = 24;
            numIndentationCtrlSpringConstByPointsDistance_um.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numIndentationCtrlSpringConstByPointsPoints
            // 
            numIndentationCtrlSpringConstByPointsPoints.Location = new Point(125, 20);
            numIndentationCtrlSpringConstByPointsPoints.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByPointsPoints.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numIndentationCtrlSpringConstByPointsPoints.Name = "numIndentationCtrlSpringConstByPointsPoints";
            numIndentationCtrlSpringConstByPointsPoints.Size = new Size(186, 23);
            numIndentationCtrlSpringConstByPointsPoints.TabIndex = 23;
            numIndentationCtrlSpringConstByPointsPoints.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // btnFindSpringConstByPoints
            // 
            btnFindSpringConstByPoints.Location = new Point(5, 168);
            btnFindSpringConstByPoints.Margin = new Padding(3, 2, 3, 2);
            btnFindSpringConstByPoints.Name = "btnFindSpringConstByPoints";
            btnFindSpringConstByPoints.Size = new Size(305, 22);
            btnFindSpringConstByPoints.TabIndex = 21;
            btnFindSpringConstByPoints.Text = "Find Spring Constant";
            btnFindSpringConstByPoints.UseVisualStyleBackColor = true;
            btnFindSpringConstByPoints.Click += btnFindSpringConstByPoints_Click;
            // 
            // groupBox22
            // 
            groupBox22.Controls.Add(label85);
            groupBox22.Controls.Add(btnFindSpringConstByForce);
            groupBox22.Controls.Add(label79);
            groupBox22.Controls.Add(numIndentationCtrlSpringConstByForceAccel_steps);
            groupBox22.Controls.Add(label80);
            groupBox22.Controls.Add(label81);
            groupBox22.Controls.Add(numIndentationCtrlSpringConstByForceVel_steps);
            groupBox22.Controls.Add(label82);
            groupBox22.Controls.Add(numIndentationCtrlSpringConstByForceEndForce_mg);
            groupBox22.Controls.Add(label83);
            groupBox22.Location = new Point(5, 404);
            groupBox22.Margin = new Padding(3, 2, 3, 2);
            groupBox22.Name = "groupBox22";
            groupBox22.Padding = new Padding(3, 2, 3, 2);
            groupBox22.Size = new Size(316, 123);
            groupBox22.TabIndex = 42;
            groupBox22.TabStop = false;
            groupBox22.Text = "By Final Force";
            // 
            // label85
            // 
            label85.AutoSize = true;
            label85.Location = new Point(283, 21);
            label85.Name = "label85";
            label85.Size = new Size(25, 15);
            label85.TabIndex = 49;
            label85.Text = "mg";
            // 
            // btnFindSpringConstByForce
            // 
            btnFindSpringConstByForce.Location = new Point(4, 96);
            btnFindSpringConstByForce.Margin = new Padding(3, 2, 3, 2);
            btnFindSpringConstByForce.Name = "btnFindSpringConstByForce";
            btnFindSpringConstByForce.Size = new Size(305, 22);
            btnFindSpringConstByForce.TabIndex = 48;
            btnFindSpringConstByForce.Text = "Find Spring Constant";
            btnFindSpringConstByForce.UseVisualStyleBackColor = true;
            btnFindSpringConstByForce.Click += btnFindSpringConstByForce_Click;
            // 
            // label79
            // 
            label79.AutoSize = true;
            label79.Location = new Point(246, 73);
            label79.Name = "label79";
            label79.Size = new Size(58, 15);
            label79.TabIndex = 45;
            label79.Text = "steps/s^2";
            // 
            // numIndentationCtrlSpringConstByForceAccel_steps
            // 
            numIndentationCtrlSpringConstByForceAccel_steps.Location = new Point(124, 71);
            numIndentationCtrlSpringConstByForceAccel_steps.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByForceAccel_steps.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            numIndentationCtrlSpringConstByForceAccel_steps.Name = "numIndentationCtrlSpringConstByForceAccel_steps";
            numIndentationCtrlSpringConstByForceAccel_steps.Size = new Size(116, 23);
            numIndentationCtrlSpringConstByForceAccel_steps.TabIndex = 44;
            numIndentationCtrlSpringConstByForceAccel_steps.Value = new decimal(new int[] { 200000, 0, 0, 0 });
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Location = new Point(4, 73);
            label80.Name = "label80";
            label80.Size = new Size(76, 15);
            label80.TabIndex = 43;
            label80.Text = "Acceleration:";
            // 
            // label81
            // 
            label81.AutoSize = true;
            label81.Location = new Point(262, 46);
            label81.Name = "label81";
            label81.Size = new Size(44, 15);
            label81.TabIndex = 41;
            label81.Text = "steps/s";
            // 
            // numIndentationCtrlSpringConstByForceVel_steps
            // 
            numIndentationCtrlSpringConstByForceVel_steps.Location = new Point(124, 44);
            numIndentationCtrlSpringConstByForceVel_steps.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByForceVel_steps.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numIndentationCtrlSpringConstByForceVel_steps.Name = "numIndentationCtrlSpringConstByForceVel_steps";
            numIndentationCtrlSpringConstByForceVel_steps.Size = new Size(132, 23);
            numIndentationCtrlSpringConstByForceVel_steps.TabIndex = 42;
            numIndentationCtrlSpringConstByForceVel_steps.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label82
            // 
            label82.AutoSize = true;
            label82.Location = new Point(4, 46);
            label82.Name = "label82";
            label82.Size = new Size(51, 15);
            label82.TabIndex = 40;
            label82.Text = "Velocity:";
            // 
            // numIndentationCtrlSpringConstByForceEndForce_mg
            // 
            numIndentationCtrlSpringConstByForceEndForce_mg.DecimalPlaces = 1;
            numIndentationCtrlSpringConstByForceEndForce_mg.Location = new Point(124, 20);
            numIndentationCtrlSpringConstByForceEndForce_mg.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByForceEndForce_mg.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numIndentationCtrlSpringConstByForceEndForce_mg.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            numIndentationCtrlSpringConstByForceEndForce_mg.Name = "numIndentationCtrlSpringConstByForceEndForce_mg";
            numIndentationCtrlSpringConstByForceEndForce_mg.Size = new Size(153, 23);
            numIndentationCtrlSpringConstByForceEndForce_mg.TabIndex = 39;
            // 
            // label83
            // 
            label83.AutoSize = true;
            label83.Location = new Point(4, 21);
            label83.Name = "label83";
            label83.Size = new Size(62, 15);
            label83.TabIndex = 38;
            label83.Text = "End Force:";
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(label84);
            groupBox15.Controls.Add(btnFindSpringConstByDistance);
            groupBox15.Controls.Add(chkIndentationCtrlSpringConstByDistanceCreepUp);
            groupBox15.Controls.Add(label73);
            groupBox15.Controls.Add(numIndentationCtrlSpringConstByDistanceAccel_steps);
            groupBox15.Controls.Add(label74);
            groupBox15.Controls.Add(label75);
            groupBox15.Controls.Add(numIndentationCtrlSpringConstByDistanceVel_steps);
            groupBox15.Controls.Add(label76);
            groupBox15.Controls.Add(numIndentationCtrlSpringConstByDistanceDistance_um);
            groupBox15.Controls.Add(label72);
            groupBox15.Location = new Point(5, 254);
            groupBox15.Margin = new Padding(3, 2, 3, 2);
            groupBox15.Name = "groupBox15";
            groupBox15.Padding = new Padding(3, 2, 3, 2);
            groupBox15.Size = new Size(316, 145);
            groupBox15.TabIndex = 41;
            groupBox15.TabStop = false;
            groupBox15.Text = "By Final Distance";
            // 
            // label84
            // 
            label84.AutoSize = true;
            label84.Location = new Point(283, 21);
            label84.Name = "label84";
            label84.Size = new Size(25, 15);
            label84.TabIndex = 49;
            label84.Text = "um";
            // 
            // btnFindSpringConstByDistance
            // 
            btnFindSpringConstByDistance.Location = new Point(5, 117);
            btnFindSpringConstByDistance.Margin = new Padding(3, 2, 3, 2);
            btnFindSpringConstByDistance.Name = "btnFindSpringConstByDistance";
            btnFindSpringConstByDistance.Size = new Size(305, 22);
            btnFindSpringConstByDistance.TabIndex = 48;
            btnFindSpringConstByDistance.Text = "Find Spring Constant";
            btnFindSpringConstByDistance.UseVisualStyleBackColor = true;
            btnFindSpringConstByDistance.Click += btnFindSpringConstByDistance_Click;
            // 
            // chkIndentationCtrlSpringConstByDistanceCreepUp
            // 
            chkIndentationCtrlSpringConstByDistanceCreepUp.AutoSize = true;
            chkIndentationCtrlSpringConstByDistanceCreepUp.Checked = true;
            chkIndentationCtrlSpringConstByDistanceCreepUp.CheckState = CheckState.Checked;
            chkIndentationCtrlSpringConstByDistanceCreepUp.Location = new Point(8, 94);
            chkIndentationCtrlSpringConstByDistanceCreepUp.Margin = new Padding(3, 2, 3, 2);
            chkIndentationCtrlSpringConstByDistanceCreepUp.Name = "chkIndentationCtrlSpringConstByDistanceCreepUp";
            chkIndentationCtrlSpringConstByDistanceCreepUp.Size = new Size(119, 19);
            chkIndentationCtrlSpringConstByDistanceCreepUp.TabIndex = 47;
            chkIndentationCtrlSpringConstByDistanceCreepUp.Text = "Creep up to point";
            chkIndentationCtrlSpringConstByDistanceCreepUp.UseVisualStyleBackColor = true;
            // 
            // label73
            // 
            label73.AutoSize = true;
            label73.Location = new Point(246, 73);
            label73.Name = "label73";
            label73.Size = new Size(58, 15);
            label73.TabIndex = 45;
            label73.Text = "steps/s^2";
            // 
            // numIndentationCtrlSpringConstByDistanceAccel_steps
            // 
            numIndentationCtrlSpringConstByDistanceAccel_steps.Location = new Point(124, 71);
            numIndentationCtrlSpringConstByDistanceAccel_steps.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByDistanceAccel_steps.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            numIndentationCtrlSpringConstByDistanceAccel_steps.Name = "numIndentationCtrlSpringConstByDistanceAccel_steps";
            numIndentationCtrlSpringConstByDistanceAccel_steps.Size = new Size(116, 23);
            numIndentationCtrlSpringConstByDistanceAccel_steps.TabIndex = 44;
            numIndentationCtrlSpringConstByDistanceAccel_steps.Value = new decimal(new int[] { 200000, 0, 0, 0 });
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.Location = new Point(4, 73);
            label74.Name = "label74";
            label74.Size = new Size(76, 15);
            label74.TabIndex = 43;
            label74.Text = "Acceleration:";
            // 
            // label75
            // 
            label75.AutoSize = true;
            label75.Location = new Point(262, 46);
            label75.Name = "label75";
            label75.Size = new Size(44, 15);
            label75.TabIndex = 41;
            label75.Text = "steps/s";
            // 
            // numIndentationCtrlSpringConstByDistanceVel_steps
            // 
            numIndentationCtrlSpringConstByDistanceVel_steps.Location = new Point(124, 44);
            numIndentationCtrlSpringConstByDistanceVel_steps.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByDistanceVel_steps.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numIndentationCtrlSpringConstByDistanceVel_steps.Name = "numIndentationCtrlSpringConstByDistanceVel_steps";
            numIndentationCtrlSpringConstByDistanceVel_steps.Size = new Size(132, 23);
            numIndentationCtrlSpringConstByDistanceVel_steps.TabIndex = 42;
            numIndentationCtrlSpringConstByDistanceVel_steps.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label76
            // 
            label76.AutoSize = true;
            label76.Location = new Point(4, 46);
            label76.Name = "label76";
            label76.Size = new Size(51, 15);
            label76.TabIndex = 40;
            label76.Text = "Velocity:";
            // 
            // numIndentationCtrlSpringConstByDistanceDistance_um
            // 
            numIndentationCtrlSpringConstByDistanceDistance_um.DecimalPlaces = 1;
            numIndentationCtrlSpringConstByDistanceDistance_um.Location = new Point(124, 20);
            numIndentationCtrlSpringConstByDistanceDistance_um.Margin = new Padding(3, 2, 3, 2);
            numIndentationCtrlSpringConstByDistanceDistance_um.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numIndentationCtrlSpringConstByDistanceDistance_um.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numIndentationCtrlSpringConstByDistanceDistance_um.Name = "numIndentationCtrlSpringConstByDistanceDistance_um";
            numIndentationCtrlSpringConstByDistanceDistance_um.Size = new Size(155, 23);
            numIndentationCtrlSpringConstByDistanceDistance_um.TabIndex = 39;
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.Location = new Point(4, 21);
            label72.Name = "label72";
            label72.Size = new Size(89, 15);
            label72.TabIndex = 38;
            label72.Text = "Travel Distance:";
            // 
            // groupBox23
            // 
            groupBox23.Controls.Add(chkSampleDetailsShowPlot);
            groupBox23.Controls.Add(label78);
            groupBox23.Controls.Add(label77);
            groupBox23.Controls.Add(numSampleDetailsStressRelaxationTime_ms);
            groupBox23.Controls.Add(chkSampleDetailsCollectStressRelaxation);
            groupBox23.Controls.Add(btnSampleDetailsSaveCollectedData);
            groupBox23.Controls.Add(btnSampleDetailsSet);
            groupBox23.Controls.Add(label88);
            groupBox23.Controls.Add(label87);
            groupBox23.Controls.Add(label86);
            groupBox23.Controls.Add(txtSampleDetailsMeasurement);
            groupBox23.Controls.Add(txtSampleDetailsLocation);
            groupBox23.Controls.Add(txtSampleDetailsSampleName);
            groupBox23.Location = new Point(1261, 564);
            groupBox23.Margin = new Padding(3, 2, 3, 2);
            groupBox23.Name = "groupBox23";
            groupBox23.Padding = new Padding(3, 2, 3, 2);
            groupBox23.Size = new Size(330, 196);
            groupBox23.TabIndex = 44;
            groupBox23.TabStop = false;
            groupBox23.Text = "Sample Details and Data Collection";
            // 
            // chkSampleDetailsShowPlot
            // 
            chkSampleDetailsShowPlot.AutoSize = true;
            chkSampleDetailsShowPlot.Checked = true;
            chkSampleDetailsShowPlot.CheckState = CheckState.Checked;
            chkSampleDetailsShowPlot.Location = new Point(240, 122);
            chkSampleDetailsShowPlot.Margin = new Padding(3, 2, 3, 2);
            chkSampleDetailsShowPlot.Name = "chkSampleDetailsShowPlot";
            chkSampleDetailsShowPlot.Size = new Size(79, 19);
            chkSampleDetailsShowPlot.TabIndex = 55;
            chkSampleDetailsShowPlot.Text = "Show Plot";
            chkSampleDetailsShowPlot.UseVisualStyleBackColor = true;
            // 
            // label78
            // 
            label78.AutoSize = true;
            label78.Location = new Point(298, 142);
            label78.Name = "label78";
            label78.Size = new Size(23, 15);
            label78.TabIndex = 54;
            label78.Text = "ms";
            // 
            // label77
            // 
            label77.AutoSize = true;
            label77.Location = new Point(7, 142);
            label77.Name = "label77";
            label77.Size = new Size(151, 15);
            label77.TabIndex = 53;
            label77.Text = "Relaxation Collection Time:";
            // 
            // numSampleDetailsStressRelaxationTime_ms
            // 
            numSampleDetailsStressRelaxationTime_ms.Location = new Point(178, 141);
            numSampleDetailsStressRelaxationTime_ms.Margin = new Padding(3, 2, 3, 2);
            numSampleDetailsStressRelaxationTime_ms.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numSampleDetailsStressRelaxationTime_ms.Name = "numSampleDetailsStressRelaxationTime_ms";
            numSampleDetailsStressRelaxationTime_ms.Size = new Size(115, 23);
            numSampleDetailsStressRelaxationTime_ms.TabIndex = 51;
            // 
            // chkSampleDetailsCollectStressRelaxation
            // 
            chkSampleDetailsCollectStressRelaxation.AutoSize = true;
            chkSampleDetailsCollectStressRelaxation.Checked = true;
            chkSampleDetailsCollectStressRelaxation.CheckState = CheckState.Checked;
            chkSampleDetailsCollectStressRelaxation.Location = new Point(11, 122);
            chkSampleDetailsCollectStressRelaxation.Margin = new Padding(3, 2, 3, 2);
            chkSampleDetailsCollectStressRelaxation.Name = "chkSampleDetailsCollectStressRelaxation";
            chkSampleDetailsCollectStressRelaxation.Size = new Size(153, 19);
            chkSampleDetailsCollectStressRelaxation.TabIndex = 52;
            chkSampleDetailsCollectStressRelaxation.Text = "Collect Stress Relaxation";
            chkSampleDetailsCollectStressRelaxation.UseVisualStyleBackColor = true;
            chkSampleDetailsCollectStressRelaxation.CheckedChanged += chkSampleDetailsCollectStressRelaxation_CheckedChanged;
            // 
            // btnSampleDetailsSaveCollectedData
            // 
            btnSampleDetailsSaveCollectedData.Enabled = false;
            btnSampleDetailsSaveCollectedData.Location = new Point(5, 166);
            btnSampleDetailsSaveCollectedData.Margin = new Padding(3, 2, 3, 2);
            btnSampleDetailsSaveCollectedData.Name = "btnSampleDetailsSaveCollectedData";
            btnSampleDetailsSaveCollectedData.Size = new Size(319, 25);
            btnSampleDetailsSaveCollectedData.TabIndex = 47;
            btnSampleDetailsSaveCollectedData.Text = "Save Collected Data";
            btnSampleDetailsSaveCollectedData.UseVisualStyleBackColor = true;
            btnSampleDetailsSaveCollectedData.Click += btnSampleDetailsSaveCollectedData_Click;
            // 
            // btnSampleDetailsSet
            // 
            btnSampleDetailsSet.Enabled = false;
            btnSampleDetailsSet.Location = new Point(5, 94);
            btnSampleDetailsSet.Margin = new Padding(3, 2, 3, 2);
            btnSampleDetailsSet.Name = "btnSampleDetailsSet";
            btnSampleDetailsSet.Size = new Size(319, 25);
            btnSampleDetailsSet.TabIndex = 46;
            btnSampleDetailsSet.Text = "Set";
            btnSampleDetailsSet.UseVisualStyleBackColor = true;
            btnSampleDetailsSet.Click += btnSampleDetailsSet_Click;
            // 
            // label88
            // 
            label88.AutoSize = true;
            label88.Location = new Point(9, 71);
            label88.Name = "label88";
            label88.Size = new Size(83, 15);
            label88.TabIndex = 45;
            label88.Text = "Measurement:";
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.Location = new Point(9, 46);
            label87.Name = "label87";
            label87.Size = new Size(56, 15);
            label87.TabIndex = 44;
            label87.Text = "Location:";
            // 
            // label86
            // 
            label86.AutoSize = true;
            label86.Location = new Point(9, 22);
            label86.Name = "label86";
            label86.Size = new Size(84, 15);
            label86.TabIndex = 43;
            label86.Text = "Sample Name:";
            // 
            // txtSampleDetailsMeasurement
            // 
            txtSampleDetailsMeasurement.Location = new Point(107, 69);
            txtSampleDetailsMeasurement.Margin = new Padding(3, 2, 3, 2);
            txtSampleDetailsMeasurement.Name = "txtSampleDetailsMeasurement";
            txtSampleDetailsMeasurement.Size = new Size(218, 23);
            txtSampleDetailsMeasurement.TabIndex = 42;
            txtSampleDetailsMeasurement.TextChanged += txtSampleDetailsMeasurement_TextChanged;
            // 
            // txtSampleDetailsLocation
            // 
            txtSampleDetailsLocation.Location = new Point(107, 44);
            txtSampleDetailsLocation.Margin = new Padding(3, 2, 3, 2);
            txtSampleDetailsLocation.Name = "txtSampleDetailsLocation";
            txtSampleDetailsLocation.Size = new Size(218, 23);
            txtSampleDetailsLocation.TabIndex = 41;
            txtSampleDetailsLocation.TextChanged += txtSampleDetailsLocation_TextChanged;
            // 
            // txtSampleDetailsSampleName
            // 
            txtSampleDetailsSampleName.Location = new Point(107, 20);
            txtSampleDetailsSampleName.Margin = new Padding(3, 2, 3, 2);
            txtSampleDetailsSampleName.Name = "txtSampleDetailsSampleName";
            txtSampleDetailsSampleName.Size = new Size(218, 23);
            txtSampleDetailsSampleName.TabIndex = 40;
            txtSampleDetailsSampleName.TextChanged += txtSampleDetailsSampleName_TextChanged;
            // 
            // groupBox24
            // 
            groupBox24.Controls.Add(tableLayoutPanel21);
            groupBox24.Location = new Point(10, 689);
            groupBox24.Margin = new Padding(3, 2, 3, 2);
            groupBox24.Name = "groupBox24";
            groupBox24.Padding = new Padding(3, 2, 3, 2);
            groupBox24.Size = new Size(144, 146);
            groupBox24.TabIndex = 46;
            groupBox24.TabStop = false;
            groupBox24.Text = "Holder Stage XY Run";
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.ColumnCount = 3;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel21.Controls.Add(btnHolderStageRunXRightYDown, 2, 2);
            tableLayoutPanel21.Controls.Add(btnHolderStageRunXRightYUp, 2, 0);
            tableLayoutPanel21.Controls.Add(btnHolderStageRunXLeftYDown, 0, 2);
            tableLayoutPanel21.Controls.Add(btnHolderStageRunXLeftYUp, 0, 0);
            tableLayoutPanel21.Controls.Add(btnHolderStageRunYDown, 1, 2);
            tableLayoutPanel21.Controls.Add(btnHolderStageRunYUp, 1, 0);
            tableLayoutPanel21.Controls.Add(btnHolderStageRunXRight, 2, 1);
            tableLayoutPanel21.Controls.Add(btnHolderStageRunXLeft, 0, 1);
            tableLayoutPanel21.Dock = DockStyle.Fill;
            tableLayoutPanel21.Location = new Point(3, 18);
            tableLayoutPanel21.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.RowCount = 3;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel21.Size = new Size(138, 126);
            tableLayoutPanel21.TabIndex = 0;
            // 
            // btnHolderStageRunXRightYDown
            // 
            btnHolderStageRunXRightYDown.Location = new Point(95, 86);
            btnHolderStageRunXRightYDown.Margin = new Padding(3, 2, 3, 2);
            btnHolderStageRunXRightYDown.Name = "btnHolderStageRunXRightYDown";
            btnHolderStageRunXRightYDown.Size = new Size(40, 38);
            btnHolderStageRunXRightYDown.TabIndex = 10;
            btnHolderStageRunXRightYDown.Text = "↘";
            btnHolderStageRunXRightYDown.UseVisualStyleBackColor = true;
            btnHolderStageRunXRightYDown.MouseDown += btnHolderStageRunXRightYDown_MouseDown;
            btnHolderStageRunXRightYDown.MouseUp += btnHolderStageRunXRightYDown_MouseUp;
            // 
            // btnHolderStageRunXRightYUp
            // 
            btnHolderStageRunXRightYUp.Location = new Point(95, 2);
            btnHolderStageRunXRightYUp.Margin = new Padding(3, 2, 3, 2);
            btnHolderStageRunXRightYUp.Name = "btnHolderStageRunXRightYUp";
            btnHolderStageRunXRightYUp.Size = new Size(40, 38);
            btnHolderStageRunXRightYUp.TabIndex = 11;
            btnHolderStageRunXRightYUp.Text = "↗";
            btnHolderStageRunXRightYUp.UseVisualStyleBackColor = true;
            btnHolderStageRunXRightYUp.MouseDown += btnHolderStageRunXRightYUp_MouseDown;
            btnHolderStageRunXRightYUp.MouseUp += btnHolderStageRunXRightYUp_MouseUp;
            // 
            // btnHolderStageRunXLeftYDown
            // 
            btnHolderStageRunXLeftYDown.Location = new Point(3, 86);
            btnHolderStageRunXLeftYDown.Margin = new Padding(3, 2, 3, 2);
            btnHolderStageRunXLeftYDown.Name = "btnHolderStageRunXLeftYDown";
            btnHolderStageRunXLeftYDown.Size = new Size(40, 38);
            btnHolderStageRunXLeftYDown.TabIndex = 9;
            btnHolderStageRunXLeftYDown.Text = "↙";
            btnHolderStageRunXLeftYDown.UseVisualStyleBackColor = true;
            btnHolderStageRunXLeftYDown.MouseDown += btnHolderStageRunXLeftYDown_MouseDown;
            btnHolderStageRunXLeftYDown.MouseUp += btnHolderStageRunXLeftYDown_MouseUp;
            // 
            // btnHolderStageRunXLeftYUp
            // 
            btnHolderStageRunXLeftYUp.Location = new Point(3, 2);
            btnHolderStageRunXLeftYUp.Margin = new Padding(3, 2, 3, 2);
            btnHolderStageRunXLeftYUp.Name = "btnHolderStageRunXLeftYUp";
            btnHolderStageRunXLeftYUp.Size = new Size(40, 38);
            btnHolderStageRunXLeftYUp.TabIndex = 8;
            btnHolderStageRunXLeftYUp.Text = "↖";
            btnHolderStageRunXLeftYUp.UseVisualStyleBackColor = true;
            btnHolderStageRunXLeftYUp.MouseDown += btnHolderStageRunXLeftYUp_MouseDown;
            btnHolderStageRunXLeftYUp.MouseUp += btnHolderStageRunXLeftYUp_MouseUp;
            // 
            // btnHolderStageRunYDown
            // 
            btnHolderStageRunYDown.Location = new Point(49, 86);
            btnHolderStageRunYDown.Margin = new Padding(3, 2, 3, 2);
            btnHolderStageRunYDown.Name = "btnHolderStageRunYDown";
            btnHolderStageRunYDown.Size = new Size(40, 38);
            btnHolderStageRunYDown.TabIndex = 4;
            btnHolderStageRunYDown.Text = "↓";
            btnHolderStageRunYDown.UseVisualStyleBackColor = true;
            btnHolderStageRunYDown.MouseDown += btnHolderStageRunYDown_MouseDown;
            btnHolderStageRunYDown.MouseUp += btnHolderStageRunYDown_MouseUp;
            // 
            // btnHolderStageRunYUp
            // 
            btnHolderStageRunYUp.Location = new Point(49, 2);
            btnHolderStageRunYUp.Margin = new Padding(3, 2, 3, 2);
            btnHolderStageRunYUp.Name = "btnHolderStageRunYUp";
            btnHolderStageRunYUp.Size = new Size(40, 38);
            btnHolderStageRunYUp.TabIndex = 0;
            btnHolderStageRunYUp.Text = "↑";
            btnHolderStageRunYUp.UseVisualStyleBackColor = true;
            btnHolderStageRunYUp.MouseDown += btnHolderStageRunYUp_MouseDown;
            btnHolderStageRunYUp.MouseUp += btnHolderStageRunYUp_MouseUp;
            // 
            // btnHolderStageRunXRight
            // 
            btnHolderStageRunXRight.Location = new Point(95, 44);
            btnHolderStageRunXRight.Margin = new Padding(3, 2, 3, 2);
            btnHolderStageRunXRight.Name = "btnHolderStageRunXRight";
            btnHolderStageRunXRight.Size = new Size(40, 38);
            btnHolderStageRunXRight.TabIndex = 3;
            btnHolderStageRunXRight.Text = "→";
            btnHolderStageRunXRight.UseVisualStyleBackColor = true;
            btnHolderStageRunXRight.MouseDown += btnHolderStageRunXRight_MouseDown;
            btnHolderStageRunXRight.MouseUp += btnHolderStageRunXRight_MouseUp;
            // 
            // btnHolderStageRunXLeft
            // 
            btnHolderStageRunXLeft.Location = new Point(3, 44);
            btnHolderStageRunXLeft.Margin = new Padding(3, 2, 3, 2);
            btnHolderStageRunXLeft.Name = "btnHolderStageRunXLeft";
            btnHolderStageRunXLeft.Size = new Size(40, 38);
            btnHolderStageRunXLeft.TabIndex = 2;
            btnHolderStageRunXLeft.Text = "←";
            btnHolderStageRunXLeft.UseVisualStyleBackColor = true;
            btnHolderStageRunXLeft.MouseDown += btnHolderStageRunXLeft_MouseDown;
            btnHolderStageRunXLeft.MouseUp += btnHolderStageRunXLeft_MouseUp;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 865);
            Controls.Add(groupBox24);
            Controls.Add(groupBox10);
            Controls.Add(groupBox23);
            Controls.Add(groupBox21);
            Controls.Add(groupBox18);
            Controls.Add(groupBox17);
            Controls.Add(groupBox16);
            Controls.Add(groupBox12);
            Controls.Add(groupBox9);
            Controls.Add(groupBox2);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmMain";
            Text = "Picomotor Stage Control";
            FormClosing += frmMain_FormClosing;
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
            groupBox12.ResumeLayout(false);
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDataCollectionRate).EndInit();
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel19.PerformLayout();
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            groupBox16.ResumeLayout(false);
            tableLayoutPanel23.ResumeLayout(false);
            tableLayoutPanel23.PerformLayout();
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlSpeed_um_s).EndInit();
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelZum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelYum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStageCtrlAbsRelXum).EndInit();
            groupBox20.ResumeLayout(false);
            tableLayoutPanel25.ResumeLayout(false);
            groupBox18.ResumeLayout(false);
            tableLayoutPanel24.ResumeLayout(false);
            tableLayoutPanel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsCalProbeWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsCalNoProbe).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsCalWithProbe).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsProbeDiameter_um).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndenterSettingsSpringConstant_N_m).EndInit();
            groupBox21.ResumeLayout(false);
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel26.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsDelay_ms).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsAccel_steps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsVel_steps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsDistance_um).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByPointsPoints).EndInit();
            groupBox22.ResumeLayout(false);
            groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByForceAccel_steps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByForceVel_steps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByForceEndForce_mg).EndInit();
            groupBox15.ResumeLayout(false);
            groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByDistanceAccel_steps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByDistanceVel_steps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIndentationCtrlSpringConstByDistanceDistance_um).EndInit();
            groupBox23.ResumeLayout(false);
            groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSampleDetailsStressRelaxationTime_ms).EndInit();
            groupBox24.ResumeLayout(false);
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
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem stripConnectStage;
        private ToolStripMenuItem stripConnectIndicator;
        private System.Windows.Forms.Timer tmrIndicatorDisplayUpdate;
        private System.Windows.Forms.Timer tmrMotorDisplayUpdate;
        private Label lblMotorSettingsEstNegAccel;
        private Label lblMotorSettingsEstNegVel;
        private System.Windows.Forms.Timer tmrPlotUpdate;
        private GroupBox groupBox16;
        private TableLayoutPanel tableLayoutPanel23;
        private Label label2;
        private Label lblIndenterDisplayForceN;
        private Label label12;
        private Label label18;
        private Label lblIndenterDisplayForcemg;
        private Label label22;
        private ToolStripMenuItem stripConnectMicroscopeStage;
        private ToolStripMenuItem stripConnectIndenter;
        private ToolStripMenuItem allToolStripMenuItem;
        private GroupBox groupBox17;
        private GroupBox groupBox18;
        private TableLayoutPanel tableLayoutPanel24;
        private NumericUpDown numIndenterSettingsCalNoProbe;
        private NumericUpDown numIndenterSettingsCalWithProbe;
        private Label label5;
        private Label label25;
        private Label label27;
        private Label label31;
        private GroupBox groupBox19;
        private Label label21;
        private Label label28;
        private Label label34;
        private Label label37;
        private NumericUpDown numStageCtrlAbsRelZum;
        private Label label39;
        private NumericUpDown numStageCtrlAbsRelYum;
        private Label label40;
        private NumericUpDown numStageCtrlAbsRelXum;
        private Button btnMicroscopeStageHome;
        private Button btnMicroscopeStageHalt;
        private GroupBox groupBox20;
        private TableLayoutPanel tableLayoutPanel25;
        private Button btnStageCtrlRunZUp;
        private Button btnStageCtrlRunZDown;
        private Button btnStageCtrlRunXRightYDown;
        private Button btnStageCtrlRunXRightYUp;
        private Button btnStageCtrlRunXLeftYDown;
        private Button btnStageCtrlRunXLeftYUp;
        private Button btnStageCtrlRunYDown;
        private Button btnStageCtrlRunYUp;
        private Button btnStageCtrlRunXRight;
        private Button btnStageCtrlRunXLeft;
        private Button numStageCtrlZGo;
        private Button numStageCtrlYGo;
        private Button numStageCtrlXGo;
        private Button numStageCtrlAllGo;
        private RadioButton radStageCtrlAbsolute;
        private RadioButton radStageCtrlRelative;
        private GroupBox groupBox21;
        private TableLayoutPanel tableLayoutPanel26;
        private Label label59;
        private Label lblMicroscopeStageDisplayZ_mm;
        private Label label63;
        private Label label43;
        private Label lblMicroscopeStageDisplayY_mm;
        private Label label49;
        private Label label51;
        private Label lblMicroscopeStageDisplayX_mm;
        private Label label55;
        private System.Windows.Forms.Timer tmrMicroscopeDisplayUpdate;
        private System.Windows.Forms.Timer tmrIndenterDisplayUpdate;
        private Label label54;
        private NumericUpDown numIndenterSettingsCalProbeWeight;
        private Label label46;
        private Button btnIndenterCalWithProbe;
        private Button btnIndenterSettingsCalNoProbe;
        private System.Windows.Forms.Timer tmrAverageIndenterValues;
        private CheckBox checkBox3;
        private Label label64;
        private Button btnStageCtrlSetSpeed;
        private NumericUpDown numStageCtrlSpeed_um_s;
        private Label label60;
        private ToolStripMenuItem openSequenceEditorToolStripMenuItem;
        private ToolStripMenuItem openPlotToolStripMenuItem;
        private ToolStripMenuItem openIndenterControlToolStripMenuItem;
        private GroupBox groupBox10;
        private GroupBox groupBox14;
        private Label label70;
        private NumericUpDown numIndentationCtrlSpringConstByPointsDelay_ms;
        private Label label71;
        private Label label69;
        private CheckBox chkIndentationCtrlSpringConstByPointsCreepUp;
        private Label label67;
        private NumericUpDown numIndentationCtrlSpringConstByPointsAccel_steps;
        private Label label68;
        private Label label66;
        private NumericUpDown numIndentationCtrlSpringConstByPointsVel_steps;
        private Label label65;
        private Label label15;
        private Label label9;
        private NumericUpDown numIndentationCtrlSpringConstByPointsDistance_um;
        private NumericUpDown numIndentationCtrlSpringConstByPointsPoints;
        private Button btnFindSpringConstByPoints;
        private GroupBox groupBox22;
        private Label label85;
        private Button btnFindSpringConstByForce;
        private Label label79;
        private NumericUpDown numIndentationCtrlSpringConstByForceAccel_steps;
        private Label label80;
        private Label label81;
        private NumericUpDown numIndentationCtrlSpringConstByForceVel_steps;
        private Label label82;
        private NumericUpDown numIndentationCtrlSpringConstByForceEndForce_mg;
        private Label label83;
        private GroupBox groupBox15;
        private Label label84;
        private Button btnFindSpringConstByDistance;
        private CheckBox chkIndentationCtrlSpringConstByDistanceCreepUp;
        private Label label73;
        private NumericUpDown numIndentationCtrlSpringConstByDistanceAccel_steps;
        private Label label74;
        private Label label75;
        private NumericUpDown numIndentationCtrlSpringConstByDistanceVel_steps;
        private Label label76;
        private NumericUpDown numIndentationCtrlSpringConstByDistanceDistance_um;
        private Label label72;
        private GroupBox groupBox23;
        private Button btnSampleDetailsSet;
        private Label label88;
        private Label label87;
        private Label label86;
        private TextBox txtSampleDetailsMeasurement;
        private TextBox txtSampleDetailsLocation;
        private TextBox txtSampleDetailsSampleName;
        private Button btnSampleDetailsSaveCollectedData;
        private Label label78;
        private Label label77;
        private NumericUpDown numSampleDetailsStressRelaxationTime_ms;
        private CheckBox chkSampleDetailsCollectStressRelaxation;
        private CheckBox chkSampleDetailsShowPlot;
        private Label lblSpringConstFlatModulus;
        private Label lblSpringConstFlat;
        private Button btnIndenterSettingsCalibrate;
        private Label label91;
        private NumericUpDown numIndenterSettingsProbeDiameter_um;
        private Label label92;
        private Label label93;
        private NumericUpDown numIndenterSettingsSpringConstant_N_m;
        private Label label94;
        private GroupBox groupBox24;
        private TableLayoutPanel tableLayoutPanel21;
        private Button btnHolderStageRunXRightYDown;
        private Button btnHolderStageRunXRightYUp;
        private Button btnHolderStageRunXLeftYDown;
        private Button btnHolderStageRunXLeftYUp;
        private Button btnHolderStageRunYDown;
        private Button btnHolderStageRunYUp;
        private Button btnHolderStageRunXRight;
        private Button btnHolderStageRunXLeft;
    }
}
