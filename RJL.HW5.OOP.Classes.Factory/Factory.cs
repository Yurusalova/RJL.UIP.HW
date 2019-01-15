using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Factory
    {

        private readonly List<Order> Orders = new List<Order>();

        private readonly List<Worker> Workers = new List<Worker>();

        public string Name { get; private set; }
        public Country Country { get; private set; }

        public Factory(Country country, string name)
        {
            this.Name = name;
            this.Country = country;
        }

        private void ExecuteWorkingDay(Car car, Plane plane, Tank tank)
        {
            if (this.Orders.Count == 0)
            {
                this.Orders.AddRange(Country.GetOrders(car,plane, tank));
            }
            foreach (var worker in this.Workers)
            {

            }
        }

        private void ExecuteWorkingMonth(Car car, Plane plane, Tank tank)
        {
            for (int i = 0; i < 30; i++)
            {
                this.ExecuteWorkingDay(car,plane,tank);
            }
        }

        public void ExecuteWorkingYear(Car car, Plane plane, Tank tank)
        {
            for (int i = 0; i < 12; i++)
            {
                this.ExecuteWorkingMonth(car, plane, tank);
            }
        }

    }
}
