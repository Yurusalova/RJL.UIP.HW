using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task3
{
    class Shop
    { public string Name { get; set; }
      public string Address { get; private set; }
        public Storage[] Storages { get; } = new Storage[5];

        internal void AddStorage(Storage storage)
        {
            for (int i = 0; i < Storages.Length; i++)
            {
                if (Storages[i] == null)
                {
                    Storages[i] = storage;
                    break;
                }
            }
        }

        public Shop(string name)
        {
            this.Name = name;
        }
    }
}
