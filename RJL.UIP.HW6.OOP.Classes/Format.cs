using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public class Format
    {
        public string Name { get; private set; }
        public int Bitrate { get; private set; }
        public Format(string name, int bitrate)
        {
            this.Name = name;
            this.Bitrate = bitrate;
        }
    }
}
