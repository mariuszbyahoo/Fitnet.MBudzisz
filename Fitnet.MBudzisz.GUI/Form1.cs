using Fitnet.MBudzisz.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitnet.MBudzisz.GUI
{
    public partial class MainForm : Form
    {
        private readonly IDataInspector _inspector;
        public MainForm()
        {
            _inspector = new HardDriveInspector();
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (!mainBackgroundWorker.IsBusy)
            {
                executeButton.Enabled = false;
                cancelButton.Enabled = true;
                mainBackgroundWorker.RunWorkerAsync();
            }
        }

        private void mainBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                sum = sum + i;
                mainBackgroundWorker.ReportProgress(i);

                if (mainBackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    mainBackgroundWorker.ReportProgress(0);
                    return;
                }

                e.Result = sum;
            }
            _inspector.InspectDataLayer(this.pathTextBox.Text, this.lookupStringTextBox.Text);
        }

        private void mainBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
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
                progressBar.Value = 0;
                logsTextBox.Text += "\n DONE.";
            }

            executeButton.Enabled = true;
            cancelButton.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (mainBackgroundWorker.IsBusy)
            {
                mainBackgroundWorker.CancelAsync();
            }
            cancelButton.Enabled = false;
        }
    }
}
