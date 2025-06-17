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
            label15 = new Label();
            btnPlotClear = new Button();
            numPlotInterval = new NumericUpDown();
            label9 = new Label();
            tmrPlotUpdate = new System.Windows.Forms.Timer(components);
            chkPlotViewIndicator = new CheckBox();
            chkPlotViewIndenterForce = new CheckBox();
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
            groupBox10.Size = new Size(207, 227);
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
            groupBox15.Size = new Size(195, 103);
            groupBox15.TabIndex = 7;
            groupBox15.TabStop = false;
            groupBox15.Text = "View";
            // 
            // tableLayoutPanel22
            // 
            tableLayoutPanel22.ColumnCount = 1;
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel22.Controls.Add(chkPlotViewIndenterForce, 0, 1);
            tableLayoutPanel22.Controls.Add(chkPlotViewIndicator, 0, 0);
            tableLayoutPanel22.Dock = DockStyle.Fill;
            tableLayoutPanel22.Location = new Point(3, 24);
            tableLayoutPanel22.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.RowCount = 2;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel22.Size = new Size(189, 75);
            tableLayoutPanel22.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(171, 156);
            label15.Name = "label15";
            label15.Size = new Size(28, 20);
            label15.TabIndex = 3;
            label15.Text = "ms";
            // 
            // btnPlotClear
            // 
            btnPlotClear.Location = new Point(6, 189);
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
            numPlotInterval.Location = new Point(6, 154);
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
            label9.Location = new Point(6, 130);
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
            // chkPlotViewIndicator
            // 
            chkPlotViewIndicator.AutoSize = true;
            chkPlotViewIndicator.Checked = true;
            chkPlotViewIndicator.CheckState = CheckState.Checked;
            chkPlotViewIndicator.Dock = DockStyle.Fill;
            chkPlotViewIndicator.Location = new Point(3, 4);
            chkPlotViewIndicator.Margin = new Padding(3, 4, 3, 4);
            chkPlotViewIndicator.Name = "chkPlotViewIndicator";
            chkPlotViewIndicator.Size = new Size(183, 29);
            chkPlotViewIndicator.TabIndex = 9;
            chkPlotViewIndicator.Text = "Indicator (um)";
            chkPlotViewIndicator.UseVisualStyleBackColor = true;
            // 
            // chkPlotViewIndenterForce
            // 
            chkPlotViewIndenterForce.AutoSize = true;
            chkPlotViewIndenterForce.Checked = true;
            chkPlotViewIndenterForce.CheckState = CheckState.Checked;
            chkPlotViewIndenterForce.Dock = DockStyle.Fill;
            chkPlotViewIndenterForce.Location = new Point(3, 41);
            chkPlotViewIndenterForce.Margin = new Padding(3, 4, 3, 4);
            chkPlotViewIndenterForce.Name = "chkPlotViewIndenterForce";
            chkPlotViewIndenterForce.Size = new Size(183, 30);
            chkPlotViewIndenterForce.TabIndex = 10;
            chkPlotViewIndenterForce.Text = "Indenter Force (mg)";
            chkPlotViewIndenterForce.UseVisualStyleBackColor = true;
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
        private Label label15;
        private Button btnPlotClear;
        private NumericUpDown numPlotInterval;
        private Label label9;
        public ScottPlot.WinForms.FormsPlot Plot;
        private System.Windows.Forms.Timer tmrPlotUpdate;
        private CheckBox chkPlotViewIndenterForce;
        private CheckBox chkPlotViewIndicator;
    }
}