using PicomotorStageControl_v2.SequenceCommands;
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
        public bool SequenceRunning { get; set; } = false;
        public bool StopSequence { get; set; } = false;
        frmMain MainForm;

        public frmSequenceEditor(frmMain mainForm)
        {
            InitializeComponent();

            this.MainForm = mainForm;

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
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBoxReference) != null)
                return;

            frmNumericInputBoxReference numInput = new("Move Distance", "Distance (um)", Decimal.MinValue, Decimal.MaxValue, 0.0005M, this.MainForm.MovementReference);
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.MoveDistance md = new(this.MainForm, numInput.Value, numInput.MovementReference);
                Commands.Add(md);
            }
        }

        private void btnCmdMoveTo_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBoxReference) != null)
                return;

            frmNumericInputBoxReference numInput = new("Move To", "Position (um)", Decimal.MinValue, Decimal.MaxValue, 0.0005M, this.MainForm.MovementReference);
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.MoveTo mt = new(this.MainForm, numInput.Value, numInput.MovementReference);
                Commands.Add(mt);
            }
        }

        private void btnCmdSetVelocity_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBoxReference) != null)
                return;

            // TO DO: CREATE A NEW NUMERIC INPUT FORM WITHOUT MOVEMENT REFERENCE.
            frmNumericInputBox numInput = new("Set Velocity", "Velocity (steps/s)", 0, Decimal.MaxValue, 1M); // TO DO: Find Max Value
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.SetVelocity sv = new(this.MainForm, (int)numInput.Value);
                Commands.Add(sv);
            }
        }

        private void btnCmdSetAcceleration_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNumericInputBox"] as frmNumericInputBoxReference) != null)
                return;

            frmNumericInputBox numInput = new("Set Acceleration", "Acceleration (steps/s^2)", 0, Decimal.MaxValue, 1M); // TO DO: Find Max Value
            numInput.ShowDialog();

            if (numInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.SetAcceleration sa = new(this.MainForm, (int)numInput.Value);
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
            SequenceCommands.StartDataCollection sdc = new StartDataCollection(this.MainForm);
            Commands.Add(sdc);
        }

        private void btnCmdStopDataCollection_Click(object sender, EventArgs e)
        {
            SequenceCommands.StopDataCollection sdc = new StopDataCollection(this.MainForm);
            Commands.Add(sdc);
        }

        private void btnRunPause_Click(object sender, EventArgs e)
        {
            if (!SequenceRunning)
            {
                DisableAllControlButtons();

                btnRun.Enabled = false;
                btnStop.Enabled = true;

                StopSequence = false;
                SequenceRunning = true;
                SequenceBackgroundWorker.RunWorkerAsync();
                statusScriptRunStatus.Text = "Running";
            }
        }

        private void SequenceBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            foreach (Command cmd in Commands)
            {
                this.MainForm.IsSequenceRunning = this.SequenceRunning; // TO DO: Is this the best place to put it?

                if (StopSequence)
                {
                    cmd.Stop();
                    SequenceRunning = false;
                    break;
                }
                if (SequenceRunning == false)
                {
                    break;
                }

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
                    System.Diagnostics.Debug.WriteLine(cmd.DisplayText);
                    if (StopSequence)
                    {
                        cmd.Stop();
                    }
                    Thread.Yield();
                }

                this.Invoke(delegate
                {
                    this.txtLog.Text += cmd.LogMessage + Environment.NewLine;
                });
            }

            this.Invoke(delegate
            {
                this.lstCommands.Items[lstCommands.Items.Count - 1].BackColor = Color.Transparent;
            });

            this.SequenceRunning = false;


            this.Invoke(delegate
            {
                this.ClearListboxColors();
                this.btnRun.Enabled = true;
                this.btnStop.Enabled = false;
                this.SequenceRunning = false;
                this.statusCurrentTask.Text = "N/A";
                this.statusScriptRunStatus.Text = "Complete";
                this.EnableAllControlButtons();
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            EnableAllControlButtons();
            btnRun.Enabled = true;
            btnStop.Enabled = false;
            StopSequence = true;
        }

        private void frmSequenceEditor_Load(object sender, EventArgs e)
        {

        }

        private void DisableAllControlButtons()
        {
            btnCmdTimeWait.Enabled = false;
            btnCmdTimeUser.Enabled = false;
            btnCmdMoveDistance.Enabled = false;
            btnCmdMoveTo.Enabled = false;
            btnCmdSetVelocity.Enabled = false;
            btnCmdSetAcceleration.Enabled = false;
            btnCmdStartDataCollection.Enabled = false;
            btnCmdStopDataCollection.Enabled = false;
            btnMngMoveUp.Enabled = false;
            btnMngClear.Enabled = false;
            btnMngMoveDown.Enabled = false;
            btnMngDeleteItem.Enabled = false;
            btnMngEnableItem.Enabled = false;
            btnMngDisableItem.Enabled = false;
        }

        private void ClearListboxColors()
        {
            for (int i = 0; i < lstCommands.Items.Count - 1; i++)
            {
                lstCommands.Items[i].BackColor = Color.Transparent;
            }
        }

        private void EnableAllControlButtons()
        {
            btnCmdTimeWait.Enabled = true;
            btnCmdTimeUser.Enabled = true;
            btnCmdMoveDistance.Enabled = true;
            btnCmdMoveTo.Enabled = true;
            btnCmdSetVelocity.Enabled = true;
            btnCmdSetAcceleration.Enabled = true;
            btnCmdStartDataCollection.Enabled = true;
            btnCmdStopDataCollection.Enabled = true;
            btnMngMoveUp.Enabled = true;
            btnMngClear.Enabled = true;
            btnMngMoveDown.Enabled = true;
            btnMngDeleteItem.Enabled = true;
            btnMngEnableItem.Enabled = true;
            btnMngDisableItem.Enabled = true;
        }

        private void btnCmdSetDataDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SequenceCommands.SetDataDirectory setDataDirectory = new(this.MainForm, folderBrowserDialog.SelectedPath);
                Commands.Add(setDataDirectory);
            }
        }

        private void btnCmdSetDataFilename_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmTextInputBox"] as frmTextInputBox) != null)
                return;

            frmTextInputBox textInput = new("Set File Name", "CSV Data File Name"); // TO DO: Find Max Value
            textInput.ShowDialog();

            if (textInput.DialogResult == DialogResult.OK)
            {
                SequenceCommands.SetDataFileName setDataFileName = new(this.MainForm, textInput.TextInput);
                Commands.Add(setDataFileName);
                // TO DO: Check if it is a valid name for a file
                // TO DO: Check if there is overwriting (will just append for now)
            }
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Sequence File (*.seq)|*.seq";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Command cmd in Commands)
                    {
                        string line = "";
                        line += cmd.Type.ToString() + "|";
                        switch (cmd.Type)
                        {
                            case CommandTypes.WaitTime:
                                WaitTime wt = (WaitTime)cmd;
                                line += wt.Time_ms.ToString();
                                break;
                            case CommandTypes.WaitUserInput:
                                break;
                            case CommandTypes.MoveDistance:
                                MoveDistance md = (MoveDistance)cmd;
                                line += md.Distance.ToString() + "|" + md.MovementReference.ToString();
                                break;
                            case CommandTypes.MoveTo:
                                MoveTo mt = (MoveTo)cmd;
                                line += mt.Position.ToString() + "|" + mt.MovementReference.ToString();
                                break;
                            case CommandTypes.SetVelocity:
                                SetVelocity sv = (SetVelocity)cmd;
                                line += sv.Velocity_steps_s.ToString();
                                break;
                            case CommandTypes.SetAcceleration:
                                SetAcceleration sa = (SetAcceleration)cmd;
                                line += sa.Acceleration_steps_s2.ToString();
                                break;
                            case CommandTypes.StartDataCollection:
                                break;
                            case CommandTypes.StopDataCollection:
                                break;
                            case CommandTypes.SetDataDirectory:
                                SetDataDirectory sdd = (SetDataDirectory)cmd;
                                line += sdd.DataDirectory; // TO DO: Reading could be fucked up. Using a pipe will be fine.
                                break;
                            case CommandTypes.SetDataFileName:
                                SetDataFileName sdf = (SetDataFileName)cmd;
                                line += sdf.DataFileName; // TO DO: Reading could be fucked up. Using a pipe as separator will be fine.
                                break;
                        }
                        if (Commands.IndexOf(cmd) < Commands.Count - 1)
                        {
                            line += Environment.NewLine;
                        }
                        sw.Write(line);
                    }
                }
            }
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            Commands.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sequence File (*.seq)|*.seq";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<string> fileLines = File.ReadLines(openFileDialog.FileName);

                try
                {
                    foreach (string line in fileLines)
                    {
                        string cmd = "";
                        string param = ""; // there is probably a better way to do this
                        string param2 = "";
                        if (line.Contains("|"))
                        {
                            cmd = line.Split('|')[0];
                            param = line.Split('|')[1];
                            if (line.Split('|').Length > 2)
                                param2 = line.Split('|')[2];
                        }
                        else
                        {
                            cmd = line;
                        }

                        object parsedCommand = Enum.Parse(typeof(SequenceCommands.CommandTypes), cmd);

                        if (parsedCommand == null)
                        {
                            MessageBox.Show("File is corrupted and could not be opened!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        switch (parsedCommand)
                        {
                            case CommandTypes.WaitTime: // GitHub co-pilot did this on its own. I was about to do it. That's impressive.
                                Commands.Add(new WaitTime(Convert.ToInt32(param)));
                                break;
                            case CommandTypes.WaitUserInput:
                                Commands.Add(new WaitUserInput());
                                break;
                            case CommandTypes.MoveDistance:
                                Commands.Add(new MoveDistance(this.MainForm, Convert.ToDecimal(param), (MovementReferenceType)Enum.Parse(typeof(MovementReferenceType), param2)));
                                break;
                            case CommandTypes.MoveTo:
                                Commands.Add(new MoveTo(this.MainForm, Convert.ToDecimal(param), (MovementReferenceType)Enum.Parse(typeof(MovementReferenceType), param2)));
                                break;
                            case CommandTypes.SetVelocity:
                                Commands.Add(new SetVelocity(this.MainForm, Convert.ToInt32(param)));
                                break;
                            case CommandTypes.SetAcceleration:
                                Commands.Add(new SetAcceleration(this.MainForm, Convert.ToInt32(param)));
                                break;
                            case CommandTypes.StartDataCollection:
                                Commands.Add(new StartDataCollection(this.MainForm));
                                break;
                            case CommandTypes.StopDataCollection:
                                Commands.Add(new StopDataCollection(this.MainForm));
                                break;
                            case CommandTypes.SetDataDirectory:
                                Commands.Add(new SetDataDirectory(this.MainForm, param));
                                break;
                            case CommandTypes.SetDataFileName:
                                Commands.Add(new SetDataFileName(this.MainForm, param));
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not open file! " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
