using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
   public abstract class Device
    {
        public  string Model { get; private set; }
        public  int Power { get; private set; }
        public bool IsConnectToGenerator { get; set;}
        public Device NextDeviceInChain { get; set; }
        public int Id 
          {
            get {
               return _Id;
            }
            set
            {
                if (value< 0)
                {
                     return;
                }
                _Id = value;
            }
        }
        private int _Id;

        public  Device(string model, int power) {
            this.Model = model;
            this.Power = power;
        }

        public abstract override string ToString();
        public  void Plug(Device device)
        {
            this.NextDeviceInChain = device;
        }
    }
}
