using System;

namespace StorageLib
{
    public class DVD : Storage
    {
        private double readWriteSpeed;
        private string type;

        public DVD(string name, string model, double readWriteSpeed, string type)
        {
            Name = name;
            Model = model;
            this.readWriteSpeed = readWriteSpeed;
            this.type = type;
        }

        // Modify the memory calculation based on the type
        public override double GetMemory()
        {
            return (type == "односторонний") ? 4.7 : 9;
        }

        // Change the data copying method
        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying {dataSize} GB to DVD. Time required: {dataSize / readWriteSpeed} seconds.");
        }

        // Modify the free space calculation
        public override double GetFreeSpace()
        {
            return 0; // Change this value if DVDs have some free space
        }

        // Modify the device information output
        public override void GetDeviceInfo()
        {
            Console.WriteLine($"DVD: {Name}, Model: {Model}, Read/Write Speed: {readWriteSpeed} GB/s, Type: {type}");
        }
    }
}
