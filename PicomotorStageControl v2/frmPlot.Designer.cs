namespace PicomotorStageControl_v2
{
    partial class frmPlot
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
            Plot = new ScottPlot.WinForms.FormsPlot();
            groupBox10 = new GroupBox();
            groupBox15 = new GroupBox();
            tableLayoutPanel22 = new TableLayoutPanel();
            chkPlotViewIndicator = new CheckBox();
            chkPlotViewMotorSteps = new CheckBox();
            chkPlotViewMotorCalibration = new CheckBox();
            chkPlotViewIndenterForce = new CheckBox();
            label15 = new Label();
            btnPlotClear = new Button();
            numPlotInterval = new NumericUpDown();
            label9 = new Label();
            tmrPlotUpdate = new System.Windows.Forms.Timer(components);
            groupBox10.SuspendLayout();
            groupBox15.SuspendLayout();
            tableLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlotInterval).BeginInit();
            SuspendLayout();
            // 
            // Plot
            // 
            Plot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Plot.DisplayScale = 1.25F;
            Plot.Location = new Point(225, 12);
            Plot.Name = "Plot";
            Plot.Size = new Size(1034, 926);
            Plot.TabIndex = 16;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(groupBox15);
            groupBox10.Controls.Add(label15);
            groupBox10.Controls.Add(btnPlotClear);
            groupBox10.Controls.Add(numPlotInterval);
            groupBox10.Controls.Add(label9);
            groupBox10.Location = new Point(12, 12);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(207, 276);
            groupBox10.TabIndex = 15;
            groupBox10.TabStop = false;
            groupBox10.Text = "Plot Settings";
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(tableLayoutPanel22);
            groupBox15.Location = new Point(6, 23);
            groupBox15.Margin = new Padding(3, 4, 3, 4);
            groupBox15.Name = "groupBox15";
            groupBox15.Padding = new Padding(3, 4, 3, 4);
            groupBox15.Size = new Size(195, 149);
            groupBox15.TabIndex = 7;
            groupBox15.TabStop = false;
            groupBox15.Text = "View";
            // 
            // tableLayoutPanel22
            // 
            tableLayoutPanel22.ColumnCount = 1;
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel22.Controls.Add(chkPlotViewIndicator, 0, 2);
            tableLayoutPanel22.Controls.Add(chkPlotViewMotorSteps, 0, 0);
            tableLayoutPanel22.Controls.Add(chkPlotViewMotorCalibration, 0, 1);
            tableLayoutPanel22.Controls.Add(chkPlotViewIndenterForce, 0, 3);
            tableLayoutPanel22.Dock = DockStyle.Fill;
            tableLayoutPanel22.Location = new Point(3, 24);
            tableLayoutPanel22.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.RowCount = 4;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel22.Size = new Size(189, 121);
            tableLayoutPanel22.TabIndex = 0;
            // 
            // chkPlotViewIndicator
            // 
            chkPlotViewIndicator.AutoSize = true;
            chkPlotViewIndicator.Checked = true;
            chkPlotViewIndicator.CheckState = CheckState.Checked;
            chkPlotViewIndicator.Dock = DockStyle.Fill;
            chkPlotViewIndicator.Location = new Point(3, 64);
            chkPlotViewIndicator.Margin = new Padding(3, 4, 3, 4);
            chkPlotViewIndicator.Name = "chkPlotViewIndicator";
            chkPlotViewIndicator.Size = new Size(184, 22);
            chkPlotViewIndicator.TabIndex = 6;
            chkPlotViewIndicator.Text = "Indicator (um)";
            chkPlotViewIndicator.UseVisualStyleBackColor = true;
            chkPlotViewIndicator.CheckedChanged += chkPlotViewIndicator_CheckedChanged;
            // 
            // chkPlotViewMotorSteps
            // 
            chkPlotViewMotorSteps.AutoSize = true;
            chkPlotViewMotorSteps.Checked = true;
            chkPlotViewMotorSteps.CheckState = CheckState.Checked;
            chkPlotViewMotorSteps.Dock = DockStyle.Fill;
            chkPlotViewMotorSteps.Location = new Point(3, 4);
            chkPlotViewMotorSteps.Margin = new Padding(3, 4, 3, 4);
            chkPlotViewMotorSteps.Name = "chkPlotViewMotorSteps";
            chkPlotViewMotorSteps.Size = new Size(184, 22);
            chkPlotViewMotorSteps.TabIndex = 4;
            chkPlotViewMotorSteps.Text = "Motor Steps (steps)";
            chkPlotViewMotorSteps.UseVisualStyleBackColor = true;
            chkPlotViewMotorSteps.CheckedChanged += chkPlotViewMotorSteps_CheckedChanged;
            // 
            // chkPlotViewMotorCalibration
            // 
            chkPlotViewMotorCalibration.AutoSize = true;
            chkPlotViewMotorCalibration.Checked = true;
            chkPlotViewMotorCalibration.CheckState = CheckState.Checked;
            chkPlotViewMotorCalibration.Dock = DockStyle.Fill;
            chkPlotViewMotorCalibration.Location = new Point(3, 34);
            chkPlotViewMotorCalibration.Margin = new Padding(3, 4, 3, 4);
            chkPlotViewMotorCalibration.Name = "chkPlotViewMotorCalibration";
            chkPlotViewMotorCalibration.Size = new Size(184, 22);
            chkPlotViewMotorCalibration.TabIndex = 5;
            chkPlotViewMotorCalibration.Text = "Motor Calibration (um)";
            chkPlotViewMotorCalibration.UseVisualStyleBackColor = true;
            chkPlotViewMotorCalibration.CheckedChanged += chkPlotViewMotorCalibration_CheckedChanged;
            // 
            // chkPlotViewIndenterForce
            // 
            chkPlotViewIndenterForce.AutoSize = true;
            chkPlotViewIndenterForce.Checked = true;
            chkPlotViewIndenterForce.CheckState = CheckState.Checked;
            chkPlotViewIndenterForce.Dock = DockStyle.Fill;
            chkPlotViewIndenterForce.Location = new Point(3, 94);
            chkPlotViewIndenterForce.Margin = new Padding(3, 4, 3, 4);
            chkPlotViewIndenterForce.Name = "chkPlotViewIndenterForce";
            chkPlotViewIndenterForce.Size = new Size(184, 23);
            chkPlotViewIndenterForce.TabIndex = 8;
            chkPlotViewIndenterForce.Text = "Indenter Force (mg)";
            chkPlotViewIndenterForce.UseVisualStyleBackColor = true;
            chkPlotViewIndenterForce.CheckedChanged += chkPlotViewIndenterForce_CheckedChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(171, 202);
            label15.Name = "label15";
            label15.Size = new Size(28, 20);
            label15.TabIndex = 3;
            label15.Text = "ms";
            // 
            // btnPlotClear
            // 
            btnPlotClear.Location = new Point(6, 235);
            btnPlotClear.Margin = new Padding(3, 4, 3, 4);
            btnPlotClear.Name = "btnPlotClear";
            btnPlotClear.Size = new Size(195, 31);
            btnPlotClear.TabIndex = 2;
            btnPlotClear.Text = "Clear Plot";
            btnPlotClear.UseVisualStyleBackColor = true;
            btnPlotClear.Click += btnPlotClear_Click;
            // 
            // numPlotInterval
            // 
            numPlotInterval.Location = new Point(6, 200);
            numPlotInterval.Margin = new Padding(3, 4, 3, 4);
            numPlotInterval.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            numPlotInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlotInterval.Name = "numPlotInterval";
            numPlotInterval.Size = new Size(159, 27);
            numPlotInterval.TabIndex = 1;
            numPlotInterval.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numPlotInterval.ValueChanged += numPlotInterval_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 176);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 0;
            label9.Text = "Plot Interval:";
            // 
            // tmrPlotUpdate
            // 
            tmrPlotUpdate.Interval = 10;
            tmrPlotUpdate.Tick += tmrPlotUpdate_Tick;
            // 
            // frmPlot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 950);
            Controls.Add(Plot);
            Controls.Add(groupBox10);
            Name = "frmPlot";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Picomotor Stage Control - Plot";
            Load += frmPlot_Load;
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox15.ResumeLayout(false);
            tableLayoutPanel22.ResumeLayout(false);
            tableLayoutPanel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPlotInterval).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox10;
        private GroupBox groupBox15;
        private TableLayoutPanel tableLayoutPanel22;
        private CheckBox chkPlotViewIndicator;
        private CheckBox chkPlotViewMotorSteps;
        private CheckBox chkPlotViewMotorCalibration;
        private Label label15;
        private Button btnPlotClear;
        private NumericUpDown numPlotInterval;
        private Label label9;
        private CheckBox chkPlotViewIndenterForce;
        public ScottPlot.WinForms.FormsPlot Plot;
        private System.Windows.Forms.Timer tmrPlotUpdate;
    }
}