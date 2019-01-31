using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RJL.UIP.HW7.LoggerLibrary.Interfaces;
using RJL.UIP.HW7.LoggerLibrary.Models;

namespace RJL.UIP.HW7.LoggerLibrary.Services
{
    public class FileStorage : IStorage
    {
        public string PathToFolder { get; private set; }

        public FileStorage(string pathToFolder)
        {
            this.PathToFolder = pathToFolder;
        }

        public void AddMessage(LogRecord logRecord)
        {
            string writePath = $@"{this.PathToFolder}log.txt";
            using (StreamWriter sw = new StreamWriter(writePath, true))
            {
                sw.WriteLine("FileStorage " + logRecord.ToString());
            }
        }
    }
}
