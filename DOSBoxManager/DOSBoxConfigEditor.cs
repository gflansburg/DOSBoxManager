using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DOSBoxManager
{
    public partial class DOSBoxConfigEditor: Form
    {
        public Point? EditorLocation { get; set; }
        public string ConfigFile { get; set; }

        public DOSBoxConfigEditor()
        {
            InitializeComponent();
            LoadOptions();
        }

        public static string ClientFilesLocation(string configFile, string dosBoxPath)
        {
            if (System.IO.File.Exists(configFile))
            {
                using (StreamReader fileReader = File.OpenText(configFile))
                {
                    string stringReader = fileReader.ReadLine();
                    // Loop to read each line and check if it is a valid setting.
                    while (stringReader != null)
                    {
                        if (stringReader.StartsWith("mount c", StringComparison.OrdinalIgnoreCase))
                        {
                            stringReader = stringReader.Substring(7);
                            if (stringReader.StartsWith(":"))
                            {
                                stringReader = stringReader.Substring(1);
                            }
                            stringReader = stringReader.Trim();
                            if (stringReader.StartsWith("\""))
                            {
                                stringReader = stringReader.Substring(1, stringReader.Length - 2);
                            }
                            if ((stringReader.StartsWith(".\\") || stringReader.StartsWith("..\\")) && !string.IsNullOrEmpty(dosBoxPath))
                            {
                                stringReader = string.Format("{0}\\{1}", System.IO.Path.GetDirectoryName(dosBoxPath), stringReader);
                            }
                            return stringReader;
                        }
                        // Read next line
                        stringReader = fileReader.ReadLine();
                    }
                    fileReader.Close();
                }
            }
            return string.Empty;
        }

        public void OpenConfig()
        {
            textBoxConfig.Clear();
            textBoxAutoExec.Clear();
            using (StreamReader fileReader = File.OpenText(ConfigFile))
            {
                string stringReader = fileReader.ReadLine();
                // Loop to read each line and check if it is a valid setting.
                bool isAutoExec = false;
                while (stringReader != null)
                {
                    if (stringReader.StartsWith("[autoexec]", StringComparison.OrdinalIgnoreCase))
                    {
                        isAutoExec = true;
                    }
                    else if (isAutoExec && stringReader.StartsWith("[", StringComparison.OrdinalIgnoreCase))
                    {
                        isAutoExec = false;
                    }
                    else if (isAutoExec)
                    {
                        textBoxAutoExec.AppendText(stringReader + "\r\n");
                    }
                    else if (stringReader.StartsWith("fullscreen=", StringComparison.OrdinalIgnoreCase))
                    {
                        fullscreenLabel1.Text = stringReader.Split('=')[0];
                        var fullscreen = stringReader.Split('=')[1];
                        if (fullscreenComboBox1.Items.Contains(fullscreen))
                        {
                            fullscreenComboBox1.SelectedIndex = fullscreenComboBox1.Items.IndexOf(fullscreen);
                        }
                    }
                    else if (stringReader.StartsWith("fulldouble=", StringComparison.OrdinalIgnoreCase))
                    {
                        fulldoubleLabel1.Text = stringReader.Split('=')[0];
                        var fulldouble = stringReader.Split('=')[1];
                        if (fulldoubleComboBox1.Items.Contains(fulldouble))
                        {
                            fulldoubleComboBox1.SelectedIndex = fulldoubleComboBox1.Items.IndexOf(fulldouble);
                        }
                    }
                    else if (stringReader.StartsWith("fullresolution=", StringComparison.OrdinalIgnoreCase))
                    {
                        fullresolutionLabel.Text = stringReader.Split('=')[0];
                        var fullresolution = stringReader.Split('=')[1];
                        // Check if full resoltion option exists
                        if (fullresolutionComboBox1.Items.Contains(fullresolution))
                        {
                            fullresolutionComboBox1.SelectedIndex = fullresolutionComboBox1.Items.IndexOf(fullresolution);
                        }
                        else
                        {
                            fullresolutionComboBox1.Text = fullresolution;
                        }
                    }
                    else if (stringReader.StartsWith("windowresolution=", StringComparison.OrdinalIgnoreCase))
                    {
                        windowresolutionLabel2.Text = stringReader.Split('=')[0];
                        var windowresolution = stringReader.Split('=')[1];
                        if (windowresolutionComboBox1.Items.Contains(windowresolution))
                        {
                            windowresolutionComboBox1.SelectedIndex = windowresolutionComboBox1.Items.IndexOf(windowresolution);
                        }
                        else
                        {
                            windowresolutionComboBox1.Text = windowresolution;
                        }
                    }
                    else if (stringReader.StartsWith("output=", StringComparison.OrdinalIgnoreCase))
                    {
                        outputLabel2.Text = stringReader.Split('=')[0];
                        var output = stringReader.Split('=')[1];
                        if (outputComboBox1.Items.Contains(output))
                        {
                            outputComboBox1.SelectedIndex = outputComboBox1.Items.IndexOf(output);
                        }
                    }
                    else if (stringReader.StartsWith("autolock=", StringComparison.OrdinalIgnoreCase))
                    {
                        autolockLabel2.Text = stringReader.Split('=')[0];
                        var autolock = stringReader.Split('=')[1];
                        if (autolockComboBox1.Items.Contains(autolock))
                        {
                            autolockComboBox1.SelectedIndex = autolockComboBox1.Items.IndexOf(autolock);
                        }
                    }
                    else if (stringReader.StartsWith("sensitivity=", StringComparison.OrdinalIgnoreCase))
                    {
                        sensitivityLabel2.Text = stringReader.Split('=')[0];
                        var sensitivity = stringReader.Split('=')[1];
                        sensitivityNumericUpDown1.Value = Convert.ToDecimal(sensitivity);
                    }
                    else if (stringReader.StartsWith("waitonerror=", StringComparison.OrdinalIgnoreCase))
                    {
                        waitonerrorLabel2.Text = stringReader.Split('=')[0];
                        var waitonerror = stringReader.Split('=')[1];
                        if (waitonerrorComboBox1.Items.Contains(waitonerror))
                        {
                            waitonerrorComboBox1.SelectedIndex = waitonerrorComboBox1.Items.IndexOf(waitonerror);
                        }
                    }
                    else if (stringReader.StartsWith("priority=", StringComparison.OrdinalIgnoreCase))
                    {
                        priorityLabel2.Text = stringReader.Split('=')[0];
                        var priority1 = stringReader.Split('=')[1];
                        var priorityFirst = priority1.Split(',')[0];
                        var prioritySecond = priority1.Split(',')[1];
                        priorityComboBox1.SelectedIndex = priorityComboBox1.Items.IndexOf(priorityFirst);
                        priorityComboBox2.SelectedIndex = priorityComboBox2.Items.IndexOf(prioritySecond);
                    }
                    else if (stringReader.StartsWith("mapperfile=", StringComparison.OrdinalIgnoreCase))
                    {
                        mapperfileLabel2.Text = stringReader.Split('=')[0];
                        var mapperfile = stringReader.Split('=')[1];
                        mapperfileTextBox2.Text = mapperfile;
                    }
                    else if (stringReader.StartsWith("usescancodes=", StringComparison.OrdinalIgnoreCase))
                    {
                        usescancodesLabel2.Text = stringReader.Split('=')[0];
                        var usescancodes = stringReader.Split('=')[1];
                        if (usescancodesComboBox1.Items.Contains(usescancodes))
                        {
                            usescancodesComboBox1.SelectedIndex = usescancodesComboBox1.Items.IndexOf(usescancodes);
                        }
                    }
                    else if (stringReader.StartsWith("language=", StringComparison.OrdinalIgnoreCase))
                    {
                        languageLabel2.Text = stringReader.Split('=')[0];
                        var language = stringReader.Split('=')[1];
                        languageTextBox2.Text = language;
                    }
                    else if (stringReader.StartsWith("machine=", StringComparison.OrdinalIgnoreCase))
                    {
                        machineLabel2.Text = stringReader.Split('=')[0];
                        var machine = stringReader.Split('=')[1];
                        if (machineComboBox1.Items.Contains(machine))
                        {
                            machineComboBox1.SelectedIndex = machineComboBox1.Items.IndexOf(machine);
                        }
                    }
                    else if (stringReader.StartsWith("captures=", StringComparison.OrdinalIgnoreCase))
                    {
                        capturesLabel2.Text = stringReader.Split('=')[0];
                        var captures = stringReader.Split('=')[1];
                        capturesTextBox2.Text = captures;
                    }
                    else if (stringReader.StartsWith("memsize=", StringComparison.OrdinalIgnoreCase))
                    {
                        memsizeLabel2.Text = stringReader.Split('=')[0];
                        var memsize = stringReader.Split('=')[1];
                        if (memsizeComboBox1.Items.Contains(memsize))
                            memsizeComboBox1.SelectedIndex = memsizeComboBox1.Items.IndexOf(memsize);
                    }
                    else if (stringReader.StartsWith("frameskip=", StringComparison.OrdinalIgnoreCase))
                    {
                        frameskipLabel2.Text = stringReader.Split('=')[0];
                        var frameskip = stringReader.Split('=')[1];
                        frameskipTextBox2.Text = frameskip;
                    }
                    else if (stringReader.StartsWith("aspect=", StringComparison.OrdinalIgnoreCase))
                    {
                        aspectLabel2.Text = stringReader.Split('=')[0];
                        var aspect = stringReader.Split('=')[1];
                        if (aspectComboBox1.Items.Contains(aspect))
                            aspectComboBox1.SelectedIndex = aspectComboBox1.Items.IndexOf(aspect);
                    }
                    else if (stringReader.StartsWith("scaler=", StringComparison.OrdinalIgnoreCase))
                    {
                        scalerLabel2.Text = stringReader.Split('=')[0];
                        var scaler = stringReader.Split('=')[1];
                        if (scalerComboBox1.Items.Contains(scaler))
                        {
                            scalerComboBox1.SelectedIndex = scalerComboBox1.Items.IndexOf(scaler);
                        }
                    }
                    else if (stringReader.StartsWith("core=", StringComparison.OrdinalIgnoreCase))
                    {
                        coreLabel2.Text = stringReader.Split('=')[0];
                        var core = stringReader.Split('=')[1];
                        if (coreComboBox1.Items.Contains(core))
                        {
                            coreComboBox1.SelectedIndex = coreComboBox1.Items.IndexOf(core);
                        }
                    }
                    else if (stringReader.StartsWith("cputype=", StringComparison.OrdinalIgnoreCase))
                    {
                        cputypeLabel2.Text = stringReader.Split('=')[0];
                        var cputype = stringReader.Split('=')[1];
                        if (cputypeComboBox1.Items.Contains(cputype))
                        {
                            cputypeComboBox1.SelectedIndex = cputypeComboBox1.Items.IndexOf(cputype);
                        }
                    }
                    else if (stringReader.StartsWith("cycles=", StringComparison.OrdinalIgnoreCase))
                    {
                        cyclesLabel2.Text = stringReader.Split('=')[0];
                        var cycles = stringReader.Split('=')[1];
                        // Check if full resoltion option exists
                        if (cyclesComboBox1.Items.Contains(cycles))
                        {
                            cyclesComboBox1.SelectedIndex = cyclesComboBox1.Items.IndexOf(cycles);
                        }
                        else
                        {
                            cyclesComboBox1.Text = cycles;
                        }
                    }
                    else if (stringReader.StartsWith("cycleup=", StringComparison.OrdinalIgnoreCase))
                    {
                        cycleupLabel2.Text = stringReader.Split('=')[0];
                        var cycleup = stringReader.Split('=')[1];
                        cycleupTextBox2.Text = cycleup;
                    }
                    else if (stringReader.StartsWith("cycledown=", StringComparison.OrdinalIgnoreCase))
                    {
                        cycledownLabel2.Text = stringReader.Split('=')[0];
                        var cycledown = stringReader.Split('=')[1];
                        cycledownTextBox2.Text = cycledown;
                    }
                    else if (stringReader.StartsWith("nosound=", StringComparison.OrdinalIgnoreCase))
                    {
                        nosoundLabel2.Text = stringReader.Split('=')[0];
                        var nosound = stringReader.Split('=')[1];
                        if (nosoundComboBox1.Items.Contains(nosound))
                        {
                            nosoundComboBox1.SelectedIndex = nosoundComboBox1.Items.IndexOf(nosound);
                        }
                    }
                    else if (stringReader.StartsWith("rate=", StringComparison.OrdinalIgnoreCase))
                    {
                        rateLabel2.Text = stringReader.Split('=')[0];
                        var rate = stringReader.Split('=')[1];
                        if (rateComboBox1.Items.Contains(rate))
                        {
                            rateComboBox1.SelectedIndex = rateComboBox1.Items.IndexOf(rate);
                        }
                    }
                    else if (stringReader.StartsWith("blocksize=", StringComparison.OrdinalIgnoreCase))
                    {
                        blocksizeLabel2.Text = stringReader.Split('=')[0];
                        var blocksize = stringReader.Split('=')[1];
                        if (blocksizeComboBox1.Items.Contains(blocksize))
                        {
                            blocksizeComboBox1.SelectedIndex = blocksizeComboBox1.Items.IndexOf(blocksize);
                        }
                    }
                    else if (stringReader.StartsWith("prebuffer=", StringComparison.OrdinalIgnoreCase))
                    {
                        prebufferLabel2.Text = stringReader.Split('=')[0];
                        var prebuffer = stringReader.Split('=')[1];
                        prebufferTextBox2.Text = prebuffer;
                    }
                    else if (stringReader.StartsWith("mpu401=", StringComparison.OrdinalIgnoreCase))
                    {
                        mpu401Label2.Text = stringReader.Split('=')[0];
                        var mpu401 = stringReader.Split('=')[1];
                        if (mpu401ComboBox1.Items.Contains(mpu401))
                        {
                            mpu401ComboBox1.SelectedIndex = mpu401ComboBox1.Items.IndexOf(mpu401);
                        }
                    }
                    else if (stringReader.StartsWith("mididevice=", StringComparison.OrdinalIgnoreCase))
                    {
                        midideviceLabel2.Text = stringReader.Split('=')[0];
                        var mididevice = stringReader.Split('=')[1];
                        if (midideviceComboBox1.Items.Contains(mididevice))
                        {
                            midideviceComboBox1.SelectedIndex = midideviceComboBox1.Items.IndexOf(mididevice);
                        }
                    }
                    else if (stringReader.StartsWith("midiconfig=", StringComparison.OrdinalIgnoreCase))
                    {
                        midiconfigLabel2.Text = stringReader.Split('=')[0];
                        var midiconfig = stringReader.Split('=')[1];
                        midiconfigTextBox2.Text = midiconfig;
                    }
                    else if (stringReader.StartsWith("sbtype=", StringComparison.OrdinalIgnoreCase))
                    {
                        sbtypeLabel2.Text = stringReader.Split('=')[0];
                        var sbtype = stringReader.Split('=')[1];
                        if (sbtypeComboBox1.Items.Contains(sbtype))
                        {
                            sbtypeComboBox1.SelectedIndex = sbtypeComboBox1.Items.IndexOf(sbtype);
                        }
                    }
                    else if (stringReader.StartsWith("sbbase=", StringComparison.OrdinalIgnoreCase))
                    {
                        sbbaseLabel2.Text = stringReader.Split('=')[0];
                        var sbbase = stringReader.Split('=')[1];
                        if (sbbaseComboBox1.Items.Contains(sbbase))
                        {
                            sbbaseComboBox1.SelectedIndex = sbbaseComboBox1.Items.IndexOf(sbbase);
                        }
                    }
                    else if (stringReader.StartsWith("irq=", StringComparison.OrdinalIgnoreCase))
                    {
                        irqLabel2.Text = stringReader.Split('=')[0];
                        var irq = stringReader.Split('=')[1];
                        if (irqComboBox1.Items.Contains(irq))
                        {
                            irqComboBox1.SelectedIndex = irqComboBox1.Items.IndexOf(irq);
                        }
                    }
                    else if (stringReader.StartsWith("dma=", StringComparison.OrdinalIgnoreCase))
                    {
                        dmaLabel2.Text = stringReader.Split('=')[0];
                        var dma = stringReader.Split('=')[1];
                        if (dmaComboBox1.Items.Contains(dma))
                        {
                            dmaComboBox1.SelectedIndex = dmaComboBox1.Items.IndexOf(dma);
                        }
                    }
                    else if (stringReader.StartsWith("hdma=", StringComparison.OrdinalIgnoreCase))
                    {
                        hdmaLabel2.Text = stringReader.Split('=')[0];
                        var hdma = stringReader.Split('=')[1];
                        if (hdmaComboBox1.Items.Contains(hdma))
                        {
                            hdmaComboBox1.SelectedIndex = hdmaComboBox1.Items.IndexOf(hdma);
                        }
                    }
                    else if (stringReader.StartsWith("sbmixer=", StringComparison.OrdinalIgnoreCase))
                    {
                        sbmixerLabel2.Text = stringReader.Split('=')[0];
                        var sbmixer = stringReader.Split('=')[1];
                        if (sbmixerComboBox1.Items.Contains(sbmixer))
                        {
                            sbmixerComboBox1.SelectedIndex = sbmixerComboBox1.Items.IndexOf(sbmixer);
                        }
                    }
                    else if (stringReader.StartsWith("oplmode=", StringComparison.OrdinalIgnoreCase))
                    {
                        oplmodeLabel2.Text = stringReader.Split('=')[0];
                        var oplmode = stringReader.Split('=')[1];
                        if (oplmodeComboBox1.Items.Contains(oplmode))
                        {
                            oplmodeComboBox1.SelectedIndex = oplmodeComboBox1.Items.IndexOf(oplmode);
                        }
                    }
                    else if (stringReader.StartsWith("oplemu=", StringComparison.OrdinalIgnoreCase))
                    {
                        oplemuLabel2.Text = stringReader.Split('=')[0];
                        var oplemu = stringReader.Split('=')[1];
                        if (oplemuComboBox1.Items.Contains(oplemu))
                        {
                            oplemuComboBox1.SelectedIndex = oplemuComboBox1.Items.IndexOf(oplemu);
                        }
                    }
                    else if (stringReader.StartsWith("oplrate=", StringComparison.OrdinalIgnoreCase))
                    {
                        oplrateLabel2.Text = stringReader.Split('=')[0];
                        var oplrate = stringReader.Split('=')[1];
                        if (oplrateComboBox1.Items.Contains(oplrate))
                        {
                            oplrateComboBox1.SelectedIndex = oplrateComboBox1.Items.IndexOf(oplrate);
                        }
                    }
                    else if (stringReader.StartsWith("gus=", StringComparison.OrdinalIgnoreCase))
                    {
                        gusLabel2.Text = stringReader.Split('=')[0];
                        var gus = stringReader.Split('=')[1];
                        if (gusComboBox1.Items.Contains(gus))
                        {
                            gusComboBox1.SelectedIndex = gusComboBox1.Items.IndexOf(gus);
                        }
                    }
                    else if (stringReader.StartsWith("gusrate=", StringComparison.OrdinalIgnoreCase))
                    {
                        gusrateLabel2.Text = stringReader.Split('=')[0];
                        var gusrate = stringReader.Split('=')[1];
                        if (gusrateComboBox1.Items.Contains(gusrate))
                        {
                            gusrateComboBox1.SelectedIndex = gusrateComboBox1.Items.IndexOf(gusrate);
                        }
                    }
                    else if (stringReader.StartsWith("gusbase=", StringComparison.OrdinalIgnoreCase))
                    {
                        gusbaseLabel2.Text = stringReader.Split('=')[0];
                        var gusbase = stringReader.Split('=')[1];
                        if (gusbaseComboBox1.Items.Contains(gusbase))
                        {
                            gusbaseComboBox1.SelectedIndex = gusbaseComboBox1.Items.IndexOf(gusbase);
                        }
                    }
                    else if (stringReader.StartsWith("gusirq=", StringComparison.OrdinalIgnoreCase))
                    {
                        gusirqLabel2.Text = stringReader.Split('=')[0];
                        var gusirq = stringReader.Split('=')[1];
                        if (gusirqComboBox1.Items.Contains(gusirq))
                        {
                            gusirqComboBox1.SelectedIndex = gusirqComboBox1.Items.IndexOf(gusirq);
                        }
                    }
                    else if (stringReader.StartsWith("gusdma=", StringComparison.OrdinalIgnoreCase))
                    {
                        gusdmaLabel2.Text = stringReader.Split('=')[0];
                        var gusdma = stringReader.Split('=')[1];
                        if (gusdmaComboBox1.Items.Contains(gusdma))
                        {
                            gusdmaComboBox1.SelectedIndex = gusdmaComboBox1.Items.IndexOf(gusdma);
                        }
                    }
                    else if (stringReader.StartsWith("ultradir=", StringComparison.OrdinalIgnoreCase))
                    {
                        ultradirLabel2.Text = stringReader.Split('=')[0];
                        var ultradir = stringReader.Split('=')[1];
                        ultradirTextBox2.Text = ultradir;
                    }
                    else if (stringReader.StartsWith("pcspeaker=", StringComparison.OrdinalIgnoreCase))
                    {
                        pcspeakerLabel2.Text = stringReader.Split('=')[0];
                        var pcspeaker = stringReader.Split('=')[1];
                        if (pcspeakerComboBox1.Items.Contains(pcspeaker))
                        {
                            pcspeakerComboBox1.SelectedIndex = pcspeakerComboBox1.Items.IndexOf(pcspeaker);
                        }
                    }
                    else if (stringReader.StartsWith("pcrate=", StringComparison.OrdinalIgnoreCase))
                    {
                        pcrateLabel2.Text = stringReader.Split('=')[0];
                        var pcrate = stringReader.Split('=')[1];
                        if (pcrateComboBox1.Items.Contains(pcrate))
                        {
                            pcrateComboBox1.SelectedIndex = pcrateComboBox1.Items.IndexOf(pcrate);
                        }
                    }
                    else if (stringReader.StartsWith("tandy=", StringComparison.OrdinalIgnoreCase))
                    {
                        tandyLabel2.Text = stringReader.Split('=')[0];
                        var tandy = stringReader.Split('=')[1];
                        if (tandyComboBox1.Items.Contains(tandy))
                        {
                            tandyComboBox1.SelectedIndex = tandyComboBox1.Items.IndexOf(tandy);
                        }
                    }
                    else if (stringReader.StartsWith("tandyrate=", StringComparison.OrdinalIgnoreCase))
                    {
                        tandyrateLabel2.Text = stringReader.Split('=')[0];
                        var tandyrate = stringReader.Split('=')[1];
                        if (tandyrateComboBox1.Items.Contains(tandyrate))
                        {
                            tandyrateComboBox1.SelectedIndex = tandyrateComboBox1.Items.IndexOf(tandyrate);
                        }
                    }
                    else if (stringReader.StartsWith("disney=", StringComparison.OrdinalIgnoreCase))
                    {
                        disneyLabel2.Text = stringReader.Split('=')[0];
                        var disney = stringReader.Split('=')[1];
                        if (disneyComboBox1.Items.Contains(disney))
                        {
                            disneyComboBox1.SelectedIndex = disneyComboBox1.Items.IndexOf(disney);
                        }
                    }
                    else if (stringReader.StartsWith("joysticktype=", StringComparison.OrdinalIgnoreCase))
                    {
                        joysticktypeLabel2.Text = stringReader.Split('=')[0];
                        var joysticktype = stringReader.Split('=')[1];
                        if (joysticktypeComboBox1.Items.Contains(joysticktype))
                        {
                            joysticktypeComboBox1.SelectedIndex = joysticktypeComboBox1.Items.IndexOf(joysticktype);
                        }
                    }
                    else if (stringReader.StartsWith("timed=", StringComparison.OrdinalIgnoreCase))
                    {
                        timedLabel2.Text = stringReader.Split('=')[0];
                        var timed = stringReader.Split('=')[1];
                        if (timedComboBox1.Items.Contains(timed))
                        {
                            timedComboBox1.SelectedIndex = timedComboBox1.Items.IndexOf(timed);
                        }
                    }
                    else if (stringReader.StartsWith("autofire=", StringComparison.OrdinalIgnoreCase))
                    {
                        autofireLabel2.Text = stringReader.Split('=')[0];
                        var autofire = stringReader.Split('=')[1];
                        if (autofireComboBox1.Items.Contains(autofire))
                        {
                            autofireComboBox1.SelectedIndex = autofireComboBox1.Items.IndexOf(autofire);
                        }
                    }
                    else if (stringReader.StartsWith("swap34=", StringComparison.OrdinalIgnoreCase))
                    {
                        swap34Label2.Text = stringReader.Split('=')[0];
                        var swap34 = stringReader.Split('=')[1];
                        if (swap34ComboBox1.Items.Contains(swap34))
                        {
                            swap34ComboBox1.SelectedIndex = swap34ComboBox1.Items.IndexOf(swap34);
                        }
                    }
                    else if (stringReader.StartsWith("buttonwrap=", StringComparison.OrdinalIgnoreCase))
                    {
                        buttonwrapLabel2.Text = stringReader.Split('=')[0];
                        var buttonwrap = stringReader.Split('=')[1];
                        if (buttonwrapComboBox1.Items.Contains(buttonwrap))
                        {
                            buttonwrapComboBox1.SelectedIndex = buttonwrapComboBox1.Items.IndexOf(buttonwrap);
                        }
                    }
                    else if (stringReader.StartsWith("serial1=", StringComparison.OrdinalIgnoreCase))
                    {
                        serial1Label2.Text = stringReader.Split('=')[0];
                        var serial1 = stringReader.Split('=')[1];
                        if (serial1ComboBox1.Items.Contains(serial1))
                        {
                            serial1ComboBox1.SelectedIndex = serial1ComboBox1.Items.IndexOf(serial1);
                        }
                    }
                    else if (stringReader.StartsWith("serial2=", StringComparison.OrdinalIgnoreCase))
                    {
                        serial2Label2.Text = stringReader.Split('=')[0];
                        var serial2 = stringReader.Split('=')[1];
                        if (serial2ComboBox1.Items.Contains(serial2))
                        {
                            serial2ComboBox1.SelectedIndex = serial2ComboBox1.Items.IndexOf(serial2);
                        }
                    }
                    else if (stringReader.StartsWith("serial3=", StringComparison.OrdinalIgnoreCase))
                    {
                        serial3Label2.Text = stringReader.Split('=')[0];
                        var serial3 = stringReader.Split('=')[1];
                        if (serial3ComboBox1.Items.Contains(serial3))
                        {
                            serial3ComboBox1.SelectedIndex = serial3ComboBox1.Items.IndexOf(serial3);
                        }
                    }
                    else if (stringReader.StartsWith("serial4=", StringComparison.OrdinalIgnoreCase))
                    {
                        serial4Label2.Text = stringReader.Split('=')[0];
                        var serial4 = stringReader.Split('=')[1];
                        if (serial4ComboBox1.Items.Contains(serial4))
                        {
                            serial4ComboBox1.SelectedIndex = serial4ComboBox1.Items.IndexOf(serial4);
                        }
                    }
                    else if (stringReader.StartsWith("xms=", StringComparison.OrdinalIgnoreCase))
                    {
                        xmsLabel2.Text = stringReader.Split('=')[0];
                        var xms = stringReader.Split('=')[1];
                        if (xmsComboBox1.Items.Contains(xms))
                        {
                            xmsComboBox1.SelectedIndex = xmsComboBox1.Items.IndexOf(xms);
                        }
                    }
                    else if (stringReader.StartsWith("ems=", StringComparison.OrdinalIgnoreCase))
                    {
                        emsLabel2.Text = stringReader.Split('=')[0];
                        var ems = stringReader.Split('=')[1];
                        if (emsComboBox1.Items.Contains(ems))
                        {
                            emsComboBox1.SelectedIndex = emsComboBox1.Items.IndexOf(ems);
                        }
                    }
                    else if (stringReader.StartsWith("umb=", StringComparison.OrdinalIgnoreCase))
                    {
                        umbLabel2.Text = stringReader.Split('=')[0];
                        var umb = stringReader.Split('=')[1];
                        if (umbComboBox1.Items.Contains(umb))
                        {
                            umbComboBox1.SelectedIndex = umbComboBox1.Items.IndexOf(umb);
                        }
                    }
                    else if (stringReader.StartsWith("keyboardlayout=", StringComparison.OrdinalIgnoreCase))
                    {
                        keyboardlayoutLabel2.Text = stringReader.Split('=')[0];
                        var keyboardlayout = stringReader.Split('=')[1];
                        var item = keyboardlayoutComboBox1.Items.Cast<KeyboardLayout>().FirstOrDefault(k => k.code.Equals(keyboardlayout, StringComparison.OrdinalIgnoreCase));
                        if (item != null)
                        {
                            keyboardlayoutComboBox1.SelectedIndex = keyboardlayoutComboBox1.Items.IndexOf(item);
                        }
                    }
                    else if (stringReader.StartsWith("ipx=", StringComparison.OrdinalIgnoreCase))
                    {
                        ipxLabel2.Text = stringReader.Split('=')[0];
                        var ipx = stringReader.Split('=')[1];
                        if (ipxComboBox1.Items.Contains(ipx))
                        {
                            ipxComboBox1.SelectedIndex = ipxComboBox1.Items.IndexOf(ipx);
                        }
                    }

                    // Populate textbox with read conf file.
                    textBoxConfig.AppendText(stringReader + "\r\n");
                    // Read next line
                    stringReader = fileReader.ReadLine();
                }
                fileReader.Close();
            }
            EnableSave = false;
            TabControl.Visible = true;
        }

        public bool EnableSave
        {
            get
            {
                return btnApply.Enabled;
            }
            set
            {
                btnApply.Enabled = value;
            }
        }
        
        public void LoadOptionsFullScreen()
        {
            fullscreenComboBox1.Items.Add("true");
            fullscreenComboBox1.Items.Add("false");
        }
        public void LoadOptionsFullDouble()
        {
            fulldoubleComboBox1.Items.Add("true");
            fulldoubleComboBox1.Items.Add("false");
        }
        public void LoadOptionAutoLock()
        {
            autolockComboBox1.Items.Add("true");
            autolockComboBox1.Items.Add("false");
        }
        public void LoadOptionWaitOnError()
        {
            waitonerrorComboBox1.Items.Add("true");
            waitonerrorComboBox1.Items.Add("false");
        }
        public void LoadOptionsFullResolution()
        {
            fullresolutionComboBox1.Items.Add("original");
            fullresolutionComboBox1.Items.Add("desktop");
            windowresolutionComboBox1.Items.Add("original");
            windowresolutionComboBox1.Items.Add("desktop");
        }
        public void LoadOutputOptions()
        {
            outputComboBox1.Items.Add("surface");
            outputComboBox1.Items.Add("overlay");
            outputComboBox1.Items.Add("opengl");
            outputComboBox1.Items.Add("openglnb");
            outputComboBox1.Items.Add("ddraw");
        }
        public void LoadOutputPriority()
        {
            priorityComboBox1.Items.Add("lowest");
            priorityComboBox1.Items.Add("lower");
            priorityComboBox1.Items.Add("normal");
            priorityComboBox1.Items.Add("higher");
            priorityComboBox1.Items.Add("highest");
            priorityComboBox1.Items.Add("pause");

            priorityComboBox2.Items.Add("lowest");
            priorityComboBox2.Items.Add("lower");
            priorityComboBox2.Items.Add("normal");
            priorityComboBox2.Items.Add("higher");
            priorityComboBox2.Items.Add("highest");
            priorityComboBox2.Items.Add("pause");
        }
        public void LoadOptionsUsesCanCodes()
        {
            usescancodesComboBox1.Items.Add("true");
            usescancodesComboBox1.Items.Add("false");
        }
        public void LoadOutputMachine()
        {
            machineComboBox1.Items.Add("hercules");
            machineComboBox1.Items.Add("cga");
            machineComboBox1.Items.Add("tandy");
            machineComboBox1.Items.Add("pcjr");
            machineComboBox1.Items.Add("ega");
            machineComboBox1.Items.Add("vgaonly");
            machineComboBox1.Items.Add("svga_s3");
            machineComboBox1.Items.Add("svga_et3000");
            machineComboBox1.Items.Add("svga_et4000");
            machineComboBox1.Items.Add("svga_paradise");
            machineComboBox1.Items.Add("vesa_nolfb");
            machineComboBox1.Items.Add("vesa_oldvbe");
        }
        public void LoadOutputScaler()
        {
            scalerComboBox1.Items.Add("none");
            scalerComboBox1.Items.Add("normal2x");
            scalerComboBox1.Items.Add("normal3x");
            scalerComboBox1.Items.Add("advmame2x");
            scalerComboBox1.Items.Add("advmame3x");
            scalerComboBox1.Items.Add("advinterp2x");
            scalerComboBox1.Items.Add("advinterp3x");
            scalerComboBox1.Items.Add("hq2x");
            scalerComboBox1.Items.Add("hq3x");
            scalerComboBox1.Items.Add("2xsai");
            scalerComboBox1.Items.Add("super2xsai");
            scalerComboBox1.Items.Add("supereagle");
            scalerComboBox1.Items.Add("tv2x");
            scalerComboBox1.Items.Add("tv3x");
            scalerComboBox1.Items.Add("rgb2x");
            scalerComboBox1.Items.Add("rgb3x");
            scalerComboBox1.Items.Add("scan2x");
            scalerComboBox1.Items.Add("scan3x");
        }
        public void LoadOptionAspect()
        {
            aspectComboBox1.Items.Add("true");
            aspectComboBox1.Items.Add("false");
        }
        public void LoadOptionCore()
        {
            coreComboBox1.Items.Add("auto");
            coreComboBox1.Items.Add("dynamic");
            coreComboBox1.Items.Add("normal");
            coreComboBox1.Items.Add("simple");
        }
        public void LoadCpuType()
        {
            cputypeComboBox1.Items.Add("auto");
            cputypeComboBox1.Items.Add("386");
            cputypeComboBox1.Items.Add("386_slow");
            cputypeComboBox1.Items.Add("486_slow");
            cputypeComboBox1.Items.Add("pentium_slow");
            cputypeComboBox1.Items.Add("386_prefetch");
        }
        public void LoadCycles()
        {
            cyclesComboBox1.Items.Add("auto");
            cyclesComboBox1.Items.Add("fixed #");
            cyclesComboBox1.Items.Add("max");
        }
        public void LoadNoSound()
        {
            nosoundComboBox1.Items.Add("true");
            nosoundComboBox1.Items.Add("false");
        }
        public void LoadMixerRate()
        {
            rateComboBox1.Items.Add("44100");
            rateComboBox1.Items.Add("48000");
            rateComboBox1.Items.Add("32000");
            rateComboBox1.Items.Add("22050");
            rateComboBox1.Items.Add("16000");
            rateComboBox1.Items.Add("11025");
            rateComboBox1.Items.Add("8000");
            rateComboBox1.Items.Add("49716");
        }
        public void LoadMixerBlockSize()
        {
            blocksizeComboBox1.Items.Add("1024");
            blocksizeComboBox1.Items.Add("2048");
            blocksizeComboBox1.Items.Add("4096");
            blocksizeComboBox1.Items.Add("8192");
            blocksizeComboBox1.Items.Add("512");
            blocksizeComboBox1.Items.Add("256");
        }
        public void LoadOptionsMpu401()
        {
            mpu401ComboBox1.Items.Add("intelligent");
            mpu401ComboBox1.Items.Add("uart");
            mpu401ComboBox1.Items.Add("none");
        }
        public void LoadMidiDevice()
        {
            midideviceComboBox1.Items.Add("default");
            midideviceComboBox1.Items.Add("win32");
            midideviceComboBox1.Items.Add("alsa");
            midideviceComboBox1.Items.Add("oss");
            midideviceComboBox1.Items.Add("coreaudio");
            midideviceComboBox1.Items.Add("coremidi");
            midideviceComboBox1.Items.Add("none");
        }
        public void LoadSbType()
        {
            sbtypeComboBox1.Items.Add("sb1");
            sbtypeComboBox1.Items.Add("sb2");
            sbtypeComboBox1.Items.Add("sbpro1");
            sbtypeComboBox1.Items.Add("sbpro2");
            sbtypeComboBox1.Items.Add("sb16");
            sbtypeComboBox1.Items.Add("gb");
            sbtypeComboBox1.Items.Add("none");
        }
        public void LoadSbBase()
        {
            sbbaseComboBox1.Items.Add("220");
            sbbaseComboBox1.Items.Add("240");
            sbbaseComboBox1.Items.Add("260");
            sbbaseComboBox1.Items.Add("280");
            sbbaseComboBox1.Items.Add("2a0");
            sbbaseComboBox1.Items.Add("2c0");
            sbbaseComboBox1.Items.Add("2e0");
            sbbaseComboBox1.Items.Add("300");
        }
        public void LoadSbIrq()
        {
            irqComboBox1.Items.Add("7");
            irqComboBox1.Items.Add("5");
            irqComboBox1.Items.Add("3");
            irqComboBox1.Items.Add("9");
            irqComboBox1.Items.Add("10");
            irqComboBox1.Items.Add("11");
            irqComboBox1.Items.Add("12");
        }
        public void LoadSbLowDma()
        {
            dmaComboBox1.Items.Add("1");
            dmaComboBox1.Items.Add("5");
            dmaComboBox1.Items.Add("0");
            dmaComboBox1.Items.Add("3");
            dmaComboBox1.Items.Add("6");
            dmaComboBox1.Items.Add("7");
        }
        public void LoadSbHiDma()
        {
            hdmaComboBox1.Items.Add("1");
            hdmaComboBox1.Items.Add("5");
            hdmaComboBox1.Items.Add("0");
            hdmaComboBox1.Items.Add("3");
            hdmaComboBox1.Items.Add("6");
            hdmaComboBox1.Items.Add("7");
        }
        public void LoadSbMixer()
        {
            sbmixerComboBox1.Items.Add("true");
            sbmixerComboBox1.Items.Add("false");
        }
        public void LoadOplMode()
        {
            oplmodeComboBox1.Items.Add("auto");
            oplmodeComboBox1.Items.Add("cms");
            oplmodeComboBox1.Items.Add("opl2");
            oplmodeComboBox1.Items.Add("dualopl2");
            oplmodeComboBox1.Items.Add("opl3");
            oplmodeComboBox1.Items.Add("none");
        }
        public void LoadOplEmu()
        {
            oplemuComboBox1.Items.Add("default");
            oplemuComboBox1.Items.Add("compat");
            oplemuComboBox1.Items.Add("fast");
        }
        public void LoadOplRate()
        {
            oplrateComboBox1.Items.Add("44100");
            oplrateComboBox1.Items.Add("49716");
            oplrateComboBox1.Items.Add("48000");
            oplrateComboBox1.Items.Add("32000");
            oplrateComboBox1.Items.Add("22050");
            oplrateComboBox1.Items.Add("16000");
            oplrateComboBox1.Items.Add("11025");
            oplrateComboBox1.Items.Add("8000");
        }
        public void LoadGus()
        {
            gusComboBox1.Items.Add("true");
            gusComboBox1.Items.Add("false");
        }
        public void LoadGusRate()
        {
            gusrateComboBox1.Items.Add("44100");
            gusrateComboBox1.Items.Add("48000");
            gusrateComboBox1.Items.Add("32000");
            gusrateComboBox1.Items.Add("22050");
            gusrateComboBox1.Items.Add("16000");
            gusrateComboBox1.Items.Add("11025");
            gusrateComboBox1.Items.Add("8000");
            gusrateComboBox1.Items.Add("49716");
        }
        public void LoadGusBase()
        {
            gusbaseComboBox1.Items.Add("240");
            gusbaseComboBox1.Items.Add("220");
            gusbaseComboBox1.Items.Add("260");
            gusbaseComboBox1.Items.Add("280");
            gusbaseComboBox1.Items.Add("2a0");
            gusbaseComboBox1.Items.Add("2c0");
            gusbaseComboBox1.Items.Add("2e0");
            gusbaseComboBox1.Items.Add("300");
        }
        public void LoadGusIrq()
        {
            gusirqComboBox1.Items.Add("5");
            gusirqComboBox1.Items.Add("3");
            gusirqComboBox1.Items.Add("7");
            gusirqComboBox1.Items.Add("9");
            gusirqComboBox1.Items.Add("10");
            gusirqComboBox1.Items.Add("11");
            gusirqComboBox1.Items.Add("12");
        }
        public void LoadGusDma()
        {
            gusdmaComboBox1.Items.Add("3");
            gusdmaComboBox1.Items.Add("0");
            gusdmaComboBox1.Items.Add("1");
            gusdmaComboBox1.Items.Add("5");
            gusdmaComboBox1.Items.Add("6");
            gusdmaComboBox1.Items.Add("7");
        }
        public void LoadPcSpeaker()
        {
            pcspeakerComboBox1.Items.Add("true");
            pcspeakerComboBox1.Items.Add("false");
        }
        public void LoadPcRate()
        {
            pcrateComboBox1.Items.Add("44100");
            pcrateComboBox1.Items.Add("48000");
            pcrateComboBox1.Items.Add("32000");
            pcrateComboBox1.Items.Add("22050");
            pcrateComboBox1.Items.Add("16000");
            pcrateComboBox1.Items.Add("11025");
            pcrateComboBox1.Items.Add("8000");
            pcrateComboBox1.Items.Add("49716");
        }
        public void LoadTandy()
        {
            tandyComboBox1.Items.Add("auto");
            tandyComboBox1.Items.Add("on");
            tandyComboBox1.Items.Add("off");
        }
        public void LoadTandyRate()
        {
            tandyrateComboBox1.Items.Add("44100");
            tandyrateComboBox1.Items.Add("48000");
            tandyrateComboBox1.Items.Add("32000");
            tandyrateComboBox1.Items.Add("22050");
            tandyrateComboBox1.Items.Add("16000");
            tandyrateComboBox1.Items.Add("11025");
            tandyrateComboBox1.Items.Add("8000");
            tandyrateComboBox1.Items.Add("49716");
        }
        public void LoadDisney()
        {
            disneyComboBox1.Items.Add("true");
            disneyComboBox1.Items.Add("false");
        }
        public void LoadJoystickType()
        {
            joysticktypeComboBox1.Items.Add("auto");
            joysticktypeComboBox1.Items.Add("2axis");
            joysticktypeComboBox1.Items.Add("4axis");
            joysticktypeComboBox1.Items.Add("4axis_2");
            joysticktypeComboBox1.Items.Add("fcs");
            joysticktypeComboBox1.Items.Add("ch");
            joysticktypeComboBox1.Items.Add("none");
        }
        public void LoadAutoFire()
        {
            autofireComboBox1.Items.Add("true");
            autofireComboBox1.Items.Add("false");
        }
        public void LoadSwap34()
        {
            swap34ComboBox1.Items.Add("true");
            swap34ComboBox1.Items.Add("false");
        }
        public void LoadButtonWrap()
        {
            buttonwrapComboBox1.Items.Add("true");
            buttonwrapComboBox1.Items.Add("false");
        }
        public void LoadTimed()
        {
            timedComboBox1.Items.Add("true");
            timedComboBox1.Items.Add("false");
        }
        public void LoadSerial()
        {
            serial1ComboBox1.Items.Add("dummy");
            serial1ComboBox1.Items.Add("disabled");
            serial1ComboBox1.Items.Add("nullmodem");
            serial1ComboBox1.Items.Add("directserial");
            serial2ComboBox1.Items.Add("dummy");
            serial2ComboBox1.Items.Add("disabled");
            serial2ComboBox1.Items.Add("nullmodem");
            serial2ComboBox1.Items.Add("directserial");
            serial3ComboBox1.Items.Add("dummy");
            serial3ComboBox1.Items.Add("disabled");
            serial3ComboBox1.Items.Add("nullmodem");
            serial3ComboBox1.Items.Add("directserial");
            serial4ComboBox1.Items.Add("dummy");
            serial4ComboBox1.Items.Add("disabled");
            serial4ComboBox1.Items.Add("nullmodem");
            serial4ComboBox1.Items.Add("directserial");
        }
        public void LoadXms()
        {
            xmsComboBox1.Items.Add("true");
            xmsComboBox1.Items.Add("false");
        }
        public void LoadEms()
        {
            emsComboBox1.Items.Add("true");
            emsComboBox1.Items.Add("false");
        }
        public void LoadUmb()
        {
            umbComboBox1.Items.Add("true");
            umbComboBox1.Items.Add("false");
        }
        public void LoadKeyboardLayout()
        {
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("auto", "Auto"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("none", "None"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("us", "US"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ux", "US International"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("dv", "US Dvorak"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("lh", "Left-Hand"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("rh", "Right-Hand"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("sq", "Albania"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("hy", "Armenia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("az", "Azerbaijan"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("by", "Belarus"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("be", "Belgium"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ba", "Bosnia & Herzegovina"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("br", "Brazil"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("bg", "Bulgaria"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ca", "Canada"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("hr", "Croatia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("cz", "Czech Republic"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("dk", "Denmark"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ee", "Estonia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("fo", "Faroe Islands"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("fi", "Finland"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("fr", "France"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ka", "Georgia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("de", "Germany"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("gk", "Greece"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("hu", "Hungary"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("is", "Iceland"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("it", "Italy"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("kk", "Kazakhstan"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ky", "Kyrgyzstan"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("la", "Latin-American-Spanish"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("lv", "Latvia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("lt", "Lithuania"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("mk", "Macedonia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("mt", "Malta"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("mo", "Mongolia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("nl", "Netherlands"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("no", "Norway"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ph", "Philippines"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("pl", "Poland"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("po", "Portugal"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ro", "Romania"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ru", "Russia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("sr", "Serbia & Montenegro"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("sk", "Slovakia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("si", "Slovenia"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("es", "Spain"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("sv", "Sweden"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("sd", "Swiss"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("tm", "Turkmenistan"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("tr", "Turkey"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("ua", "Ukraine"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("uk", "United Kingdom"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("uz", "Uzbekistan"));
            keyboardlayoutComboBox1.Items.Add(new KeyboardLayout("yu", "Yugoslavia"));
        }
        public void LoadIpx()
        {
            ipxComboBox1.Items.Add("true");
            ipxComboBox1.Items.Add("false");
        }

        public void LoadMemsize()
        {
            memsizeComboBox1.Items.Add("1");
            memsizeComboBox1.Items.Add("2");
            memsizeComboBox1.Items.Add("4");
            memsizeComboBox1.Items.Add("8");
            memsizeComboBox1.Items.Add("12");
            memsizeComboBox1.Items.Add("16");
            memsizeComboBox1.Items.Add("24");
            memsizeComboBox1.Items.Add("32");
            memsizeComboBox1.Items.Add("64");
            memsizeComboBox1.Items.Add("128");
            memsizeComboBox1.Items.Add("256");
        }

        public void LoadOptions()
        {
            LoadMemsize();
            LoadKeyboardLayout();
            LoadIpx();
            LoadUmb();
            LoadEms();
            LoadXms();
            LoadSerial();
            LoadTimed();
            LoadSwap34();
            LoadButtonWrap();
            LoadAutoFire();
            LoadJoystickType();
            LoadDisney();
            LoadTandyRate();
            LoadTandy();
            LoadPcRate();
            LoadPcSpeaker();
            LoadGusDma();
            LoadGusIrq();
            LoadGusBase();
            LoadGusRate();
            LoadGus();
            LoadOplRate();
            LoadOplEmu();
            LoadOplMode();
            LoadSbMixer();
            LoadSbHiDma();
            LoadSbLowDma();
            LoadSbIrq();
            LoadSbBase();
            LoadOptionsFullScreen();
            LoadOptionsFullDouble();
            LoadOptionsFullResolution();
            LoadOutputOptions();
            LoadOptionAutoLock();
            LoadOptionWaitOnError();
            LoadOutputPriority();
            LoadOptionsUsesCanCodes();
            LoadOutputMachine();
            LoadOptionAspect();
            LoadOutputScaler();
            LoadOptionCore();
            LoadCpuType();
            LoadCycles();
            LoadNoSound();
            LoadMixerRate();
            LoadMixerBlockSize();
            LoadOptionsMpu401();
            LoadMidiDevice();
            LoadSbType();
        }

        private void DOSBoxConfigEditor_Load(object sender, EventArgs e)
        {
            if(EditorLocation.HasValue && DOSBoxManagerForm.IsLocationVisible(EditorLocation.Value))
            {
                this.Location = EditorLocation.Value;
            }
            TabControl.Visible = false;
            OpenConfig();
            this.Text = string.Format("DOSBox Config Editor - {0}", System.IO.Path.GetFileName(ConfigFile));
            EnableSave = false;
        }

        private void UpdateSetting(string key, string value)
        {
            string[] tempArray = textBoxConfig.Lines;
            for (var i = 0; i <= tempArray.Length - 1; i++)
            {
                if (tempArray[i].StartsWith(key + "=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], key + "=" + value);
                    EnableSave = true;
                    break;
                }
            }
            textBoxConfig.Lines = tempArray;
        }

        private void UpdateAutoExec(string value)
        {
            List<string> tempArray = textBoxConfig.Lines.ToList();
            int start = -1, end = -1;
            for (var i = 0; i <= tempArray.Count - 1; i++)
            {
                if (tempArray[i].StartsWith("[autoexec]", StringComparison.OrdinalIgnoreCase))
                {
                    start = i + 1;
                }
                else if (start != -1 && tempArray[i].StartsWith("["))
                {
                    break;
                }
                else if (start != -1)
                {
                    end = i;
                }
            }
            if(start != -1 && end != -1)
            {
                for(int i = end; i >= start; i--)
                {
                    tempArray.RemoveAt(i);
                }
                string[] autoExec = value.Split('\n');
                for(int i = 0; i < autoExec.Length; i++)
                {
                    tempArray.Insert(start + i, autoExec[i].Replace("\r", string.Empty));
                }
                EnableSave = true;
            }
            textBoxConfig.Lines = tempArray.ToArray();
        }

        public void UpdateConfig()
        {
            // Replace settings in textbox1 text to save as file.
            string[] tempArray = textBoxConfig.Lines;
            for (var i = 0; i <= tempArray.Length - 1; i++)
            {
                if (tempArray[i].StartsWith("fullscreen=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "fullscreen=" + fullscreenComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("fulldouble=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "fulldouble=" + fulldoubleComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("fullresolution=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "fullresolution=" + fullresolutionComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("windowresolution=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "windowresolution=" + windowresolutionComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("output=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "output=" + outputComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("autolock=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "autolock=" + autolockComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("sensitivity=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "sensitivity=" + sensitivityNumericUpDown1.Value.ToString());
                }
                else if (tempArray[i].StartsWith("waitonerror=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "waitonerror=" + waitonerrorComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("priority=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "priority=" + priorityComboBox1.Text + "," + priorityComboBox2.Text);
                }
                else if (tempArray[i].StartsWith("mapperfile=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "mapperfile=" + mapperfileTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("usescancodes=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "usescancodes=" + usescancodesComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("language=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "language=" + languageTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("machine=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "machine=" + machineComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("captures=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "captures=" + capturesTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("memsize=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "memsize=" + memsizeComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("frameskip=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "frameskip=" + frameskipTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("aspect=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "aspect=" + aspectComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("scaler=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "scaler=" + scalerComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("core=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "core=" + coreComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("cputype=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "cputype=" + cputypeComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("cycles=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "cycles=" + cyclesComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("cycleup=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "cycleup=" + cycleupTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("cycledown=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "cycledown=" + cycledownTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("nosound=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "nosound=" + nosoundComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("rate=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "rate=" + rateComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("blocksize=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "blocksize=" + blocksizeComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("prebuffer=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "prebuffer=" + prebufferTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("mpu401=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "mpu401=" + mpu401ComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("mididevice=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "mididevice=" + midideviceComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("midiconfig=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "midiconfig=" + midiconfigTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("sbtype=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "sbtype=" + sbtypeComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("sbbase=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "sbbase=" + sbbaseComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("irq=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "irq=" + irqComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("dma=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "dma=" + dmaComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("hdma=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "hdma=" + hdmaComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("sbmixer=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "sbmixer=" + sbmixerComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("oplmode=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "oplmode=" + oplmodeComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("oplemu=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "oplemu=" + oplemuComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("oplrate=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "oplrate=" + oplrateComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("gus=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "gus=" + gusComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("gusrate=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "gusrate=" + gusrateComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("gusbase=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "gusbase=" + gusbaseComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("gusirq=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "gusirq=" + gusirqComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("gusdma=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "gusdma=" + gusdmaComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("ultradir=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "ultradir=" + ultradirTextBox2.Text);
                }
                else if (tempArray[i].StartsWith("pcspeaker=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "pcspeaker=" + pcspeakerComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("pcrate=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "pcrate=" + pcrateComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("tandy=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "tandy=" + tandyComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("tandyrate=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "tandyrate=" + tandyrateComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("disney=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "disney=" + disneyComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("joysticktype=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "joysticktype=" + joysticktypeComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("timed=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "timed=" + timedComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("autofire=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "autofire=" + autofireComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("swap34=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "swap34=" + swap34ComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("buttonwrap=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "buttonwrap=" + buttonwrapComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("serial1=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "serial1=" + serial1ComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("serial2=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "serial2=" + serial2ComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("serial3=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "serial3=" + serial3ComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("serial4=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "serial4=" + serial4ComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("xms=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "xms=" + xmsComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("ems=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "ems=" + emsComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("umb=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "umb=" + umbComboBox1.Text);
                }
                else if (tempArray[i].StartsWith("keyboardlayout=", StringComparison.OrdinalIgnoreCase))
                {
                    //tempArray[i] = tempArray[i].Replace(tempArray[i], "keyboardlayout=" + keyboardlayoutComboBox1.Text);
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "keyboardlayout=" + (keyboardlayoutComboBox1.SelectedItem as KeyboardLayout).code);
                }
                else if (tempArray[i].StartsWith("ipx=", StringComparison.OrdinalIgnoreCase))
                {
                    tempArray[i] = tempArray[i].Replace(tempArray[i], "ipx=" + ipxComboBox1.Text);
                }
            }
            textBoxConfig.Lines = tempArray;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveConfig();
            EditorLocation = this.Location;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            EditorLocation = this.Location;
            SaveConfig();
        }

        private void SaveConfig()
        {
            string[] tempArray = textBoxConfig.Lines;
            using (StreamWriter writer = File.CreateText(ConfigFile))
            {
                foreach(string line in tempArray)
                {
                    writer.WriteLine(line);
                }
            }
            EnableSave = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "MAP Files (*.map)|*.conf|All Files (*.*)|*.*";
            if (!string.IsNullOrEmpty(mapperfileTextBox2.Text) && System.IO.File.Exists(mapperfileTextBox2.Text))
            {
                openFileDialog1.FileName = mapperfileTextBox2.Text;
            }
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                mapperfileTextBox2.Text = openFileDialog1.FileName;
                UpdateSetting("mapperfile", openFileDialog1.FileName);
            }
        }

        private void capturesButton2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(capturesTextBox2.Text) && System.IO.Directory.Exists(capturesTextBox2.Text))
            {
                folderBrowserDialog1.SelectedPath = capturesTextBox2.Text;
            }
            if(folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                capturesTextBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void languageTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("language", languageTextBox2.Text);
        }

        private void machineComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("machine", machineComboBox1.Text);
        }

        private void capturesTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("captures", capturesTextBox2.Text);
        }

        private void fullscreenComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("fullscreen", fullscreenComboBox1.Text);
        }

        private void mapperfileTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("mapperfile", mapperfileTextBox2.Text);
        }

        private void fulldoubleComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("fulldouble", fulldoubleComboBox1.Text);
        }

        private void usescancodesComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("usescancodes", usescancodesComboBox1.Text);
        }

        private void fullresolutionComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("fullresolution", fullresolutionComboBox1.Text);
        }

        private void windowresolutionComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("windowresolution", windowresolutionComboBox1.Text);
        }

        private void outputComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("output", outputComboBox1.Text);
        }

        private void autolockComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("autolock", autolockComboBox1.Text);
        }

        private void sensitivityNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateSetting("sensitivity", sensitivityNumericUpDown1.Value.ToString());
        }

        private void waitonerrorComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("waitonerror", waitonerrorComboBox1.Text);
        }

        private void priorityComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("priority", priorityComboBox1.Text + "," + priorityComboBox2.Text);
        }

        private void priorityComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("priority", priorityComboBox1.Text + "," + priorityComboBox2.Text);
        }

        private void frameskipTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("frameskip", frameskipTextBox2.Text);
        }

        private void aspectComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("aspect", aspectComboBox1.ToString());
        }

        private void scalerComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("scaler", scalerComboBox1.Text);
        }

        private void coreComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("core", coreComboBox1.Text);
        }

        private void cputypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("cputype", cputypeComboBox1.Text);
        }

        private void cyclesComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("cycles", cyclesComboBox1.Text);
        }

        private void cycleupTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("cycleup", cycleupTextBox2.Text);
        }

        private void cycledownTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("cycledown", cycledownTextBox2.Text);
        }

        private void nosoundComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("nosound", nosoundComboBox1.Text);
        }

        private void rateComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("rate", rateComboBox1.Text);
        }

        private void blocksizeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("blocksize", blocksizeComboBox1.Text);
        }

        private void prebufferTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("prebuffer", prebufferTextBox2.Text);
        }

        private void mpu401ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("mpu401", mpu401ComboBox1.Text);
        }

        private void midideviceComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("mididevice", midideviceComboBox1.Text);
        }

        private void midiconfigTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("midiconfig", midiconfigTextBox2.Text);
        }

        private void sbtypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("sbtype", sbtypeComboBox1.Text);
        }

        private void sbbaseComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("sbbase", sbbaseComboBox1.Text);
        }

        private void irqComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("irq", irqComboBox1.Text);
        }

        private void dmaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("dma", dmaComboBox1.Text);
        }

        private void hdmaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("hdma", hdmaComboBox1.Text);
        }

        private void sbmixerComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("sbmixer", sbmixerComboBox1.Text);
        }

        private void oplmodeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("oplmode", oplmodeComboBox1.Text);
        }

        private void oplemuComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("oplemu", oplemuComboBox1.Text);
        }

        private void oplrateComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("oplrate", oplrateComboBox1.Text);
        }

        private void gusComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("gus", gusComboBox1.Text);
        }

        private void gusrateComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("gusrate", gusrateComboBox1.Text);
        }

        private void gusbaseComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("gusbase", gusbaseComboBox1.Text);
        }

        private void gusirqComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("gusirq", gusirqComboBox1.Text);
        }

        private void gusdmaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("gusdma", gusdmaComboBox1.Text);
        }

        private void ultradirTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("ultradir", ultradirTextBox2.Text);
        }

        private void pcspeakerComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("pcspeaker", pcspeakerComboBox1.Text);
        }

        private void pcrateComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("pcrate", pcrateComboBox1.Text);
        }

        private void tandyComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("tandy", tandyComboBox1.Text);
        }

        private void tandyrateComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("tandyrate", tandyrateComboBox1.Text);
        }

        private void disneyComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("disney", disneyComboBox1.Text);
        }

        private void joysticktypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("joysticktype", joysticktypeComboBox1.Text);
        }

        private void timedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("timed", timedComboBox1.Text);
        }

        private void autofireComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("autofire", autofireComboBox1.Text);
        }

        private void swap34ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("swap34", swap34ComboBox1.Text);
        }

        private void buttonwrapComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("buttonwrap", buttonwrapComboBox1.Text);
        }

        private void serial1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("serial1", serial1ComboBox1.Text);
        }

        private void serial2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("serial2", serial2ComboBox1.Text);
        }

        private void serial3ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("serial3", serial3ComboBox1.Text);
        }

        private void serial4ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("serial4", serial4ComboBox1.Text);
        }

        private void xmsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("xms", xmsComboBox1.Text);
        }

        private void emsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("ems", emsComboBox1.Text);
        }

        private void umbComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("umb", umbComboBox1.Text);
        }

        private void keyboardlayoutComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateSetting("keyboardlayout", keyboardlayoutComboBox1.Text);
            UpdateSetting("keyboardlayout", (keyboardlayoutComboBox1.SelectedItem as KeyboardLayout).code);
        }

        private void ipxComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("ipx", ipxComboBox1.Text);
        }

        private void textBoxAutoExec_TextChanged(object sender, EventArgs e)
        {
            UpdateAutoExec(textBoxAutoExec.Text);
        }

        private void memsizeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetting("memsize", memsizeComboBox1.Text);
        }

        private void cycleupTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cycledownTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void prebufferTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frameskipTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Language Files (*.lng)|*.lng|All Files (*.*)|*.*";
            if (!string.IsNullOrEmpty(languageTextBox2.Text) && System.IO.File.Exists(languageTextBox2.Text))
            {
                openFileDialog1.FileName = languageTextBox2.Text;
            }
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                languageTextBox2.Text = openFileDialog1.FileName;
                UpdateSetting("language", openFileDialog1.FileName);
            }
        }
    }
}
