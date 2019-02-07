using RJL.UIP.EarthAreaCalculator.Core.DI;
using RJL.UIP.HW8.EarthAreaCalculator.BAL.Services;
using RJL.UIP.HW8.EarthAreaCalculator.DAL.Services;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW8.EarthAreaCalculator.UI.ConsoleUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RJL.UIP.HW8.EarthAreaCalculator.UI.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContainer.ConfigureContainer();
            new UserСonsoleInteractor().StartMainMenu();
            Console.ReadLine();
        }
    }
}
