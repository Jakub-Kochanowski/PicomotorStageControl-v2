using PicomotorStageControl_v2.SequenceCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class SetAcceleration : Command
    {
        private frmMain MainForm;
        public int Acceleration_steps_s2 { get; private set; }

        public SetAcceleration(frmMain mainForm, int velocity_steps_s2) : base()
        {
            this.MainForm = mainForm;
            this.Type = CommandTypes.SetAcceleration;
            this.Acceleration_steps_s2 = velocity_steps_s2;
            this.DisplayText = "Set Acceleration To " + velocity_steps_s2.ToString() + " steps/s^2";
            this.LogMessage = "Set Acceleration To: " + velocity_steps_s2.ToString() + " steps/s^2";
        }

        public override void Execute()
        {
            if (this.MainForm.Motor == null)
            {
                return;
            }

            this.Running = true;
            this.MainForm.Motor.SetAcceleration(this.Acceleration_steps_s2);
            this.Running = false;
        }
    }
}
