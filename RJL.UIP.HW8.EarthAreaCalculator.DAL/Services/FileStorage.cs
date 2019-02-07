using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Models;
using Newtonsoft.Json.Linq;

namespace RJL.UIP.HW8.EarthAreaCalculator.DAL.Services
{
    public class FileStorage : IFileStorage
    {
        public string PathToFolder { get; private set; } = @"C:\Users\Rusalovay\Documents\My\UIP\Files\log.txt";
        //need to add logic for getting PathToFolder from File

        public void AddMessage(List<LogRecord> logRecords,int colorNumber)
        {
            using (StreamWriter sw = new StreamWriter(PathToFolder, false))
            {
                    string json = Serialize(logRecords);
                    sw.WriteLine(json);
            }
        }
        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public List<LogRecord> LoadLogs()
        {
            List<LogRecord> logrecords = new List<LogRecord>();
            using (StreamReader sr = new StreamReader(PathToFolder, System.Text.Encoding.Default))
            {
                string json = sr.ReadToEnd();
                if (json != null)
                {
                    logrecords = JsonConvert.DeserializeObject<List<LogRecord>>(json);
                }
            }
            return logrecords;
        }

        public void CreateNewFile() {
            using (StreamWriter sw = new StreamWriter(PathToFolder, false))
            {
            }
        }

        public string GetLogsByType(String type) {
            return "";
        }

        public string GetLogsByDate(DateTime date)
        {
            return "";
        }

    }
}
