using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task3
{
    class Storage
    {
        public string Address { get; private set; }
        public int Number { get; private set; }
        public Phone[] Phones { get; } = new Phone[10];
        public Storage(int number, string address)
        {
            this.Number = number;
            this.Address = address;
        }

        public void AddPhonetoStorage(Phone phone)
        {
            for (int i = 0; i < Phones.Length; i++)
            {
                if (Phones[i]==null)
                {
                    Phones[i] = phone;
                    break;
                }
            }
        }
    }
}
