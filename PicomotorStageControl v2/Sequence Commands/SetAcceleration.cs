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
        public decimal Acceleration_steps_s2 { get; private set; }

        public SetAcceleration(decimal velocity_steps_s2) : base()
        {
            this.Type = CommandTypes.SetAcceleration;
            this.Acceleration_steps_s2 = velocity_steps_s2;
            this.DisplayText = "Set Acceleration To " + velocity_steps_s2.ToString() + " steps/s^2";
        }

        public override void Execute()
        {

        }
    }
}
