using PicomotorStageControl_v2.SequenceCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class SetDataDirectory : Command
    {
        frmMain MainForm;
        public string DataDirectory { get; private set; } = "";

        public SetDataDirectory(frmMain mainForm, string dataDirectory) : base()
        {
            this.MainForm = mainForm;
            this.Type = CommandTypes.SetDataDirectory;
            this.DataDirectory = dataDirectory;
            this.DisplayText = "Set Data Collection Directory To " + DataDirectory;
            this.LogMessage = "Set Data Collection Directory To " + DataDirectory;
        }

        public override void Execute()
        {
            this.MainForm.SetDataDirectory(this.DataDirectory);
        }
    }
}
