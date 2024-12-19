﻿namespace PicomotorStageControl_v2
{
    partial class frmSequenceEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRun = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusScriptRunStatus = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            statusCurrentTask = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            toolStripStatusLabel9 = new ToolStripStatusLabel();
            statusTimeRemainingCurrent = new ToolStripStatusLabel();
            toolStripStatusLabel11 = new ToolStripStatusLabel();
            statusTimeRemainingMax = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCmdTimeWait = new Button();
            btnCmdTimeUser = new Button();
            btnCmdMoveDistance = new Button();
            btnCmdMoveTo = new Button();
            btnCmdSetVelocity = new Button();
            btnCmdSetAcceleration = new Button();
            btnCmdStartDataCollection = new Button();
            btnCmdStopDataCollection = new Button();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnMngMoveUp = new Button();
            btnMngClear = new Button();
            btnMngMoveDown = new Button();
            btnMngDeleteItem = new Button();
            btnMngEnableItem = new Button();
            btnMngDisableItem = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnStop = new Button();
            lstCommands = new ListView();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Dock = DockStyle.Fill;
            btnRun.Location = new Point(3, 3);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(334, 62);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRunPause_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(825, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(152, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(152, 26);
            saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(152, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusScriptRunStatus, toolStripStatusLabel3, toolStripStatusLabel4, statusCurrentTask, toolStripStatusLabel6, toolStripStatusLabel9, statusTimeRemainingCurrent, toolStripStatusLabel11, statusTimeRemainingMax });
            statusStrip1.Location = new Point(0, 582);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(825, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(123, 20);
            toolStripStatusLabel1.Text = "Script Run Status:";
            // 
            // statusScriptRunStatus
            // 
            statusScriptRunStatus.Name = "statusScriptRunStatus";
            statusScriptRunStatus.Size = new Size(36, 20);
            statusScriptRunStatus.Text = "N/A";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(13, 20);
            toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(91, 20);
            toolStripStatusLabel4.Text = "Current Task:";
            // 
            // statusCurrentTask
            // 
            statusCurrentTask.Name = "statusCurrentTask";
            statusCurrentTask.Size = new Size(36, 20);
            statusCurrentTask.Text = "N/A";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(13, 20);
            toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel9
            // 
            toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            toolStripStatusLabel9.Size = new Size(190, 20);
            toolStripStatusLabel9.Text = "Estimated Time Remaining:";
            // 
            // statusTimeRemainingCurrent
            // 
            statusTimeRemainingCurrent.Name = "statusTimeRemainingCurrent";
            statusTimeRemainingCurrent.Size = new Size(23, 20);
            statusTimeRemainingCurrent.Text = "0s";
            // 
            // toolStripStatusLabel11
            // 
            toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            toolStripStatusLabel11.Size = new Size(15, 20);
            toolStripStatusLabel11.Text = "/";
            // 
            // statusTimeRemainingMax
            // 
            statusTimeRemainingMax.Name = "statusTimeRemainingMax";
            statusTimeRemainingMax.Size = new Size(23, 20);
            statusTimeRemainingMax.Text = "0s";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(467, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Commands";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCmdTimeWait);
            flowLayoutPanel1.Controls.Add(btnCmdTimeUser);
            flowLayoutPanel1.Controls.Add(btnCmdMoveDistance);
            flowLayoutPanel1.Controls.Add(btnCmdMoveTo);
            flowLayoutPanel1.Controls.Add(btnCmdSetVelocity);
            flowLayoutPanel1.Controls.Add(btnCmdSetAcceleration);
            flowLayoutPanel1.Controls.Add(btnCmdStartDataCollection);
            flowLayoutPanel1.Controls.Add(btnCmdStopDataCollection);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(340, 143);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCmdTimeWait
            // 
            btnCmdTimeWait.Location = new Point(3, 3);
            btnCmdTimeWait.Name = "btnCmdTimeWait";
            btnCmdTimeWait.Size = new Size(164, 29);
            btnCmdTimeWait.TabIndex = 0;
            btnCmdTimeWait.Text = "Wait (Time)";
            btnCmdTimeWait.UseVisualStyleBackColor = true;
            btnCmdTimeWait.Click += btnCmdTimeWait_Click;
            // 
            // btnCmdTimeUser
            // 
            btnCmdTimeUser.Location = new Point(173, 3);
            btnCmdTimeUser.Name = "btnCmdTimeUser";
            btnCmdTimeUser.Size = new Size(164, 29);
            btnCmdTimeUser.TabIndex = 1;
            btnCmdTimeUser.Text = "Wait (User Input)";
            btnCmdTimeUser.UseVisualStyleBackColor = true;
            btnCmdTimeUser.Click += btnCmdTimeUser_Click;
            // 
            // btnCmdMoveDistance
            // 
            btnCmdMoveDistance.Location = new Point(3, 38);
            btnCmdMoveDistance.Name = "btnCmdMoveDistance";
            btnCmdMoveDistance.Size = new Size(164, 29);
            btnCmdMoveDistance.TabIndex = 2;
            btnCmdMoveDistance.Text = "Move Distance";
            btnCmdMoveDistance.UseVisualStyleBackColor = true;
            btnCmdMoveDistance.Click += btnCmdMoveDistance_Click;
            // 
            // btnCmdMoveTo
            // 
            btnCmdMoveTo.Location = new Point(173, 38);
            btnCmdMoveTo.Name = "btnCmdMoveTo";
            btnCmdMoveTo.Size = new Size(164, 29);
            btnCmdMoveTo.TabIndex = 3;
            btnCmdMoveTo.Text = "Move To";
            btnCmdMoveTo.UseVisualStyleBackColor = true;
            btnCmdMoveTo.Click += btnCmdMoveTo_Click;
            // 
            // btnCmdSetVelocity
            // 
            btnCmdSetVelocity.Location = new Point(3, 73);
            btnCmdSetVelocity.Name = "btnCmdSetVelocity";
            btnCmdSetVelocity.Size = new Size(164, 29);
            btnCmdSetVelocity.TabIndex = 4;
            btnCmdSetVelocity.Text = "Set Velocity";
            btnCmdSetVelocity.UseVisualStyleBackColor = true;
            btnCmdSetVelocity.Click += btnCmdSetVelocity_Click;
            // 
            // btnCmdSetAcceleration
            // 
            btnCmdSetAcceleration.Location = new Point(173, 73);
            btnCmdSetAcceleration.Name = "btnCmdSetAcceleration";
            btnCmdSetAcceleration.Size = new Size(164, 29);
            btnCmdSetAcceleration.TabIndex = 5;
            btnCmdSetAcceleration.Text = "Set Acceleration";
            btnCmdSetAcceleration.UseVisualStyleBackColor = true;
            btnCmdSetAcceleration.Click += btnCmdSetAcceleration_Click;
            // 
            // btnCmdStartDataCollection
            // 
            btnCmdStartDataCollection.Location = new Point(3, 108);
            btnCmdStartDataCollection.Name = "btnCmdStartDataCollection";
            btnCmdStartDataCollection.Size = new Size(164, 29);
            btnCmdStartDataCollection.TabIndex = 6;
            btnCmdStartDataCollection.Text = "Start Data Collection";
            btnCmdStartDataCollection.UseVisualStyleBackColor = true;
            btnCmdStartDataCollection.Click += btnCmdStartDataCollection_Click;
            // 
            // btnCmdStopDataCollection
            // 
            btnCmdStopDataCollection.Location = new Point(173, 108);
            btnCmdStopDataCollection.Name = "btnCmdStopDataCollection";
            btnCmdStopDataCollection.Size = new Size(164, 29);
            btnCmdStopDataCollection.TabIndex = 7;
            btnCmdStopDataCollection.Text = "Stop Data Collection";
            btnCmdStopDataCollection.UseVisualStyleBackColor = true;
            btnCmdStopDataCollection.Click += btnCmdStopDataCollection_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Location = new Point(467, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 134);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sequence Managment";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnMngMoveUp);
            flowLayoutPanel2.Controls.Add(btnMngClear);
            flowLayoutPanel2.Controls.Add(btnMngMoveDown);
            flowLayoutPanel2.Controls.Add(btnMngDeleteItem);
            flowLayoutPanel2.Controls.Add(btnMngEnableItem);
            flowLayoutPanel2.Controls.Add(btnMngDisableItem);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 23);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(340, 108);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnMngMoveUp
            // 
            btnMngMoveUp.Location = new Point(3, 3);
            btnMngMoveUp.Name = "btnMngMoveUp";
            btnMngMoveUp.Size = new Size(164, 29);
            btnMngMoveUp.TabIndex = 1;
            btnMngMoveUp.Text = "Move Up";
            btnMngMoveUp.UseVisualStyleBackColor = true;
            btnMngMoveUp.Click += btnMngMoveUp_Click;
            // 
            // btnMngClear
            // 
            btnMngClear.Location = new Point(173, 3);
            btnMngClear.Name = "btnMngClear";
            btnMngClear.Size = new Size(164, 29);
            btnMngClear.TabIndex = 2;
            btnMngClear.Text = "Clear Sequence";
            btnMngClear.UseVisualStyleBackColor = true;
            btnMngClear.Click += btnMngClear_Click;
            // 
            // btnMngMoveDown
            // 
            btnMngMoveDown.Location = new Point(3, 38);
            btnMngMoveDown.Name = "btnMngMoveDown";
            btnMngMoveDown.Size = new Size(164, 29);
            btnMngMoveDown.TabIndex = 3;
            btnMngMoveDown.Text = "Move Down";
            btnMngMoveDown.UseVisualStyleBackColor = true;
            btnMngMoveDown.Click += btnMngMoveDown_Click;
            // 
            // btnMngDeleteItem
            // 
            btnMngDeleteItem.Location = new Point(173, 38);
            btnMngDeleteItem.Name = "btnMngDeleteItem";
            btnMngDeleteItem.Size = new Size(164, 29);
            btnMngDeleteItem.TabIndex = 4;
            btnMngDeleteItem.Text = "Delete Item";
            btnMngDeleteItem.UseVisualStyleBackColor = true;
            btnMngDeleteItem.Click += btnMngDeleteItem_Click;
            // 
            // btnMngEnableItem
            // 
            btnMngEnableItem.Location = new Point(3, 73);
            btnMngEnableItem.Name = "btnMngEnableItem";
            btnMngEnableItem.Size = new Size(164, 29);
            btnMngEnableItem.TabIndex = 5;
            btnMngEnableItem.Text = "Enable Item";
            btnMngEnableItem.UseVisualStyleBackColor = true;
            btnMngEnableItem.Click += btnMngEnableItem_Click;
            // 
            // btnMngDisableItem
            // 
            btnMngDisableItem.Location = new Point(173, 73);
            btnMngDisableItem.Name = "btnMngDisableItem";
            btnMngDisableItem.Size = new Size(164, 29);
            btnMngDisableItem.TabIndex = 6;
            btnMngDisableItem.Text = "Disable Item";
            btnMngDisableItem.UseVisualStyleBackColor = true;
            btnMngDisableItem.Click += btnMngDisableItem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Location = new Point(467, 346);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(346, 163);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sequence Controls";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnStop, 0, 1);
            tableLayoutPanel1.Controls.Add(btnRun, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(340, 137);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStop
            // 
            btnStop.Dock = DockStyle.Fill;
            btnStop.Location = new Point(3, 71);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(334, 63);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lstCommands
            // 
            lstCommands.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstCommands.Location = new Point(12, 31);
            lstCommands.MultiSelect = false;
            lstCommands.Name = "lstCommands";
            lstCommands.Size = new Size(449, 548);
            lstCommands.TabIndex = 9;
            lstCommands.UseCompatibleStateImageBehavior = false;
            lstCommands.View = View.List;
            // 
            // frmSequenceEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 608);
            Controls.Add(lstCommands);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmSequenceEditor";
            Text = "Picomotor Stage Control - Sequence Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRun;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCmdTimeWait;
        private Button btnCmdTimeUser;
        private Button btnCmdMoveDistance;
        private Button btnCmdMoveTo;
        private Button btnCmdSetVelocity;
        private Button btnCmdSetAcceleration;
        private Button btnCmdStartDataCollection;
        private Button btnCmdStopDataCollection;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnMngMoveUp;
        private Button btnMngClear;
        private Button btnMngMoveDown;
        private Button btnMngDeleteItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnStop;
        private Button btnMngEnableItem;
        private Button btnMngDisableItem;
        private ListView lstCommands;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusScriptRunStatus;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel statusCurrentTask;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabel9;
        private ToolStripStatusLabel statusTimeRemainingCurrent;
        private ToolStripStatusLabel toolStripStatusLabel11;
        private ToolStripStatusLabel statusTimeRemainingMax;
    }
}