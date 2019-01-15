using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Order
    {
        public List<Car> Cars = new List<Car>();
        public List<Plane> Planes = new List<Plane>();
        public List<Tank> Tanks = new List<Tank>();

        public int CountOfCar { get; private set; }
        public int CountOfPlane { get; private set; }
        public int CountOfTank { get; private set; }
        public int Number { get; private set; } = 1;
        public bool isOrderCompleted
        {
            get
            {
                foreach (var car in this.Cars)
                {
                    if (car.isReady)
                    {
                        return false;
                    }
                }
                foreach (var plane in this.Planes)
                {
                    if (plane.isReady)
                    {
                        return false;
                    }
                }
                foreach (var tank in this.Tanks)
                {
                    if (tank.isReady)
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
        public void FillOrder(Car car, Plane plane, Tank tank)
        {
            for (int i = 0; i < this.CountOfCar; i++)
            {
                this.Cars.Add(car);
             }
            for (int i = 0; i < this.CountOfPlane; i++)
            {
                this.Planes.Add(plane);
            }
            for (int i = 0; i < this.CountOfTank; i++)
            {
                this.Tanks.Add(tank);
            }
        }
        public void PrintOrder()
        {
            Console.WriteLine($"Order number {this.Number} contains:");
            Console.WriteLine($"{this.Cars.Count} cars,{this.Planes.Count} planes, {this.Tanks.Count} tanks");
            Console.WriteLine($"Car contains {this.Cars[0].GeneralCountDetails} details. ");
            Console.WriteLine($"Plane contains {this.Planes[0].GeneralCountDetails} details. ");
            Console.WriteLine($"Tank contains {this.Tanks[0].GeneralCountDetails} details. ");
        }

        
    }
}
