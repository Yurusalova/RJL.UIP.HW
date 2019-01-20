using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Country
    {
        public int OrderCounter { get; private set;}

        public  List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            int OrderLength=1;
           for (int index = 0; index < 7; index++)
            {
                this.OrderCounter++;
                orders.Add(new Order(this.OrderCounter, 2, 2, 2));
                FillOrder(orders[index]);
                OrderLength++;                
            }
            return orders;
        }
        public void FillOrder(Order order)
        {
            for (int i = 0; i < order.CountOfCar; i++)
            {
                order.Cars.Add(new Car(5));
            }
            for (int i = 0; i < order.CountOfPlane; i++)
            {
                order.Planes.Add(new Plane(6));
            }
            for (int i = 0; i < order.CountOfTank; i++)
            {
                order.Tanks.Add(new Tank(7));
            }
        }
    }
}
