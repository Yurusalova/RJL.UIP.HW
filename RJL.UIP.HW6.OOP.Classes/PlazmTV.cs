using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
   sealed public class PlazmTV:TV
    {
        public string Resolution { get; private set; }
        public PlazmTV(string model, int power, string diagonal, string resolution):base(model, power, diagonal)
        {
             this.Resolution = resolution;
        }
        public override string ToString()
        {
            return $"{this.Id}. {this.GetType().Name} model {this.Model}, power {this.Power} W, diagonal {this.Diagonal}, screen resolution {this.Resolution}";
        }
    }
}
