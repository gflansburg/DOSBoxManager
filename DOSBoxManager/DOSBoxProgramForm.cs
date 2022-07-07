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
    public partial class DOSBoxProgramForm : Form
    {
        public Point? ProgramLocation { get; set; }
        public Point? EditorLocation { get; set; }

        public DOSBoxProgramForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbPath.Text) && System.IO.File.Exists(tbPath.Text))
            {
                openFileDialog1.FileName = tbPath.Text;
            }
            openFileDialog1.Filter = "Config Files (*.conf)|*.conf|All Files (*.*)|*.*";
            openFileDialog1.FileName = tbPath.Text;
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbPath.Text = openFileDialog1.FileName;
                btnEdit.Enabled = true;
            }
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbIcon.Text) && System.IO.File.Exists(tbIcon.Text))
            {
                openFileDialog1.FileName = tbIcon.Text;
            }
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.gif;*.bmp|Jpeg Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            openFileDialog1.FileName = tbIcon.Text;
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbIcon.Text = openFileDialog1.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ProgramLocation = this.Location;
            DOSBoxProgram.Name = tbName.Text;
            DOSBoxProgram.Path = tbPath.Text;
            DOSBoxProgram.Icon = tbIcon.Text;
            DOSBoxProgram.Args = tbArgs.Text;
            this.Close();
        }

        public DOSBoxProgram DOSBoxProgram { get; set; }

        private void Emulator_Load(object sender, EventArgs e)
        {
            if(ProgramLocation.HasValue && DOSBoxManagerForm.IsLocationVisible(ProgramLocation.Value))
            {
                this.Location = ProgramLocation.Value;
            }
            tbName.Text = DOSBoxProgram.Name;
            tbPath.Text = DOSBoxProgram.Path;
            tbIcon.Text = DOSBoxProgram.Icon;
            tbArgs.Text = DOSBoxProgram.Args;
            btnEdit.Enabled = System.IO.File.Exists(DOSBoxProgram.Path);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbName.Text))
            {
                saveFileDialog1.FileName = string.Format("{0}.conf", tbName.Text);
            }
            if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbPath.Text = saveFileDialog1.FileName;
                using (System.IO.StreamWriter writer = System.IO.File.CreateText(saveFileDialog1.FileName))
                {
                    writer.Write(DOSBoxManager.Properties.Resources.DefaultConfig);
                }
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DOSBoxConfigEditor editor = new DOSBoxConfigEditor()
            {
                ConfigFile = tbPath.Text,
                EditorLocation = EditorLocation
            };
            if(editor.ShowDialog(this) == DialogResult.OK)
            {
                EditorLocation = editor.Location;
            }
        }
    }
}
