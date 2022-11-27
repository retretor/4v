using System.Diagnostics.Contracts;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OST_Labs
{
    public class Resource : INotifyPropertyChanged
    {
        private Process _activeProcess;
        public Process ActiveProcess
        {
            get => _activeProcess;
            set { _activeProcess = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public void WorkingCycle()
        {
            if (!IsFree())
            {
                ActiveProcess?.IncreaseWorkTime();
            }
        }
        [Pure]
        public bool IsFree()
        {
            return ActiveProcess == null;
        }
        public void Clear()
        {
            ActiveProcess = null;
        }
    }
}