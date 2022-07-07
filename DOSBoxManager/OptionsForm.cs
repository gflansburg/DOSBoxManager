using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOSBoxManager
{
    public partial class OptionsForm : Form
    {
        public bool MinimizeToSystemTray { get; set; }
        public bool MinimizeOnLaunch { get; set; }
        public bool StartMinimized { get; set; }
        public bool StartWithWindows { get; set; }
        public string ManagerGame { get; set; }
        public string DOSBoxPath { get; set; }
        public Point? OptionsLocation { get; set; }

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            if(OptionsLocation.HasValue && DOSBoxManagerForm.IsLocationVisible(OptionsLocation.Value))
            {
                this.Location = OptionsLocation.Value;
            }
            cbMinimizeToSystemTray.Checked = MinimizeToSystemTray;
            cbMinimizeOnLaunch.Checked = MinimizeOnLaunch;
            cbStartMinimized.Checked = StartMinimized;
            cbStartWithWindows.Checked = StartWithWindows;
            tbManagerName.Text = ManagerGame ?? "DOSBox Manager";
            tbPath.Text = DOSBoxPath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OptionsLocation = this.Location;
            MinimizeToSystemTray = cbMinimizeToSystemTray.Checked;
            MinimizeOnLaunch = cbMinimizeOnLaunch.Checked;
            StartMinimized = cbStartMinimized.Checked;
            StartWithWindows = cbStartWithWindows.Checked;
            ManagerGame = tbManagerName.Text;
            DOSBoxPath = tbPath.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog1.FileName = tbPath.Text;
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
