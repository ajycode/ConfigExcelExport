using System;
using System.Windows.Forms;

namespace ExcelExport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DLLImport.AllocConsole();//调用系统API，调用控制台窗口
            DLLImport.SetConsoleTitle("打印excel导出信息");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            DLLImport.FreeConsole();//释放控制台
        }
    }
}
