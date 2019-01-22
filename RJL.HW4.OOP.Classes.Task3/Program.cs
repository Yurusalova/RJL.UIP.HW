using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuiItems = new string[] { "quit", "add store to shop", "add phone to store", "show all phones in stores", "clear console" };
            Shop mobileShop = new Shop(GetInputNameShop());
            Console.WriteLine("=> Great, the name of shop is '" + mobileShop.Name + "'");
            int indexCommand;
            do
            {
                indexCommand = GetCommandFromOptionMenu(menuiItems);
                ChooseOptionMenu(indexCommand, mobileShop);
            } while (indexCommand != 0);
            
            Console.ReadLine();
        }
        static string GetInputNameShop()
        {
            string inputName;
            do
            {
                Console.WriteLine("Please write valid (not empty) name for shop");
                inputName = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(inputName));

            return inputName;
        }
        static int GetCommandFromOptionMenu(string[] menuItems)
        {
            Console.WriteLine("---------------------------NEW COMMAND----------------------------");
            Console.WriteLine("Please write the index of command from the list below. Commands:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"[{i}] = {menuItems[i]}");
            }
            string inputResult = Console.ReadLine();
            int inputIntResult;
            bool isSuccessInput = int.TryParse(inputResult, out inputIntResult);
            return inputIntResult;
        }
        static void ChooseOptionMenu(int inputIntResult,  Shop shop)
        {
            switch (inputIntResult)
            {
                case 0:
                    Console.WriteLine("Good bye!");
                    break;
                case 1:
                    AddStoreToShop(shop);
                    break;
                case 2:
                    SelectStoreForAddPhones(shop);
                    break;
                case 3:
                    AllStoresOutput(shop, true);
                    break;
                case 4:
                    Console.Clear();
                    break;
            }
        }
        static void PhonesInStoreOutput(Storage storage)
        {
            for (int i = 0; i < storage.Phones.Length; i++)
            {
                string textForOutput = storage.Phones[i] != null ? $"    [{i}] - Phone model name '{storage.Phones[i].Name}' " +
                     $"and price '{storage.Phones[i].Price}'" : $"    [{i}] - Phone cell is empty";
                Console.WriteLine(textForOutput);
            }
        }
        static void AllStoresOutput(Shop mobileshop, bool isNeededPhoneOutput)
        {
            string textForOutput;
            Console.WriteLine("=> Store in '" + mobileshop.Name + "'");
            for (int i = 0; i < mobileshop.Storages.Length; i++)
            {
                if (mobileshop.Storages[i] != null)
                {
                    textForOutput = $"[{i}] - Store cell is '{mobileshop.Storages[i].Number}'" +
                      $" with address '{mobileshop.Storages[i].Address}' and capacity '{mobileshop.Storages[i].Phones.Length}'";
                }
                else if (isNeededPhoneOutput)
                {
                    textForOutput = $"[{i}] - Store cell is empty";
                }
                else { break; }
                Console.WriteLine(textForOutput);
                if (mobileshop.Storages[i] != null && isNeededPhoneOutput) { PhonesInStoreOutput(mobileshop.Storages[i]); }
            }
        }
        static void AddStoreToShop(Shop shop)
        {
            string inputNumberStore, inputAddressStore, inputPhoneCapacity;
            int inputIntNumberStore, inputIntPhoneCapacity;
            bool isSuccessInput;
            do
            {
                Console.WriteLine("Please write the number of store (number >0 and number<=500) in shop '" + shop.Name + "'");
                inputNumberStore = Console.ReadLine();
                isSuccessInput = int.TryParse(inputNumberStore, out inputIntNumberStore);
            } while (!isSuccessInput || inputIntNumberStore > 500 || inputIntNumberStore < 1);
            do
            {
                Console.WriteLine("Please write shop address (text with length>10) of store");
                inputAddressStore = Console.ReadLine();
            } while (inputAddressStore.Length < 10);
            do
            {
                Console.WriteLine("Please write capacity (number >0 and number<=10) of phones which could be in store'" + shop.Name + "'");
                inputPhoneCapacity = Console.ReadLine();
                isSuccessInput = int.TryParse(inputPhoneCapacity, out inputIntPhoneCapacity);
            } while (!isSuccessInput || inputIntPhoneCapacity > 10 || inputIntPhoneCapacity < 1);

            Storage storage = new Storage(inputIntNumberStore, inputAddressStore, inputIntPhoneCapacity);
            shop.AddStorage(storage);
            Console.WriteLine($"=> Store with number {inputIntNumberStore}, address '{inputAddressStore}' and capacity '{inputIntPhoneCapacity}' successfully created");
        }
        static void AddPhoneToStore(Shop shop, int storeNumber)
        {
            string inputNamePhone, inputPricePhone;
            int inputIntPricePhone;
            bool isSuccessInput;
            do
            {
                Console.WriteLine("Please write phone model name (text with length>10)");
                inputNamePhone = Console.ReadLine();
            } while (inputNamePhone.Length < 10);
            do
            {
                Console.WriteLine("Please write price (number>0 and number<=100000) of phones which could be in store");
                inputPricePhone = Console.ReadLine();
                isSuccessInput = int.TryParse(inputPricePhone, out inputIntPricePhone);
            } while (!isSuccessInput || inputIntPricePhone <= 0 || inputIntPricePhone > 100000);
            Phone phone = new Phone(inputNamePhone, inputIntPricePhone);
            shop.AddPhoneToStore(phone, shop.Storages[storeNumber].Number);
            Console.WriteLine($"=> Phone with model name '{inputNamePhone}' and price '{inputIntPricePhone}'" +
                      $" was successfully added to store number '{shop.Storages[storeNumber].Number}' " +
                     $"with address '{shop.Storages[storeNumber].Address}' and capacity '{shop.Storages[storeNumber].Phones.Length}'");
        }
        static void SelectStoreForAddPhones(Shop mobileshop)
        {
            Storage[] storages = mobileshop.Storages;
            if (isShopHasStorage(mobileshop))
            {
                int inputIntIndexStore;
                string inputStringIndexStore;
                bool isSuccessAllInput;
                do
                {
                    Console.WriteLine("Please write index number of MobilephoneStore from list below. MobilePhoneStores:");
                    AllStoresOutput(mobileshop, false);
                    inputStringIndexStore = Console.ReadLine();
                    bool isSuccessIntInput = int.TryParse(inputStringIndexStore, out inputIntIndexStore);
                    isSuccessAllInput = isSuccessIntInput && inputIntIndexStore >= 0 && inputIntIndexStore <= GetMaxIndexOfStorages(mobileshop);
                    if (!isSuccessAllInput) { Console.WriteLine("=> Invalid number"); }
                } while (!isSuccessAllInput);
                if (!isStorageHasFreePhoneCell(mobileshop.Storages[inputIntIndexStore]))
                {
                    Console.WriteLine($"There are no free cell phone in storage {mobileshop.Storages[inputIntIndexStore].Number}");
                }
                else
                {
                    AddPhoneToStore(mobileshop, inputIntIndexStore);
                }
            }
            else
            {
                Console.WriteLine($"=> In '{mobileshop.Name}' no real stores are available. Please add any real store before add a phone");
            }
        }
        static bool isShopHasStorage(Shop shop)
        {
            foreach (var store in shop.Storages)
            {
                if (store != null)
                {
                    return true;
                }
            }
            return false;
        }
        static int GetMaxIndexOfStorages(Shop shop)
        {
            int maxIndexStorage = 0; ;
            for (int i = 0; i < shop.Storages.Length; i++)
            {
                if (shop.Storages[i] != null)
                {
                    maxIndexStorage = i;
                }
                else
                {
                    break;
                }

            }
            return maxIndexStorage;
        }
        static bool isStorageHasFreePhoneCell(Storage storage)
        {
            foreach (var phone in storage.Phones)
            {
                if (phone == null)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
