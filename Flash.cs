using System;

namespace StorageLib
{
    public class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;

        public Flash(string name, string model, double usbSpeed, double memorySize)
        {
            Name = name;
            Model = model;
            this.usbSpeed = usbSpeed;
            this.memorySize = memorySize;
        }

        // Modify the memory calculation
        public override double GetMemory()
        {
            return memorySize;
        }

        // Change the data copying method
        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying {dataSize} GB of data to Flash. Time required: {dataSize / usbSpeed} seconds.");
        }

        // Modify the free space calculation
        public override double GetFreeSpace()
        {
            return memorySize * 0.2; // Change this value if Flash drives have some free space
        }

        // Modify the device information output
        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Flash Drive: {Name}, Model: {Model}, USB Speed: {usbSpeed} GB/s, Memory Size: {memorySize} GB");
        }
    }
}
