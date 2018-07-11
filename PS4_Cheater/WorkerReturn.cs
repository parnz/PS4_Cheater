namespace PS4_Cheater
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class WorkerReturn
    {
        public List<ListViewItem> ListViewItems { get; set; }
        public bool[] MappedSectionCheckeSet { get; set; }
        public ulong Results { get; set; }
    }

}

