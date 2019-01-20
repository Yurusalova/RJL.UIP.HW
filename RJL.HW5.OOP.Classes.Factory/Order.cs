using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Order
    {
        public List<Unit> Units = new List<Unit>();
        public Unit CurrentFreeUnit { get; set; } 
        public int CountOfCar { get; private set; }
        public int CountOfPlane { get; private set; }
        public int CountOfTank { get; private set; }
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

        public Order(int number, int countOfCar, int countofPlane, int countOfTank)
        {
            this.Number = number;
            this.CountOfCar = countOfCar;
            this.CountOfPlane = countofPlane;
            this.CountOfTank = countOfTank;
        }

        public void PrintOrder()
        {
            Logger.LogWithoutDate($"Order number {this.Number} contains:");
            Logger.LogWithoutDate($"  {this.CountOfCar} cars,{this.CountOfPlane} planes, {this.CountOfTank} tanks");
        }
    }
}
