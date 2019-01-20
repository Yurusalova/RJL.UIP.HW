using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
  static   class Logger
    {
       public static int CountLog { get; private set; } = 1;
       public static void LogInfo(string message ) {
            Console.WriteLine($"{CountLog}. Info: day {Date2.CountDay}, month {Date2.CountMonth}. {message}");
            CountLog++;
        }
        public static void LogWarning(string message)
        {
            Console.WriteLine($"{CountLog}. Warning: day {Date2.CountDay}, month {Date2.CountMonth}. {message}");
            CountLog++;
        }
        public static void LogWithoutDate(string message) {
            Console.WriteLine(message);
        }
    }
}
