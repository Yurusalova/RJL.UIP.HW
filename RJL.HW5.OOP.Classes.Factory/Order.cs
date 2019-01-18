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
                    if (!car.IsReady)
                    {
                        return false;
                    }
                }
                foreach (var plane in this.Planes)
                {
                    if (!plane.IsReady)
                    {
                        return false;
                    }
                }
                foreach (var tank in this.Tanks)
                {
                    if (!tank.IsReady)
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


        public bool isCarsInOrderAssembled() {
            foreach(var car in this.Cars)
                {
                if (!car.IsReady)
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
                if (!plane.IsReady)
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
                if (!tank.IsReady)
                {
                    return false;
                }
            }
            return true;
        }
        public void PrintOrder()
        {
            Logger.LogWithoutDate($"Order number {this.Number} contains:");
            Logger.LogWithoutDate($"{this.Cars.Count} cars,{this.Planes.Count} planes, {this.Tanks.Count} tanks");
            Logger.LogWithoutDate($"Each car contains {this.Cars[0].GeneralCountDetails} details. ");
            Logger.LogWithoutDate($"Each plane contains {this.Planes[0].GeneralCountDetails} details. ");
            Logger.LogWithoutDate($"Each tank contains {this.Tanks[0].GeneralCountDetails} details. ");
        }


    }
}
