using AppComercial.Ioc;

namespace AppComercial.Windows
{
    internal static class Program
    {
        public static IServiceProvider _serviceProvider = null!;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DI.ConfigurarDI();
            Application.Run(new FrmPrincipal());
        }
    }
}