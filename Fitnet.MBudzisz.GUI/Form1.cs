using Fitnet.MBudzisz.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            _inspector.InspectDataLayer(this.pathTextBox.Text, this.lookupStringTextBox.Text);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
