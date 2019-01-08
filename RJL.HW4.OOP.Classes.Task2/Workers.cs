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

        public int  GetAgregatAssembly(int tempCountDetails,int generalCountDetail)
        {
            int workerCountDetails;
            int workerCurrentCountDetails = 0;
            switch (this.Experience)
            {
                case "experienced":
                    workerCountDetails = 3;
                    break;
                case "inexperienced":
                    workerCountDetails = 1;
                    break;
                case "master":
                    workerCountDetails = 5;
                    break;
                default:
                    workerCountDetails = 0;
                    break;
            }
            
                for (int i = 1; i <= workerCountDetails; i++)
                {
                    
                    tempCountDetails ++;
                    workerCurrentCountDetails = i;
                    if (tempCountDetails == generalCountDetail) {
                        Console.WriteLine($"Worker {this.Name} added {workerCurrentCountDetails} detail(s) to Agregat");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("Agregat has been assembled");
                        Console.WriteLine("----------------------------------------------------------");
                        return tempCountDetails;
                    }
                }
                Console.WriteLine($"Worker {this.Name} added {workerCurrentCountDetails} detail(s) to Agregat");
            
            return tempCountDetails;
        }
    }
}
