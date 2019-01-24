using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public class Computer:Device
    {
        public int RAM { get; private set; }

        public Computer(string model, int power, int RAM) : base(model, power) {
            this.RAM = RAM;
        }

        public override string ToString()
        {
            return "Just computer";
        }
    }
}
