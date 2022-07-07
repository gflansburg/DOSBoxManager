using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSBoxManager
{
    public class DOSBoxSettings
    {
        public DOSBoxSettings()
        {
            Programs = new List<DOSBoxProgram>();
        }

        public Size? Size { get; set; }
        
        public Point? Location { get; set; }
        
        public Point? AboutLocation { get; set; }
        
        public Point? OptionsLocation { get; set; }
        
        public Point? ProgramLocation { get; set; }
        
        public Point? EditorLocation { get; set; }

        public Point? DeleteLocation { get; set; }

        public bool StartWithWindows { get; set; }

        public bool StartMinimized { get; set; }

        public bool MinimizeToSystemTray { get; set; }

        public bool MinimizeOnLaunch { get; set; }

        public bool IsMaximized { get; set; }

        public string ManagerName { get; set; }

        public string DOSBoxPath { get; set; }

        public List<DOSBoxProgram> Programs { get; set; }
    }
}
