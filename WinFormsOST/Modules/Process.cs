using System;

namespace OST_Labs
{
    public class Process : IComparable, IComparable<Process>
    {
        private readonly long _id;
        private readonly long _priority;
        private long _workTime;
        private readonly Random _random;

        public long BurstTime { get; set; }
        public ProcessStatus ProcessStatus { get; set; }
        public long AddressSpace { get; }
        
        public event EventHandler FreeingAResource;

        public Process(long pId, long pAddressSpace, long priority)
        {
            _id = pId;
            AddressSpace = pAddressSpace;
            ProcessStatus = ProcessStatus.Ready;
            _random = new Random();
            _priority = priority;
        }
        public void IncreaseWorkTime()
        {
            if (_workTime < BurstTime)
            {
                _workTime++;
            }
            else
            {
                if (ProcessStatus == ProcessStatus.Running)
                {
                   
                    ProcessStatus = _random.Next(0, 2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting;
                }
                else
                {
                    ProcessStatus = ProcessStatus.Ready;
                }
                OnFreeingAResource(this, null);
            }
        }

        public void ResetWorkTime()
        {
            _workTime = 0;
        }

        public override string ToString()
        {
            return "Process ID: " + _id +
                   "; Process Priority: " + _priority +
                   "; Process Status: " + ProcessStatus +
                   "; Process Address Space: " + AddressSpace +
                   "; Process Burst Time: " + BurstTime + ";";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Process otherProcess)
            {
                if (_priority < otherProcess._priority)
                    return -1;
                return _priority < otherProcess._priority ? 1 : 0;
            }
            throw new ArgumentException("Object is not a Process");
        }
        public int CompareTo(Process other)
        {
            if (other == null)
            {
                return 1;
            }
            return other._priority.CompareTo(_priority);
        }

        private void OnFreeingAResource(object sender, EventArgs e)
        {
            if (FreeingAResource != null)
            {
                FreeingAResource(sender, e);
            }
        }

    }

    public enum ProcessStatus
    {
        Ready,
        Running,
        Waiting,
        Terminated
    }
}