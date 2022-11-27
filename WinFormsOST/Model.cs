using Queues;
using Structures;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OST_Labs
{

    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public SystemClock Clock { get; private set; }
        /**/
        public readonly Resource Cpu;
        /**/
        public readonly Resource Device;
        public readonly Resource Device2;
        public readonly Resource Device3;
        private readonly IDGenerator _idGen;
        private readonly CpuScheduler _cpuScheduler;
        private readonly DeviceScheduler _deviceScheduler;
        private readonly DeviceScheduler _deviceScheduler2;
        private readonly DeviceScheduler _deviceScheduler3;
        public Memory Ram { get; private set; }
        private readonly MemoryManager _memoryManager;
        private readonly Random _processRand;
        public Settings ModelSettings { get; set; }
        private SortedUnsortedCombination _readyQueue;
        private IQueueable<Process> _deviceQueue;
        private IQueueable<Process> _deviceQueue2;
        private IQueueable<Process> _deviceQueue3;
        public SortedUnsortedCombination ReadyQueue
        {
            get => _readyQueue;
            private set { _readyQueue = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> DeviceQueue
        {
            get => _deviceQueue;
            private set { _deviceQueue = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> DeviceQueue2
        {
            get => _deviceQueue2;
            private set { _deviceQueue2 = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> DeviceQueue3
        {
            get => _deviceQueue3;
            private set { _deviceQueue3 = value; OnPropertyChanged(); }
        }


        public Model()
        {
            Clock = new SystemClock();
            Cpu = new Resource();
            Device = new Resource();
            Device2 = new Resource();
            Device3 = new Resource();
            Ram = new Memory();
            _idGen = new IDGenerator();
            ReadyQueue = new SortedUnsortedCombination();
            DeviceQueue = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            DeviceQueue2 = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            DeviceQueue3 = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            _cpuScheduler = new CpuScheduler(Cpu, ReadyQueue);
            _memoryManager = new MemoryManager();
            _deviceScheduler = new DeviceScheduler(Device, DeviceQueue);
            _deviceScheduler2 = new DeviceScheduler(Device2, DeviceQueue2);
            _deviceScheduler3 = new DeviceScheduler(Device3, DeviceQueue3);
            _processRand = new Random();
            ModelSettings = new Settings();
        }

        public void SaveSettings()
        {
            Ram.Save(ModelSettings.ValueOfRamSize);
            _memoryManager.Save(Ram);
        }

        public void WorkingCycle()
        {
            Clock.WorkingCycle();
            //---------------------------------------------------------------------------------
            int averageTime = (ModelSettings.MaxValueOfBurstTime - ModelSettings.MinValueOfBurstTime) / 2;
            if(Clock.Clock % (averageTime * averageTime / ModelSettings.Intensity) == 0)
            {
                ReadyQueue.Sort();
            }
            //---------------------------------------------------------------------------------
            
            if (_processRand.NextDouble() < ModelSettings.Intensity)
            {
                Process proc = new Process(_idGen.Id, 
                    _processRand.Next(ModelSettings.MinValueOfAddrSpace, ModelSettings.MaxValueOfAddrSpace + 1),
                    _processRand.Next(1, 6));
                if (_memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    Subscribe(proc);
                    ReadyQueue = ReadyQueue.Put(proc);
                    if (Cpu.IsFree())
                    {
                        ReadyQueue = _cpuScheduler.Session();
                    }
                }
            }
            Cpu.WorkingCycle();
            Device.WorkingCycle();
            Device2.WorkingCycle();
            Device3.WorkingCycle();
        }

        public void Clear()
        {
            Cpu.Clear();
            Device.Clear();
            Device2.Clear();
            Device3.Clear();
            Ram.Clear();
            Clock.Clear();
            _idGen.Clear();
            ReadyQueue = ReadyQueue.Clear();
            DeviceQueue = DeviceQueue.Clear();
            DeviceQueue2 = DeviceQueue2.Clear();
            DeviceQueue3 = DeviceQueue3.Clear();
        }

        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process p = sender as Process;
            switch (p.ProcessStatus)
            {
                case ProcessStatus.Ready:
                    ClearDevice(p);
                    
                    p.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    p.ResetWorkTime();
                    ReadyQueue = ReadyQueue.Put(p);
                    if (Cpu.IsFree())
                    {
                        ReadyQueue = _cpuScheduler.Session();
                    }
                    break;
                
                case ProcessStatus.Terminated:
                    Cpu.Clear();
                    if(ReadyQueue.Count != 0)
                    {
                        ReadyQueue = _cpuScheduler.Session();
                    }
                    _memoryManager.Free(p);
                    Unsubscribe(p);
                    break;
                
                case ProcessStatus.Waiting:
                    Cpu.Clear();
                    p.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    p.ResetWorkTime();
                    
                    PutOnDevice(p);
                    if (ReadyQueue.Count != 0)
                    {
                        ReadyQueue = _cpuScheduler.Session();
                    }
                    break;
                default:
                    break;
            }
        }

        private void ClearDevice(Process p)
        {
            if (Device.ActiveProcess == p)
            {
                Device.Clear();
                if (DeviceQueue.Count != 0)
                {
                    DeviceQueue = _deviceScheduler.Session();
                }
            }
            else if (Device2.ActiveProcess == p)
            {
                Device2.Clear();
                if (DeviceQueue2.Count != 0)
                {
                    DeviceQueue2 = _deviceScheduler2.Session();
                }
            }
            else if (Device3.ActiveProcess == p)
            {
                Device3.Clear();
                if (DeviceQueue3.Count != 0)
                {
                    DeviceQueue3 = _deviceScheduler3.Session();
                }
            }
        }

        private readonly Random _rand = new Random();
        private void PutOnDevice(Process p)
        {
            int device = _rand.Next(1, 4);
            switch (device)
            {
                case 1:
                    DeviceQueue = DeviceQueue.Put(p);
                    if (Device.IsFree())
                    {
                        DeviceQueue = _deviceScheduler.Session();
                    }
                    break;
                case 2:
                    DeviceQueue2 = DeviceQueue2.Put(p);
                    if (Device2.IsFree())
                    {
                        DeviceQueue2 = _deviceScheduler2.Session();
                    }
                    break;
                default:
                    DeviceQueue3 = DeviceQueue3.Put(p);
                    if (Device3.IsFree())
                    {
                        DeviceQueue3 = _deviceScheduler3.Session();
                    }
                    break;
            }
        }

        private void Subscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource += FreeingAResourceEventHandler;
            }
        }

        private void Unsubscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource -= FreeingAResourceEventHandler;
            }
        }
    }
}