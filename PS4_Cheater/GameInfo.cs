using librpc;
using System.Collections.Generic;

namespace PS4_Cheater
{

    public class GameInfo
    {
        const string GAME_INFO_4_05_PROCESS_NAME = "SceCdlgApp";
        const string GAME_INFO_4_05_SECTION_NAME = "libSceCdlgUtilServer.sprx";
        const int GAME_INFO_4_05_SECTION_PROT = 3;
        const int GAME_INFO_4_05_ID_OFFSET = 0XA0;
        const int GAME_INFO_4_05_VERSION_OFFSET = 0XC8;

        const string GAME_INFO_4_55_PROCESS_NAME = "SceCdlgApp";
        const string GAME_INFO_4_55_SECTION_NAME = "libSceCdlgUtilServer.sprx";
        const int GAME_INFO_4_55_SECTION_PROT = 3;
        const int GAME_INFO_4_55_ID_OFFSET = 0XA0;
        const int GAME_INFO_4_55_VERSION_OFFSET = 0XC8;

		const string GAME_INFO_5_05_PROCESS_NAME = "SceCdlgApp";
        const string GAME_INFO_5_05_SECTION_NAME = "libSceCdlgUtilServer.sprx";
        const int GAME_INFO_5_05_SECTION_PROT = 3;
        const int GAME_INFO_5_05_ID_OFFSET = 0XA0;
        const int GAME_INFO_5_05_VERSION_OFFSET = 0XC8;
		
        public string GameID = "";
        public string Version = "";

        public GameInfo()
        {
            string process_name = "";
            string section_name = "";
            ulong id_offset = 0;
            ulong version_offset = 0;
            int section_prot = 0;

            switch (Util.Version)
            {
                case 405:
                    process_name = GAME_INFO_4_05_PROCESS_NAME;
                    section_name = GAME_INFO_4_05_SECTION_NAME;
                    id_offset = GAME_INFO_4_05_ID_OFFSET;
                    version_offset = GAME_INFO_4_05_VERSION_OFFSET;
                    section_prot = GAME_INFO_4_05_SECTION_PROT;
                    break;
                case 455:
                    process_name = GAME_INFO_4_55_PROCESS_NAME;
                    section_name = GAME_INFO_4_55_SECTION_NAME;
                    id_offset = GAME_INFO_4_55_ID_OFFSET;
                    version_offset = GAME_INFO_4_55_VERSION_OFFSET;
                    section_prot = GAME_INFO_4_55_SECTION_PROT;
                    break;
				case 505:
                    process_name = GAME_INFO_5_05_PROCESS_NAME;
                    section_name = GAME_INFO_5_05_SECTION_NAME;
                    id_offset = GAME_INFO_5_05_ID_OFFSET;
                    version_offset = GAME_INFO_5_05_VERSION_OFFSET;
                    section_prot = GAME_INFO_5_05_SECTION_PROT;
                    break;
                default:
                    break;
            }

            try
            {
                ProcessManager processManager = new ProcessManager();
                ProcessInfo processInfo = processManager.GetProcessInfo(process_name);

                MemoryHelper memoryHelper = new MemoryHelper(false, processInfo.pid);
                MappedSectionList mappedSectionList = processManager.MappedSectionList;
                mappedSectionList.InitMemorySectionList(processInfo);
                List<MappedSection> sectionList = mappedSectionList.GetMappedSectionList(section_name, section_prot);

                if (sectionList.Count != 1)
                    return;

                GameID = System.Text.Encoding.Default.GetString(memoryHelper.ReadMemory(sectionList[0].Start + id_offset, 16));
                GameID = GameID.Trim(new char[] { '\0' });
                Version = System.Text.Encoding.Default.GetString(memoryHelper.ReadMemory(sectionList[0].Start + version_offset, 16));
                Version = Version.Trim(new char[] { '\0' });
            }
            catch
            {

            }
        }
    }

}
