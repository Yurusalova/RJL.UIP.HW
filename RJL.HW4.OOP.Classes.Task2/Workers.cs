using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task2
{
    class Worker
    {
        public string Name { get; private set; }
        public string Experience{get; private set;}
        
        public Worker(string name, string experience)
        {
            this.Name = name;
            this.Experience = experience;
        }

        public void  AgregatAssembly(Agregat agregat)
        {
            int workerCapacity;
            int leftAssembleDetails = 0;
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
            leftAssembleDetails = agregat.GeneralCountDetails - agregat.CurrentAssembledDetails;
            agregat.CurrentAssembledDetails = agregat.CurrentAssembledDetails + workerCapacity;
            if (agregat.CurrentAssembledDetails >= agregat.GeneralCountDetails)
            {
                agregat.CurrentAssembledDetails = agregat.GeneralCountDetails;
                Console.WriteLine($"Worker {this.Name} added {leftAssembleDetails} detail(s) to Agregat");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Agregat has been assembled");
                Console.WriteLine("----------------------------------------------------------");
            }
            else
            {
                Console.WriteLine($"Worker {this.Name} added {workerCapacity} detail(s) to Agregat");
            }
           // return agregat.CurrentAssembledDetails;
        }
    }
}
