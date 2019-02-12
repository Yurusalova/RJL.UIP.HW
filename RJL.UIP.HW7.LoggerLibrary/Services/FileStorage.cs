using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RJL.UIP.HW7.LoggerLibrary.Interfaces;
using RJL.UIP.HW7.LoggerLibrary.Models;
using Newtonsoft.Json;

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
            using (StreamWriter sw = new StreamWriter(this.PathToFolder, true))
            {
                string json = Serialize<LogRecord>(logRecord);
                // File.WriteAllText(filepath, json);
                sw.WriteLine(json);
               // sw.WriteLine("FileStorage " + logRecord.ToString());
            }
        }
        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
