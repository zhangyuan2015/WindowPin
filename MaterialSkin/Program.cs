using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowPin.MaterialSkin
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (CanRunCheck())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }

        public static bool CanRunCheck()
        {
            bool isNoRun;
            Mutex mutex = new Mutex(true, Application.ProductName, out isNoRun);
            return isNoRun;
        }
    }
}
