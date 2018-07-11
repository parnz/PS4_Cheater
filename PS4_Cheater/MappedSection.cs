using System;
using System.Linq;

namespace PS4_Cheater
{
    public class MappedSection
    {
        public ulong Start { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }
        public bool Check { set; get; }
        public uint Prot { get; set; }

        public ResultList ResultList { get; set; }


        public MappedSection()
        {
            ResultList = null;
        }

        public void UpdateResultList(ProcessManager processManager, MemoryHelper memoryHelper,
            string default_value_0_str, string default_value_1_str, bool is_hex, bool newScan)
        {
            if (!Check)
            {
                ResultList = null;
                return;
            }

            ResultList new_result_list = new ResultList(memoryHelper.Length, memoryHelper.Alignment);

            ulong address = this.Start;
            uint base_address = 0;
            int length = this.Length;

            const int buffer_length = 1024 * 1024 * 128;

            while (length != 0)
            {
                int cur_length = buffer_length;

                if (cur_length > length)
                {
                    cur_length = length;
                    length = 0;
                }
                else
                {
                    length -= cur_length;
                }

                byte[] buffer = memoryHelper.ReadMemory(address, (int)cur_length);

                byte[] default_value_0 = null;
                if (memoryHelper.ParseFirstValue)
                {
                    if (is_hex)
                    {
                        default_value_0 = memoryHelper.HexStringToBytes(default_value_0_str);
                    }
                    else
                    {
                        default_value_0 = memoryHelper.StringToBytes(default_value_0_str);
                    }
                }

                byte[] default_value_1 = null;
                if (memoryHelper.ParseSecondValue)
                {
                    if (is_hex)
                    {
                        default_value_1 = memoryHelper.HexStringToBytes(default_value_1_str);
                    }
                    else
                    {
                        default_value_1 = memoryHelper.StringToBytes(default_value_1_str);
                    }
                }

                if (newScan)
                {
                    memoryHelper.CompareWithMemoryBufferNewScanner(default_value_0, default_value_1, buffer, new_result_list, base_address);
                }
                else
                {
                    memoryHelper.CompareWithMemoryBufferNextScanner(default_value_0, default_value_1, buffer, ResultList, new_result_list);
                }

                address += (ulong)cur_length;
                base_address += (uint)cur_length;
            }
            ResultList = new_result_list;
        }

        public void PointerSearchInit(ProcessManager processManager, MemoryHelper memoryHelper, PointerList pointerList)
        {
            ulong address = this.Start;
            int length = this.Length;

            const int buffer_length = 1024 * 1024 * 128;

            while (length != 0)
            {
                int cur_length = buffer_length;

                if (cur_length > length)
                {
                    cur_length = length;
                    length = 0;
                }
                else
                {
                    length -= cur_length;
                }

                byte[] buffer = memoryHelper.ReadMemory(address, (int)cur_length);

                memoryHelper.CompareWithMemoryBufferPointerScanner(processManager, buffer, pointerList, address);

                address += (ulong)cur_length;
            }
        }
    }
}
