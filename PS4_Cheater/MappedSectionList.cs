using librpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS4_Cheater
{
    public class MappedSectionList
    {
        public ulong TotalMemorySize { get; set; }

        private List<MappedSection> mapped_section_list = new List<MappedSection>();

        public MappedSectionList()
        {

        }

        public MappedSection this[int index]
        {
            get
            {
                return mapped_section_list[index];
            }
        }

        private int FindSectionID(ulong address)
        {
            int low = 0;
            int high = mapped_section_list.Count - 1;
            int middle;

            while (low <= high)
            {
                middle = (low + high) / 2;
                if (address >= mapped_section_list[middle].Start + (ulong)(mapped_section_list[middle].Length))
                {
                    low = middle + 1;   //查找数组后部分  
                }
                else if (address < mapped_section_list[middle].Start)
                {
                    high = middle - 1;  //查找数组前半部分  
                }
                else
                {
                    return middle;  //找到用户要查找的数字，返回下标  
                }
            }

            return -1;
        }



        public int GetMappedSectionID(ulong address)
        {
            ulong start = 0;
            ulong end = 0;

            if (mapped_section_list.Count > 0)
            {
                start = mapped_section_list[0].Start;
                end = mapped_section_list[mapped_section_list.Count - 1].Start + (ulong)mapped_section_list[mapped_section_list.Count - 1].Length;
            }

            if (start > address || end < address)
            {
                return -1;
            }

            return FindSectionID(address);
        }

        public MappedSection GetMappedSection(ulong address)
        {
            int sectionID = GetMappedSectionID(address);
            if (sectionID < 0)
            {
                return null;
            }
            return mapped_section_list[sectionID];
        }

        public void SectionCheck(int idx, bool _checked)
        {
            mapped_section_list[idx].Check = _checked;
            if (mapped_section_list[idx].Check)
            {
                TotalMemorySize += (ulong)mapped_section_list[idx].Length;
            }
            else
            {
                TotalMemorySize -= (ulong)mapped_section_list[idx].Length;
            }
        }


        public string GetSectionName(int section_idx)
        {
            if (section_idx < 0)
            {
                return "sectioni wrong!";
            }
            MappedSection sectionInfo = mapped_section_list[section_idx];

            StringBuilder section_name = new StringBuilder();
            section_name.Append(sectionInfo.Name + "-");
            section_name.Append(String.Format("{0:X}", sectionInfo.Prot) + "-");
            section_name.Append(String.Format("{0:X}", sectionInfo.Start) + "-");
            section_name.Append((sectionInfo.Length / 1024).ToString() + "KB");

            return section_name.ToString();
        }

        public List<MappedSection> GetMappedSectionList(string name, int prot)
        {
            List<MappedSection> result_list = new List<MappedSection>();
            for (int idx = 0; idx < mapped_section_list.Count; ++idx)
            {
                if (mapped_section_list[idx].Prot == prot &&
                    mapped_section_list[idx].Name.StartsWith(name))
                {
                    result_list.Add(mapped_section_list[idx]);
                }
            }
            return result_list;
        }

        public void InitMemorySectionList(ProcessInfo pi)
        {
            mapped_section_list.Clear();
            TotalMemorySize = 0;

            for (int i = 0; i < pi.entries.Length; i++)
            {
                MemoryEntry entry = pi.entries[i];
                if ((entry.prot & 0x1) == 0x1)
                {
                    ulong length = entry.end - entry.start;
                    ulong start = entry.start;
                    string name = entry.name;
                    int idx = 0;
                    ulong buffer_length = 1024 * 1024 * 128;

                    //Executable section
                    if ((entry.prot & 0x5) == 0x5)
                    {
                        buffer_length = length;
                    }

                    while (length != 0)
                    {
                        ulong cur_length = buffer_length;

                        if (cur_length > length)
                        {
                            cur_length = length;
                            length = 0;
                        }
                        else
                        {
                            length -= cur_length;
                        }

                        MappedSection mappedSection = new MappedSection();
                        mappedSection.Start = start;
                        mappedSection.Length = (int)cur_length;
                        mappedSection.Name = entry.name + "[" + idx + "]";
                        mappedSection.Check = false;
                        mappedSection.Prot = entry.prot;

                        mapped_section_list.Add(mappedSection);

                        start += cur_length;
                        ++idx;
                    }
                }
            }

        }

        public ulong TotalResultCount()
        {
            ulong total_result_count = 0;
            for (int idx = 0; idx < mapped_section_list.Count; ++idx)
            {
                if (mapped_section_list[idx].Check && mapped_section_list[idx].ResultList != null)
                {
                    total_result_count += (ulong)mapped_section_list[idx].ResultList.Count;
                }
            }
            return total_result_count;
        }

        public void ClearResultList()
        {
            for (int idx = 0; idx < mapped_section_list.Count; ++idx)
            {
                if (mapped_section_list[idx].ResultList != null)
                {
                    mapped_section_list[idx].ResultList.Clear();
                }
            }
        }

        public int Count { get { return mapped_section_list.Count; } }
    }
}
