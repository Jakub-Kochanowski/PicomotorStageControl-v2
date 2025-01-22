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
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAvgPosStepSizeUm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAvgNegStepSizeUm).BeginInit();
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
            btnCancel.Location = new Point(302, 183);
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
            btnApply.Location = new Point(202, 183);
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
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 224);
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
    }
}