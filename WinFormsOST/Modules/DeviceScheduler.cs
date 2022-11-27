using Queues;

namespace OST_Labs
{

    public class DeviceScheduler
    {
        private Resource _resource;
        private IQueueable<Process> _queue;

        public DeviceScheduler(Resource resource, IQueueable<Process> queue)
        {
            _resource = resource;
            _queue = queue;
        }

        public IQueueable<Process> Session()
        {
            Process newActiveProcess = _queue.Item();
            _queue.Remove();
            _resource.ActiveProcess = newActiveProcess;
            return _queue;
        }
    }
}