using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExcelExport
{
    public static class DLLImport
    {
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [DllImport("Kernel32.dll")]
        public static extern bool SetConsoleTitle(string strMessage);
    }
}
