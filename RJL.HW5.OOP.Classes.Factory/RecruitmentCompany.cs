using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class RecruitmentCompany
    {
        public string Name { get; set; }

        public List<Worker> GetWorkers(int countJunWorker, int countMiddleWorker, int countSeniourWorker)
        {
            int indexJunName = 1;
            int indexMidName = 1;
            int indexSenName = 1;
            int sumCountWorkers = countJunWorker + countMiddleWorker + countSeniourWorker;
            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < countJunWorker; i++)
            {
                workers.Add(new Worker("JunWorkerName_" + indexJunName, "inexperienced", 1000));
                indexJunName++;
            }
            for (int i = countJunWorker; i < countMiddleWorker + countJunWorker; i++)
            {
                workers.Add(new Worker("MiddleWorkerName_" + indexMidName, "experienced", 2000));
                indexMidName++;
            }
            for (int i = countMiddleWorker + countJunWorker; i < sumCountWorkers; i++)
            {
                workers.Add(new Worker("SeniourWorkerName_" + indexSenName, "master", 3000));
                indexSenName++;
            }
            return workers;
        }
    }
}
