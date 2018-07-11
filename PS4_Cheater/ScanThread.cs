using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace PS4_Cheater
{
    public class PeekThread
    {
        private ProcessManager processManager;
        private BackgroundWorker worker;
        private List<byte[]> buffer_queue;

        private Semaphore consumer_mutex;
        private Semaphore producer_mutex;

        private int productor_idx = 0;

        public PeekThread(ProcessManager processManager, List<byte[]> bufferQueue,
            Semaphore consumerMutex, Semaphore producerMutex)
        {
            this.processManager = processManager;
            this.buffer_queue = bufferQueue;
            this.consumer_mutex = consumerMutex;
            this.producer_mutex = producerMutex;
            this.productor_idx = 0;
        }

        public void Peek()
        {
            for (int section_idx = 0; section_idx < processManager.MappedSectionList.Count; ++section_idx)
            {
                MappedSection mappedSection = processManager.MappedSectionList[section_idx];

                if (!mappedSection.Check)
                {
                    mappedSection.ResultList = null;
                    continue;
                }

                ulong address = mappedSection.Start;
                int length = mappedSection.Length;

                while (length != 0)
                {
                    int cur_length = CONSTANT.PEEK_BUFFER_LENGTH;

                    if (cur_length > length)
                    {
                        cur_length = length;
                        length = 0;
                    }
                    else
                    {
                        length -= cur_length;
                    }

                    if (worker.CancellationPending) break;

                    producer_mutex.WaitOne();
                    //buffer_queue[productor_idx] = memoryHelper.ReadMemory(address, (int)cur_length);
                    productor_idx = (productor_idx + 1) % CONSTANT.MAX_PEEK_QUEUE;
                    consumer_mutex.Release();

                    address += (ulong)cur_length;
                }
            }
        }
    }
}
