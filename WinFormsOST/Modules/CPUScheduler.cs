using Queues;

namespace OST_Labs
{
    public class CpuScheduler
    {
        private Resource _resource;
        private SortedUnsortedCombination _queue;

        public CpuScheduler(Resource resource, SortedUnsortedCombination queue)
        {
            _resource = resource;
            _queue = queue;
        }

        public SortedUnsortedCombination Session()
        {
            Process process = _queue.Item();
            process.ProcessStatus = ProcessStatus.Running;
            _queue.Remove();
            _resource.ActiveProcess = process;
            return _queue;
        }
    }
}