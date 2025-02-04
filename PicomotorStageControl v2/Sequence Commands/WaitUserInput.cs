using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class WaitUserInput : Command
    {
        public WaitUserInput() : base()
        {
            this.Type = CommandTypes.WaitUserInput;
            this.DisplayText = "Wait For User Input";
            this.LogMessage = "Obtained User Input";
        }

        public override void Execute()
        {
            this.Running = true;
            this.Progress = "Waiting for user input";
            MessageBox.Show("Press OK to continue.", "Wait (User Input)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Running = false;
        }
    }
}