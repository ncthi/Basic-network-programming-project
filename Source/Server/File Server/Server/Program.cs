namespace Server
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQL_server Database = new SQL_server();
            Database.ConnectSqlServer();
            SocketServer server =new  SocketServer(3000);
            Thread threadServer = new Thread(server.Listen);
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_FileManager());
        }
    }
}