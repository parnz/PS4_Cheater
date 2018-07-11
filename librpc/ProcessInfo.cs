using System;
using System.Linq;

namespace librpc
{
    public class ProcessInfo
    {
        public int pid;
        public MemoryEntry[] entries;

        /// <summary>
        /// Initializes ProcessInfo class with memory entries and process ID
        /// </summary>
        /// <param name="pid">Process ID</param>
        /// <param name="entries">Process memory entries</param>
        /// <returns></returns>
        public ProcessInfo(int pid, MemoryEntry[] entries)
        {
            this.pid = pid;
            this.entries = entries;
        }

        /// <summary>
        /// Finds a virtual memory entry based off name
        /// </summary>
        /// <param name="name">Virtual memory entry name</param>
        /// <returns></returns>
        public MemoryEntry FindEntry(string name)
        {
            foreach (MemoryEntry entry in entries)
            {
                if (entry.name == name)
                {
                    return entry;
                }
            }

            return null;
        }

        /// <summary>
        /// Finds a virtual memory entry based off size
        /// </summary>
        /// <param name="size">Virtual memory entry size</param>
        /// <returns></returns>
        public MemoryEntry FindEntry(ulong size)
        {
            foreach (MemoryEntry entry in entries)
            {
                if ((entry.start - entry.end) == size)
                {
                    return entry;
                }
            }

            return null;
        }
    }
}
