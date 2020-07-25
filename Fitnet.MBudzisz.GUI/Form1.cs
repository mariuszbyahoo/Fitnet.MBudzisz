using Fitnet.MBudzisz.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitnet.MBudzisz.GUI
{
    public partial class MainForm : Form
    {
        private readonly IFileInspector _inspector;
        private readonly string noDirFound = $"No directory found at provided path, start from providing the drive ie: 'C://'";
        private readonly string badPatternSupplied = "You have to provide at least 2 characters long pattern.";

        public MainForm()
        {
            _inspector = new HardDriveInspector();
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (!mainBackgroundWorker.IsBusy)
            {
                if (lookupStringTextBox.Text.Length > 1)
                {
                    if (Directory.Exists(pathTextBox.Text))
                    {
                        executeButton.Enabled = false;
                        cancelButton.Enabled = true;
                        mainBackgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        logsTextBox.AppendText(noDirFound);
                    }
                }
                else
                {
                    logsTextBox.AppendText(badPatternSupplied);
                }
            }
        }

        private void mainBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var dir = new DirectoryInfo(pathTextBox.Text);
            var files = dir.EnumerateFiles().Where(f => (f.Name.Contains(".txt")) || (f.Name.Contains(".bin"))).ToArray();

            mainBackgroundWorker.ReportProgress(0);
            // using parenthesees to make loop stop condition clear
            for (var i = 1; i < (files.Length+1); i ++)
            {
                var start = DateTime.Now.Millisecond;
                var file = files[i-1];

                var progressVal = (int)((double)i / (double)files.Length * 100.00);
                var result = _inspector.InspectFile(file, lookupStringTextBox.Text);

                var stop = DateTime.Now.Millisecond;
                var lookupTime = stop - start;

                var msg = $"In a file : {file.Name} Pattern: {lookupStringTextBox.Text} occured: {result} times. " +
                    $"Lookup took: {lookupTime}ms{Environment.NewLine}";

                mainBackgroundWorker.ReportProgress(progressVal, msg);
            }
        }

        private void mainBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            logsTextBox.AppendText($"{e.UserState as string}");
            progressBar.Value = e.ProgressPercentage;
            logsTextBox.ScrollToCaret();
        }

        private void mainBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar.Value = 0;
                logsTextBox.Text = string.Empty;
            }
            else if(e.Error != null)
            {
                progressBar.Value = 0;
                logsTextBox.Text = e.Error.Message;
            }
            else
            {
                logsTextBox.AppendText($"{Environment.NewLine}DONE.{Environment.NewLine}");
                logsTextBox.ScrollToCaret();
            }

            executeButton.Enabled = true;
            cancelButton.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            logsTextBox.Clear();
            if (mainBackgroundWorker.IsBusy)
            {
                mainBackgroundWorker.CancelAsync();
            }
        }

        private void logsTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
