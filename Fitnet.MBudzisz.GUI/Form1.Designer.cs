namespace Fitnet.MBudzisz.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logsTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lookupStringTextBox = new System.Windows.Forms.TextBox();
            this.stringLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.mainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.executeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonsSplitter = new System.Windows.Forms.Splitter();
            this.ssMain.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssMain.Location = new System.Drawing.Point(0, 424);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(800, 26);
            this.ssMain.TabIndex = 0;
            this.ssMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(502, 20);
            this.toolStripStatusLabel1.Text = "+48-796-666-343 mariusz.budzisz@yahoo.com SKYPE: live:mariusz.budzisz";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 424);
            this.mainPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.logsTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 174);
            this.panel4.TabIndex = 3;
            // 
            // logsTextBox
            // 
            this.logsTextBox.BackColor = System.Drawing.Color.Navy;
            this.logsTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logsTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.logsTextBox.Location = new System.Drawing.Point(0, 0);
            this.logsTextBox.Multiline = true;
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logsTextBox.Size = new System.Drawing.Size(800, 174);
            this.logsTextBox.TabIndex = 0;
            this.logsTextBox.Text = resources.GetString("logsTextBox.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonsPanel);
            this.panel3.Controls.Add(this.progressPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lookupStringTextBox);
            this.panel2.Controls.Add(this.stringLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 75);
            this.panel2.TabIndex = 1;
            // 
            // lookupStringTextBox
            // 
            this.lookupStringTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookupStringTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lookupStringTextBox.Location = new System.Drawing.Point(0, 38);
            this.lookupStringTextBox.Name = "lookupStringTextBox";
            this.lookupStringTextBox.Size = new System.Drawing.Size(800, 38);
            this.lookupStringTextBox.TabIndex = 2;
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.BackColor = System.Drawing.Color.Transparent;
            this.stringLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stringLabel.Location = new System.Drawing.Point(0, 0);
            this.stringLabel.Margin = new System.Windows.Forms.Padding(3);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Padding = new System.Windows.Forms.Padding(3);
            this.stringLabel.Size = new System.Drawing.Size(360, 38);
            this.stringLabel.TabIndex = 1;
            this.stringLabel.Text = "Enter a string to for lookup:";
            this.stringLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pathTextBox);
            this.panel1.Controls.Add(this.pathLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 0;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathTextBox.Location = new System.Drawing.Point(0, 38);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(800, 34);
            this.pathTextBox.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.BackColor = System.Drawing.Color.Transparent;
            this.pathLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathLabel.Location = new System.Drawing.Point(0, 0);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(3);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Padding = new System.Windows.Forms.Padding(3);
            this.pathLabel.Size = new System.Drawing.Size(396, 38);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Enter a path to catalog below:";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainBackgroundWorker
            // 
            this.mainBackgroundWorker.WorkerReportsProgress = true;
            this.mainBackgroundWorker.WorkerSupportsCancellation = true;
            // 
            // executeButton
            // 
            this.executeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.executeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.executeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.executeButton.Location = new System.Drawing.Point(0, 0);
            this.executeButton.Name = "executeButton";
            this.executeButton.Padding = new System.Windows.Forms.Padding(3);
            this.executeButton.Size = new System.Drawing.Size(396, 50);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "ExecuteLookup";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.progressBar);
            this.progressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressPanel.Location = new System.Drawing.Point(0, 0);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(800, 50);
            this.progressPanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.buttonsSplitter);
            this.buttonsPanel.Controls.Add(this.executeButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 50);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(800, 50);
            this.buttonsPanel.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 50);
            this.progressBar.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(399, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(401, 50);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "cancel button";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // buttonsSplitter
            // 
            this.buttonsSplitter.Location = new System.Drawing.Point(396, 0);
            this.buttonsSplitter.Name = "buttonsSplitter";
            this.buttonsSplitter.Size = new System.Drawing.Size(3, 50);
            this.buttonsSplitter.TabIndex = 1;
            this.buttonsSplitter.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.ssMain);
            this.Name = "MainForm";
            this.Text = "My InterviewTask solutiuon";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox logsTextBox;
        private System.Windows.Forms.TextBox lookupStringTextBox;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker mainBackgroundWorker;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Splitter buttonsSplitter;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

