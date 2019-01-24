using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public class CRTTV:TV
    {
        public string Frequency { get; private set; }
        public CRTTV(string model, int power, string diagonal, string frequency) : base(model, power, diagonal)
        {
            this.Frequency = frequency;
        }
        public override string ToString()
        {
            return $"{this.Id}. {this.GetType().Name} model {this.Model}, power {this.Power} W, diagonal {this.Diagonal}, scanning frequency {this.Frequency}";
        }
    }
}
