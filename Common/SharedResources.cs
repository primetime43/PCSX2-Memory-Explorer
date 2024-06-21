using System;
using Common.Managers;

namespace Common
{
    public static class SharedResources
    {
        public static IntPtr ProcessHandle { get; set; } = IntPtr.Zero;
        public static BaseAddressManager BaseAddressManager { get; set; } = new BaseAddressManager();
    }
}
