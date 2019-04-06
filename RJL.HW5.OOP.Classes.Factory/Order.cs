using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Order
    {
        public List<Unit> Units { get; } = new List<Unit>();

        public Unit CurrentFreeUnit { get; set; } 

        public int Number { get; private set; } = 1;
        public bool isOrderCompleted
        {
            get
            {
                foreach (var unit in this.Units)
                {
                    if (!unit.IsReady)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public void PrintOrder() 
        {
            Logger.LogWithoutDate($"Order number {this.Number} contains:");
            // TODO: print state of all units
        }
    }
}
