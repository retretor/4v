using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OST_Labs
{

    public class SystemClock : INotifyPropertyChanged
    {
        private long _clock;
        public long Clock
        {
            get => _clock;
            private set { _clock = value; OnPropertyChanged(); }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public void WorkingCycle()
        {
            Clock++;
        }
        public void Clear()
        {
            Clock = 0;
        }
    }
}