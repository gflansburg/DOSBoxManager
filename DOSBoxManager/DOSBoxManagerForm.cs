using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOSBoxManager
{
    public partial class DOSBoxManagerForm : Form
    {
        public DOSBoxSettings settings = new DOSBoxSettings();

        private int _selectedIndex = -1;
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (_selectedIndex >= 0 && _selectedIndex < pnlItems.Controls.Count)
                {
                    pnlItems.Controls[_selectedIndex].BackColor = Color.Transparent;
                }
                _selectedIndex = value;
                if (_selectedIndex >= 0 && _selectedIndex < pnlItems.Controls.Count)
                {
                    pnlItems.Controls[_selectedIndex].BackColor = SystemColors.Highlight;
                    pnlItems.ScrollControlIntoView(pnlItems.Controls[_selectedIndex]);
                }
            }
        }

        public DOSBoxManagerForm()
        {
            InitializeComponent();
            settings = LoadSettings();
            if (settings.Size.HasValue)
            {
                this.Size = settings.Size.Value;
            }
            if (settings.Location.HasValue && IsLocationVisible(settings.Location.Value))
            {
                this.Location = settings.Location.Value;
            }
            if (settings.IsMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            if (!string.IsNullOrEmpty(settings.ManagerName))
            {
                this.Text = settings.ManagerName;
                this.notifyIcon1.Text = settings.ManagerName;
            }
            RefreshItems();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DOSBoxManager_Load(object sender, EventArgs e)
        {
            if (settings.StartMinimized)
            {
                if (settings.MinimizeToSystemTray)
                {
                    ShowInTaskbar = false;
                    Visible = false;
                    this.Hide();
                }
                else
                {
                    WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (settings.StartWithWindows)
            {
                if (!rk.GetValueNames().Contains("DOSBox Manager"))
                {
                    rk.SetValue("DOSBox Manager", Application.ExecutablePath);
                }
            }
            else
            {
                if (rk.GetValueNames().Contains("DOSBox Manager"))
                {
                    rk.DeleteValue("DOSBox Manager", false);
                }
            }
        }

        public static bool IsLocationVisible(Point p)
        {
            return SystemInformation.VirtualScreen.Contains(p);
        }

        public static DOSBoxSettings LoadSettings()
        {
            string filename = string.Format("{0}\\DOSBoxManager.xml", GetExecutingDirectory());
            if (System.IO.File.Exists(filename))
            {
                using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
                {
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, (int)fs.Length);
                    fs.Close();
                    string xml = System.Text.ASCIIEncoding.ASCII.GetString(data);
                    DOSBoxSettings settings = (DOSBoxSettings)SerializerHelper.FromXml(xml, typeof(DOSBoxSettings));
                    return settings;
                }
            }
            return new DOSBoxSettings();
        }

        private void newProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOSBoxProgramForm form = new DOSBoxProgramForm()
            {
                DOSBoxProgram = new DOSBoxProgram(),
                EditorLocation = settings.EditorLocation
            };
            if(settings.ProgramLocation.HasValue)
            {
                form.Location = settings.ProgramLocation.Value;
            }
            if(form.ShowDialog(this) == DialogResult.OK)
            {
                settings.ProgramLocation = form.Location;
                settings.EditorLocation = form.EditorLocation;
                settings.Programs.Add(form.DOSBoxProgram);
                var items = settings.Programs.OrderBy(p => p.Name);
                _selectedIndex = items.ToList().IndexOf(form.DOSBoxProgram);
                SaveSettings();
                RefreshItems();
            }
        }

        private void RefreshItems()
        {
            UseWaitCursor = true;
            pnlItems.SuspendLayout();
            var items = settings.Programs.OrderBy(p => p.Name);
            pnlItems.Controls.Clear();
            for(int i = contextMenuStrip1.Items.Count - 1; i > 2; i--)
            {
                contextMenuStrip1.Items.RemoveAt(i);
            }
            int index = 0;
            foreach (DOSBoxProgram item in items)
            {
                Panel pnl = new Panel();
                pnl.Size = new Size(128, 156);
                PictureBox box = new PictureBox();
                box.Image = GetBitmapResource(item.Icon);
                box.MouseDown += new MouseEventHandler(Box_MouseDown);
                box.MouseDoubleClick += new MouseEventHandler(Box_MouseDoubleClick);
                box.Tag = item;
                box.Size = new Size(128, 128);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Cursor = Cursors.Hand;
                pnl.Controls.Add(box);
                Label lbl = new Label();
                lbl.Text = item.Name;
                lbl.Location = new Point(0, 128);
                lbl.AutoSize = false;
                lbl.Size = new Size(128, 28);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                pnl.Controls.Add(lbl);
                pnl.BackColor = index == SelectedIndex ? SystemColors.Highlight : Color.Transparent;
                pnlItems.Controls.Add(pnl);
                System.Windows.Forms.ToolStripMenuItem menuItem = new System.Windows.Forms.ToolStripMenuItem();
                menuItem.Text = item.Name;
                menuItem.Tag = item;
                menuItem.Click += new System.EventHandler(MenuItem_Click);
                contextMenuStrip1.Items.Insert(contextMenuStrip1.Items.Count, menuItem);
                index++;
            }
            pnlItems.ResumeLayout();
            UseWaitCursor = false;
        }

        private void Box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox box = sender as PictureBox;
            var items = settings.Programs.OrderBy(p => p.Name);
            SelectedIndex = items.ToList().IndexOf(box.Tag as DOSBoxProgram);
            LaunchProgram(box.Tag as DOSBoxProgram);
        }

        private void RefreshItem(DOSBoxProgram item)
        {
            bool fullRefresh = false;
            for(int i = 0; i < pnlItems.Controls.Count; i++)
            {
                Panel pnl = pnlItems.Controls[i] as Panel;
                PictureBox box = pnl.Controls[0] as PictureBox;
                if(box.Tag == item)
                {
                    box.Image = GetBitmapResource(item.Icon);
                    Label lbl = pnl.Controls[1] as Label;
                    if (!lbl.Text.Equals(item.Name))
                    {
                        lbl.Text = item.Name;
                        fullRefresh = true;
                        var items = settings.Programs.OrderBy(p => p.Name);
                        _selectedIndex = items.ToList().IndexOf(item);
                    }
                    SaveSettings();
                    break;
                }
            }
            if (fullRefresh)
            {
                RefreshItems();
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem menuItem = sender as System.Windows.Forms.ToolStripMenuItem;
            LaunchProgram(menuItem.Tag as DOSBoxProgram);
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox box = sender as PictureBox;
            var items = settings.Programs.OrderBy(p => p.Name);
            SelectedIndex = items.ToList().IndexOf(box.Tag as DOSBoxProgram);
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        contextMenuStrip2.Tag = box.Tag;
                        contextMenuStrip2.Show(this, this.PointToClient(Cursor.Position));
                    }
                    break;
            }
        }
        
        private void LaunchProgram(DOSBoxProgram item)
        {
            UseWaitCursor = true;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = settings.DOSBoxPath;
            startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(settings.DOSBoxPath);
            if(!string.IsNullOrEmpty(item.Args))
            {
                startInfo.Arguments = item.Args;
            }
            startInfo.Arguments += string.Format("{0}-conf \"{1}\" -noconsole", !string.IsNullOrEmpty(startInfo.Arguments) ? " " : string.Empty, item.Path);
            if (System.IO.File.Exists(startInfo.FileName) && System.IO.File.Exists(item.Path))
            {
                try
                {
                    System.Diagnostics.Process.Start(startInfo);
                    if (settings.MinimizeOnLaunch)
                    {
                        //ShowInTaskbar = false;
                        this.Hide();
                    }
                }
                catch
                {
                }
            }
            UseWaitCursor = false;
        }

        private void ShowWindow()
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            this.Show();
            this.BringToFront();
            this.Focus();
            this.Activate();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SYSCOMMAND)
            {
                if (m.WParam.ToInt32() == NativeMethods.SC_MINIMIZE)
                {
                    if (settings.MinimizeToSystemTray)
                    {
                        m.Result = IntPtr.Zero;
                        //ShowInTaskbar = false;
                        //Visible = false;
                        this.Hide();
                        return;
                    }
                }
                else if (m.WParam.ToInt32() == NativeMethods.SC_CLOSE)
                {
                    if (settings.MinimizeToSystemTray)
                    {
                        m.Result = IntPtr.Zero;
                        //ShowInTaskbar = false;
                        //Visible = false;
                        this.Hide();
                        return;
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDlg dlg = new AboutDlg()
            {
                AboutLocation = settings.AboutLocation
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                settings.AboutLocation = dlg.AboutLocation;
                SaveSettings();
            }
        }

        public static string GetExecutingDirectory()
        {
            var location = new Uri(System.Reflection.Assembly.GetEntryAssembly().GetName().CodeBase);
            return System.Net.WebUtility.UrlDecode(new FileInfo(location.AbsolutePath).Directory.FullName);
        }

        private void DOSBoxManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            settings.Size = this.Size;
            settings.Location = this.Location;
            settings.IsMaximized = this.WindowState == FormWindowState.Maximized;
            if(settings.IsMaximized)
            {
                settings.Location = new Point(this.RestoreBounds.X, this.RestoreBounds.Y);
                settings.Size = new Size(this.RestoreBounds.Width, this.RestoreBounds.Height);
            }
            string xml = SerializerHelper.ToXml(settings);
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(xml);
            string filename = string.Format("{0}\\DOSBoxManager.xml", GetExecutingDirectory());
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                fs.Write(data, 0, data.Length);
                fs.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm dlg = new OptionsForm()
            {
                MinimizeToSystemTray = settings.MinimizeToSystemTray,
                MinimizeOnLaunch = settings.MinimizeOnLaunch,
                StartMinimized = settings.StartMinimized,
                StartWithWindows = settings.StartWithWindows,
                ManagerGame = settings.ManagerName,
                DOSBoxPath = settings.DOSBoxPath,
                OptionsLocation = settings.OptionsLocation
            };
            if(dlg.ShowDialog(this) == DialogResult.OK)
            {
                settings.OptionsLocation = dlg.OptionsLocation;
                settings.MinimizeToSystemTray = dlg.MinimizeToSystemTray;
                settings.MinimizeOnLaunch = dlg.MinimizeOnLaunch;
                settings.StartMinimized = dlg.StartMinimized;
                settings.StartWithWindows = dlg.StartWithWindows;
                settings.ManagerName = dlg.ManagerGame;
                settings.DOSBoxPath = dlg.DOSBoxPath;
                this.Text = settings.ManagerName;
                this.notifyIcon1.Text = settings.ManagerName;
                SaveSettings();
                SetStartup();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOSBoxProgram item = contextMenuStrip2.Tag as DOSBoxProgram;
            DeleteDOSBoxProgramForm form = new DeleteDOSBoxProgramForm()
            {
                DOSBoxProgram = item,
                CaptionTitle = settings.ManagerName ?? "DOSBox Manager",
                DeleteLocation = settings.DeleteLocation,
                DOSBoxPath = settings.DOSBoxPath
            };
            if (form.ShowDialog(this) == DialogResult.Yes)
            {
                if(form.DeleteClientFiles)
                {
                    string clientFilesPath = DOSBoxConfigEditor.ClientFilesLocation(item.Path, settings.DOSBoxPath);
                    if(System.IO.Directory.Exists(clientFilesPath))
                    {
                        System.IO.Directory.Delete(clientFilesPath, true);
                    }    
                }
                if(form.DeleteConfigFile && System.IO.File.Exists(item.Path))
                {
                    System.IO.File.Delete(item.Path);
                }    
                settings.Programs.Remove(item);
                settings.DeleteLocation = form.DeleteLocation;
                if(SelectedIndex >= settings.Programs.Count)
                {
                    SelectedIndex = -1;
                }
                SaveSettings();
                RefreshItems();
            }
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            DOSBoxProgram item = contextMenuStrip2.Tag as DOSBoxProgram;
            DOSBoxProgramForm dlg = new DOSBoxProgramForm()
            {
                DOSBoxProgram = item,
                ProgramLocation = settings.ProgramLocation,
                EditorLocation = settings.EditorLocation
            };
            if(dlg.ShowDialog(this) == DialogResult.OK)
            {
                settings.ProgramLocation = dlg.ProgramLocation;
                settings.EditorLocation = dlg.EditorLocation;
                RefreshItem(item);
            }
        }

        private void bulkAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string[] files = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.conf");
                foreach(string file in files)
                {
                    DOSBoxProgram item = new DOSBoxProgram()
                    {
                        Name = System.IO.Path.GetFileNameWithoutExtension(file),
                        Path = file
                    };
                    string icon = string.Format("{0}\\{1}.jpg", System.IO.Path.GetDirectoryName(item.Path), item.Name);
                    if(System.IO.File.Exists(icon))
                    {
                        item.Icon = icon;
                    }
                    else
                    {
                        icon = string.Format("{0}\\{1}.png", System.IO.Path.GetDirectoryName(item.Path), item.Name);
                        if (System.IO.File.Exists(icon))
                        {
                            item.Icon = icon;
                        }
                        else
                        {
                            icon = string.Format("{0}\\{1}.gif", System.IO.Path.GetDirectoryName(item.Path), item.Name);
                            if (System.IO.File.Exists(icon))
                            {
                                item.Icon = icon;
                            }
                            else
                            {
                                icon = string.Format("{0}\\{1}.bmp", System.IO.Path.GetDirectoryName(item.Path), item.Name);
                                if (System.IO.File.Exists(icon))
                                {
                                    item.Icon = icon;
                                }
                            }
                        }
                    }
                    settings.Programs.Add(item);
                }
                SelectedIndex = -1;
                SaveSettings();
                RefreshItems();
            }
        }

        static public Image GetBitmapResource(string filename)
        {
            if (System.IO.File.Exists(filename))
            {
                using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(stream);
                }
            }
            return DOSBoxManager.Properties.Resources.DOSBox;
        }

        private void changeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOSBoxProgram item = contextMenuStrip2.Tag as DOSBoxProgram;
            if(!string.IsNullOrEmpty(item.Icon) && System.IO.File.Exists(item.Icon))
            {
                openFileDialog1.FileName = item.Icon;
            }
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.gif;*.bmp|Jpeg Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            openFileDialog1.FileName = item.Icon;
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                item.Icon = openFileDialog1.FileName;
                RefreshItem(item);
            }
        }

        private void DOSBoxSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOSBoxProgram item = contextMenuStrip2.Tag as DOSBoxProgram;
            DOSBoxConfigEditor editor = new DOSBoxConfigEditor()
            {
                ConfigFile = item.Path,
                EditorLocation = settings.EditorLocation
            };
            if(editor.ShowDialog(this) == DialogResult.OK)
            {
                settings.EditorLocation = editor.EditorLocation;
                SaveSettings();
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            DOSBoxProgram item = contextMenuStrip2.Tag as DOSBoxProgram;
            DOSBoxSettingsToolStripMenuItem.Enabled = System.IO.File.Exists(item.Path);
            openToolStripMenuItem.Enabled = System.IO.File.Exists(item.Path) && System.IO.File.Exists(settings.DOSBoxPath);
        }

        private void DOSBoxManagerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        if (SelectedIndex != -1)
                        {
                            Panel pnl = pnlItems.Controls[SelectedIndex] as Panel;
                            PictureBox box = pnl.Controls[0] as PictureBox;
                            LaunchProgram(box.Tag as DOSBoxProgram);
                        }
                        e.Handled = true;
                    }
                    break;
                case Keys.Up:
                    {
                        if (pnlItems.Controls.Count > 0)
                        {
                            int colCount = pnlItems.GetColumnCount();
                            int rowCount = pnlItems.GetRowCount();
                            int selectedColumn = Math.Max(0, SelectedIndex) % colCount;
                            int index = SelectedIndex == -1 ? 0 : SelectedIndex - colCount;
                            if (index < 0)
                            {
                                index = ((rowCount - 1) * colCount) + selectedColumn;
                                if (index >= pnlItems.Controls.Count)
                                {
                                    index -= colCount;
                                }
                            }
                            SelectedIndex = index;
                        }
                    }
                    e.Handled = true;
                    break;
                case Keys.Down:
                    {
                        if (pnlItems.Controls.Count > 0)
                        {
                            int colCount = pnlItems.GetColumnCount();
                            int selectedColumn = Math.Max(0, SelectedIndex) % colCount;
                            int index = SelectedIndex == -1 ? 0 : SelectedIndex + colCount;
                            if (index >= pnlItems.Controls.Count)
                            {
                                index = selectedColumn;
                            }
                            SelectedIndex = index;
                        }
                    }
                    e.Handled = true;
                    break;
                case Keys.Left:
                    {
                        if (pnlItems.Controls.Count > 0)
                        {
                            int colCount = pnlItems.GetColumnCount();
                            int selectedRow = (int)(Math.Max(0, SelectedIndex) / colCount);
                            int index = (SelectedIndex == -1 ? 0 : SelectedIndex - 1);
                            int newRow = (int)(Math.Max(0, index) / colCount);
                            if (newRow < selectedRow || index < 0)
                            {
                                index += colCount;
                                if (index >= pnlItems.Controls.Count)
                                {
                                    index = pnlItems.Controls.Count - 1;
                                }
                            }
                            SelectedIndex = index;
                        }
                    }
                    e.Handled = true;
                    break;
                case Keys.Right:
                    if (pnlItems.Controls.Count > 0)
                    {
                        int colCount = pnlItems.GetColumnCount();
                        int selectedRow = (int)(Math.Max(0, SelectedIndex) / colCount);
                        int index = (SelectedIndex == -1 ? 0 : SelectedIndex + 1);
                        int newRow = (int)(Math.Max(0, index) / colCount);
                        if (newRow > selectedRow || index >= pnlItems.Controls.Count)
                        {
                            index = (selectedRow * colCount);
                        }
                        SelectedIndex = index;
                    }
                    e.Handled = true;
                    break;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOSBoxProgram item = contextMenuStrip2.Tag as DOSBoxProgram;
            LaunchProgram(item);
        }
    }
}
