using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace librpc
{
    public class Process
    {
        public string name;
        public int pid;

        /// <summary>
        /// Initializes Process class
        /// </summary>
        /// <param name="name">Process name</param>
        /// <param name="pid">Process ID</param>
        /// <returns></returns>
        public Process(string name, int pid)
        {
            this.name = name;
            this.pid = pid;
        }
    }
}
