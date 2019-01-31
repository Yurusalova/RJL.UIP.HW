using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RJL.UIP.HW7.LoggerLibrary.Interfaces;
using RJL.UIP.HW7.LoggerLibrary.Models;

namespace RJL.UIP.HW7.LoggerLibrary.Services
{
   public class Logger : ILogger
    {
        private List<IStorage> Storages;
        private static int IdCounter=0;
        public LogLevel LogLevel { get; set; }

        public Logger(List<IStorage> storages)
        {
            this.Storages = storages;
        }

        public void Debug(string message)
        {
            AddMessage(message, LogLevel.Debug);
        }

        public void Error(string message)
        {
            AddMessage(message, LogLevel.Error);
        }

        public void Fatal(string message)
        {
            AddMessage(message, LogLevel.Fatal);
        }

        public void Info(string message)
        {
            AddMessage(message, LogLevel.Info);
        }

        public void Warn(string message)
        {
            AddMessage(message, LogLevel.Warn);
        }

        private void AddMessage(string message, LogLevel logLevel)
        {
            if (logLevel < this.LogLevel)
            {
                return;
            }
            LogRecord logRecord = new LogRecord()
            {
                Id = IdCounter,
                Message = message,
                DateTime = DateTime.Now,
                LogLevel = logLevel
            };

            foreach (var storage in Storages)
            {
                storage.AddMessage(logRecord);
            }
            IdCounter++;
        }
    }
}
