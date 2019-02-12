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
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Services;

namespace RJL.UIP.HW8.EarthAreaCalculator.DAL.Services
{
    public class FileStorage : IFileStorage
    {
        private JSONSerializer JSONSerializer = new JSONSerializer();

        public string PathToFolder { get; private set; } = @"C:\Users\Rusalovay\Documents\My\UIP\Files\log.txt";
        //need to add logic for getting PathToFolder from File

        public void AddMessageToStorage(List<LogRecord> logRecords,int colorNumber)
        {
            using (StreamWriter sw = new StreamWriter(PathToFolder, false))
            {
                    string json = JSONSerializer.Serialize(logRecords);
                    sw.WriteLine(json);
            }
        }

        public List<LogRecord> GetAllLogs()
        {
            List<LogRecord> logrecords = new List<LogRecord>();
            using (StreamReader sr = new StreamReader(PathToFolder, System.Text.Encoding.Default))
            {
                string json = sr.ReadToEnd();
                if (json != null)
                {
                    logrecords = JSONSerializer.Deserialize<List<LogRecord>>(json);
                   }
            }
            return logrecords;
        }

        public void ClearAllLogs() {
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
