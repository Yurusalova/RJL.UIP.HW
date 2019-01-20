using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Worker
    {
        public string Name { get; private set; }
        public string Experience { get; private set; }
        public int Salary { get; private set; }
        public bool isWorkDayEnded { get; set; }

        public Worker(string name, string experience, int salary)
        {
            this.Name = name;
            this.Experience = experience;
            this.Salary = salary;
        }

       public void UnitAssembly(Unit unit)
        {
            if (this.isWorkDayEnded) { return; }
            else
            {
                int workerCapacity = GetWorkerCapacity();
                int leftAssembleDetails = unit.GeneralCountDetails - unit.CurrentAddedDetails;
                int countDetailsToAssemble = workerCapacity >= leftAssembleDetails ? leftAssembleDetails : workerCapacity;
                unit.CurrentAddedDetails += countDetailsToAssemble;
                Logger.LogInfo($"Worker {this.Name} added {countDetailsToAssemble} detail(s) to {unit.Name}");
            }
        }
         public int GetWorkerCapacity()
        {
            int workerCapacity;
            switch (this.Experience)
            {
                case "experienced":
                    workerCapacity = 4;
                    break;
                case "inexperienced":
                    workerCapacity = 1;
                    break;
                case "master":
                    workerCapacity = 5;
                    break;
                default:
                    workerCapacity = 0;
                    break;
            }
            return workerCapacity;
        }
    }
}
