using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces
{
    public interface IStorageManager
    {
        List<IStorage> CreateStorages();
        void AddStorages(List<IStorage> storages, IStorage storage);
        void RemoveStorages(List<IStorage> storages, IStorage storage);
    }
}
