using RJL.UIP.HW9.EarthAreaCalculator.Core.DI;
using RJL.UIP.HW9.EarthAreaCalculator.UI.ConsoleUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW9.EarthAreaCalculator.UI.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContainer.ConfigureContainer();
            string[] menuiItems = new string[] {"start new calculation area",
                                                "view logs",
                                                "clear console",
                                                "quit"};
            new UserСonsoleInteractor().StartMenu(menuiItems, 1);
            Console.ReadLine();
        }
    }
}
