using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OST_Labs
{
    public class Memory : INotifyPropertyChanged
    {
        public long Size { get; private set; }
        private long _occupiedSize;
        public long OccupiedSize
        {
            get { return _occupiedSize; }
            set { _occupiedSize = value; OnPropertyChanged(); }
        }
        private long _freeSize;
        public long FreeSize
        {
            get { return Size - OccupiedSize; }
            private set { _freeSize = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public void Save(long size)
        {
            FreeSize = Size = size;
            OccupiedSize = 0;
        }
        public void Clear()
        {
            OccupiedSize = 0;
        }

        /*public bool Allocate(Process process)
        {
            if (process.AddressSpace > FreeSize)
            {
                return false;
            }
            OccupiedSize += process.AddressSpace;
            return true;
        }

        public void Free(Process process)
        {
            OccupiedSize -= process.AddressSpace;
        }*/
    }
}