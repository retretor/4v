namespace OST_Labs
{

    public class MemoryManager
    {
        private Memory _memory;

        public void Save(Memory memory)
        {
            _memory = memory;
            //_memory.Save(size);
        }
        public Memory Allocate(Process process)
        {
            if (_memory.FreeSize >= process.AddressSpace)
            {
                _memory.OccupiedSize += process.AddressSpace;
                return _memory;
            }
            return null;
        }
        public Memory Free(Process process)
        {
            _memory.OccupiedSize -= process.AddressSpace;
            return _memory;
        }

    }
}