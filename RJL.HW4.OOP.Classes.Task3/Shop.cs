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
        internal void AddPhoneToStore(Phone phone, int storeNum) {
            foreach (var storage in Storages)
            {
                if (storage.Number == storeNum)
                {
                    storage.AddPhonetoStorage(phone);
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
