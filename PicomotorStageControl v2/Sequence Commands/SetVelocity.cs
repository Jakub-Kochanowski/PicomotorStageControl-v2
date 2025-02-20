﻿using PicomotorStageControl_v2.SequenceCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class SetVelocity : Command
    {
        frmMain MainForm;
        public int Velocity_steps_s { get; private set; }

        public SetVelocity(frmMain mainForm, int velocity_steps_s) : base()
        {
            this.MainForm = mainForm;
            this.Type = CommandTypes.SetVelocity;
            this.Velocity_steps_s = velocity_steps_s;
            this.DisplayText = "Set Velocity To " + velocity_steps_s.ToString() + " steps/s";
            this.LogMessage = "Set Velocity To: " + velocity_steps_s.ToString() + " steps/s";
        }

        public override void Execute()
        {
            if (this.MainForm.Motor == null)
            {
                return;
            }

            this.Running = true;
            this.MainForm.Motor.SetVelocity(this.Velocity_steps_s);
            this.Running = false;
        }
    }
}
