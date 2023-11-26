using System;

namespace StorageLib
{
    public class HDD : Storage
    {
        private double usbSpeed;
        private int partitionsCount;
        private double partitionsSize;

        public HDD(string name, string model, double usbSpeed, int partitionsCount, double partitionsSize)
        {
            Name = name;
            Model = model;
            this.usbSpeed = usbSpeed;
            this.partitionsCount = partitionsCount;
            this.partitionsSize = partitionsSize;
        }

        // Modify the memory calculation
        public override double GetMemory()
        {
            return partitionsCount * partitionsSize;
        }

        // Change the data copying method
        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying {dataSize} GB to HDD. Time required: {dataSize / usbSpeed} seconds.");
        }

        // Modify the free space calculation
        public override double GetFreeSpace()
        {
            return partitionsSize * 0.1 * partitionsCount; // Change this value if HDDs have some free space
        }

        // Modify the device information output
        public override void GetDeviceInfo()
        {
            Console.WriteLine($"HDD: {Name}, Model: {Model}, USB Speed: {usbSpeed} GB/s, Partitions: {partitionsCount}, Partition Size: {partitionsSize} GB");
        }
    }
}
