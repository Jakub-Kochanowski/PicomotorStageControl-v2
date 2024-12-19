using ScottPlot.Rendering.RenderActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    public abstract class Command
    {
        public CommandTypes Type { get; protected set; }
        public string DisplayText { get; protected set; } = string.Empty;
        public bool Enabled { get; protected set; } = true;
        public string Progress { get; protected set; } = string.Empty; // TODO: Figure out if to use virtual or not.
        public bool Running { get; protected set; } = false;

        public Command()
        {

        }

        public virtual void Execute() { }

        public virtual void Stop() { }

        public void Enable()
        {
            this.Enabled = true;
        }

        public void Disable() 
        {
            this.Enabled = false; 
        }
    }
}
