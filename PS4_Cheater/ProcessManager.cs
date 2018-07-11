using librpc;

namespace PS4_Cheater
{
    public class ProcessManager
    {
        public MappedSectionList MappedSectionList { get; }
        

        public ProcessManager()
        {
            MappedSectionList = new MappedSectionList();
        }

        public ProcessInfo GetProcessInfo(string process_name)
        {
            ProcessList processList = MemoryHelper.GetProcessList();
            ProcessInfo processInfo = null;
            foreach (Process process in processList.processes)
            {
                if (process.name == process_name)
                {
                    processInfo = MemoryHelper.GetProcessInfo(process.pid);
                    break;
                }
            }

            return processInfo;
        }

        public string GetProcessName(int idx)
        {
            ProcessList processList = MemoryHelper.GetProcessList();
            return processList.processes[idx].name;
        }

    }
}
