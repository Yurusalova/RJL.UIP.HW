using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task3
{
    class Phone
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Phone(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
