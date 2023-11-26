using System;

namespace StorageLib
{
    public abstract class Storage
    {
        private string storageName;
        private string storageModel;

        public string StorageName
        {
            get { return storageName; }
            set { storageName = value; }
        }

        public string StorageModel
        {
            get { return storageModel; }
            set { storageModel = value; }
        }

        // Modify or add properties as needed

        public abstract double GetMemory();
        public abstract void CopyData(double dataSize);
        public abstract double GetFreeSpace();
        public abstract void GetDeviceInfo();
    }
}
