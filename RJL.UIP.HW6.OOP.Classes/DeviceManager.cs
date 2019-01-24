using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    public static class DeviceManager
    {
        public static int GetSumPowerAllDevices(List<Device> devices)
        {
            int sumPowerAllDevices = 0;
            foreach (var device in devices)
            {
                sumPowerAllDevices += device.Power;
            }
            return sumPowerAllDevices;
        }
        public static void DescriptionDevicesOutput(List<Device> devices)
        {
            foreach (var device in devices)
            {
                Console.WriteLine(device.ToString());
            }
        }
        public static int GetSumRAMAllDevices(List<Device> devices)
        {
            int sumRAMAllDevices = 0;
            foreach (var device in devices)
            {
                if (device is Computer)
                {
                    Computer computer = (Computer)device;
                    sumRAMAllDevices += computer.RAM;
                }
            }
            return sumRAMAllDevices;
        }
        public static void SetDevicesIDs(List<Device> devices)
        {
            Random randomizer = new Random();
            int startId = randomizer.Next(0, 100);
            foreach (var device in devices)
            {
                device.Id = startId;
                startId++;
            }
        }
        public static void ChainCreation(List<Device> devices, Generator generator)
        {
            Device lastConnectedDevice = null;
            generator.IsConnectToGenerator = true;
            if (devices != null)
            {
                //connect first device to generator
                foreach (var device in devices)
                {
                    if (IsConnectDeviceToAnother(generator, device, generator))
                    {
                        lastConnectedDevice = device;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                //connect all other devices
                for (int i = 1; i < devices.Count; i++)
                {
                    if (IsConnectDeviceToAnother(lastConnectedDevice, devices[i], generator))
                    {
                        lastConnectedDevice = devices[i];
                    }
                }
            }
        }
        public static bool IsConnectDeviceToAnother(Device firstDevice, Device nextDevice, Generator generator)
        {
            if (nextDevice.Power <= generator.Power && nextDevice.Power < generator.LeftPower && !nextDevice.IsConnectToGenerator)
            {
                firstDevice.NextDeviceInChain = nextDevice;
                generator.LeftPower -= nextDevice.Power;
                nextDevice.IsConnectToGenerator = true;
                Console.WriteLine($"{nextDevice.GetType().Name} {nextDevice.Model} connected to Generator");
                return true;
            }
            return false;
        }
        public static void PrintDevicesInGenerator(Device device)
        {
            if (!device.IsConnectToGenerator)
            {
                return;
            }
            Console.WriteLine(device.Id + " " + device.GetType().Name + " " + device.Model + " " + device.Power);
            if (device.NextDeviceInChain != null)
            {
                PrintDevicesInGenerator(device.NextDeviceInChain);
            }
        }
        public static void DisconnectDeviceFromGenerator(Device device, int idDeviceForDisconnect)
        {
            if (device.Id == idDeviceForDisconnect && device.IsConnectToGenerator)
            {
                device.IsConnectToGenerator = false;
                device.NextDeviceInChain = null;
                Console.WriteLine($"{device.GetType().Name} {device.Id} was disconnected from Generator");
                return;
            }
            else if(device.Id == idDeviceForDisconnect && !device.IsConnectToGenerator)
                {
                Console.WriteLine($"Device {device.Id} {device.Model} has already disconnected");
                return;
            }
            else
            {
                DisconnectDeviceFromGenerator(device.NextDeviceInChain, idDeviceForDisconnect);
            }
        }
        public static int GetIdDeviceForDisconnectFromInput(List<Device> devices) {
            bool isSuccessInput=false;
            do
            {
                Console.WriteLine("Enter ID of device that should be disconnected");
                string inputIDDevice = Console.ReadLine();
                int outputIDDevice;
                isSuccessInput = int.TryParse(inputIDDevice, out outputIDDevice);
                if (isSuccessInput)
                {
                    foreach (var device in devices)
                    {
                        if (outputIDDevice == device.Id)
                        {
                            return outputIDDevice;
                        }
                        else
                        {
                            continue;
                        }
                    }
                 }
                isSuccessInput = false;
                Console.WriteLine("You enter incorrect id");
            } while (!isSuccessInput);
            return 0;
        }
    }
}

