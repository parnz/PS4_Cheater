using System;
using System.Linq;

namespace librpc
{
    public class ProcessList
    {
        public Process[] processes;

        /// <summary>
        /// Initializes ProcessList class
        /// </summary>
        /// <param name="number">Number of processes</param>
        /// <param name="names">Process names</param>
        /// <param name="pids">Process IDs</param>
        /// <returns></returns>
        public ProcessList(int number, string[] names, int[] pids)
        {
            processes = new Process[number];
            for (int i = 0; i < number; i++)
            {
                processes[i] = new Process(names[i], pids[i]);
            }
        }

        /// <summary>
        /// Finds a process based off name
        /// </summary>
        /// <param name="name">Process name</param>
        /// <param name="contains">Condition to check if process name contains name</param>
        /// <returns></returns>
        public Process FindProcess(string name, bool contains = false)
        {
            foreach (Process p in processes)
            {
                if (contains)
                {
                    if (p.name.Contains(name))
                    {
                        return p;
                    }
                }
                else
                {
                    if (p.name == name)
                    {
                        return p;
                    }
                }
            }

            return null;
        }
    }
}
