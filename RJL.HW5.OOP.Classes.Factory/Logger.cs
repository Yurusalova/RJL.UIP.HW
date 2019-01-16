using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
  static   class Logger
    {
        public static int CountLog { get; set; } = 1;
        public static int CountDay { get; set; } = 1;
        public static int CountMonth { get; set; } = 1;
        public static void LogInfo(string message ) {
            Console.WriteLine($"{CountLog}. Info: day {CountDay}, month {CountMonth}. {message}");
        }
        public static void LogWarning(string message)
        {
            Console.WriteLine($"{CountLog}. Warning: day {CountDay}, month {CountMonth}. {message}");
        }
    }
}
