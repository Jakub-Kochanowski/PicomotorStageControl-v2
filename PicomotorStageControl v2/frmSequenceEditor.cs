﻿using PicomotorStageControl_v2.SequenceCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace PicomotorStageControl_v2
{
    public partial class frmSequenceEditor : Form
    {
        // Is this the best data structure?
        ObservableCollection<Command> Commands = new ObservableCollection<Command>();

        BackgroundWorker SequenceBackgroundWorker = new BackgroundWorker();
        public bool SequenceRunning { get; private set; } = false;

        public frmSequenceEditor()
        {
            InitializeComponent();
            Commands.CollectionChanged += Commands_CollectionChanged;
            SequenceBackgroundWorker.WorkerReportsProgress = true;
            SequenceBackgroundWorker.WorkerSupportsCancellation = true;
            SequenceBackgroundWorker.DoWork += SequenceBackgroundWorker_DoWork;
        }

        private void btnCmdTimeWait_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBox) != null)
                return;

            frmNumericInputBox numInput = new("Time (Wait)", "Time (ms)", 0.0M, Decimal.MaxValue, 1M);
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.WaitTime wt = new(numInput.Value);
                Commands.Add(wt);
            }
        }

        private void btnMngMoveUp_Click(object sender, EventArgs e)
        {
            if (lstCommands.SelectedIndices.Count > 1 || lstCommands.SelectedIndices.Count == 0)
                return;

            int selectedIndex = lstCommands.SelectedIndices[0]; // TO DO: Allow for several items to be selected

            if (selectedIndex == 0)
                return;

            Commands.Move(selectedIndex, selectedIndex - 1);
            lstCommands.SelectedIndices.Clear();
            lstCommands.SelectedIndices.Add(selectedIndex - 1);
        }

        private void btnMngMoveDown_Click(object sender, EventArgs e)
        {
            if (lstCommands.SelectedIndices.Count > 1 || lstCommands.SelectedIndices.Count == 0)
                return;

            int selectedIndex = lstCommands.SelectedIndices[0];

            if (selectedIndex == lstCommands.Items.Count - 1)
                return;

            Commands.Move(selectedIndex, selectedIndex + 1);

            lstCommands.SelectedIndices.Clear();
            lstCommands.SelectedIndices.Add(selectedIndex + 1);
        }

        private void btnMngClear_Click(object sender, EventArgs e)
        {
            Commands.Clear();
        }

        private void UpdateCommandList()
        {
            lstCommands.Items.Clear();
            foreach (Command cmd in Commands)
            {
                lstCommands.Items.Add(cmd.DisplayText);
                if (cmd.Enabled == false)
                {
                    lstCommands.Items[lstCommands.Items.Count - 1].ForeColor = Color.Red;
                }
            }
        }

        private void Commands_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdateCommandList();
        }

        private void btnMngDeleteItem_Click(object sender, EventArgs e)
        {
            if (lstCommands.SelectedIndices.Count > 1 || lstCommands.SelectedIndices.Count == 0)
                return;

            int selectedIndex = lstCommands.SelectedIndices[0];

            Commands.RemoveAt(lstCommands.SelectedIndices[0]);
        }

        private void btnMngEnableItem_Click(object sender, EventArgs e)
        {
            if (lstCommands.SelectedIndices.Count > 1 || lstCommands.SelectedIndices.Count == 0)
                return;

            int selectedIndex = lstCommands.SelectedIndices[0];

            Commands[selectedIndex].Enable();
            this.UpdateCommandList();
            lstCommands.SelectedIndices.Add(selectedIndex);
        }

        private void btnMngDisableItem_Click(object sender, EventArgs e)
        {
            if (lstCommands.SelectedIndices.Count > 1 || lstCommands.SelectedIndices.Count == 0)
                return;

            int selectedIndex = lstCommands.SelectedIndices[0];

            Commands[selectedIndex].Disable();
            this.UpdateCommandList();
            lstCommands.SelectedIndices.Add(selectedIndex);
        }

        private void btnCmdMoveDistance_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBox) != null)
                return;

            frmNumericInputBox numInput = new("Move Distance", "Distance (um)", Decimal.MinValue, Decimal.MaxValue, 0.0005M);
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.MoveDistance md = new(numInput.Value);
                Commands.Add(md);
            }
        }

        private void btnCmdMoveTo_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBox) != null)
                return;

            frmNumericInputBox numInput = new("Move To", "Position (um)", Decimal.MinValue, Decimal.MaxValue, 0.0005M);
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.MoveTo mt = new(numInput.Value);
                Commands.Add(mt);
            }
        }

        private void btnCmdSetVelocity_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBox) != null)
                return;

            frmNumericInputBox numInput = new("Set Velocity", "Velocity (steps/s)", 0, Decimal.MaxValue, 1M); // TO DO: Find Max Value
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.SetVelocity sv = new(numInput.Value);
                Commands.Add(sv);
            }
        }

        private void btnCmdSetAcceleration_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBox) != null)
                return;

            frmNumericInputBox numInput = new("Set Acceleration", "Acceleration (steps/s^2)", 0, Decimal.MaxValue, 1M); // TO DO: Find Max Value
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.SetAcceleration sa = new(numInput.Value);
                Commands.Add(sa);
            }
        }

        private void btnCmdTimeUser_Click(object sender, EventArgs e)
        {
            SequenceCommands.WaitUserInput wui = new();
            Commands.Add(wui);
        }

        private void btnCmdStartDataCollection_Click(object sender, EventArgs e)
        {
            SequenceCommands.StartDataCollection sdc = new();
            Commands.Add(sdc);
        }

        private void btnCmdStopDataCollection_Click(object sender, EventArgs e)
        {
            SequenceCommands.StopDataCollection sdc = new();
            Commands.Add(sdc);
        }

        private void btnRunPause_Click(object sender, EventArgs e)
        {
            if (!SequenceRunning)
            {
                SequenceRunning = true;
                SequenceBackgroundWorker.RunWorkerAsync();
                statusScriptRunStatus.Text = "Running";
            }
        }

        private void SequenceBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            while (SequenceRunning)
            {
                foreach (Command cmd in Commands)
                {
                    this.Invoke(delegate
                    {
                        int currentIndex = Commands.IndexOf(cmd);
                        this.lstCommands.Items[currentIndex].BackColor = Color.Green;
                        if (currentIndex > 0)
                        {
                            this.lstCommands.Items[currentIndex - 1].BackColor = Color.Transparent;
                        }
                        this.statusCurrentTask.Text = cmd.DisplayText;
                    });



                    cmd.Execute();
                    while (cmd.Running == true)
                    {
                        this.Invoke(delegate
                        {
                            this.statusCurrentTask.Text = cmd.DisplayText + " (" + cmd.Progress + ")";
                        });

                        if (!SequenceRunning)
                        {
                            cmd.Stop();
                        }
                        Thread.Yield();
                    }



                }
                this.Invoke(delegate
                {
                    this.lstCommands.Items[lstCommands.Items.Count - 1].BackColor = Color.Transparent;
                });
                this.SequenceRunning = false;
            }
            this.Invoke(delegate
            {
                this.statusCurrentTask.Text = "N/A";
                this.statusScriptRunStatus.Text = "Complete";
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.SequenceRunning = false;
        }
    }
}
