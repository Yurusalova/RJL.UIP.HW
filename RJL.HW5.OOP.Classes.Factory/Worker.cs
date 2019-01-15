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

        public Worker(string name, string experience)
        {
            this.Name = name;
            this.Experience = experience;
        }

        public void AgregatAssembly(Agregat agregat)
        {
            int workerCapacity = GetWorkerCapacity();
            int leftAssembleDetails = agregat.GeneralCountDetails - agregat.CurrentAssembledDetails;
            int countDetailsToAssemble = workerCapacity >= leftAssembleDetails ? leftAssembleDetails : workerCapacity;
            agregat.CurrentAssembledDetails += countDetailsToAssemble;
            Console.WriteLine($"Worker {this.Name} added {countDetailsToAssemble} detail(s) to Agregat");
        }
        public int GetWorkerCapacity()
        {
            int workerCapacity;
            switch (this.Experience)
            {
                case "experienced":
                    workerCapacity = 3;
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
