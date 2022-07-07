using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSBoxManager
{
    public class KeyboardLayout
    {
        public KeyboardLayout(string _code, string _name)
        {
            code = _code;
            name = _name;
        }
        public string code { get; set; }
        public string name { get; set; }
    }
}
