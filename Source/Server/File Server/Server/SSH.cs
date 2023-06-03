using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Renci.SshNet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server
{
    internal class SSH
    {
        private string userName;
        private string password;
        private string ip;
        SshClient sshClient;

        //Initialize an ssh connection
        public SSH(string IP, string UserName, string Password)
        {
            this.userName = UserName;
            this.password = Password;
            this.ip = IP;
            sshClient = new SshClient(ip, userName, password);
            //Start the connection
            sshClient.Connect();
        }

        // Add user
        public void AddUser(string UserName, string Password)
        {
            string stringCmd = $"sudo useradd -m {UserName} -p $(openssl passwd -1 {Password})";
            MessageBox.Show(sshClient.RunCommand(stringCmd).ToString()); 
            string cmdAddFtp= $"echo \"{UserName}\" | sudo tee -a /etc/vsftpd.userlist";
            sshClient.RunCommand(cmdAddFtp);
        }
        //Delete user
        public bool DelUser(string UserName)
        {
            try
            {
                string strigComand = $"sudo userdel {UserName}";
                var respone = sshClient.RunCommand(strigComand);
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Change password of user
        public bool ChangePassword(string UserName,string NewPassword)
        {
            try
            {
                string cmd = $"echo -e \"{NewPassword}\\n{NewPassword}\" | sudo passwd {userName}";
                sshClient.RunCommand(cmd);
                return true;
            }
            catch { return false; }
        }
        ~SSH() {
            sshClient.Disconnect();
        }
    }
}
