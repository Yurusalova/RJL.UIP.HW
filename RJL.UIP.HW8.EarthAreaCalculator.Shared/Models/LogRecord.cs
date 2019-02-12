using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW8.EarthAreaCalculator.Shared.Models
{
    public class LogRecord
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime DateTime { get; set; }

        public LogLevel LogLevel { get; set; }

        public int ColorText { get; set; }

        public override string ToString()
        {
            return $"{Id}, {DateTime.ToString()}, {LogLevel}, {Message}";
        }

        public int GetLogRecordColorByLogLevel(LogLevel logLevel)
        {
             switch (logLevel)
            {
                case LogLevel.Info:
                    return 9;
                case LogLevel.Warn:
                    return 6;
                case LogLevel.Debug:
                    return 10;
                case LogLevel.Fatal:
                    return 13;
                case LogLevel.Error:
                    return 4;
                default:
                    return 0;
            }
        }
    }
    
    public enum LogLevel
    {
        Info,
        Warn,
        Debug,
        Fatal,
        Error
    }
}

