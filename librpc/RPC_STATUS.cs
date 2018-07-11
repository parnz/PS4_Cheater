namespace librpc
{
    public partial class PS4RPC
    {
        /** status **/
        private enum RPC_STATUS : uint
        {
            RPC_SUCCESS = 0x80000000,
            RPC_TOO_MUCH_DATA = 0xF0000001,
            RPC_READ_ERROR = 0xF0000002,
            RPC_WRITE_ERROR = 0xF0000003,
            RPC_LIST_ERROR = 0xF0000004,
            RPC_INFO_ERROR = 0xF0000005,
            RPC_INFO_NO_MAP = 0x80000006,
            RPC_NO_PROC = 0xF0000007,
            RPC_INSTALL_ERROR = 0xF0000008,
            RPC_CALL_ERROR = 0xF0000009,
            RPC_ELF_ERROR = 0xF000000A,
        };
    }
}
