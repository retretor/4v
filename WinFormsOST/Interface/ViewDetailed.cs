using Queues;
using System.ComponentModel;
using System.Windows.Forms;

namespace OST_Labs
{
    class ViewDetailed : View
    {
        private readonly Form1 form;
        public ViewDetailed(Model model, Controller controller, Form1 form) : base(model, controller)
        {
            this.form = form;
        }

        public override void DataBind()
        {
            // Cpu process
            Binding cpuText = new Binding("Text", Model.Cpu, "ActiveProcess");
            form.CpuText.DataBindings.Add(cpuText);
            // Device process
            Binding deviceText = new Binding("Text", Model.Device, "ActiveProcess");
            form.DeviceText1.DataBindings.Add(deviceText);
            Binding deviceText2 = new Binding("Text", Model.Device2, "ActiveProcess");
            form.DeviceText2.DataBindings.Add(deviceText2);
            Binding deviceText3 = new Binding("Text", Model.Device3, "ActiveProcess");
            form.DeviceText3.DataBindings.Add(deviceText3);
            // Occupied RAM
            Binding occupiedRamText = new Binding("Text", Model.Ram, "OccupiedSize");
            form.OccupiedRamText.DataBindings.Add(occupiedRamText);
            // Free RAM
            Binding freeRamText = new Binding("Text", Model.Ram, "FreeSize");
            form.FreeRamText.DataBindings.Add(freeRamText);
            // System clock
            Binding tasksText = new Binding("Text", Model.Clock, "Clock");
            form.TacktsText.DataBindings.Add(tasksText);
            

            // Intensivity
            Binding intensity = new Binding("Value", Model.ModelSettings, "Intensity");
            intensity.ControlUpdateMode = ControlUpdateMode.Never;
            form.ProcessIntensivityNumeric.DataBindings.Add(intensity);
            
            
            // MinWorkTimeNumeric
            Binding minWorkTimeNumeric = new Binding("Value", Model.ModelSettings, "MinValueOfBurstTime");
            minWorkTimeNumeric.ControlUpdateMode = ControlUpdateMode.Never;
            form.MinWorkTimeNumeric.DataBindings.Add(minWorkTimeNumeric);
            // MaxWorkTimeNumeric
            Binding maxWorkTimeNumeric = new Binding("Value", Model.ModelSettings, "MaxValueOfBurstTime");
            maxWorkTimeNumeric.ControlUpdateMode = ControlUpdateMode.Never;
            form.MaxWorkTimeNumeric.DataBindings.Add(maxWorkTimeNumeric);
            // MinAddrSpaceNumeric
            Binding minAddrSpaceNumeric = new Binding("Value", Model.ModelSettings, "MinValueOfAddrSpace");
            minAddrSpaceNumeric.ControlUpdateMode = ControlUpdateMode.Never;
            form.MinAddrSpaceNumeric.DataBindings.Add(minAddrSpaceNumeric);
            // MaxAddrSpaceNumeric
            Binding maxAddrSpaceNumeric = new Binding("Value", Model.ModelSettings, "MaxValueOfAddrSpace");
            maxAddrSpaceNumeric.ControlUpdateMode = ControlUpdateMode.Never;
            form.MaxAddrSpaceNumeric.DataBindings.Add(maxAddrSpaceNumeric);
            // ValueOfRamSize
            Binding valueOfRamSize = new Binding("SelectedItem", Model.ModelSettings, "ValueOfRamSize", true);
            valueOfRamSize.ControlUpdateMode = ControlUpdateMode.Never;
            form.RamSize.DataBindings.Add(valueOfRamSize);
            
            Subscribe();

        }

        public override void DataUnbind()
        {
            form.CpuText.DataBindings.RemoveAt(0);
            form.DeviceText1.DataBindings.RemoveAt(0);
            form.DeviceText2.DataBindings.RemoveAt(0);
            form.DeviceText3.DataBindings.RemoveAt(0);
            form.OccupiedRamText.DataBindings.RemoveAt(0);
            form.FreeRamText.DataBindings.RemoveAt(0);
            form.TacktsText.DataBindings.RemoveAt(0);
            form.ProcessIntensivityNumeric.DataBindings.RemoveAt(0);
            form.MinWorkTimeNumeric.DataBindings.RemoveAt(0);
            form.MaxWorkTimeNumeric.DataBindings.RemoveAt(0);
            form.MinAddrSpaceNumeric.DataBindings.RemoveAt(0);
            form.MaxAddrSpaceNumeric.DataBindings.RemoveAt(0);
            form.RamSize.DataBindings.Clear();
           
            Unsubscribe();
        }

        private void Subscribe()
        {
            Model.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
            Model.ReadyQueue.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
        }
        private void Unsubscribe()
        {
            Model.PropertyChanged -= PropertyChangedHandler;
            Model.ReadyQueue.PropertyChanged -= PropertyChangedHandler;
        }
        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SortedList")
            {
                UpdateListBox(Model.ReadyQueue.SortedList, form.CpuQueueList);
            }
            else if (e.PropertyName == "UnsortedList")
            {
                UpdateListBox(Model.ReadyQueue.UnsortedList, form.CpuQueueList2);
            }
            else if (e.PropertyName == "DeviceQueue")
            {
                UpdateListBox(Model.DeviceQueue, form.DeviceQueueList1);
            }
            else if (e.PropertyName == "DeviceQueue2")
            {
                UpdateListBox(Model.DeviceQueue2, form.DeviceQueueList2);
            }
            else if (e.PropertyName == "DeviceQueue3")
            {
                UpdateListBox(Model.DeviceQueue3, form.DeviceQueueList3);
            }
        }

        private void UpdateListBox(IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());
        }
    }
}

