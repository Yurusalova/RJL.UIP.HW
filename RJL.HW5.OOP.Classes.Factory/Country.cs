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
           for (int index = 0; index < 3; index++)
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
                order.Units.Add(new Car(5, "Car_"+(i+1)));
            }
            for (int i = 0; i < order.CountOfPlane; i++)
            {
                order.Units.Add(new Plane(6,"Plane_"+(i+1)));
            }
            for (int i = 0; i < order.CountOfTank; i++)
            {
                order.Units.Add(new Tank(7,"Tank_"+(i+1)));
            }
            order.CurrentFreeUnit = order.Units[0];
        }
    }
}
