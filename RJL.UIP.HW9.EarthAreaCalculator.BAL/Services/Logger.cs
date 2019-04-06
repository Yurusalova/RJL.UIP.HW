using RJL.UIP.HW9.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW9.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW9.EarthAreaCalculator.BAL.Services
{
    public class Logger : ILogger
    {
        private List<IStorage> Storages;

        private static int IdCounter = 0;

        private IStorageManager StorageManager;

        public LogLevel LogLevel { get; set; }

        public Logger(IStorageManager storageManager)
        {
            StorageManager = storageManager;
            Storages = storageManager.CreateStorages();
        }

        public void Debug(string message)
        {
            AddMessage(message, LogLevel.Debug,10);
        }

        public void Error(string message)
        {
            AddMessage(message, LogLevel.Error,4);
        }

        public void Fatal(string message)
        {
            AddMessage(message, LogLevel.Fatal,13);
        }

        public void Info(string message)
        {
            AddMessage(message, LogLevel.Info,9);
        }

        public void Warn(string message)
        {
            AddMessage(message, LogLevel.Warn,6);
        }

        private void AddMessage(string message, LogLevel logLevel, int colorNumber)
        {
            if (logLevel < this.LogLevel)
            {
                return;
            }
            LogRecord logRecord = new LogRecord()            
            {
                Id = ++IdCounter,
                Message = message,
                DateTime = DateTime.Now,
                LogLevel = logLevel,
            };
            foreach (var storage in Storages)
            {
                List<LogRecord> Buffer = new List<LogRecord>();
                if (storage.GetAllLogs() != null)
                {
                    Buffer = storage.GetAllLogs();
                }
                Buffer.Add(logRecord);
                storage.AddMessageToStorage(Buffer, colorNumber);
            }
        }
    }
}
