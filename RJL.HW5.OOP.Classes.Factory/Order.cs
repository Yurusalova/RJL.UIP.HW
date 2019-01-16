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
                    if (car.isReady==false)
                    {
                        return false;
                    }
                }
                foreach (var plane in this.Planes)
                {
                    if (plane.isReady==false)
                    {
                        return false;
                    }
                }
                foreach (var tank in this.Tanks)
                {
                    if (tank.isReady==false)
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
        public void FillOrder()
        {
            for (int i = 0; i < this.CountOfCar; i++)
            {
                this.Cars.Add(new Car(10));
             }
            for (int i = 0; i < this.CountOfPlane; i++)
            {
                this.Planes.Add(new Plane(15));
            }
            for (int i = 0; i < this.CountOfTank; i++)
            {
                this.Tanks.Add(new Tank(20));
            }
        }
        public void PrintOrder()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Order number {this.Number} contains:");
            Console.WriteLine($"{this.Cars.Count} cars,{this.Planes.Count} planes, {this.Tanks.Count} tanks");
            Console.WriteLine($"Each car contains {this.Cars[0].GeneralCountDetails} details. ");
            Console.WriteLine($"Each plane contains {this.Planes[0].GeneralCountDetails} details. ");
            Console.WriteLine($"Each tank contains {this.Tanks[0].GeneralCountDetails} details. ");
         
        }
        public bool isCarsInOrderAssembled() {
            foreach(var car in this.Cars)
                {
                if (car.isReady == false)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isPlanesInOrderAssembled()
        {
            foreach (var plane in this.Planes)
            {
                if (plane.isReady == false)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isTanksInOrderAssembled()
        {
            foreach (var tank in this.Tanks)
            {
                if (tank.isReady == false)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
