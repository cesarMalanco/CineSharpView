using Forms_individuales_proyecto;
using WinFormsFinalProject;

namespace WinFormsFinalProyect
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();
            /*Application.Run(new FormLoadingScreen());*/ //Este es el final
            Application.Run(new FormLoadingScreen());
        }
    }
}