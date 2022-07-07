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
    public partial class DeleteDOSBoxProgramForm : Form
    {
        public string DOSBoxPath { get; set; }

        public Point? DeleteLocation { get; set; }

        public DOSBoxProgram DOSBoxProgram { get; set; }

        public string CaptionTitle { get; set; }

        public bool DeleteClientFiles
        {
            get
            {
                return cbDeleteClientFiles.Checked;
            }
        }

        public bool DeleteConfigFile
        {
            get
            {
                return cbDeleteConfigFile.Checked;
            }
        }

        public DeleteDOSBoxProgramForm()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            DeleteLocation = this.Location;
            this.Close();
        }

        private void DeleteDOSBoxProgramForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CaptionTitle))
            {
                this.Text = CaptionTitle;
            }
            lblTitle.Text = string.Format(lblTitle.Text, DOSBoxProgram.Name);
            cbDeleteConfigFile.Visible = cbDeleteClientFiles.Visible = System.IO.File.Exists(DOSBoxProgram.Path);
            if(DeleteLocation.HasValue && DOSBoxManagerForm.IsLocationVisible(DeleteLocation.Value))
            {
                this.Location = DeleteLocation.Value;
            }
            string clientFilePath = DOSBoxConfigEditor.ClientFilesLocation(DOSBoxProgram.Path, DOSBoxPath);
            cbDeleteClientFiles.Visible = cbDeleteConfigFile.Visible && !string.IsNullOrEmpty(clientFilePath) && System.IO.Directory.Exists(clientFilePath);
        }
    }
}
