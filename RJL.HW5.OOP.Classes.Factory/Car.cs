using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Car
    {
        public string Name { get; private set; } = "car";
        public int GeneralCountDetails { get; private set; }
        
        public int CurrentAddedDetails
        {
            get {
                return _currentAddedDetails;
            }
            set
            {
                if (value >= 0 && value <= this.GeneralCountDetails)
                {
                    _currentAddedDetails = value;
                }
            }
        }
        private int _currentAddedDetails;
        public bool IsReady {
            get {
                return this.CurrentAddedDetails >= this.GeneralCountDetails;
            }
        }

        public Car(int generalCountDetails)
        {
            this.GeneralCountDetails = generalCountDetails;
        }
    }
}
