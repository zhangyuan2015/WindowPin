namespace WindowPin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (CanRunCheck())
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }

        public static bool CanRunCheck()
        {
            _ = new Mutex(true, Application.ProductName, out bool isNoRun);
            return isNoRun;
        }
    }
}