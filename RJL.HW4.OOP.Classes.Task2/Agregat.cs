using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task2
{
    class Agregat
    {
        public int GeneralCountDetails { get; private set;}
        public int CurrentAssembledDetails { get; set;}
        public Agregat(int agregatCountDetails, int currentAssembledDetails)
        {
            this.GeneralCountDetails = agregatCountDetails;
            this.CurrentAssembledDetails = currentAssembledDetails;

        }
        public bool IsAgregateAssambled()
        {
            return this.CurrentAssembledDetails >= this.GeneralCountDetails;
        }

    }
}
