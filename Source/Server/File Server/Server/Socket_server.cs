using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Server
{
    internal class SocketServer
    {
        public TcpListener server;
        public int port;
        public IPEndPoint iPEndPoint;
        private static int sizeBuffer = 1024 * 32;
        private bool checkConnect;
        private SQL_server database;
        private string ipDatabase;
        private SSH sshClinet;
        private string ipSSh;
        public SocketServer(int Port)
        {
            this.port = Port;
            this.iPEndPoint = new IPEndPoint(IPAddress.Any, Port);
            server = new TcpListener(iPEndPoint);
            database = new SQL_server();
            database.ConnectSqlServer();
            sshClinet = new SSH(ipSSh, "caothi", "123456");
        }
        public static string receive(NetworkStream stream)
        {
            byte[] buffer = new byte[sizeBuffer];
            stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer);
        }
        public static void send(string data, NetworkStream stream)
        {
            byte[] buffer = new byte[sizeBuffer];
            buffer = Encoding.UTF8.GetBytes(data);
            stream.Write(buffer, 0, buffer.Length);
        }
        public void Listen()
        {
            server.Start();
            checkConnect = true;
            while (checkConnect)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    Thread t = new Thread(new ThreadStart(() => acceptClient(client)));
                    t.Start();
                }
                catch { }
            }
        }
        private void acceptClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            while (checkConnect)
            {
                try
                {
                    string[] data = receive(stream).Split(',');
                    string status = data[2].Trim('\0');
                    string u = data[0];
                    string p = data[1];
                    if (status=="registry")
                    {
                        string res = database.AddUser(u, p, "").ToString();
                        sshClinet.AddUser(u, p);
                        send(res, stream);
                        return;
                    }
                    else
                    {
                        send(database.checkUser(data[0], data[1]).ToString(), stream);
                        return;
                    }
                }
                catch
                {
                    send("false", stream);
                    return;
                }
            }
            stream.Close();
            client.Close();
        }
        public void disconect(bool check)
        {
            server.Stop();
            checkConnect = check;
        }
    }
}
