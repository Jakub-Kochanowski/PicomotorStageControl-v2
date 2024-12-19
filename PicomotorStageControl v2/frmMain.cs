using NewFocus.Picomotor;

namespace PicomotorStageControl_v2
{
    public partial class frmMain : Form
    {
        public CmdLib8742 StageCMD;
        public string DeviceID { get; private set; }
        public Motor Motor { get; private set; } // Bad name?

        public Indicator Indicator { get; private set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmAbout"] as frmAbout) != null)
                return;

            frmAbout calibrationForm = new frmAbout();
            calibrationForm.Show();
        }

        private void btnOpenSequenceEditor_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmSequenceEditor"] as frmSequenceEditor) != null)
                return;

            frmSequenceEditor calibrationForm = new frmSequenceEditor();
            calibrationForm.Show();
        }

        private void btnConnectIndicator_Click(object sender, EventArgs e)
        {
            if (!Indicator.Connected)
            {
                Indicator = new Indicator("COM15"); // TO DO: Set from settings
                Indicator.Connect();
                btnConnectIndicator.Text = "Disconnect Indicator";
                statusIndicatorConnected.Text = "Connected";
            }
        }
    }
}
