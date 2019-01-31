using RJL.UIP.HW7.LoggerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.Models
{
    class HorizontalLine
    {
        public HorizontalLine(int xFirst, int xSecond, int y, Logger logger)
        {
            for (int x = xFirst; x <= xSecond; x++)
            {
                Point point = new Point(x, y,logger);
                point.PrintPoint();
            }
        }
    }
}
