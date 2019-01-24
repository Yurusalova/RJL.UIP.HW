using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public class Laptop:Computer
    {
        public string Weight { get; private set; }
        public Laptop(string model, int power, int RAM, string weight):base(model, power, RAM)
        {
            this.Weight = weight;
        }
        public override string ToString()
        {
            return $"{this.Id}. {this.GetType().Name} model  {this.Model}, power {this.Power} W, RAM {this.RAM} Gb, weight {this.Weight}";
        }
    }
}
