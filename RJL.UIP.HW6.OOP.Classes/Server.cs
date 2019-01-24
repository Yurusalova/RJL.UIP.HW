using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public class Server:Computer
    {
        public int ProcCount { get; private set; }
        public Server(string model, int power, int RAM, int procCount):base(model, power, RAM)
        {
            this.ProcCount = procCount;
        }
        public override string ToString()
        {
            return $"{this.Id}. {this.GetType().Name} model {this.Model}, power {this.Power} W, RAM {this.RAM} Gb, the count of proccessors {this.ProcCount}";
        }
    }
}
