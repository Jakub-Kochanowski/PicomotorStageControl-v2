using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class StartDataCollection : Command
    {
        private frmMain MainForm;

        public StartDataCollection(frmMain mainForm) : base()
        {
            this.MainForm = mainForm;
            this.Type = CommandTypes.StartDataCollection;
            this.DisplayText = "Start Data Collection";
            this.LogMessage = "Start Data Collection";
        }

        public override void Execute()
        {
            this.MainForm.StartDataCollection(false);
        }
    }
}
