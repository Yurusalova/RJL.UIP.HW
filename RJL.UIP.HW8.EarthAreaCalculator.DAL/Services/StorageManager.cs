using RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW8.EarthAreaCalculator.DAL.Services
{
    public class StorageManager : IStorageManager
    {
        public List<IStorage> CreateStorages()
        {
            List<IStorage> storages = new List<IStorage>();
            storages.Add(new ConsoleStorage());
            storages.Add(new FileStorage());
            return storages;
        }

        public void AddStorages(List<IStorage> storages, IStorage storage) {
            storages.Add(storage);
        }
        public void RemoveStorages(List<IStorage> storages, IStorage storage)
        {
            storages.Remove(storage);
        }
    }
}
