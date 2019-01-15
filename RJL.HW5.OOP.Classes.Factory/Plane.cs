using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Plane
    {
        public string Name { get; private set; } = "plane";
        public int GeneralCountDetails { get; private set; }
        public int CurrentAddedDetails { get; set; } = 0;
        public bool isReady { get { return this.CurrentAddedDetails >= this.GeneralCountDetails; } }

        public Plane(int generalCountDetails)
        {
            this.GeneralCountDetails = generalCountDetails;
        }
    }
}
