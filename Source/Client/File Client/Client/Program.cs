using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public const string ipServerManager = "127.0.0.1";
        public const int portServerManager = 8080;
        public const string ipFTPServer = "192.168.126.150";
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Login());
        }
    }
}