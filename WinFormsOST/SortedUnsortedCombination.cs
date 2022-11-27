using System.ComponentModel;
using System.Runtime.CompilerServices;
using Queues;
using Structures;

namespace OST_Labs
{
    public class SortedUnsortedCombination
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        private IQueueable<Process> _sortedList;
        private IQueueable<Process> _unsortedList;
        public int Count { get; private set; }
        public IQueueable<Process> SortedList
        {
            get { return _sortedList; }
            private set
            {
                _sortedList = value;
                OnPropertyChanged();
            }
        }
        public IQueueable<Process> UnsortedList
        {
            get { return _unsortedList; }
            private set
            {
                _unsortedList = value;
                OnPropertyChanged();
            }
        }

        public SortedUnsortedCombination()
        {
            SortedList = new PriorityQueue<Process, SortedLinkedList<Process>>(new SortedLinkedList<Process>());
            UnsortedList = new FIFOQueue<Process, QueueableLinkedList<Process>>(new QueueableLinkedList<Process>());
            Count = 0;
        }
        public void Sort()
        {
            while (_unsortedList.Count != 0)
            {
                Process tempItem = _unsortedList.Item();
                UnsortedList = _unsortedList.Remove();
                SortedList = _sortedList.Put(tempItem);
            }
        }

        public Process Item()
        {
            if (_sortedList.Count == 0)
            {
                Sort();
            }
            return _sortedList.Item();
        }

        public SortedUnsortedCombination Put(Process value)
        {
            UnsortedList = _unsortedList.Put(value);
            if (_sortedList.Count == 0)
            {
                Sort();
            }
            Count++;
            return this;
        }

        public SortedUnsortedCombination Clear()
        {
            SortedList = _sortedList.Clear();
            UnsortedList = _unsortedList.Clear();
            Count = 0;
            return this;
        }

        public SortedUnsortedCombination Remove()
        {
            SortedList = _sortedList.Remove();
            Count--;
            return this;
        }
    }
}