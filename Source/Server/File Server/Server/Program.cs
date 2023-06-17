using Client;
using System;

namespace Server
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///
        public static string ipFTPServer = "192.168.126.150";
        [STAThread]
        static void Main()
        {
            SocketServer server =new  SocketServer(8080);
            Thread threadServer = new Thread(server.Listen);
            threadServer.Start();
            //SSH ssh = new SSH("192.168.137.109", "caothi", "123456");
            //ssh.AddUser("nc", "123456");
            //string passRandom = Email.GenerateRandomPassword();
            //Email email = new Email();
            //string path = @"D:\\studing\\ÐH2\\Basic network programing\\Basic-network-programming-project\\Source\\Server\\File Server\\Server\\Email\\Email.html";
            //email.SendPasswordResetEmail("21522613@gm.uit.edu.vn", path,"caothi",passRandom);
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_FileManager("caothi","123456"));
            server.disconect(false);
        }
    }
}