namespace librpc
{
    public partial class PS4RPC
    {
        /** commands **/
        private enum RPC_CMDS : uint
        {
            RPC_PROC_READ = 0xBD000001,
            RPC_PROC_WRITE = 0xBD000002,
            RPC_PROC_LIST = 0xBD000003,
            RPC_PROC_INFO = 0xBD000004,
            RPC_PROC_INTALL = 0xBD000005,
            RPC_PROC_CALL = 0xBD000006,
            RPC_PROC_ELF = 0xBD000007,
            RPC_END = 0xBD000008,
            RPC_REBOOT = 0xBD000009,
            RPC_KERN_BASE = 0xBD00000A,
            RPC_KERN_READ = 0xBD00000B,
            RPC_KERN_WRITE = 0xBD00000C
        };
    }
}
