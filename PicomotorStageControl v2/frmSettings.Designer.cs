namespace PicomotorStageControl_v2
{
    partial class frmSettings
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbIndicatorPorts = new ComboBox();
            label1 = new Label();
            btnCancel = new Button();
            btnApply = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            numAvgPosStepSizeUm = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            numAvgNegStepSizeUm = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            numStageMovementSlowDownVelocity = new NumericUpDown();
            label7 = new Label();
            numStageMovementSlowDownDistance = new NumericUpDown();
            label6 = new Label();
            chkStageMovementCreepUp = new CheckBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAvgPosStepSizeUm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAvgNegStepSizeUm).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStageMovementSlowDownVelocity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStageMovementSlowDownDistance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indicator";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cmbIndicatorPorts, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(381, 35);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // cmbIndicatorPorts
            // 
            cmbIndicatorPorts.Dock = DockStyle.Fill;
            cmbIndicatorPorts.FormattingEnabled = true;
            cmbIndicatorPorts.Location = new Point(84, 3);
            cmbIndicatorPorts.Name = "cmbIndicatorPorts";
            cmbIndicatorPorts.Size = new Size(294, 28);
            cmbIndicatorPorts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 35);
            label1.TabIndex = 1;
            label1.Text = "COM Port:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(302, 308);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApply.Location = new Point(202, 308);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(94, 29);
            btnApply.TabIndex = 3;
            btnApply.Text = "&Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(11, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 92);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Calibration";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(numAvgPosStepSizeUm, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(numAvgNegStepSizeUm, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 2, 0);
            tableLayoutPanel2.Controls.Add(label5, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(381, 66);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // numAvgPosStepSizeUm
            // 
            numAvgPosStepSizeUm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numAvgPosStepSizeUm.DecimalPlaces = 5;
            numAvgPosStepSizeUm.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            numAvgPosStepSizeUm.Location = new Point(179, 36);
            numAvgPosStepSizeUm.Name = "numAvgPosStepSizeUm";
            numAvgPosStepSizeUm.Size = new Size(163, 27);
            numAvgPosStepSizeUm.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(170, 33);
            label3.TabIndex = 5;
            label3.Text = "Avg. Positive Step Size:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 33);
            label2.TabIndex = 4;
            label2.Text = "Avg. Negative Step Size:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numAvgNegStepSizeUm
            // 
            numAvgNegStepSizeUm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numAvgNegStepSizeUm.DecimalPlaces = 5;
            numAvgNegStepSizeUm.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            numAvgNegStepSizeUm.Location = new Point(179, 3);
            numAvgNegStepSizeUm.Name = "numAvgNegStepSizeUm";
            numAvgNegStepSizeUm.Size = new Size(163, 27);
            numAvgNegStepSizeUm.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(348, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 33);
            label4.TabIndex = 7;
            label4.Text = "um";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(348, 33);
            label5.Name = "label5";
            label5.Size = new Size(30, 33);
            label5.TabIndex = 8;
            label5.Text = "um";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(numStageMovementSlowDownVelocity);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(numStageMovementSlowDownDistance);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(chkStageMovementCreepUp);
            groupBox3.Location = new Point(14, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 125);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Stage Movement";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(323, 86);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 6;
            label9.Text = "steps/s";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 53);
            label8.Name = "label8";
            label8.Size = new Size(30, 20);
            label8.TabIndex = 5;
            label8.Text = "um";
            // 
            // numStageMovementSlowDownVelocity
            // 
            numStageMovementSlowDownVelocity.Enabled = false;
            numStageMovementSlowDownVelocity.Location = new Point(159, 84);
            numStageMovementSlowDownVelocity.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numStageMovementSlowDownVelocity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numStageMovementSlowDownVelocity.Name = "numStageMovementSlowDownVelocity";
            numStageMovementSlowDownVelocity.Size = new Size(158, 27);
            numStageMovementSlowDownVelocity.TabIndex = 4;
            numStageMovementSlowDownVelocity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 86);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 3;
            label7.Text = "Slow-Down Velocity:";
            // 
            // numStageMovementSlowDownDistance
            // 
            numStageMovementSlowDownDistance.Enabled = false;
            numStageMovementSlowDownDistance.Location = new Point(159, 51);
            numStageMovementSlowDownDistance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numStageMovementSlowDownDistance.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numStageMovementSlowDownDistance.Name = "numStageMovementSlowDownDistance";
            numStageMovementSlowDownDistance.Size = new Size(183, 27);
            numStageMovementSlowDownDistance.TabIndex = 2;
            numStageMovementSlowDownDistance.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 53);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 1;
            label6.Text = "Slow-Down Distance:";
            // 
            // chkStageMovementCreepUp
            // 
            chkStageMovementCreepUp.AutoSize = true;
            chkStageMovementCreepUp.Location = new Point(6, 26);
            chkStageMovementCreepUp.Name = "chkStageMovementCreepUp";
            chkStageMovementCreepUp.Size = new Size(200, 24);
            chkStageMovementCreepUp.TabIndex = 0;
            chkStageMovementCreepUp.Text = "Creep up to final position";
            chkStageMovementCreepUp.UseVisualStyleBackColor = true;
            chkStageMovementCreepUp.CheckedChanged += chkStageMovementCreepUp_CheckedChanged;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 349);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Name = "frmSettings";
            Text = "Picomotor Stage Control - Settings";
            Load += frmSettings_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAvgPosStepSizeUm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAvgNegStepSizeUm).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStageMovementSlowDownVelocity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStageMovementSlowDownDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbIndicatorPorts;
        private Label label1;
        private Button btnCancel;
        private Button btnApply;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown numAvgPosStepSizeUm;
        private Label label3;
        private Label label2;
        private NumericUpDown numAvgNegStepSizeUm;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private NumericUpDown numStageMovementSlowDownVelocity;
        private Label label7;
        private NumericUpDown numStageMovementSlowDownDistance;
        private Label label6;
        private CheckBox chkStageMovementCreepUp;
        private Label label9;
        private Label label8;
    }
}