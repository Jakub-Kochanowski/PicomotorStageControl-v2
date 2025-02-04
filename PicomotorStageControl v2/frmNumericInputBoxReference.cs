using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicomotorStageControl_v2
{
    public partial class frmNumericInputBoxReference : Form
    {
        public decimal Value { get; private set; } = 0.0M;
        public MovementReferenceType MovementReference { get; private set; }
        public frmNumericInputBoxReference(string title, string label, decimal minValue, decimal maxValue, decimal numIncrement, MovementReferenceType defaultReference)
        {
            InitializeComponent();
            this.Text = title;
            this.lblDescription.Text = label;
            this.MovementReference = defaultReference;
            this.numValue.Minimum = minValue;
            this.numValue.Maximum = maxValue;
            this.numValue.Increment = numIncrement;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Value = numValue.Value;

            if (cmbReference.Text == "um (Indicator)")
            {
                this.MovementReference = MovementReferenceType.Indicator;
            }
            else if (cmbReference.Text == "Steps")
            {
                this.MovementReference = MovementReferenceType.Steps;
            }
            else if (cmbReference.Text == "um (Calibration)")
            {
                this.MovementReference = MovementReferenceType.Calibration;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmNumericInputBox_Load(object sender, EventArgs e)
        {
            if (this.MovementReference == MovementReferenceType.Steps)
            {
                cmbReference.Text = "Steps";
            }
            else if (this.MovementReference == MovementReferenceType.Calibration)
            {
                cmbReference.Text = "um (Calibration)";
            }
            else if (this.MovementReference == MovementReferenceType.Indicator)
            {
                cmbReference.Text = "um (Indicator)";
            }

            numValue.Select(0, numValue.Text.Length);
        }
    }
}
