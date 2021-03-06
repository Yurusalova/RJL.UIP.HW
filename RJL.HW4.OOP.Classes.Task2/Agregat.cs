﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task2
{
    class Agregat
    {
        public int GeneralCountDetails { get; private set;}
        public int CurrentAssembledDetails { get; set; } = 0;
        public Agregat(int agregatCountDetails)
        {
            this.GeneralCountDetails = agregatCountDetails;
        }
        public bool IsAgregateAssambled()
        {
            return this.CurrentAssembledDetails >= this.GeneralCountDetails;
        }

    }
}
