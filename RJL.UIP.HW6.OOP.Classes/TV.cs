using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public class TV:Device
    {
        public string Diagonal { get; private set; }

        public TV(string model, int power, string diagonal) : base(model, power) {
            this.Diagonal = diagonal;
        }

        public override string ToString()
        {
            return "Just TV";
        }
    }
}
