
namespace DOSBoxManager
{
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    partial class DOSBoxConfigEditor : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOSBoxConfigEditor));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabSdl = new System.Windows.Forms.TabPage();
            this.usescancodesComboBox1 = new System.Windows.Forms.ComboBox();
            this.usescancodesLabel2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.mapperfileTextBox2 = new System.Windows.Forms.TextBox();
            this.mapperfileLabel2 = new System.Windows.Forms.Label();
            this.priorityComboBox2 = new System.Windows.Forms.ComboBox();
            this.priorityComboBox1 = new System.Windows.Forms.ComboBox();
            this.priorityLabel2 = new System.Windows.Forms.Label();
            this.waitonerrorComboBox1 = new System.Windows.Forms.ComboBox();
            this.waitonerrorLabel2 = new System.Windows.Forms.Label();
            this.sensitivityNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sensitivityLabel2 = new System.Windows.Forms.Label();
            this.autolockComboBox1 = new System.Windows.Forms.ComboBox();
            this.autolockLabel2 = new System.Windows.Forms.Label();
            this.outputComboBox1 = new System.Windows.Forms.ComboBox();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.windowresolutionComboBox1 = new System.Windows.Forms.ComboBox();
            this.windowresolutionLabel2 = new System.Windows.Forms.Label();
            this.fullresolutionComboBox1 = new System.Windows.Forms.ComboBox();
            this.fullresolutionLabel = new System.Windows.Forms.Label();
            this.fulldoubleComboBox1 = new System.Windows.Forms.ComboBox();
            this.fulldoubleLabel1 = new System.Windows.Forms.Label();
            this.fullscreenComboBox1 = new System.Windows.Forms.ComboBox();
            this.fullscreenLabel1 = new System.Windows.Forms.Label();
            this.tabDOSBox = new System.Windows.Forms.TabPage();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.memsizeComboBox1 = new System.Windows.Forms.ComboBox();
            this.memsizeLabel2 = new System.Windows.Forms.Label();
            this.capturesButton2 = new System.Windows.Forms.Button();
            this.capturesTextBox2 = new System.Windows.Forms.TextBox();
            this.capturesLabel2 = new System.Windows.Forms.Label();
            this.machineComboBox1 = new System.Windows.Forms.ComboBox();
            this.machineLabel2 = new System.Windows.Forms.Label();
            this.languageTextBox2 = new System.Windows.Forms.TextBox();
            this.languageLabel2 = new System.Windows.Forms.Label();
            this.tabRender = new System.Windows.Forms.TabPage();
            this.scalerComboBox1 = new System.Windows.Forms.ComboBox();
            this.scalerLabel2 = new System.Windows.Forms.Label();
            this.aspectComboBox1 = new System.Windows.Forms.ComboBox();
            this.aspectLabel2 = new System.Windows.Forms.Label();
            this.frameskipTextBox2 = new System.Windows.Forms.TextBox();
            this.frameskipLabel2 = new System.Windows.Forms.Label();
            this.tabCpu = new System.Windows.Forms.TabPage();
            this.cycledownTextBox2 = new System.Windows.Forms.TextBox();
            this.cycledownLabel2 = new System.Windows.Forms.Label();
            this.cycleupTextBox2 = new System.Windows.Forms.TextBox();
            this.cycleupLabel2 = new System.Windows.Forms.Label();
            this.cyclesComboBox1 = new System.Windows.Forms.ComboBox();
            this.cyclesLabel2 = new System.Windows.Forms.Label();
            this.cputypeComboBox1 = new System.Windows.Forms.ComboBox();
            this.cputypeLabel2 = new System.Windows.Forms.Label();
            this.coreComboBox1 = new System.Windows.Forms.ComboBox();
            this.coreLabel2 = new System.Windows.Forms.Label();
            this.tabMixer = new System.Windows.Forms.TabPage();
            this.prebufferTextBox2 = new System.Windows.Forms.TextBox();
            this.prebufferLabel2 = new System.Windows.Forms.Label();
            this.blocksizeComboBox1 = new System.Windows.Forms.ComboBox();
            this.blocksizeLabel2 = new System.Windows.Forms.Label();
            this.rateComboBox1 = new System.Windows.Forms.ComboBox();
            this.rateLabel2 = new System.Windows.Forms.Label();
            this.nosoundComboBox1 = new System.Windows.Forms.ComboBox();
            this.nosoundLabel2 = new System.Windows.Forms.Label();
            this.tabMidi = new System.Windows.Forms.TabPage();
            this.midiconfigTextBox2 = new System.Windows.Forms.TextBox();
            this.midiconfigLabel2 = new System.Windows.Forms.Label();
            this.midideviceComboBox1 = new System.Windows.Forms.ComboBox();
            this.midideviceLabel2 = new System.Windows.Forms.Label();
            this.mpu401ComboBox1 = new System.Windows.Forms.ComboBox();
            this.mpu401Label2 = new System.Windows.Forms.Label();
            this.tabSblaster = new System.Windows.Forms.TabPage();
            this.irqComboBox1 = new System.Windows.Forms.ComboBox();
            this.irqLabel2 = new System.Windows.Forms.Label();
            this.oplrateComboBox1 = new System.Windows.Forms.ComboBox();
            this.oplrateLabel2 = new System.Windows.Forms.Label();
            this.oplemuComboBox1 = new System.Windows.Forms.ComboBox();
            this.oplemuLabel2 = new System.Windows.Forms.Label();
            this.oplmodeComboBox1 = new System.Windows.Forms.ComboBox();
            this.oplmodeLabel2 = new System.Windows.Forms.Label();
            this.sbmixerComboBox1 = new System.Windows.Forms.ComboBox();
            this.sbmixerLabel2 = new System.Windows.Forms.Label();
            this.hdmaComboBox1 = new System.Windows.Forms.ComboBox();
            this.hdmaLabel2 = new System.Windows.Forms.Label();
            this.dmaComboBox1 = new System.Windows.Forms.ComboBox();
            this.dmaLabel2 = new System.Windows.Forms.Label();
            this.sbbaseComboBox1 = new System.Windows.Forms.ComboBox();
            this.sbbaseLabel2 = new System.Windows.Forms.Label();
            this.sbtypeComboBox1 = new System.Windows.Forms.ComboBox();
            this.sbtypeLabel2 = new System.Windows.Forms.Label();
            this.tabGus = new System.Windows.Forms.TabPage();
            this.ultradirTextBox2 = new System.Windows.Forms.TextBox();
            this.ultradirLabel2 = new System.Windows.Forms.Label();
            this.gusdmaComboBox1 = new System.Windows.Forms.ComboBox();
            this.gusdmaLabel2 = new System.Windows.Forms.Label();
            this.gusirqComboBox1 = new System.Windows.Forms.ComboBox();
            this.gusirqLabel2 = new System.Windows.Forms.Label();
            this.gusbaseComboBox1 = new System.Windows.Forms.ComboBox();
            this.gusbaseLabel2 = new System.Windows.Forms.Label();
            this.gusrateComboBox1 = new System.Windows.Forms.ComboBox();
            this.gusrateLabel2 = new System.Windows.Forms.Label();
            this.gusComboBox1 = new System.Windows.Forms.ComboBox();
            this.gusLabel2 = new System.Windows.Forms.Label();
            this.tabSpeaker = new System.Windows.Forms.TabPage();
            this.disneyComboBox1 = new System.Windows.Forms.ComboBox();
            this.disneyLabel2 = new System.Windows.Forms.Label();
            this.tandyrateComboBox1 = new System.Windows.Forms.ComboBox();
            this.tandyrateLabel2 = new System.Windows.Forms.Label();
            this.tandyComboBox1 = new System.Windows.Forms.ComboBox();
            this.tandyLabel2 = new System.Windows.Forms.Label();
            this.pcrateComboBox1 = new System.Windows.Forms.ComboBox();
            this.pcrateLabel2 = new System.Windows.Forms.Label();
            this.pcspeakerComboBox1 = new System.Windows.Forms.ComboBox();
            this.pcspeakerLabel2 = new System.Windows.Forms.Label();
            this.tabJoystick = new System.Windows.Forms.TabPage();
            this.buttonwrapComboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonwrapLabel2 = new System.Windows.Forms.Label();
            this.swap34ComboBox1 = new System.Windows.Forms.ComboBox();
            this.swap34Label2 = new System.Windows.Forms.Label();
            this.autofireComboBox1 = new System.Windows.Forms.ComboBox();
            this.autofireLabel2 = new System.Windows.Forms.Label();
            this.timedComboBox1 = new System.Windows.Forms.ComboBox();
            this.timedLabel2 = new System.Windows.Forms.Label();
            this.joysticktypeComboBox1 = new System.Windows.Forms.ComboBox();
            this.joysticktypeLabel2 = new System.Windows.Forms.Label();
            this.tabSerial = new System.Windows.Forms.TabPage();
            this.serial4ComboBox1 = new System.Windows.Forms.ComboBox();
            this.serial4Label2 = new System.Windows.Forms.Label();
            this.serial3ComboBox1 = new System.Windows.Forms.ComboBox();
            this.serial3Label2 = new System.Windows.Forms.Label();
            this.serial2ComboBox1 = new System.Windows.Forms.ComboBox();
            this.serial2Label2 = new System.Windows.Forms.Label();
            this.serial1ComboBox1 = new System.Windows.Forms.ComboBox();
            this.serial1Label2 = new System.Windows.Forms.Label();
            this.tabDos = new System.Windows.Forms.TabPage();
            this.keyboardlayoutComboBox1 = new System.Windows.Forms.ComboBox();
            this.keyboardlayoutLabel2 = new System.Windows.Forms.Label();
            this.umbComboBox1 = new System.Windows.Forms.ComboBox();
            this.umbLabel2 = new System.Windows.Forms.Label();
            this.emsComboBox1 = new System.Windows.Forms.ComboBox();
            this.emsLabel2 = new System.Windows.Forms.Label();
            this.xmsComboBox1 = new System.Windows.Forms.ComboBox();
            this.xmsLabel2 = new System.Windows.Forms.Label();
            this.tabIpx = new System.Windows.Forms.TabPage();
            this.ipxComboBox1 = new System.Windows.Forms.ComboBox();
            this.ipxLabel2 = new System.Windows.Forms.Label();
            this.tabAutoexec = new System.Windows.Forms.TabPage();
            this.textBoxAutoExec = new System.Windows.Forms.TextBox();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxConfig = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.tabSdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityNumericUpDown1)).BeginInit();
            this.tabDOSBox.SuspendLayout();
            this.tabRender.SuspendLayout();
            this.tabCpu.SuspendLayout();
            this.tabMixer.SuspendLayout();
            this.tabMidi.SuspendLayout();
            this.tabSblaster.SuspendLayout();
            this.tabGus.SuspendLayout();
            this.tabSpeaker.SuspendLayout();
            this.tabJoystick.SuspendLayout();
            this.tabSerial.SuspendLayout();
            this.tabDos.SuspendLayout();
            this.tabIpx.SuspendLayout();
            this.tabAutoexec.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tabSdl);
            this.TabControl.Controls.Add(this.tabDOSBox);
            this.TabControl.Controls.Add(this.tabRender);
            this.TabControl.Controls.Add(this.tabCpu);
            this.TabControl.Controls.Add(this.tabMixer);
            this.TabControl.Controls.Add(this.tabMidi);
            this.TabControl.Controls.Add(this.tabSblaster);
            this.TabControl.Controls.Add(this.tabGus);
            this.TabControl.Controls.Add(this.tabSpeaker);
            this.TabControl.Controls.Add(this.tabJoystick);
            this.TabControl.Controls.Add(this.tabSerial);
            this.TabControl.Controls.Add(this.tabDos);
            this.TabControl.Controls.Add(this.tabIpx);
            this.TabControl.Controls.Add(this.tabAutoexec);
            this.TabControl.ImageList = this.icons;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(480, 471);
            this.TabControl.TabIndex = 0;
            // 
            // tabSdl
            // 
            this.tabSdl.Controls.Add(this.usescancodesComboBox1);
            this.tabSdl.Controls.Add(this.usescancodesLabel2);
            this.tabSdl.Controls.Add(this.Button1);
            this.tabSdl.Controls.Add(this.mapperfileTextBox2);
            this.tabSdl.Controls.Add(this.mapperfileLabel2);
            this.tabSdl.Controls.Add(this.priorityComboBox2);
            this.tabSdl.Controls.Add(this.priorityComboBox1);
            this.tabSdl.Controls.Add(this.priorityLabel2);
            this.tabSdl.Controls.Add(this.waitonerrorComboBox1);
            this.tabSdl.Controls.Add(this.waitonerrorLabel2);
            this.tabSdl.Controls.Add(this.sensitivityNumericUpDown1);
            this.tabSdl.Controls.Add(this.sensitivityLabel2);
            this.tabSdl.Controls.Add(this.autolockComboBox1);
            this.tabSdl.Controls.Add(this.autolockLabel2);
            this.tabSdl.Controls.Add(this.outputComboBox1);
            this.tabSdl.Controls.Add(this.outputLabel2);
            this.tabSdl.Controls.Add(this.windowresolutionComboBox1);
            this.tabSdl.Controls.Add(this.windowresolutionLabel2);
            this.tabSdl.Controls.Add(this.fullresolutionComboBox1);
            this.tabSdl.Controls.Add(this.fullresolutionLabel);
            this.tabSdl.Controls.Add(this.fulldoubleComboBox1);
            this.tabSdl.Controls.Add(this.fulldoubleLabel1);
            this.tabSdl.Controls.Add(this.fullscreenComboBox1);
            this.tabSdl.Controls.Add(this.fullscreenLabel1);
            this.tabSdl.ImageKey = "computer-4.png";
            this.tabSdl.Location = new System.Drawing.Point(4, 42);
            this.tabSdl.Name = "tabSdl";
            this.tabSdl.Padding = new System.Windows.Forms.Padding(3);
            this.tabSdl.Size = new System.Drawing.Size(472, 425);
            this.tabSdl.TabIndex = 0;
            this.tabSdl.Text = "[sdl]";
            this.tabSdl.UseVisualStyleBackColor = true;
            // 
            // usescancodesComboBox1
            // 
            this.usescancodesComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usescancodesComboBox1.FormattingEnabled = true;
            this.usescancodesComboBox1.Location = new System.Drawing.Point(101, 59);
            this.usescancodesComboBox1.Name = "usescancodesComboBox1";
            this.usescancodesComboBox1.Size = new System.Drawing.Size(84, 21);
            this.usescancodesComboBox1.TabIndex = 25;
            this.usescancodesComboBox1.SelectedIndexChanged += new System.EventHandler(this.usescancodesComboBox1_SelectedIndexChanged);
            // 
            // usescancodesLabel2
            // 
            this.usescancodesLabel2.AutoSize = true;
            this.usescancodesLabel2.Location = new System.Drawing.Point(98, 43);
            this.usescancodesLabel2.Name = "usescancodesLabel2";
            this.usescancodesLabel2.Size = new System.Drawing.Size(76, 13);
            this.usescancodesLabel2.TabIndex = 24;
            this.usescancodesLabel2.Text = "usescancodes";
            this.ToolTip1.SetToolTip(this.usescancodesLabel2, "Avoid usage of symkeys, might not work on all operating systems.");
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.AutoSize = true;
            this.Button1.Location = new System.Drawing.Point(388, 15);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(76, 27);
            this.Button1.TabIndex = 23;
            this.Button1.Text = "Browse";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mapperfileTextBox2
            // 
            this.mapperfileTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapperfileTextBox2.Location = new System.Drawing.Point(101, 19);
            this.mapperfileTextBox2.Name = "mapperfileTextBox2";
            this.mapperfileTextBox2.Size = new System.Drawing.Size(281, 20);
            this.mapperfileTextBox2.TabIndex = 22;
            this.mapperfileTextBox2.TextChanged += new System.EventHandler(this.mapperfileTextBox2_TextChanged);
            // 
            // mapperfileLabel2
            // 
            this.mapperfileLabel2.AutoSize = true;
            this.mapperfileLabel2.Location = new System.Drawing.Point(98, 3);
            this.mapperfileLabel2.Name = "mapperfileLabel2";
            this.mapperfileLabel2.Size = new System.Drawing.Size(55, 13);
            this.mapperfileLabel2.TabIndex = 21;
            this.mapperfileLabel2.Text = "mapperfile";
            this.ToolTip1.SetToolTip(this.mapperfileLabel2, "File used to load/save the key/event mappings from. Resetmapper only works with t" +
        "he defaul value.");
            // 
            // priorityComboBox2
            // 
            this.priorityComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox2.FormattingEnabled = true;
            this.priorityComboBox2.Location = new System.Drawing.Point(101, 338);
            this.priorityComboBox2.Name = "priorityComboBox2";
            this.priorityComboBox2.Size = new System.Drawing.Size(84, 21);
            this.priorityComboBox2.TabIndex = 20;
            this.priorityComboBox2.SelectedIndexChanged += new System.EventHandler(this.priorityComboBox2_SelectedIndexChanged);
            // 
            // priorityComboBox1
            // 
            this.priorityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox1.FormattingEnabled = true;
            this.priorityComboBox1.Location = new System.Drawing.Point(11, 338);
            this.priorityComboBox1.Name = "priorityComboBox1";
            this.priorityComboBox1.Size = new System.Drawing.Size(84, 21);
            this.priorityComboBox1.TabIndex = 19;
            this.priorityComboBox1.SelectedIndexChanged += new System.EventHandler(this.priorityComboBox1_SelectedIndexChanged);
            // 
            // priorityLabel2
            // 
            this.priorityLabel2.AutoSize = true;
            this.priorityLabel2.Location = new System.Drawing.Point(8, 322);
            this.priorityLabel2.Name = "priorityLabel2";
            this.priorityLabel2.Size = new System.Drawing.Size(37, 13);
            this.priorityLabel2.TabIndex = 18;
            this.priorityLabel2.Text = "priority";
            this.ToolTip1.SetToolTip(this.priorityLabel2, resources.GetString("priorityLabel2.ToolTip"));
            // 
            // waitonerrorComboBox1
            // 
            this.waitonerrorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waitonerrorComboBox1.FormattingEnabled = true;
            this.waitonerrorComboBox1.Location = new System.Drawing.Point(11, 298);
            this.waitonerrorComboBox1.Name = "waitonerrorComboBox1";
            this.waitonerrorComboBox1.Size = new System.Drawing.Size(84, 21);
            this.waitonerrorComboBox1.TabIndex = 17;
            this.waitonerrorComboBox1.SelectedIndexChanged += new System.EventHandler(this.waitonerrorComboBox1_SelectedIndexChanged);
            // 
            // waitonerrorLabel2
            // 
            this.waitonerrorLabel2.AutoSize = true;
            this.waitonerrorLabel2.Location = new System.Drawing.Point(8, 282);
            this.waitonerrorLabel2.Name = "waitonerrorLabel2";
            this.waitonerrorLabel2.Size = new System.Drawing.Size(59, 13);
            this.waitonerrorLabel2.TabIndex = 16;
            this.waitonerrorLabel2.Text = "waitonerror";
            this.ToolTip1.SetToolTip(this.waitonerrorLabel2, "Wait before closing the console if DOSBox has an error.");
            // 
            // sensitivityNumericUpDown1
            // 
            this.sensitivityNumericUpDown1.Location = new System.Drawing.Point(11, 259);
            this.sensitivityNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sensitivityNumericUpDown1.Name = "sensitivityNumericUpDown1";
            this.sensitivityNumericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.sensitivityNumericUpDown1.TabIndex = 15;
            this.sensitivityNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sensitivityNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sensitivityNumericUpDown1.ValueChanged += new System.EventHandler(this.sensitivityNumericUpDown1_ValueChanged);
            // 
            // sensitivityLabel2
            // 
            this.sensitivityLabel2.AutoSize = true;
            this.sensitivityLabel2.Location = new System.Drawing.Point(8, 243);
            this.sensitivityLabel2.Name = "sensitivityLabel2";
            this.sensitivityLabel2.Size = new System.Drawing.Size(52, 13);
            this.sensitivityLabel2.TabIndex = 14;
            this.sensitivityLabel2.Text = "sensitivity";
            this.ToolTip1.SetToolTip(this.sensitivityLabel2, "Mouse sensitivity.");
            // 
            // autolockComboBox1
            // 
            this.autolockComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autolockComboBox1.FormattingEnabled = true;
            this.autolockComboBox1.Location = new System.Drawing.Point(11, 219);
            this.autolockComboBox1.Name = "autolockComboBox1";
            this.autolockComboBox1.Size = new System.Drawing.Size(84, 21);
            this.autolockComboBox1.TabIndex = 13;
            this.autolockComboBox1.SelectedIndexChanged += new System.EventHandler(this.autolockComboBox1_SelectedIndexChanged);
            // 
            // autolockLabel2
            // 
            this.autolockLabel2.AutoSize = true;
            this.autolockLabel2.Location = new System.Drawing.Point(8, 203);
            this.autolockLabel2.Name = "autolockLabel2";
            this.autolockLabel2.Size = new System.Drawing.Size(48, 13);
            this.autolockLabel2.TabIndex = 12;
            this.autolockLabel2.Text = "autolock";
            this.ToolTip1.SetToolTip(this.autolockLabel2, "Mouse will automatically lock, if you click on the screen. (Press CTRL-F10 to unl" +
        "ock)");
            // 
            // outputComboBox1
            // 
            this.outputComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputComboBox1.FormattingEnabled = true;
            this.outputComboBox1.Location = new System.Drawing.Point(11, 179);
            this.outputComboBox1.Name = "outputComboBox1";
            this.outputComboBox1.Size = new System.Drawing.Size(84, 21);
            this.outputComboBox1.TabIndex = 11;
            this.outputComboBox1.SelectedIndexChanged += new System.EventHandler(this.outputComboBox1_SelectedIndexChanged);
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(8, 163);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(37, 13);
            this.outputLabel2.TabIndex = 10;
            this.outputLabel2.Text = "output";
            this.ToolTip1.SetToolTip(this.outputLabel2, "What video system to use for output.\r\nPossible values: surface, overlay, opengl, " +
        "openglnb, ddraw.");
            // 
            // windowresolutionComboBox1
            // 
            this.windowresolutionComboBox1.FormattingEnabled = true;
            this.windowresolutionComboBox1.Location = new System.Drawing.Point(11, 139);
            this.windowresolutionComboBox1.Name = "windowresolutionComboBox1";
            this.windowresolutionComboBox1.Size = new System.Drawing.Size(84, 21);
            this.windowresolutionComboBox1.TabIndex = 9;
            this.windowresolutionComboBox1.SelectedIndexChanged += new System.EventHandler(this.windowresolutionComboBox1_SelectedIndexChanged);
            // 
            // windowresolutionLabel2
            // 
            this.windowresolutionLabel2.AutoSize = true;
            this.windowresolutionLabel2.Location = new System.Drawing.Point(8, 123);
            this.windowresolutionLabel2.Name = "windowresolutionLabel2";
            this.windowresolutionLabel2.Size = new System.Drawing.Size(88, 13);
            this.windowresolutionLabel2.TabIndex = 8;
            this.windowresolutionLabel2.Text = "windowresolution";
            this.ToolTip1.SetToolTip(this.windowresolutionLabel2, "Scale the window to this size IF the output device supports hardware scaling.\r\n(o" +
        "utput=surface does not!)");
            // 
            // fullresolutionComboBox1
            // 
            this.fullresolutionComboBox1.FormattingEnabled = true;
            this.fullresolutionComboBox1.Location = new System.Drawing.Point(11, 99);
            this.fullresolutionComboBox1.Name = "fullresolutionComboBox1";
            this.fullresolutionComboBox1.Size = new System.Drawing.Size(84, 21);
            this.fullresolutionComboBox1.TabIndex = 7;
            this.fullresolutionComboBox1.SelectedIndexChanged += new System.EventHandler(this.fullresolutionComboBox1_SelectedIndexChanged);
            // 
            // fullresolutionLabel
            // 
            this.fullresolutionLabel.AutoSize = true;
            this.fullresolutionLabel.Location = new System.Drawing.Point(8, 83);
            this.fullresolutionLabel.Name = "fullresolutionLabel";
            this.fullresolutionLabel.Size = new System.Drawing.Size(65, 13);
            this.fullresolutionLabel.TabIndex = 6;
            this.fullresolutionLabel.Text = "fullresolution";
            this.ToolTip1.SetToolTip(this.fullresolutionLabel, resources.GetString("fullresolutionLabel.ToolTip"));
            // 
            // fulldoubleComboBox1
            // 
            this.fulldoubleComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fulldoubleComboBox1.FormattingEnabled = true;
            this.fulldoubleComboBox1.Location = new System.Drawing.Point(11, 59);
            this.fulldoubleComboBox1.Name = "fulldoubleComboBox1";
            this.fulldoubleComboBox1.Size = new System.Drawing.Size(84, 21);
            this.fulldoubleComboBox1.TabIndex = 5;
            this.fulldoubleComboBox1.SelectedIndexChanged += new System.EventHandler(this.fulldoubleComboBox1_SelectedIndexChanged);
            // 
            // fulldoubleLabel1
            // 
            this.fulldoubleLabel1.AutoSize = true;
            this.fulldoubleLabel1.Location = new System.Drawing.Point(8, 43);
            this.fulldoubleLabel1.Name = "fulldoubleLabel1";
            this.fulldoubleLabel1.Size = new System.Drawing.Size(52, 13);
            this.fulldoubleLabel1.TabIndex = 4;
            this.fulldoubleLabel1.Text = "fulldouble";
            this.ToolTip1.SetToolTip(this.fulldoubleLabel1, "Use double buffering in fullscreen. It can reduce screen flickering, but it can a" +
        "lso result in a slow DOSBox.");
            // 
            // fullscreenComboBox1
            // 
            this.fullscreenComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullscreenComboBox1.FormattingEnabled = true;
            this.fullscreenComboBox1.Location = new System.Drawing.Point(11, 19);
            this.fullscreenComboBox1.Name = "fullscreenComboBox1";
            this.fullscreenComboBox1.Size = new System.Drawing.Size(84, 21);
            this.fullscreenComboBox1.TabIndex = 3;
            this.fullscreenComboBox1.SelectedIndexChanged += new System.EventHandler(this.fullscreenComboBox1_SelectedIndexChanged);
            // 
            // fullscreenLabel1
            // 
            this.fullscreenLabel1.AutoSize = true;
            this.fullscreenLabel1.Location = new System.Drawing.Point(8, 3);
            this.fullscreenLabel1.Name = "fullscreenLabel1";
            this.fullscreenLabel1.Size = new System.Drawing.Size(52, 13);
            this.fullscreenLabel1.TabIndex = 2;
            this.fullscreenLabel1.Text = "fullscreen";
            this.ToolTip1.SetToolTip(this.fullscreenLabel1, "Start DOSBox directly in fullscreen. (Press ALT-Enter to go back)");
            // 
            // tabDOSBox
            // 
            this.tabDOSBox.Controls.Add(this.btnLanguage);
            this.tabDOSBox.Controls.Add(this.memsizeComboBox1);
            this.tabDOSBox.Controls.Add(this.memsizeLabel2);
            this.tabDOSBox.Controls.Add(this.capturesButton2);
            this.tabDOSBox.Controls.Add(this.capturesTextBox2);
            this.tabDOSBox.Controls.Add(this.capturesLabel2);
            this.tabDOSBox.Controls.Add(this.machineComboBox1);
            this.tabDOSBox.Controls.Add(this.machineLabel2);
            this.tabDOSBox.Controls.Add(this.languageTextBox2);
            this.tabDOSBox.Controls.Add(this.languageLabel2);
            this.tabDOSBox.ImageKey = "DOSBox_icon_jYr_icon.ico";
            this.tabDOSBox.Location = new System.Drawing.Point(4, 42);
            this.tabDOSBox.Name = "tabDOSBox";
            this.tabDOSBox.Padding = new System.Windows.Forms.Padding(3);
            this.tabDOSBox.Size = new System.Drawing.Size(472, 425);
            this.tabDOSBox.TabIndex = 1;
            this.tabDOSBox.Text = "[DOSBox]";
            this.tabDOSBox.UseVisualStyleBackColor = true;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLanguage.AutoSize = true;
            this.btnLanguage.Location = new System.Drawing.Point(388, 15);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(76, 27);
            this.btnLanguage.TabIndex = 32;
            this.btnLanguage.Text = "Browse";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // memsizeComboBox1
            // 
            this.memsizeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memsizeComboBox1.FormattingEnabled = true;
            this.memsizeComboBox1.Location = new System.Drawing.Point(11, 137);
            this.memsizeComboBox1.Name = "memsizeComboBox1";
            this.memsizeComboBox1.Size = new System.Drawing.Size(84, 21);
            this.memsizeComboBox1.TabIndex = 31;
            this.memsizeComboBox1.SelectedIndexChanged += new System.EventHandler(this.memsizeComboBox1_SelectedIndexChanged);
            // 
            // memsizeLabel2
            // 
            this.memsizeLabel2.AutoSize = true;
            this.memsizeLabel2.Location = new System.Drawing.Point(8, 121);
            this.memsizeLabel2.Name = "memsizeLabel2";
            this.memsizeLabel2.Size = new System.Drawing.Size(47, 13);
            this.memsizeLabel2.TabIndex = 30;
            this.memsizeLabel2.Text = "memsize";
            this.ToolTip1.SetToolTip(this.memsizeLabel2, resources.GetString("memsizeLabel2.ToolTip"));
            // 
            // capturesButton2
            // 
            this.capturesButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.capturesButton2.AutoSize = true;
            this.capturesButton2.Location = new System.Drawing.Point(388, 94);
            this.capturesButton2.Name = "capturesButton2";
            this.capturesButton2.Size = new System.Drawing.Size(76, 27);
            this.capturesButton2.TabIndex = 29;
            this.capturesButton2.Text = "Browse";
            this.capturesButton2.UseVisualStyleBackColor = true;
            this.capturesButton2.Click += new System.EventHandler(this.capturesButton2_Click);
            // 
            // capturesTextBox2
            // 
            this.capturesTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.capturesTextBox2.Location = new System.Drawing.Point(11, 98);
            this.capturesTextBox2.Name = "capturesTextBox2";
            this.capturesTextBox2.Size = new System.Drawing.Size(371, 20);
            this.capturesTextBox2.TabIndex = 28;
            this.capturesTextBox2.TextChanged += new System.EventHandler(this.capturesTextBox2_TextChanged);
            // 
            // capturesLabel2
            // 
            this.capturesLabel2.AutoSize = true;
            this.capturesLabel2.Location = new System.Drawing.Point(8, 82);
            this.capturesLabel2.Name = "capturesLabel2";
            this.capturesLabel2.Size = new System.Drawing.Size(48, 13);
            this.capturesLabel2.TabIndex = 27;
            this.capturesLabel2.Text = "captures";
            this.ToolTip1.SetToolTip(this.capturesLabel2, "Directory where things like wave, midi, screenshot get captured.");
            // 
            // machineComboBox1
            // 
            this.machineComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machineComboBox1.FormattingEnabled = true;
            this.machineComboBox1.Location = new System.Drawing.Point(11, 58);
            this.machineComboBox1.Name = "machineComboBox1";
            this.machineComboBox1.Size = new System.Drawing.Size(84, 21);
            this.machineComboBox1.TabIndex = 26;
            this.machineComboBox1.SelectedIndexChanged += new System.EventHandler(this.machineComboBox1_SelectedIndexChanged);
            // 
            // machineLabel2
            // 
            this.machineLabel2.AutoSize = true;
            this.machineLabel2.Location = new System.Drawing.Point(8, 42);
            this.machineLabel2.Name = "machineLabel2";
            this.machineLabel2.Size = new System.Drawing.Size(47, 13);
            this.machineLabel2.TabIndex = 25;
            this.machineLabel2.Text = "machine";
            this.ToolTip1.SetToolTip(this.machineLabel2, "The type of machine DOSBox tries to emulate.\r\nPossible values: hercules, cga, tan" +
        "dy, pcjr, ega, vgaonly, svga_s3, svga_et3000, svga_et4000, svga_paradise, vesa_n" +
        "olfb, vesa_oldvbe.");
            // 
            // languageTextBox2
            // 
            this.languageTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageTextBox2.Location = new System.Drawing.Point(11, 19);
            this.languageTextBox2.Name = "languageTextBox2";
            this.languageTextBox2.Size = new System.Drawing.Size(371, 20);
            this.languageTextBox2.TabIndex = 24;
            this.languageTextBox2.TextChanged += new System.EventHandler(this.languageTextBox2_TextChanged);
            // 
            // languageLabel2
            // 
            this.languageLabel2.AutoSize = true;
            this.languageLabel2.Location = new System.Drawing.Point(8, 3);
            this.languageLabel2.Name = "languageLabel2";
            this.languageLabel2.Size = new System.Drawing.Size(51, 13);
            this.languageLabel2.TabIndex = 23;
            this.languageLabel2.Text = "language";
            this.ToolTip1.SetToolTip(this.languageLabel2, "Select another language file.");
            // 
            // tabRender
            // 
            this.tabRender.Controls.Add(this.scalerComboBox1);
            this.tabRender.Controls.Add(this.scalerLabel2);
            this.tabRender.Controls.Add(this.aspectComboBox1);
            this.tabRender.Controls.Add(this.aspectLabel2);
            this.tabRender.Controls.Add(this.frameskipTextBox2);
            this.tabRender.Controls.Add(this.frameskipLabel2);
            this.tabRender.ImageKey = "display_properties-3.png";
            this.tabRender.Location = new System.Drawing.Point(4, 42);
            this.tabRender.Name = "tabRender";
            this.tabRender.Padding = new System.Windows.Forms.Padding(3);
            this.tabRender.Size = new System.Drawing.Size(472, 425);
            this.tabRender.TabIndex = 2;
            this.tabRender.Text = "[render]";
            this.tabRender.UseVisualStyleBackColor = true;
            // 
            // scalerComboBox1
            // 
            this.scalerComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scalerComboBox1.FormattingEnabled = true;
            this.scalerComboBox1.Location = new System.Drawing.Point(9, 97);
            this.scalerComboBox1.Name = "scalerComboBox1";
            this.scalerComboBox1.Size = new System.Drawing.Size(84, 21);
            this.scalerComboBox1.TabIndex = 29;
            this.scalerComboBox1.SelectedIndexChanged += new System.EventHandler(this.scalerComboBox1_SelectedIndexChanged);
            // 
            // scalerLabel2
            // 
            this.scalerLabel2.AutoSize = true;
            this.scalerLabel2.Location = new System.Drawing.Point(7, 80);
            this.scalerLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scalerLabel2.Name = "scalerLabel2";
            this.scalerLabel2.Size = new System.Drawing.Size(35, 13);
            this.scalerLabel2.TabIndex = 28;
            this.scalerLabel2.Text = "scaler";
            this.ToolTip1.SetToolTip(this.scalerLabel2, resources.GetString("scalerLabel2.ToolTip"));
            // 
            // aspectComboBox1
            // 
            this.aspectComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aspectComboBox1.FormattingEnabled = true;
            this.aspectComboBox1.Location = new System.Drawing.Point(9, 57);
            this.aspectComboBox1.Name = "aspectComboBox1";
            this.aspectComboBox1.Size = new System.Drawing.Size(84, 21);
            this.aspectComboBox1.TabIndex = 27;
            this.aspectComboBox1.SelectedIndexChanged += new System.EventHandler(this.aspectComboBox1_SelectedIndexChanged);
            // 
            // aspectLabel2
            // 
            this.aspectLabel2.AutoSize = true;
            this.aspectLabel2.Location = new System.Drawing.Point(7, 40);
            this.aspectLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aspectLabel2.Name = "aspectLabel2";
            this.aspectLabel2.Size = new System.Drawing.Size(39, 13);
            this.aspectLabel2.TabIndex = 2;
            this.aspectLabel2.Text = "aspect";
            this.ToolTip1.SetToolTip(this.aspectLabel2, "Do aspect correction, if your output method doesn\'t support scaling this can slow" +
        " things down!");
            // 
            // frameskipTextBox2
            // 
            this.frameskipTextBox2.Location = new System.Drawing.Point(9, 20);
            this.frameskipTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.frameskipTextBox2.Name = "frameskipTextBox2";
            this.frameskipTextBox2.Size = new System.Drawing.Size(37, 20);
            this.frameskipTextBox2.TabIndex = 1;
            this.frameskipTextBox2.TextChanged += new System.EventHandler(this.frameskipTextBox2_TextChanged);
            this.frameskipTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frameskipTextBox2_KeyPress);
            // 
            // frameskipLabel2
            // 
            this.frameskipLabel2.AutoSize = true;
            this.frameskipLabel2.Location = new System.Drawing.Point(7, 3);
            this.frameskipLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.frameskipLabel2.Name = "frameskipLabel2";
            this.frameskipLabel2.Size = new System.Drawing.Size(52, 13);
            this.frameskipLabel2.TabIndex = 0;
            this.frameskipLabel2.Text = "frameskip";
            this.ToolTip1.SetToolTip(this.frameskipLabel2, "How many frames DOSBox skips before drawing one.");
            // 
            // tabCpu
            // 
            this.tabCpu.Controls.Add(this.cycledownTextBox2);
            this.tabCpu.Controls.Add(this.cycledownLabel2);
            this.tabCpu.Controls.Add(this.cycleupTextBox2);
            this.tabCpu.Controls.Add(this.cycleupLabel2);
            this.tabCpu.Controls.Add(this.cyclesComboBox1);
            this.tabCpu.Controls.Add(this.cyclesLabel2);
            this.tabCpu.Controls.Add(this.cputypeComboBox1);
            this.tabCpu.Controls.Add(this.cputypeLabel2);
            this.tabCpu.Controls.Add(this.coreComboBox1);
            this.tabCpu.Controls.Add(this.coreLabel2);
            this.tabCpu.ImageKey = "processor-1.png";
            this.tabCpu.Location = new System.Drawing.Point(4, 42);
            this.tabCpu.Name = "tabCpu";
            this.tabCpu.Padding = new System.Windows.Forms.Padding(3);
            this.tabCpu.Size = new System.Drawing.Size(472, 425);
            this.tabCpu.TabIndex = 3;
            this.tabCpu.Text = "[cpu]";
            this.tabCpu.UseVisualStyleBackColor = true;
            // 
            // cycledownTextBox2
            // 
            this.cycledownTextBox2.Location = new System.Drawing.Point(9, 180);
            this.cycledownTextBox2.Name = "cycledownTextBox2";
            this.cycledownTextBox2.Size = new System.Drawing.Size(37, 20);
            this.cycledownTextBox2.TabIndex = 37;
            this.cycledownTextBox2.TextChanged += new System.EventHandler(this.cycledownTextBox2_TextChanged);
            this.cycledownTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cycledownTextBox2_KeyPress);
            // 
            // cycledownLabel2
            // 
            this.cycledownLabel2.AutoSize = true;
            this.cycledownLabel2.Location = new System.Drawing.Point(7, 164);
            this.cycledownLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cycledownLabel2.Name = "cycledownLabel2";
            this.cycledownLabel2.Size = new System.Drawing.Size(58, 13);
            this.cycledownLabel2.TabIndex = 36;
            this.cycledownLabel2.Text = "cycledown";
            this.ToolTip1.SetToolTip(this.cycledownLabel2, "Setting it lower than 100 will be a percentage.");
            // 
            // cycleupTextBox2
            // 
            this.cycleupTextBox2.Location = new System.Drawing.Point(9, 141);
            this.cycleupTextBox2.Name = "cycleupTextBox2";
            this.cycleupTextBox2.Size = new System.Drawing.Size(37, 20);
            this.cycleupTextBox2.TabIndex = 35;
            this.cycleupTextBox2.TextChanged += new System.EventHandler(this.cycleupTextBox2_TextChanged);
            this.cycleupTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cycleupTextBox2_KeyPress);
            // 
            // cycleupLabel2
            // 
            this.cycleupLabel2.AutoSize = true;
            this.cycleupLabel2.Location = new System.Drawing.Point(7, 125);
            this.cycleupLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cycleupLabel2.Name = "cycleupLabel2";
            this.cycleupLabel2.Size = new System.Drawing.Size(44, 13);
            this.cycleupLabel2.TabIndex = 34;
            this.cycleupLabel2.Text = "cycleup";
            this.ToolTip1.SetToolTip(this.cycleupLabel2, "Amount of cycles to decrease/increase with keycombos.(CTRL-F11/CTRL-F12)");
            // 
            // cyclesComboBox1
            // 
            this.cyclesComboBox1.FormattingEnabled = true;
            this.cyclesComboBox1.Location = new System.Drawing.Point(9, 101);
            this.cyclesComboBox1.Name = "cyclesComboBox1";
            this.cyclesComboBox1.Size = new System.Drawing.Size(84, 21);
            this.cyclesComboBox1.TabIndex = 33;
            this.cyclesComboBox1.SelectedIndexChanged += new System.EventHandler(this.cyclesComboBox1_SelectedIndexChanged);
            // 
            // cyclesLabel2
            // 
            this.cyclesLabel2.AutoSize = true;
            this.cyclesLabel2.Location = new System.Drawing.Point(7, 84);
            this.cyclesLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cyclesLabel2.Name = "cyclesLabel2";
            this.cyclesLabel2.Size = new System.Drawing.Size(37, 13);
            this.cyclesLabel2.TabIndex = 32;
            this.cyclesLabel2.Text = "cycles";
            this.ToolTip1.SetToolTip(this.cyclesLabel2, resources.GetString("cyclesLabel2.ToolTip"));
            // 
            // cputypeComboBox1
            // 
            this.cputypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cputypeComboBox1.FormattingEnabled = true;
            this.cputypeComboBox1.Location = new System.Drawing.Point(9, 60);
            this.cputypeComboBox1.Name = "cputypeComboBox1";
            this.cputypeComboBox1.Size = new System.Drawing.Size(84, 21);
            this.cputypeComboBox1.TabIndex = 31;
            this.cputypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.cputypeComboBox1_SelectedIndexChanged);
            // 
            // cputypeLabel2
            // 
            this.cputypeLabel2.AutoSize = true;
            this.cputypeLabel2.Location = new System.Drawing.Point(7, 43);
            this.cputypeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cputypeLabel2.Name = "cputypeLabel2";
            this.cputypeLabel2.Size = new System.Drawing.Size(45, 13);
            this.cputypeLabel2.TabIndex = 30;
            this.cputypeLabel2.Text = "cputype";
            this.ToolTip1.SetToolTip(this.cputypeLabel2, "CPU Type used in emulation. auto is the fastest choice.\r\nPossible values: auto, 3" +
        "86, 386_slow, 486_slow, pentium_slow, 386_prefetch.");
            // 
            // coreComboBox1
            // 
            this.coreComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coreComboBox1.FormattingEnabled = true;
            this.coreComboBox1.Location = new System.Drawing.Point(9, 20);
            this.coreComboBox1.Name = "coreComboBox1";
            this.coreComboBox1.Size = new System.Drawing.Size(84, 21);
            this.coreComboBox1.TabIndex = 29;
            this.coreComboBox1.SelectedIndexChanged += new System.EventHandler(this.coreComboBox1_SelectedIndexChanged);
            // 
            // coreLabel2
            // 
            this.coreLabel2.AutoSize = true;
            this.coreLabel2.Location = new System.Drawing.Point(7, 3);
            this.coreLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coreLabel2.Name = "coreLabel2";
            this.coreLabel2.Size = new System.Drawing.Size(28, 13);
            this.coreLabel2.TabIndex = 28;
            this.coreLabel2.Text = "core";
            this.ToolTip1.SetToolTip(this.coreLabel2, "CPU Core used in emulation. auto will switch to dynamic if available and\r\nappropr" +
        "iate.\r\nPossible values: auto, dynamic, normal, simple.");
            // 
            // tabMixer
            // 
            this.tabMixer.Controls.Add(this.prebufferTextBox2);
            this.tabMixer.Controls.Add(this.prebufferLabel2);
            this.tabMixer.Controls.Add(this.blocksizeComboBox1);
            this.tabMixer.Controls.Add(this.blocksizeLabel2);
            this.tabMixer.Controls.Add(this.rateComboBox1);
            this.tabMixer.Controls.Add(this.rateLabel2);
            this.tabMixer.Controls.Add(this.nosoundComboBox1);
            this.tabMixer.Controls.Add(this.nosoundLabel2);
            this.tabMixer.ImageKey = "mixer_cd_sound-1.png";
            this.tabMixer.Location = new System.Drawing.Point(4, 42);
            this.tabMixer.Name = "tabMixer";
            this.tabMixer.Padding = new System.Windows.Forms.Padding(3);
            this.tabMixer.Size = new System.Drawing.Size(472, 425);
            this.tabMixer.TabIndex = 4;
            this.tabMixer.Text = "[mixer]";
            this.tabMixer.UseVisualStyleBackColor = true;
            // 
            // prebufferTextBox2
            // 
            this.prebufferTextBox2.Location = new System.Drawing.Point(9, 142);
            this.prebufferTextBox2.Name = "prebufferTextBox2";
            this.prebufferTextBox2.Size = new System.Drawing.Size(37, 20);
            this.prebufferTextBox2.TabIndex = 37;
            this.prebufferTextBox2.TextChanged += new System.EventHandler(this.prebufferTextBox2_TextChanged);
            this.prebufferTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prebufferTextBox2_KeyPress);
            // 
            // prebufferLabel2
            // 
            this.prebufferLabel2.AutoSize = true;
            this.prebufferLabel2.Location = new System.Drawing.Point(7, 126);
            this.prebufferLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prebufferLabel2.Name = "prebufferLabel2";
            this.prebufferLabel2.Size = new System.Drawing.Size(49, 13);
            this.prebufferLabel2.TabIndex = 36;
            this.prebufferLabel2.Text = "prebuffer";
            this.ToolTip1.SetToolTip(this.prebufferLabel2, "How many milliseconds of data to keep on top of the blocksize.");
            // 
            // blocksizeComboBox1
            // 
            this.blocksizeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blocksizeComboBox1.FormattingEnabled = true;
            this.blocksizeComboBox1.Location = new System.Drawing.Point(9, 102);
            this.blocksizeComboBox1.Name = "blocksizeComboBox1";
            this.blocksizeComboBox1.Size = new System.Drawing.Size(84, 21);
            this.blocksizeComboBox1.TabIndex = 35;
            this.blocksizeComboBox1.SelectedIndexChanged += new System.EventHandler(this.blocksizeComboBox1_SelectedIndexChanged);
            // 
            // blocksizeLabel2
            // 
            this.blocksizeLabel2.AutoSize = true;
            this.blocksizeLabel2.Location = new System.Drawing.Point(7, 85);
            this.blocksizeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blocksizeLabel2.Name = "blocksizeLabel2";
            this.blocksizeLabel2.Size = new System.Drawing.Size(51, 13);
            this.blocksizeLabel2.TabIndex = 34;
            this.blocksizeLabel2.Text = "blocksize";
            this.ToolTip1.SetToolTip(this.blocksizeLabel2, "ixer block size, larger blocks might help sound stuttering but sound will also be" +
        " more lagged.\r\nPossible values: 1024, 2048, 4096, 8192, 512, 256.");
            // 
            // rateComboBox1
            // 
            this.rateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rateComboBox1.FormattingEnabled = true;
            this.rateComboBox1.Location = new System.Drawing.Point(9, 61);
            this.rateComboBox1.Name = "rateComboBox1";
            this.rateComboBox1.Size = new System.Drawing.Size(84, 21);
            this.rateComboBox1.TabIndex = 33;
            this.rateComboBox1.SelectedIndexChanged += new System.EventHandler(this.rateComboBox1_SelectedIndexChanged);
            // 
            // rateLabel2
            // 
            this.rateLabel2.AutoSize = true;
            this.rateLabel2.Location = new System.Drawing.Point(7, 44);
            this.rateLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rateLabel2.Name = "rateLabel2";
            this.rateLabel2.Size = new System.Drawing.Size(25, 13);
            this.rateLabel2.TabIndex = 32;
            this.rateLabel2.Text = "rate";
            this.ToolTip1.SetToolTip(this.rateLabel2, "Mixer sample rate, setting any device\'s rate higher than this will probably lower" +
        " their sound quality.\r\nPossible values: 44100, 48000, 32000, 22050, 16000, 11025" +
        ", 8000, 49716.");
            // 
            // nosoundComboBox1
            // 
            this.nosoundComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nosoundComboBox1.FormattingEnabled = true;
            this.nosoundComboBox1.Location = new System.Drawing.Point(9, 20);
            this.nosoundComboBox1.Name = "nosoundComboBox1";
            this.nosoundComboBox1.Size = new System.Drawing.Size(84, 21);
            this.nosoundComboBox1.TabIndex = 31;
            this.nosoundComboBox1.SelectedIndexChanged += new System.EventHandler(this.nosoundComboBox1_SelectedIndexChanged);
            // 
            // nosoundLabel2
            // 
            this.nosoundLabel2.AutoSize = true;
            this.nosoundLabel2.Location = new System.Drawing.Point(7, 3);
            this.nosoundLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nosoundLabel2.Name = "nosoundLabel2";
            this.nosoundLabel2.Size = new System.Drawing.Size(48, 13);
            this.nosoundLabel2.TabIndex = 30;
            this.nosoundLabel2.Text = "nosound";
            this.ToolTip1.SetToolTip(this.nosoundLabel2, "Enable silent mode, sound is still emulated though.");
            // 
            // tabMidi
            // 
            this.tabMidi.Controls.Add(this.midiconfigTextBox2);
            this.tabMidi.Controls.Add(this.midiconfigLabel2);
            this.tabMidi.Controls.Add(this.midideviceComboBox1);
            this.tabMidi.Controls.Add(this.midideviceLabel2);
            this.tabMidi.Controls.Add(this.mpu401ComboBox1);
            this.tabMidi.Controls.Add(this.mpu401Label2);
            this.tabMidi.ImageKey = "midi_bl-0.png";
            this.tabMidi.Location = new System.Drawing.Point(4, 42);
            this.tabMidi.Name = "tabMidi";
            this.tabMidi.Padding = new System.Windows.Forms.Padding(3);
            this.tabMidi.Size = new System.Drawing.Size(472, 425);
            this.tabMidi.TabIndex = 5;
            this.tabMidi.Text = "[midi]";
            this.tabMidi.UseVisualStyleBackColor = true;
            // 
            // midiconfigTextBox2
            // 
            this.midiconfigTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.midiconfigTextBox2.Location = new System.Drawing.Point(9, 102);
            this.midiconfigTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.midiconfigTextBox2.Name = "midiconfigTextBox2";
            this.midiconfigTextBox2.Size = new System.Drawing.Size(455, 20);
            this.midiconfigTextBox2.TabIndex = 37;
            this.midiconfigTextBox2.TextChanged += new System.EventHandler(this.midiconfigTextBox2_TextChanged);
            // 
            // midiconfigLabel2
            // 
            this.midiconfigLabel2.AutoSize = true;
            this.midiconfigLabel2.Location = new System.Drawing.Point(7, 85);
            this.midiconfigLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.midiconfigLabel2.Name = "midiconfigLabel2";
            this.midiconfigLabel2.Size = new System.Drawing.Size(54, 13);
            this.midiconfigLabel2.TabIndex = 36;
            this.midiconfigLabel2.Text = "midiconfig";
            this.ToolTip1.SetToolTip(this.midiconfigLabel2, resources.GetString("midiconfigLabel2.ToolTip"));
            // 
            // midideviceComboBox1
            // 
            this.midideviceComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.midideviceComboBox1.FormattingEnabled = true;
            this.midideviceComboBox1.Location = new System.Drawing.Point(9, 61);
            this.midideviceComboBox1.Name = "midideviceComboBox1";
            this.midideviceComboBox1.Size = new System.Drawing.Size(84, 21);
            this.midideviceComboBox1.TabIndex = 35;
            this.midideviceComboBox1.SelectedIndexChanged += new System.EventHandler(this.midideviceComboBox1_SelectedIndexChanged);
            // 
            // midideviceLabel2
            // 
            this.midideviceLabel2.AutoSize = true;
            this.midideviceLabel2.Location = new System.Drawing.Point(7, 44);
            this.midideviceLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.midideviceLabel2.Name = "midideviceLabel2";
            this.midideviceLabel2.Size = new System.Drawing.Size(57, 13);
            this.midideviceLabel2.TabIndex = 34;
            this.midideviceLabel2.Text = "mididevice";
            this.ToolTip1.SetToolTip(this.midideviceLabel2, "Device that will receive the MIDI data from MPU-401.\r\nPossible values: default, w" +
        "in32, alsa, oss, coreaudio, coremidi, none.");
            // 
            // mpu401ComboBox1
            // 
            this.mpu401ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mpu401ComboBox1.FormattingEnabled = true;
            this.mpu401ComboBox1.Location = new System.Drawing.Point(9, 20);
            this.mpu401ComboBox1.Name = "mpu401ComboBox1";
            this.mpu401ComboBox1.Size = new System.Drawing.Size(84, 21);
            this.mpu401ComboBox1.TabIndex = 33;
            this.mpu401ComboBox1.SelectedIndexChanged += new System.EventHandler(this.mpu401ComboBox1_SelectedIndexChanged);
            // 
            // mpu401Label2
            // 
            this.mpu401Label2.AutoSize = true;
            this.mpu401Label2.Location = new System.Drawing.Point(7, 3);
            this.mpu401Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mpu401Label2.Name = "mpu401Label2";
            this.mpu401Label2.Size = new System.Drawing.Size(45, 13);
            this.mpu401Label2.TabIndex = 32;
            this.mpu401Label2.Text = "mpu401";
            this.ToolTip1.SetToolTip(this.mpu401Label2, "Type of MPU-401 to emulate.\r\nPossible values: intelligent, uart, none.");
            // 
            // tabSblaster
            // 
            this.tabSblaster.Controls.Add(this.irqComboBox1);
            this.tabSblaster.Controls.Add(this.irqLabel2);
            this.tabSblaster.Controls.Add(this.oplrateComboBox1);
            this.tabSblaster.Controls.Add(this.oplrateLabel2);
            this.tabSblaster.Controls.Add(this.oplemuComboBox1);
            this.tabSblaster.Controls.Add(this.oplemuLabel2);
            this.tabSblaster.Controls.Add(this.oplmodeComboBox1);
            this.tabSblaster.Controls.Add(this.oplmodeLabel2);
            this.tabSblaster.Controls.Add(this.sbmixerComboBox1);
            this.tabSblaster.Controls.Add(this.sbmixerLabel2);
            this.tabSblaster.Controls.Add(this.hdmaComboBox1);
            this.tabSblaster.Controls.Add(this.hdmaLabel2);
            this.tabSblaster.Controls.Add(this.dmaComboBox1);
            this.tabSblaster.Controls.Add(this.dmaLabel2);
            this.tabSblaster.Controls.Add(this.sbbaseComboBox1);
            this.tabSblaster.Controls.Add(this.sbbaseLabel2);
            this.tabSblaster.Controls.Add(this.sbtypeComboBox1);
            this.tabSblaster.Controls.Add(this.sbtypeLabel2);
            this.tabSblaster.ImageKey = "expansion_board-1.png";
            this.tabSblaster.Location = new System.Drawing.Point(4, 42);
            this.tabSblaster.Name = "tabSblaster";
            this.tabSblaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabSblaster.Size = new System.Drawing.Size(472, 425);
            this.tabSblaster.TabIndex = 6;
            this.tabSblaster.Text = "[sblaster]";
            this.tabSblaster.UseVisualStyleBackColor = true;
            // 
            // irqComboBox1
            // 
            this.irqComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.irqComboBox1.FormattingEnabled = true;
            this.irqComboBox1.Location = new System.Drawing.Point(9, 102);
            this.irqComboBox1.Name = "irqComboBox1";
            this.irqComboBox1.Size = new System.Drawing.Size(84, 21);
            this.irqComboBox1.TabIndex = 53;
            this.irqComboBox1.SelectedIndexChanged += new System.EventHandler(this.irqComboBox1_SelectedIndexChanged);
            // 
            // irqLabel2
            // 
            this.irqLabel2.AutoSize = true;
            this.irqLabel2.Location = new System.Drawing.Point(7, 85);
            this.irqLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.irqLabel2.Name = "irqLabel2";
            this.irqLabel2.Size = new System.Drawing.Size(18, 13);
            this.irqLabel2.TabIndex = 52;
            this.irqLabel2.Text = "irq";
            this.ToolTip1.SetToolTip(this.irqLabel2, "The IRQ number of the soundblaster.\r\nPossible values: 7, 5, 3, 9, 10, 11, 12.");
            // 
            // oplrateComboBox1
            // 
            this.oplrateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oplrateComboBox1.FormattingEnabled = true;
            this.oplrateComboBox1.Location = new System.Drawing.Point(9, 348);
            this.oplrateComboBox1.Name = "oplrateComboBox1";
            this.oplrateComboBox1.Size = new System.Drawing.Size(84, 21);
            this.oplrateComboBox1.TabIndex = 51;
            this.oplrateComboBox1.SelectedIndexChanged += new System.EventHandler(this.oplrateComboBox1_SelectedIndexChanged);
            // 
            // oplrateLabel2
            // 
            this.oplrateLabel2.AutoSize = true;
            this.oplrateLabel2.Location = new System.Drawing.Point(7, 331);
            this.oplrateLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oplrateLabel2.Name = "oplrateLabel2";
            this.oplrateLabel2.Size = new System.Drawing.Size(39, 13);
            this.oplrateLabel2.TabIndex = 50;
            this.oplrateLabel2.Text = "oplrate";
            this.ToolTip1.SetToolTip(this.oplrateLabel2, "Sample rate of OPL music emulation. Use 49716 for highest quality (set the mixer " +
        "rate accordingly).\r\nPossible values: 44100, 49716, 48000, 32000, 22050, 16000, 1" +
        "1025, 8000.");
            // 
            // oplemuComboBox1
            // 
            this.oplemuComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oplemuComboBox1.FormattingEnabled = true;
            this.oplemuComboBox1.Location = new System.Drawing.Point(9, 307);
            this.oplemuComboBox1.Name = "oplemuComboBox1";
            this.oplemuComboBox1.Size = new System.Drawing.Size(84, 21);
            this.oplemuComboBox1.TabIndex = 49;
            this.oplemuComboBox1.SelectedIndexChanged += new System.EventHandler(this.oplemuComboBox1_SelectedIndexChanged);
            // 
            // oplemuLabel2
            // 
            this.oplemuLabel2.AutoSize = true;
            this.oplemuLabel2.Location = new System.Drawing.Point(7, 290);
            this.oplemuLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oplemuLabel2.Name = "oplemuLabel2";
            this.oplemuLabel2.Size = new System.Drawing.Size(41, 13);
            this.oplemuLabel2.TabIndex = 48;
            this.oplemuLabel2.Text = "oplemu";
            this.ToolTip1.SetToolTip(this.oplemuLabel2, "Provider for the OPL emulation. compat might provide better quality (see oplrate " +
        "as well).\r\nPossible values: default, compat, fast.");
            // 
            // oplmodeComboBox1
            // 
            this.oplmodeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oplmodeComboBox1.FormattingEnabled = true;
            this.oplmodeComboBox1.Location = new System.Drawing.Point(9, 266);
            this.oplmodeComboBox1.Name = "oplmodeComboBox1";
            this.oplmodeComboBox1.Size = new System.Drawing.Size(84, 21);
            this.oplmodeComboBox1.TabIndex = 47;
            this.oplmodeComboBox1.SelectedIndexChanged += new System.EventHandler(this.oplmodeComboBox1_SelectedIndexChanged);
            // 
            // oplmodeLabel2
            // 
            this.oplmodeLabel2.AutoSize = true;
            this.oplmodeLabel2.Location = new System.Drawing.Point(7, 249);
            this.oplmodeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oplmodeLabel2.Name = "oplmodeLabel2";
            this.oplmodeLabel2.Size = new System.Drawing.Size(47, 13);
            this.oplmodeLabel2.TabIndex = 46;
            this.oplmodeLabel2.Text = "oplmode";
            this.ToolTip1.SetToolTip(this.oplmodeLabel2, "Type of OPL emulation. On \'auto\' the mode is determined by sblaster type. All OPL" +
        " modes are Adlib-compatible, except for \'cms\'.\r\nPossible values: auto, cms, opl2" +
        ", dualopl2, opl3, none.");
            // 
            // sbmixerComboBox1
            // 
            this.sbmixerComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbmixerComboBox1.FormattingEnabled = true;
            this.sbmixerComboBox1.Location = new System.Drawing.Point(9, 225);
            this.sbmixerComboBox1.Name = "sbmixerComboBox1";
            this.sbmixerComboBox1.Size = new System.Drawing.Size(84, 21);
            this.sbmixerComboBox1.TabIndex = 45;
            this.sbmixerComboBox1.SelectedIndexChanged += new System.EventHandler(this.sbmixerComboBox1_SelectedIndexChanged);
            // 
            // sbmixerLabel2
            // 
            this.sbmixerLabel2.AutoSize = true;
            this.sbmixerLabel2.Location = new System.Drawing.Point(7, 208);
            this.sbmixerLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sbmixerLabel2.Name = "sbmixerLabel2";
            this.sbmixerLabel2.Size = new System.Drawing.Size(42, 13);
            this.sbmixerLabel2.TabIndex = 44;
            this.sbmixerLabel2.Text = "sbmixer";
            this.ToolTip1.SetToolTip(this.sbmixerLabel2, "Allow the soundblaster mixer to modify the DOSBox mixer.");
            // 
            // hdmaComboBox1
            // 
            this.hdmaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hdmaComboBox1.FormattingEnabled = true;
            this.hdmaComboBox1.Location = new System.Drawing.Point(9, 184);
            this.hdmaComboBox1.Name = "hdmaComboBox1";
            this.hdmaComboBox1.Size = new System.Drawing.Size(84, 21);
            this.hdmaComboBox1.TabIndex = 43;
            this.hdmaComboBox1.SelectedIndexChanged += new System.EventHandler(this.hdmaComboBox1_SelectedIndexChanged);
            // 
            // hdmaLabel2
            // 
            this.hdmaLabel2.AutoSize = true;
            this.hdmaLabel2.Location = new System.Drawing.Point(7, 167);
            this.hdmaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hdmaLabel2.Name = "hdmaLabel2";
            this.hdmaLabel2.Size = new System.Drawing.Size(33, 13);
            this.hdmaLabel2.TabIndex = 42;
            this.hdmaLabel2.Text = "hdma";
            this.ToolTip1.SetToolTip(this.hdmaLabel2, "The High DMA number of the soundblaster.\r\nPossible values: 1, 5, 0, 3, 6, 7.");
            // 
            // dmaComboBox1
            // 
            this.dmaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dmaComboBox1.FormattingEnabled = true;
            this.dmaComboBox1.Location = new System.Drawing.Point(9, 143);
            this.dmaComboBox1.Name = "dmaComboBox1";
            this.dmaComboBox1.Size = new System.Drawing.Size(84, 21);
            this.dmaComboBox1.TabIndex = 41;
            this.dmaComboBox1.SelectedIndexChanged += new System.EventHandler(this.dmaComboBox1_SelectedIndexChanged);
            // 
            // dmaLabel2
            // 
            this.dmaLabel2.AutoSize = true;
            this.dmaLabel2.Location = new System.Drawing.Point(7, 126);
            this.dmaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dmaLabel2.Name = "dmaLabel2";
            this.dmaLabel2.Size = new System.Drawing.Size(27, 13);
            this.dmaLabel2.TabIndex = 40;
            this.dmaLabel2.Text = "dma";
            this.ToolTip1.SetToolTip(this.dmaLabel2, "The DMA number of the soundblaster.\r\nPossible values: 1, 5, 0, 3, 6, 7.");
            // 
            // sbbaseComboBox1
            // 
            this.sbbaseComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbbaseComboBox1.FormattingEnabled = true;
            this.sbbaseComboBox1.Location = new System.Drawing.Point(9, 61);
            this.sbbaseComboBox1.Name = "sbbaseComboBox1";
            this.sbbaseComboBox1.Size = new System.Drawing.Size(84, 21);
            this.sbbaseComboBox1.TabIndex = 37;
            this.sbbaseComboBox1.SelectedIndexChanged += new System.EventHandler(this.sbbaseComboBox1_SelectedIndexChanged);
            // 
            // sbbaseLabel2
            // 
            this.sbbaseLabel2.AutoSize = true;
            this.sbbaseLabel2.Location = new System.Drawing.Point(7, 44);
            this.sbbaseLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sbbaseLabel2.Name = "sbbaseLabel2";
            this.sbbaseLabel2.Size = new System.Drawing.Size(41, 13);
            this.sbbaseLabel2.TabIndex = 36;
            this.sbbaseLabel2.Text = "sbbase";
            this.ToolTip1.SetToolTip(this.sbbaseLabel2, "The IO address of the soundblaster.\r\nPossible values: 220, 240, 260, 280, 2a0, 2c" +
        "0, 2e0, 300.");
            // 
            // sbtypeComboBox1
            // 
            this.sbtypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbtypeComboBox1.FormattingEnabled = true;
            this.sbtypeComboBox1.Location = new System.Drawing.Point(9, 20);
            this.sbtypeComboBox1.Name = "sbtypeComboBox1";
            this.sbtypeComboBox1.Size = new System.Drawing.Size(84, 21);
            this.sbtypeComboBox1.TabIndex = 35;
            this.sbtypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.sbtypeComboBox1_SelectedIndexChanged);
            // 
            // sbtypeLabel2
            // 
            this.sbtypeLabel2.AutoSize = true;
            this.sbtypeLabel2.Location = new System.Drawing.Point(7, 3);
            this.sbtypeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sbtypeLabel2.Name = "sbtypeLabel2";
            this.sbtypeLabel2.Size = new System.Drawing.Size(38, 13);
            this.sbtypeLabel2.TabIndex = 34;
            this.sbtypeLabel2.Text = "sbtype";
            this.ToolTip1.SetToolTip(this.sbtypeLabel2, "Type of Soundblaster to emulate. gb is Gameblaster.\r\nPossible values: sb1, sb2, s" +
        "bpro1, sbpro2, sb16, gb, none.");
            // 
            // tabGus
            // 
            this.tabGus.Controls.Add(this.ultradirTextBox2);
            this.tabGus.Controls.Add(this.ultradirLabel2);
            this.tabGus.Controls.Add(this.gusdmaComboBox1);
            this.tabGus.Controls.Add(this.gusdmaLabel2);
            this.tabGus.Controls.Add(this.gusirqComboBox1);
            this.tabGus.Controls.Add(this.gusirqLabel2);
            this.tabGus.Controls.Add(this.gusbaseComboBox1);
            this.tabGus.Controls.Add(this.gusbaseLabel2);
            this.tabGus.Controls.Add(this.gusrateComboBox1);
            this.tabGus.Controls.Add(this.gusrateLabel2);
            this.tabGus.Controls.Add(this.gusComboBox1);
            this.tabGus.Controls.Add(this.gusLabel2);
            this.tabGus.ImageKey = "expansion_board_modem-1.png";
            this.tabGus.Location = new System.Drawing.Point(4, 42);
            this.tabGus.Name = "tabGus";
            this.tabGus.Padding = new System.Windows.Forms.Padding(3);
            this.tabGus.Size = new System.Drawing.Size(472, 425);
            this.tabGus.TabIndex = 7;
            this.tabGus.Text = "[gus]";
            this.tabGus.UseVisualStyleBackColor = true;
            // 
            // ultradirTextBox2
            // 
            this.ultradirTextBox2.Location = new System.Drawing.Point(9, 225);
            this.ultradirTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.ultradirTextBox2.Name = "ultradirTextBox2";
            this.ultradirTextBox2.Size = new System.Drawing.Size(84, 20);
            this.ultradirTextBox2.TabIndex = 47;
            this.ultradirTextBox2.TextChanged += new System.EventHandler(this.ultradirTextBox2_TextChanged);
            // 
            // ultradirLabel2
            // 
            this.ultradirLabel2.AutoSize = true;
            this.ultradirLabel2.Location = new System.Drawing.Point(7, 208);
            this.ultradirLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ultradirLabel2.Name = "ultradirLabel2";
            this.ultradirLabel2.Size = new System.Drawing.Size(38, 13);
            this.ultradirLabel2.TabIndex = 46;
            this.ultradirLabel2.Text = "ultradir";
            this.ToolTip1.SetToolTip(this.ultradirLabel2, "Path to Ultrasound directory. In this directory\r\nthere should be a MIDI directory" +
        " that contains\r\nthe patch files for GUS playback. Patch sets used\r\nwith Timidity" +
        " should work fine.");
            // 
            // gusdmaComboBox1
            // 
            this.gusdmaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gusdmaComboBox1.FormattingEnabled = true;
            this.gusdmaComboBox1.Location = new System.Drawing.Point(9, 184);
            this.gusdmaComboBox1.Name = "gusdmaComboBox1";
            this.gusdmaComboBox1.Size = new System.Drawing.Size(84, 21);
            this.gusdmaComboBox1.TabIndex = 45;
            this.gusdmaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gusdmaComboBox1_SelectedIndexChanged);
            // 
            // gusdmaLabel2
            // 
            this.gusdmaLabel2.AutoSize = true;
            this.gusdmaLabel2.Location = new System.Drawing.Point(7, 167);
            this.gusdmaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gusdmaLabel2.Name = "gusdmaLabel2";
            this.gusdmaLabel2.Size = new System.Drawing.Size(44, 13);
            this.gusdmaLabel2.TabIndex = 44;
            this.gusdmaLabel2.Text = "gusdma";
            this.ToolTip1.SetToolTip(this.gusdmaLabel2, "The DMA channel of the Gravis Ultrasound.\r\nPossible values: 3, 0, 1, 5, 6, 7.");
            // 
            // gusirqComboBox1
            // 
            this.gusirqComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gusirqComboBox1.FormattingEnabled = true;
            this.gusirqComboBox1.Location = new System.Drawing.Point(9, 143);
            this.gusirqComboBox1.Name = "gusirqComboBox1";
            this.gusirqComboBox1.Size = new System.Drawing.Size(84, 21);
            this.gusirqComboBox1.TabIndex = 43;
            this.gusirqComboBox1.SelectedIndexChanged += new System.EventHandler(this.gusirqComboBox1_SelectedIndexChanged);
            // 
            // gusirqLabel2
            // 
            this.gusirqLabel2.AutoSize = true;
            this.gusirqLabel2.Location = new System.Drawing.Point(7, 126);
            this.gusirqLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gusirqLabel2.Name = "gusirqLabel2";
            this.gusirqLabel2.Size = new System.Drawing.Size(35, 13);
            this.gusirqLabel2.TabIndex = 42;
            this.gusirqLabel2.Text = "gusirq";
            this.ToolTip1.SetToolTip(this.gusirqLabel2, "The IRQ number of the Gravis Ultrasound.\r\nPossible values: 5, 3, 7, 9, 10, 11, 12" +
        ".");
            // 
            // gusbaseComboBox1
            // 
            this.gusbaseComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gusbaseComboBox1.FormattingEnabled = true;
            this.gusbaseComboBox1.Location = new System.Drawing.Point(9, 102);
            this.gusbaseComboBox1.Name = "gusbaseComboBox1";
            this.gusbaseComboBox1.Size = new System.Drawing.Size(84, 21);
            this.gusbaseComboBox1.TabIndex = 41;
            this.gusbaseComboBox1.SelectedIndexChanged += new System.EventHandler(this.gusbaseComboBox1_SelectedIndexChanged);
            // 
            // gusbaseLabel2
            // 
            this.gusbaseLabel2.AutoSize = true;
            this.gusbaseLabel2.Location = new System.Drawing.Point(7, 85);
            this.gusbaseLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gusbaseLabel2.Name = "gusbaseLabel2";
            this.gusbaseLabel2.Size = new System.Drawing.Size(47, 13);
            this.gusbaseLabel2.TabIndex = 40;
            this.gusbaseLabel2.Text = "gusbase";
            this.ToolTip1.SetToolTip(this.gusbaseLabel2, "The IO base address of the Gravis Ultrasound.\r\nPossible values: 240, 220, 260, 28" +
        "0, 2a0, 2c0, 2e0, 300.");
            // 
            // gusrateComboBox1
            // 
            this.gusrateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gusrateComboBox1.FormattingEnabled = true;
            this.gusrateComboBox1.Location = new System.Drawing.Point(9, 61);
            this.gusrateComboBox1.Name = "gusrateComboBox1";
            this.gusrateComboBox1.Size = new System.Drawing.Size(84, 21);
            this.gusrateComboBox1.TabIndex = 39;
            this.gusrateComboBox1.SelectedIndexChanged += new System.EventHandler(this.gusrateComboBox1_SelectedIndexChanged);
            // 
            // gusrateLabel2
            // 
            this.gusrateLabel2.AutoSize = true;
            this.gusrateLabel2.Location = new System.Drawing.Point(7, 44);
            this.gusrateLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gusrateLabel2.Name = "gusrateLabel2";
            this.gusrateLabel2.Size = new System.Drawing.Size(42, 13);
            this.gusrateLabel2.TabIndex = 38;
            this.gusrateLabel2.Text = "gusrate";
            this.ToolTip1.SetToolTip(this.gusrateLabel2, "Sample rate of Ultrasound emulation.\r\nPossible values: 44100, 48000, 32000, 22050" +
        ", 16000, 11025, 8000, 49716.");
            // 
            // gusComboBox1
            // 
            this.gusComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gusComboBox1.FormattingEnabled = true;
            this.gusComboBox1.Location = new System.Drawing.Point(9, 20);
            this.gusComboBox1.Name = "gusComboBox1";
            this.gusComboBox1.Size = new System.Drawing.Size(84, 21);
            this.gusComboBox1.TabIndex = 37;
            this.gusComboBox1.SelectedIndexChanged += new System.EventHandler(this.gusComboBox1_SelectedIndexChanged);
            // 
            // gusLabel2
            // 
            this.gusLabel2.AutoSize = true;
            this.gusLabel2.Location = new System.Drawing.Point(7, 3);
            this.gusLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gusLabel2.Name = "gusLabel2";
            this.gusLabel2.Size = new System.Drawing.Size(24, 13);
            this.gusLabel2.TabIndex = 36;
            this.gusLabel2.Text = "gus";
            this.ToolTip1.SetToolTip(this.gusLabel2, "Enable the Gravis Ultrasound emulation.");
            // 
            // tabSpeaker
            // 
            this.tabSpeaker.Controls.Add(this.disneyComboBox1);
            this.tabSpeaker.Controls.Add(this.disneyLabel2);
            this.tabSpeaker.Controls.Add(this.tandyrateComboBox1);
            this.tabSpeaker.Controls.Add(this.tandyrateLabel2);
            this.tabSpeaker.Controls.Add(this.tandyComboBox1);
            this.tabSpeaker.Controls.Add(this.tandyLabel2);
            this.tabSpeaker.Controls.Add(this.pcrateComboBox1);
            this.tabSpeaker.Controls.Add(this.pcrateLabel2);
            this.tabSpeaker.Controls.Add(this.pcspeakerComboBox1);
            this.tabSpeaker.Controls.Add(this.pcspeakerLabel2);
            this.tabSpeaker.ImageKey = "loudspeaker_rays-0.png";
            this.tabSpeaker.Location = new System.Drawing.Point(4, 42);
            this.tabSpeaker.Name = "tabSpeaker";
            this.tabSpeaker.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpeaker.Size = new System.Drawing.Size(472, 425);
            this.tabSpeaker.TabIndex = 8;
            this.tabSpeaker.Text = "[speaker]";
            this.tabSpeaker.UseVisualStyleBackColor = true;
            // 
            // disneyComboBox1
            // 
            this.disneyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disneyComboBox1.FormattingEnabled = true;
            this.disneyComboBox1.Location = new System.Drawing.Point(9, 184);
            this.disneyComboBox1.Name = "disneyComboBox1";
            this.disneyComboBox1.Size = new System.Drawing.Size(84, 21);
            this.disneyComboBox1.TabIndex = 47;
            this.disneyComboBox1.SelectedIndexChanged += new System.EventHandler(this.disneyComboBox1_SelectedIndexChanged);
            // 
            // disneyLabel2
            // 
            this.disneyLabel2.AutoSize = true;
            this.disneyLabel2.Location = new System.Drawing.Point(7, 167);
            this.disneyLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.disneyLabel2.Name = "disneyLabel2";
            this.disneyLabel2.Size = new System.Drawing.Size(37, 13);
            this.disneyLabel2.TabIndex = 46;
            this.disneyLabel2.Text = "disney";
            this.ToolTip1.SetToolTip(this.disneyLabel2, "Enable Disney Sound Source emulation. (Covox Voice Master and Speech Thing compat" +
        "ible).");
            // 
            // tandyrateComboBox1
            // 
            this.tandyrateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tandyrateComboBox1.FormattingEnabled = true;
            this.tandyrateComboBox1.Location = new System.Drawing.Point(9, 143);
            this.tandyrateComboBox1.Name = "tandyrateComboBox1";
            this.tandyrateComboBox1.Size = new System.Drawing.Size(84, 21);
            this.tandyrateComboBox1.TabIndex = 45;
            this.tandyrateComboBox1.SelectedIndexChanged += new System.EventHandler(this.tandyrateComboBox1_SelectedIndexChanged);
            // 
            // tandyrateLabel2
            // 
            this.tandyrateLabel2.AutoSize = true;
            this.tandyrateLabel2.Location = new System.Drawing.Point(7, 126);
            this.tandyrateLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tandyrateLabel2.Name = "tandyrateLabel2";
            this.tandyrateLabel2.Size = new System.Drawing.Size(51, 13);
            this.tandyrateLabel2.TabIndex = 44;
            this.tandyrateLabel2.Text = "tandyrate";
            this.ToolTip1.SetToolTip(this.tandyrateLabel2, "Sample rate of the Tandy 3-Voice generation.\r\nPossible values: 44100, 48000, 3200" +
        "0, 22050, 16000, 11025, 8000, 49716.");
            // 
            // tandyComboBox1
            // 
            this.tandyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tandyComboBox1.FormattingEnabled = true;
            this.tandyComboBox1.Location = new System.Drawing.Point(9, 102);
            this.tandyComboBox1.Name = "tandyComboBox1";
            this.tandyComboBox1.Size = new System.Drawing.Size(84, 21);
            this.tandyComboBox1.TabIndex = 43;
            this.tandyComboBox1.SelectedIndexChanged += new System.EventHandler(this.tandyComboBox1_SelectedIndexChanged);
            // 
            // tandyLabel2
            // 
            this.tandyLabel2.AutoSize = true;
            this.tandyLabel2.Location = new System.Drawing.Point(7, 85);
            this.tandyLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tandyLabel2.Name = "tandyLabel2";
            this.tandyLabel2.Size = new System.Drawing.Size(33, 13);
            this.tandyLabel2.TabIndex = 42;
            this.tandyLabel2.Text = "tandy";
            this.ToolTip1.SetToolTip(this.tandyLabel2, "Enable Tandy Sound System emulation. For \'auto\', emulation is present only if mac" +
        "hine is set to \'tandy\'.\r\nPossible values: auto, on, off.");
            // 
            // pcrateComboBox1
            // 
            this.pcrateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcrateComboBox1.FormattingEnabled = true;
            this.pcrateComboBox1.Location = new System.Drawing.Point(9, 61);
            this.pcrateComboBox1.Name = "pcrateComboBox1";
            this.pcrateComboBox1.Size = new System.Drawing.Size(84, 21);
            this.pcrateComboBox1.TabIndex = 41;
            this.pcrateComboBox1.SelectedIndexChanged += new System.EventHandler(this.pcrateComboBox1_SelectedIndexChanged);
            // 
            // pcrateLabel2
            // 
            this.pcrateLabel2.AutoSize = true;
            this.pcrateLabel2.Location = new System.Drawing.Point(7, 44);
            this.pcrateLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pcrateLabel2.Name = "pcrateLabel2";
            this.pcrateLabel2.Size = new System.Drawing.Size(37, 13);
            this.pcrateLabel2.TabIndex = 40;
            this.pcrateLabel2.Text = "pcrate";
            this.ToolTip1.SetToolTip(this.pcrateLabel2, "Sample rate of the PC-Speaker sound generation.\r\nPossible values: 44100, 48000, 3" +
        "2000, 22050, 16000, 11025, 8000, 49716.");
            // 
            // pcspeakerComboBox1
            // 
            this.pcspeakerComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcspeakerComboBox1.FormattingEnabled = true;
            this.pcspeakerComboBox1.Location = new System.Drawing.Point(9, 20);
            this.pcspeakerComboBox1.Name = "pcspeakerComboBox1";
            this.pcspeakerComboBox1.Size = new System.Drawing.Size(84, 21);
            this.pcspeakerComboBox1.TabIndex = 39;
            this.pcspeakerComboBox1.SelectedIndexChanged += new System.EventHandler(this.pcspeakerComboBox1_SelectedIndexChanged);
            // 
            // pcspeakerLabel2
            // 
            this.pcspeakerLabel2.AutoSize = true;
            this.pcspeakerLabel2.Location = new System.Drawing.Point(7, 3);
            this.pcspeakerLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pcspeakerLabel2.Name = "pcspeakerLabel2";
            this.pcspeakerLabel2.Size = new System.Drawing.Size(57, 13);
            this.pcspeakerLabel2.TabIndex = 38;
            this.pcspeakerLabel2.Text = "pcspeaker";
            this.ToolTip1.SetToolTip(this.pcspeakerLabel2, "Enable PC-Speaker emulation.");
            // 
            // tabJoystick
            // 
            this.tabJoystick.Controls.Add(this.buttonwrapComboBox1);
            this.tabJoystick.Controls.Add(this.buttonwrapLabel2);
            this.tabJoystick.Controls.Add(this.swap34ComboBox1);
            this.tabJoystick.Controls.Add(this.swap34Label2);
            this.tabJoystick.Controls.Add(this.autofireComboBox1);
            this.tabJoystick.Controls.Add(this.autofireLabel2);
            this.tabJoystick.Controls.Add(this.timedComboBox1);
            this.tabJoystick.Controls.Add(this.timedLabel2);
            this.tabJoystick.Controls.Add(this.joysticktypeComboBox1);
            this.tabJoystick.Controls.Add(this.joysticktypeLabel2);
            this.tabJoystick.ImageKey = "joystick-0.png";
            this.tabJoystick.Location = new System.Drawing.Point(4, 42);
            this.tabJoystick.Name = "tabJoystick";
            this.tabJoystick.Padding = new System.Windows.Forms.Padding(3);
            this.tabJoystick.Size = new System.Drawing.Size(472, 425);
            this.tabJoystick.TabIndex = 9;
            this.tabJoystick.Text = "[joystick]";
            this.tabJoystick.UseVisualStyleBackColor = true;
            // 
            // buttonwrapComboBox1
            // 
            this.buttonwrapComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buttonwrapComboBox1.FormattingEnabled = true;
            this.buttonwrapComboBox1.Location = new System.Drawing.Point(9, 184);
            this.buttonwrapComboBox1.Name = "buttonwrapComboBox1";
            this.buttonwrapComboBox1.Size = new System.Drawing.Size(84, 21);
            this.buttonwrapComboBox1.TabIndex = 49;
            this.buttonwrapComboBox1.SelectedIndexChanged += new System.EventHandler(this.buttonwrapComboBox1_SelectedIndexChanged);
            // 
            // buttonwrapLabel2
            // 
            this.buttonwrapLabel2.AutoSize = true;
            this.buttonwrapLabel2.Location = new System.Drawing.Point(7, 167);
            this.buttonwrapLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buttonwrapLabel2.Name = "buttonwrapLabel2";
            this.buttonwrapLabel2.Size = new System.Drawing.Size(60, 13);
            this.buttonwrapLabel2.TabIndex = 48;
            this.buttonwrapLabel2.Text = "buttonwrap";
            this.ToolTip1.SetToolTip(this.buttonwrapLabel2, "enable button wrapping at the number of emulated buttons.");
            // 
            // swap34ComboBox1
            // 
            this.swap34ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.swap34ComboBox1.FormattingEnabled = true;
            this.swap34ComboBox1.Location = new System.Drawing.Point(9, 143);
            this.swap34ComboBox1.Name = "swap34ComboBox1";
            this.swap34ComboBox1.Size = new System.Drawing.Size(84, 21);
            this.swap34ComboBox1.TabIndex = 47;
            this.swap34ComboBox1.SelectedIndexChanged += new System.EventHandler(this.swap34ComboBox1_SelectedIndexChanged);
            // 
            // swap34Label2
            // 
            this.swap34Label2.AutoSize = true;
            this.swap34Label2.Location = new System.Drawing.Point(7, 126);
            this.swap34Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.swap34Label2.Name = "swap34Label2";
            this.swap34Label2.Size = new System.Drawing.Size(44, 13);
            this.swap34Label2.TabIndex = 46;
            this.swap34Label2.Text = "swap34";
            this.ToolTip1.SetToolTip(this.swap34Label2, "swap the 3rd and the 4th axis. Can be useful for certain joysticks.");
            // 
            // autofireComboBox1
            // 
            this.autofireComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autofireComboBox1.FormattingEnabled = true;
            this.autofireComboBox1.Location = new System.Drawing.Point(9, 102);
            this.autofireComboBox1.Name = "autofireComboBox1";
            this.autofireComboBox1.Size = new System.Drawing.Size(84, 21);
            this.autofireComboBox1.TabIndex = 45;
            this.autofireComboBox1.SelectedIndexChanged += new System.EventHandler(this.autofireComboBox1_SelectedIndexChanged);
            // 
            // autofireLabel2
            // 
            this.autofireLabel2.AutoSize = true;
            this.autofireLabel2.Location = new System.Drawing.Point(7, 85);
            this.autofireLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autofireLabel2.Name = "autofireLabel2";
            this.autofireLabel2.Size = new System.Drawing.Size(42, 13);
            this.autofireLabel2.TabIndex = 44;
            this.autofireLabel2.Text = "autofire";
            this.ToolTip1.SetToolTip(this.autofireLabel2, "continuously fires as long as you keep the button pressed.");
            // 
            // timedComboBox1
            // 
            this.timedComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timedComboBox1.FormattingEnabled = true;
            this.timedComboBox1.Location = new System.Drawing.Point(9, 61);
            this.timedComboBox1.Name = "timedComboBox1";
            this.timedComboBox1.Size = new System.Drawing.Size(84, 21);
            this.timedComboBox1.TabIndex = 43;
            this.timedComboBox1.SelectedIndexChanged += new System.EventHandler(this.timedComboBox1_SelectedIndexChanged);
            // 
            // timedLabel2
            // 
            this.timedLabel2.AutoSize = true;
            this.timedLabel2.Location = new System.Drawing.Point(7, 44);
            this.timedLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timedLabel2.Name = "timedLabel2";
            this.timedLabel2.Size = new System.Drawing.Size(32, 13);
            this.timedLabel2.TabIndex = 42;
            this.timedLabel2.Text = "timed";
            this.ToolTip1.SetToolTip(this.timedLabel2, "enable timed intervals for axis. Experiment with this option, if your joystick dr" +
        "ifts (away).");
            // 
            // joysticktypeComboBox1
            // 
            this.joysticktypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.joysticktypeComboBox1.FormattingEnabled = true;
            this.joysticktypeComboBox1.Location = new System.Drawing.Point(9, 20);
            this.joysticktypeComboBox1.Name = "joysticktypeComboBox1";
            this.joysticktypeComboBox1.Size = new System.Drawing.Size(84, 21);
            this.joysticktypeComboBox1.TabIndex = 41;
            this.joysticktypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.joysticktypeComboBox1_SelectedIndexChanged);
            // 
            // joysticktypeLabel2
            // 
            this.joysticktypeLabel2.AutoSize = true;
            this.joysticktypeLabel2.Location = new System.Drawing.Point(7, 3);
            this.joysticktypeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.joysticktypeLabel2.Name = "joysticktypeLabel2";
            this.joysticktypeLabel2.Size = new System.Drawing.Size(62, 13);
            this.joysticktypeLabel2.TabIndex = 40;
            this.joysticktypeLabel2.Text = "joysticktype";
            this.ToolTip1.SetToolTip(this.joysticktypeLabel2, resources.GetString("joysticktypeLabel2.ToolTip"));
            // 
            // tabSerial
            // 
            this.tabSerial.Controls.Add(this.serial4ComboBox1);
            this.tabSerial.Controls.Add(this.serial4Label2);
            this.tabSerial.Controls.Add(this.serial3ComboBox1);
            this.tabSerial.Controls.Add(this.serial3Label2);
            this.tabSerial.Controls.Add(this.serial2ComboBox1);
            this.tabSerial.Controls.Add(this.serial2Label2);
            this.tabSerial.Controls.Add(this.serial1ComboBox1);
            this.tabSerial.Controls.Add(this.serial1Label2);
            this.tabSerial.ImageKey = "cable-0.png";
            this.tabSerial.Location = new System.Drawing.Point(4, 42);
            this.tabSerial.Name = "tabSerial";
            this.tabSerial.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerial.Size = new System.Drawing.Size(472, 425);
            this.tabSerial.TabIndex = 10;
            this.tabSerial.Text = "[serial]";
            this.tabSerial.UseVisualStyleBackColor = true;
            // 
            // serial4ComboBox1
            // 
            this.serial4ComboBox1.FormattingEnabled = true;
            this.serial4ComboBox1.Location = new System.Drawing.Point(9, 143);
            this.serial4ComboBox1.Name = "serial4ComboBox1";
            this.serial4ComboBox1.Size = new System.Drawing.Size(84, 21);
            this.serial4ComboBox1.TabIndex = 49;
            this.serial4ComboBox1.SelectedIndexChanged += new System.EventHandler(this.serial4ComboBox1_SelectedIndexChanged);
            // 
            // serial4Label2
            // 
            this.serial4Label2.AutoSize = true;
            this.serial4Label2.Location = new System.Drawing.Point(7, 126);
            this.serial4Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serial4Label2.Name = "serial4Label2";
            this.serial4Label2.Size = new System.Drawing.Size(37, 13);
            this.serial4Label2.TabIndex = 48;
            this.serial4Label2.Text = "serial4";
            this.ToolTip1.SetToolTip(this.serial4Label2, "see serial1\r\nPossible values: dummy, disabled, modem, nullmodem, directserial.");
            // 
            // serial3ComboBox1
            // 
            this.serial3ComboBox1.FormattingEnabled = true;
            this.serial3ComboBox1.Location = new System.Drawing.Point(9, 102);
            this.serial3ComboBox1.Name = "serial3ComboBox1";
            this.serial3ComboBox1.Size = new System.Drawing.Size(84, 21);
            this.serial3ComboBox1.TabIndex = 47;
            this.serial3ComboBox1.SelectedIndexChanged += new System.EventHandler(this.serial3ComboBox1_SelectedIndexChanged);
            // 
            // serial3Label2
            // 
            this.serial3Label2.AutoSize = true;
            this.serial3Label2.Location = new System.Drawing.Point(7, 85);
            this.serial3Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serial3Label2.Name = "serial3Label2";
            this.serial3Label2.Size = new System.Drawing.Size(37, 13);
            this.serial3Label2.TabIndex = 46;
            this.serial3Label2.Text = "serial3";
            this.ToolTip1.SetToolTip(this.serial3Label2, "see serial1\r\nPossible values: dummy, disabled, modem, nullmodem, directserial.");
            // 
            // serial2ComboBox1
            // 
            this.serial2ComboBox1.FormattingEnabled = true;
            this.serial2ComboBox1.Location = new System.Drawing.Point(9, 61);
            this.serial2ComboBox1.Name = "serial2ComboBox1";
            this.serial2ComboBox1.Size = new System.Drawing.Size(84, 21);
            this.serial2ComboBox1.TabIndex = 45;
            this.serial2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.serial2ComboBox1_SelectedIndexChanged);
            // 
            // serial2Label2
            // 
            this.serial2Label2.AutoSize = true;
            this.serial2Label2.Location = new System.Drawing.Point(7, 44);
            this.serial2Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serial2Label2.Name = "serial2Label2";
            this.serial2Label2.Size = new System.Drawing.Size(37, 13);
            this.serial2Label2.TabIndex = 44;
            this.serial2Label2.Text = "serial2";
            this.ToolTip1.SetToolTip(this.serial2Label2, "see serial1\r\nPossible values: dummy, disabled, modem, nullmodem, directserial.");
            // 
            // serial1ComboBox1
            // 
            this.serial1ComboBox1.FormattingEnabled = true;
            this.serial1ComboBox1.Location = new System.Drawing.Point(9, 20);
            this.serial1ComboBox1.Name = "serial1ComboBox1";
            this.serial1ComboBox1.Size = new System.Drawing.Size(84, 21);
            this.serial1ComboBox1.TabIndex = 43;
            this.serial1ComboBox1.SelectedIndexChanged += new System.EventHandler(this.serial1ComboBox1_SelectedIndexChanged);
            // 
            // serial1Label2
            // 
            this.serial1Label2.AutoSize = true;
            this.serial1Label2.Location = new System.Drawing.Point(7, 3);
            this.serial1Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serial1Label2.Name = "serial1Label2";
            this.serial1Label2.Size = new System.Drawing.Size(37, 13);
            this.serial1Label2.TabIndex = 42;
            this.serial1Label2.Text = "serial1";
            this.ToolTip1.SetToolTip(this.serial1Label2, resources.GetString("serial1Label2.ToolTip"));
            // 
            // tabDos
            // 
            this.tabDos.Controls.Add(this.keyboardlayoutComboBox1);
            this.tabDos.Controls.Add(this.keyboardlayoutLabel2);
            this.tabDos.Controls.Add(this.umbComboBox1);
            this.tabDos.Controls.Add(this.umbLabel2);
            this.tabDos.Controls.Add(this.emsComboBox1);
            this.tabDos.Controls.Add(this.emsLabel2);
            this.tabDos.Controls.Add(this.xmsComboBox1);
            this.tabDos.Controls.Add(this.xmsLabel2);
            this.tabDos.ImageKey = "console_prompt-1.png";
            this.tabDos.Location = new System.Drawing.Point(4, 42);
            this.tabDos.Name = "tabDos";
            this.tabDos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDos.Size = new System.Drawing.Size(472, 425);
            this.tabDos.TabIndex = 11;
            this.tabDos.Text = "[dos]";
            this.tabDos.UseVisualStyleBackColor = true;
            // 
            // keyboardlayoutComboBox1
            // 
            this.keyboardlayoutComboBox1.DisplayMember = "name";
            this.keyboardlayoutComboBox1.FormattingEnabled = true;
            this.keyboardlayoutComboBox1.Location = new System.Drawing.Point(10, 142);
            this.keyboardlayoutComboBox1.Name = "keyboardlayoutComboBox1";
            this.keyboardlayoutComboBox1.Size = new System.Drawing.Size(145, 21);
            this.keyboardlayoutComboBox1.TabIndex = 49;
            this.keyboardlayoutComboBox1.ValueMember = "code";
            this.keyboardlayoutComboBox1.SelectedIndexChanged += new System.EventHandler(this.keyboardlayoutComboBox1_SelectedIndexChanged);
            // 
            // keyboardlayoutLabel2
            // 
            this.keyboardlayoutLabel2.AutoSize = true;
            this.keyboardlayoutLabel2.Location = new System.Drawing.Point(7, 126);
            this.keyboardlayoutLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyboardlayoutLabel2.Name = "keyboardlayoutLabel2";
            this.keyboardlayoutLabel2.Size = new System.Drawing.Size(79, 13);
            this.keyboardlayoutLabel2.TabIndex = 48;
            this.keyboardlayoutLabel2.Text = "keyboardlayout";
            this.ToolTip1.SetToolTip(this.keyboardlayoutLabel2, "Language code of the keyboard layout (or none).");
            // 
            // umbComboBox1
            // 
            this.umbComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.umbComboBox1.FormattingEnabled = true;
            this.umbComboBox1.Location = new System.Drawing.Point(9, 102);
            this.umbComboBox1.Name = "umbComboBox1";
            this.umbComboBox1.Size = new System.Drawing.Size(84, 21);
            this.umbComboBox1.TabIndex = 47;
            this.umbComboBox1.SelectedIndexChanged += new System.EventHandler(this.umbComboBox1_SelectedIndexChanged);
            // 
            // umbLabel2
            // 
            this.umbLabel2.AutoSize = true;
            this.umbLabel2.Location = new System.Drawing.Point(7, 85);
            this.umbLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.umbLabel2.Name = "umbLabel2";
            this.umbLabel2.Size = new System.Drawing.Size(27, 13);
            this.umbLabel2.TabIndex = 46;
            this.umbLabel2.Text = "umb";
            this.ToolTip1.SetToolTip(this.umbLabel2, "Enable UMB support.");
            // 
            // emsComboBox1
            // 
            this.emsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emsComboBox1.FormattingEnabled = true;
            this.emsComboBox1.Location = new System.Drawing.Point(9, 61);
            this.emsComboBox1.Name = "emsComboBox1";
            this.emsComboBox1.Size = new System.Drawing.Size(84, 21);
            this.emsComboBox1.TabIndex = 45;
            this.emsComboBox1.SelectedIndexChanged += new System.EventHandler(this.emsComboBox1_SelectedIndexChanged);
            // 
            // emsLabel2
            // 
            this.emsLabel2.AutoSize = true;
            this.emsLabel2.Location = new System.Drawing.Point(7, 44);
            this.emsLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emsLabel2.Name = "emsLabel2";
            this.emsLabel2.Size = new System.Drawing.Size(26, 13);
            this.emsLabel2.TabIndex = 44;
            this.emsLabel2.Text = "ems";
            this.ToolTip1.SetToolTip(this.emsLabel2, "Enable EMS support.");
            // 
            // xmsComboBox1
            // 
            this.xmsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xmsComboBox1.FormattingEnabled = true;
            this.xmsComboBox1.Location = new System.Drawing.Point(9, 20);
            this.xmsComboBox1.Name = "xmsComboBox1";
            this.xmsComboBox1.Size = new System.Drawing.Size(84, 21);
            this.xmsComboBox1.TabIndex = 43;
            this.xmsComboBox1.SelectedIndexChanged += new System.EventHandler(this.xmsComboBox1_SelectedIndexChanged);
            // 
            // xmsLabel2
            // 
            this.xmsLabel2.AutoSize = true;
            this.xmsLabel2.Location = new System.Drawing.Point(7, 3);
            this.xmsLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xmsLabel2.Name = "xmsLabel2";
            this.xmsLabel2.Size = new System.Drawing.Size(25, 13);
            this.xmsLabel2.TabIndex = 42;
            this.xmsLabel2.Text = "xms";
            this.ToolTip1.SetToolTip(this.xmsLabel2, "Enable XMS support.");
            // 
            // tabIpx
            // 
            this.tabIpx.Controls.Add(this.ipxComboBox1);
            this.tabIpx.Controls.Add(this.ipxLabel2);
            this.tabIpx.ImageKey = "connected_world-1.png";
            this.tabIpx.Location = new System.Drawing.Point(4, 42);
            this.tabIpx.Name = "tabIpx";
            this.tabIpx.Padding = new System.Windows.Forms.Padding(3);
            this.tabIpx.Size = new System.Drawing.Size(472, 425);
            this.tabIpx.TabIndex = 12;
            this.tabIpx.Text = "[ipx]";
            this.tabIpx.UseVisualStyleBackColor = true;
            // 
            // ipxComboBox1
            // 
            this.ipxComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ipxComboBox1.FormattingEnabled = true;
            this.ipxComboBox1.Location = new System.Drawing.Point(9, 20);
            this.ipxComboBox1.Name = "ipxComboBox1";
            this.ipxComboBox1.Size = new System.Drawing.Size(84, 21);
            this.ipxComboBox1.TabIndex = 45;
            this.ipxComboBox1.SelectedIndexChanged += new System.EventHandler(this.ipxComboBox1_SelectedIndexChanged);
            // 
            // ipxLabel2
            // 
            this.ipxLabel2.AutoSize = true;
            this.ipxLabel2.Location = new System.Drawing.Point(7, 3);
            this.ipxLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipxLabel2.Name = "ipxLabel2";
            this.ipxLabel2.Size = new System.Drawing.Size(20, 13);
            this.ipxLabel2.TabIndex = 44;
            this.ipxLabel2.Text = "ipx";
            this.ToolTip1.SetToolTip(this.ipxLabel2, "Enable ipx over UDP/IP emulation.");
            // 
            // tabAutoexec
            // 
            this.tabAutoexec.Controls.Add(this.textBoxAutoExec);
            this.tabAutoexec.ImageKey = "registration-1.png";
            this.tabAutoexec.Location = new System.Drawing.Point(4, 42);
            this.tabAutoexec.Name = "tabAutoexec";
            this.tabAutoexec.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutoexec.Size = new System.Drawing.Size(472, 425);
            this.tabAutoexec.TabIndex = 13;
            this.tabAutoexec.Text = "[autoexec]";
            this.tabAutoexec.UseVisualStyleBackColor = true;
            // 
            // textBoxAutoExec
            // 
            this.textBoxAutoExec.AcceptsReturn = true;
            this.textBoxAutoExec.AcceptsTab = true;
            this.textBoxAutoExec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAutoExec.Location = new System.Drawing.Point(3, 3);
            this.textBoxAutoExec.Multiline = true;
            this.textBoxAutoExec.Name = "textBoxAutoExec";
            this.textBoxAutoExec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAutoExec.Size = new System.Drawing.Size(466, 419);
            this.textBoxAutoExec.TabIndex = 11;
            this.textBoxAutoExec.TextChanged += new System.EventHandler(this.textBoxAutoExec_TextChanged);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "computer-4.png");
            this.icons.Images.SetKeyName(1, "display_properties-3.png");
            this.icons.Images.SetKeyName(2, "expansion_board-1.png");
            this.icons.Images.SetKeyName(3, "loudspeaker_rays-0.png");
            this.icons.Images.SetKeyName(4, "processor-1.png");
            this.icons.Images.SetKeyName(5, "midi_bl-0.png");
            this.icons.Images.SetKeyName(6, "mixer_cd_sound-1.png");
            this.icons.Images.SetKeyName(7, "expansion_board_modem-1.png");
            this.icons.Images.SetKeyName(8, "joystick-0.png");
            this.icons.Images.SetKeyName(9, "cable-0.png");
            this.icons.Images.SetKeyName(10, "connected_world-1.png");
            this.icons.Images.SetKeyName(11, "console_prompt-1.png");
            this.icons.Images.SetKeyName(12, "notepad_file-1.png");
            this.icons.Images.SetKeyName(13, "registration-1.png");
            this.icons.Images.SetKeyName(14, "DOSBox_icon_jYr_icon.ico");
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(393, 481);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(312, 481);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(231, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToolTip1
            // 
            this.ToolTip1.IsBalloon = true;
            // 
            // textBoxConfig
            // 
            this.textBoxConfig.AcceptsReturn = true;
            this.textBoxConfig.AcceptsTab = true;
            this.textBoxConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConfig.Location = new System.Drawing.Point(0, 0);
            this.textBoxConfig.Multiline = true;
            this.textBoxConfig.Name = "textBoxConfig";
            this.textBoxConfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConfig.Size = new System.Drawing.Size(480, 516);
            this.textBoxConfig.TabIndex = 0;
            this.textBoxConfig.Visible = false;
            // 
            // DOSBoxConfigEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 516);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.textBoxConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DOSBoxConfigEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOSBox Config Editor";
            this.Load += new System.EventHandler(this.DOSBoxConfigEditor_Load);
            this.TabControl.ResumeLayout(false);
            this.tabSdl.ResumeLayout(false);
            this.tabSdl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityNumericUpDown1)).EndInit();
            this.tabDOSBox.ResumeLayout(false);
            this.tabDOSBox.PerformLayout();
            this.tabRender.ResumeLayout(false);
            this.tabRender.PerformLayout();
            this.tabCpu.ResumeLayout(false);
            this.tabCpu.PerformLayout();
            this.tabMixer.ResumeLayout(false);
            this.tabMixer.PerformLayout();
            this.tabMidi.ResumeLayout(false);
            this.tabMidi.PerformLayout();
            this.tabSblaster.ResumeLayout(false);
            this.tabSblaster.PerformLayout();
            this.tabGus.ResumeLayout(false);
            this.tabGus.PerformLayout();
            this.tabSpeaker.ResumeLayout(false);
            this.tabSpeaker.PerformLayout();
            this.tabJoystick.ResumeLayout(false);
            this.tabJoystick.PerformLayout();
            this.tabSerial.ResumeLayout(false);
            this.tabSerial.PerformLayout();
            this.tabDos.ResumeLayout(false);
            this.tabDos.PerformLayout();
            this.tabIpx.ResumeLayout(false);
            this.tabIpx.PerformLayout();
            this.tabAutoexec.ResumeLayout(false);
            this.tabAutoexec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl TabControl;
        private TabPage tabSdl;
        private TabPage tabDOSBox;
        private TabPage tabRender;
        private TabPage tabCpu;
        private TabPage tabMixer;
        private TabPage tabMidi;
        private TabPage tabSblaster;
        private TabPage tabGus;
        private TabPage tabSpeaker;
        private TabPage tabJoystick;
        private TabPage tabSerial;
        private TabPage tabDos;
        private TabPage tabIpx;
        private TabPage tabAutoexec;
        private Label fullscreenLabel1;
        private ComboBox fullscreenComboBox1;
        private ComboBox fulldoubleComboBox1;
        private Label fulldoubleLabel1;
        private ComboBox fullresolutionComboBox1;
        private Label fullresolutionLabel;
        private ComboBox windowresolutionComboBox1;
        private Label windowresolutionLabel2;
        private ComboBox outputComboBox1;
        private Label outputLabel2;
        private ComboBox autolockComboBox1;
        private Label autolockLabel2;
        private Label sensitivityLabel2;
        private NumericUpDown sensitivityNumericUpDown1;
        private ComboBox waitonerrorComboBox1;
        private Label waitonerrorLabel2;
        private ComboBox priorityComboBox2;
        private ComboBox priorityComboBox1;
        private Label priorityLabel2;
        private Button Button1;
        private TextBox mapperfileTextBox2;
        private Label mapperfileLabel2;
        private ComboBox usescancodesComboBox1;
        private Label usescancodesLabel2;
        private Label memsizeLabel2;
        private Button capturesButton2;
        private TextBox capturesTextBox2;
        private Label capturesLabel2;
        private ComboBox machineComboBox1;
        private Label machineLabel2;
        private TextBox languageTextBox2;
        private Label languageLabel2;
        private TextBox frameskipTextBox2;
        private Label frameskipLabel2;
        private ComboBox aspectComboBox1;
        private Label aspectLabel2;
        private ComboBox scalerComboBox1;
        private Label scalerLabel2;
        private ComboBox coreComboBox1;
        private Label coreLabel2;
        private ComboBox cputypeComboBox1;
        private Label cputypeLabel2;
        private ComboBox cyclesComboBox1;
        private Label cyclesLabel2;
        private TextBox cycledownTextBox2;
        private Label cycledownLabel2;
        private TextBox cycleupTextBox2;
        private Label cycleupLabel2;
        private TextBox prebufferTextBox2;
        private Label prebufferLabel2;
        private ComboBox blocksizeComboBox1;
        private Label blocksizeLabel2;
        private ComboBox rateComboBox1;
        private Label rateLabel2;
        private ComboBox nosoundComboBox1;
        private Label nosoundLabel2;
        private TextBox midiconfigTextBox2;
        private Label midiconfigLabel2;
        private ComboBox midideviceComboBox1;
        private Label midideviceLabel2;
        private ComboBox mpu401ComboBox1;
        private Label mpu401Label2;
        private ComboBox oplrateComboBox1;
        private Label oplrateLabel2;
        private ComboBox oplemuComboBox1;
        private Label oplemuLabel2;
        private ComboBox oplmodeComboBox1;
        private Label oplmodeLabel2;
        private ComboBox sbmixerComboBox1;
        private Label sbmixerLabel2;
        private ComboBox hdmaComboBox1;
        private Label hdmaLabel2;
        private ComboBox dmaComboBox1;
        private Label dmaLabel2;
        private ComboBox sbbaseComboBox1;
        private Label sbbaseLabel2;
        private ComboBox sbtypeComboBox1;
        private Label sbtypeLabel2;
        private ComboBox irqComboBox1;
        private Label irqLabel2;
        private ComboBox gusComboBox1;
        private Label gusLabel2;
        private TextBox ultradirTextBox2;
        private Label ultradirLabel2;
        private ComboBox gusdmaComboBox1;
        private Label gusdmaLabel2;
        private ComboBox gusirqComboBox1;
        private Label gusirqLabel2;
        private ComboBox gusbaseComboBox1;
        private Label gusbaseLabel2;
        private ComboBox gusrateComboBox1;
        private Label gusrateLabel2;
        private ComboBox disneyComboBox1;
        private Label disneyLabel2;
        private ComboBox tandyrateComboBox1;
        private Label tandyrateLabel2;
        private ComboBox tandyComboBox1;
        private Label tandyLabel2;
        private ComboBox pcrateComboBox1;
        private Label pcrateLabel2;
        private ComboBox pcspeakerComboBox1;
        private Label pcspeakerLabel2;
        private ComboBox buttonwrapComboBox1;
        private Label buttonwrapLabel2;
        private ComboBox swap34ComboBox1;
        private Label swap34Label2;
        private ComboBox autofireComboBox1;
        private Label autofireLabel2;
        private ComboBox timedComboBox1;
        private Label timedLabel2;
        private ComboBox joysticktypeComboBox1;
        private Label joysticktypeLabel2;
        private ComboBox serial4ComboBox1;
        private Label serial4Label2;
        private ComboBox serial3ComboBox1;
        private Label serial3Label2;
        private ComboBox serial2ComboBox1;
        private Label serial2Label2;
        private ComboBox serial1ComboBox1;
        private Label serial1Label2;
        private ComboBox umbComboBox1;
        private Label umbLabel2;
        private ComboBox emsComboBox1;
        private Label emsLabel2;
        private ComboBox xmsComboBox1;
        private Label xmsLabel2;
        private ComboBox keyboardlayoutComboBox1;
        private Label keyboardlayoutLabel2;
        private ComboBox ipxComboBox1;
        private Label ipxLabel2;
        private Button btnOK;
        private Button btnApply;
        private Button btnCancel;
        private OpenFileDialog openFileDialog1;
        private ImageList icons;
        private ToolTip ToolTip1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBoxAutoExec;
        private TextBox textBoxConfig;
        private ComboBox memsizeComboBox1;
        private Button btnLanguage;
    }
}