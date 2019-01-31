using RJL.UIP.HW7.LoggerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.Models
{
    class VerticalLine
    {
        public VerticalLine(int yFirst, int ySecond, int x, Logger logger)
        {
            for (int y = yFirst; y <= ySecond; y++)
            {
               Point point = new Point(x, y, logger);
               point.PrintPoint();
            }
        }
    }
}
