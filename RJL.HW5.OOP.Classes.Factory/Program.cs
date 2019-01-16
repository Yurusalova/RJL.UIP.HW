using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Country Ukraine = new Country();
            Factory factory = new Factory(Ukraine, "Arsenal");

            factory.Orders = Ukraine.GetOrders();
            factory.PrintOrders(factory.Orders);
              
            factory.Workers = factory.GetWorkers(4, 3, 3);
            factory.PrintWorkersTeam(factory.Workers);

            factory.ExecuteWorkingYear();
          
            Console.ReadLine();
        }

       
        static void OrderExecuting(List<Order> orders, Worker[] workersTeam)
        {
            foreach (var order in orders)
            {
                
                while (order.isOrderCompleted==false)
                {
                    for (int i = 0; i < workersTeam.Length; i++)
                    {
                       
                    }
                }
            }
        }
 
    }
}

