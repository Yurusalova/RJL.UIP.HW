using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.LoggerLibrary.Models
{
    public class LogRecord
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime DateTime { get; set; }

        public LogLevel LogLevel { get; set; }

        public override string ToString()
        {
           return $"{Id}, {DateTime.ToString()}, {LogLevel}, {Message}";
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
