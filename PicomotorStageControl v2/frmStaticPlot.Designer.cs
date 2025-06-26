namespace PicomotorStageControl_v2
{
    partial class frmStaticPlot
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
            Plot = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // Plot
            // 
            Plot.DisplayScale = 1.25F;
            Plot.Dock = DockStyle.Fill;
            Plot.Location = new Point(0, 0);
            Plot.Name = "Plot";
            Plot.Size = new Size(758, 705);
            Plot.TabIndex = 0;
            // 
            // frmStaticPlot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 705);
            Controls.Add(Plot);
            Name = "frmStaticPlot";
            Text = "Plot";
            Load += frmStaticPlot_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot Plot;
    }
}