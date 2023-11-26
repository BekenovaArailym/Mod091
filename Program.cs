using System;

namespace Mod091
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[]
            {
                new Flash("NewFlashDrive", "Samsung", 4, 128),
                new DVD("DVD-RW", "LG", 0.02, "двусторонний"),
                new HDD("HDD", "Western Digital", 2, 4, 1000)
            };

            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemory();
            }
            Console.WriteLine($"Total memory of all devices: {totalMemory} GB");

            double dataSize = 1024; // Change the data size for devices
            double dataSize2 = 16; // Change the data size for DVDs
            foreach (var device in devices)
            {
                if (device is DVD)
                {
                    device.CopyData(dataSize2);
                }
                else
                {
                    device.CopyData(dataSize);
                }            
            }

            double fileSize = 1.5; // Change the file size
            int requiredDevices = (int)Math.Ceiling(dataSize / fileSize);
            Console.WriteLine($"Required devices for data transfer: {requiredDevices}");

            foreach (var device in devices)
            {
                Console.WriteLine($"Free space on {device.Name}: {device.GetFreeSpace()} GB");
            }

            foreach (var device in devices)
            {
                device.GetDeviceInfo();
            }

            Console.ReadLine();
        }
    }
}
