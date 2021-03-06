﻿using RJL.UIP.HW7.LoggerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RJL.UIP.HW7.LoggerLibrary.Interfaces;
using RJL.UIP.HW7.LoggerLibrary.Models;
using RJL.UIP.HW7.Services;

namespace RJL.UIP.HW7.Models
{
    public class Point
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
