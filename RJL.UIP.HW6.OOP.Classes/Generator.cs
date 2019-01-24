using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public class Generator:Device
    {
        public int LeftPower { get; set; }
 
        public Generator(string model, int power):base(model, power) {
                        this.LeftPower = power;
        }
        public  override string ToString()
        {
            return $"{this.GetType().Name} model {this.Model}, power {this.Power} W";
        }
    }
}
