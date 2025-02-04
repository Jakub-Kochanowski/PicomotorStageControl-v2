namespace PicomotorStageControl_v2
{
    partial class frmNumericInputBoxReference
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
            btnOK = new Button();
            btnCancel = new Button();
            numValue = new NumericUpDown();
            lblDescription = new Label();
            cmbReference = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numValue).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(234, 65);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(334, 65);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // numValue
            // 
            numValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numValue.Location = new Point(12, 32);
            numValue.Name = "numValue";
            numValue.Size = new Size(273, 27);
            numValue.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 9);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(43, 20);
            lblDescription.TabIndex = 100;
            lblDescription.Text = "Input";
            // 
            // cmbReference
            // 
            cmbReference.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbReference.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReference.FormattingEnabled = true;
            cmbReference.Items.AddRange(new object[] { "um (Indicator)", "Steps", "um (Calibration)" });
            cmbReference.Location = new Point(291, 31);
            cmbReference.Name = "cmbReference";
            cmbReference.Size = new Size(137, 28);
            cmbReference.TabIndex = 101;
            // 
            // frmNumericInputBox
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(440, 106);
            Controls.Add(cmbReference);
            Controls.Add(lblDescription);
            Controls.Add(numValue);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNumericInputBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Input";
            Load += frmNumericInputBox_Load;
            ((System.ComponentModel.ISupportInitialize)numValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private NumericUpDown numValue;
        private Label lblDescription;
        private ComboBox cmbReference;
    }
}