using RJL.UIP.HW7.LoggerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.Models
{
    class DiagonalLine
    {
        public DiagonalLine(int xFirst, int xSecond, int yFirst, int ySecond,Logger logger)
        {
            for (int x = xFirst; x <= xSecond; x++)
            {
                for (int y = yFirst; y < x; y++)
                {
                    Point point = new Point(x, y, logger);
                    point.PrintPoint();
                }
            }
        }
    }
}
