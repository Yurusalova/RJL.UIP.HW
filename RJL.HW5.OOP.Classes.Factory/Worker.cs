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

        private string _Experience;
        public string Experience {
            get { return _Experience; }
            set {
                _Experience = value;
                switch (Experience) {
                    case "experienced":
                        WorkerCapacity = 4;
                        break;
                    case "inexperienced":
                        WorkerCapacity = 1;
                        break;
                    case "master":
                        WorkerCapacity = 5;
                        break;
                    default:
                        WorkerCapacity = 0;
                        break;
                }
            }
        }

        public int Salary { get; private set; }

        public int WorkerCapacity { get; private set; }

        public Worker(string name, string experience, int salary)
        {
            this.Name = name;
            this.Experience = experience;
            this.Salary = salary;
        }

        public void UnitAssembly(Unit unit)
        {
            int leftAssembleDetails = unit.GeneralCountDetails - unit.CurrentAddedDetails;
            int countDetailsToAssemble = WorkerCapacity >= leftAssembleDetails ? leftAssembleDetails : WorkerCapacity;
            unit.CurrentAddedDetails += countDetailsToAssemble;
            Logger.LogInfo($"Worker {this.Name} added {countDetailsToAssemble} detail(s) to {unit.Name}"); 
        }

        internal void DoWorkWithUnits(List<Unit> unitsForWorker) {
            foreach (var item in unitsForWorker) {
                UnitAssembly(item);
            }
        }
    }
}
