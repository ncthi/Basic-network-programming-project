using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Server
{
    internal class SQL_server
    {
        private string serverName;
        private string databaseName;
        private string userName;
        private string password;
        private SqlConnection sqlConnection;

        public SQL_server()
        {
            serverName = "(local)";
            databaseName = "Basic network programming project";
            userName = "LTM";
            password = "30052022";
        }
        public SQL_server(string serverName, string databaseName, string userName, string password)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.userName = userName;
            this.password = password;
        }

        public string ServerName { set => serverName = value; }
        public string DatabaseName { set => databaseName = value; }
        public string UserName { set => userName = value; }
        public string Password { set => password = value; }

        public void ConnectSqlServer()
        {
            string stringConnection = string.Concat("server=", serverName, ";database=", databaseName, ";uid=", userName, ";pwd=", password);
            sqlConnection = new SqlConnection(stringConnection);
            sqlConnection.Open();
        }
        public bool AddUser(string UserName, string Pass, string Email)
        {
            SqlCommand cm = new SqlCommand();
            try
            {
                Pass=EncodePass(Pass);
                string stringAddUser = $"INSERT INTO dbo.account (UserName, Pass, Email) VALUES ('{UserName}','{Pass}','{Email}');";
                cm = new SqlCommand(stringAddUser, sqlConnection);
                // mở chuỗi kết nối
                // sử dụng phương thức ExecuteNonQuery() để thực thi câu lệnh
                cm.ExecuteNonQuery();
                // thông báo ra màn hình khi thêm dữ liệu thành công
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public void Resetpassword(string userName)
        {
            string stringSet = $"UPDATE dbo.account SET Pass='123456' WHERE UserName='{userName}';";
            SqlCommand cm = new SqlCommand(stringSet,sqlConnection);
            cm.ExecuteNonQuery();
        }
        public List<string> ListUser()
        {
            List<string> listName = new List<string>();
            string stringSelect = "SELECT UserName,Email FROM dbo.account";
            SqlCommand cm = new SqlCommand(stringSelect, sqlConnection);
            SqlDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                listName.Add(reader["UserName"].ToString());
            }
            reader.Close();
            return listName;
        }
        private string EncodePass(string pass)
        {

            MD5 md5 = new MD5CryptoServiceProvider();
            // Compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            // Get hash result after compute it
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        ~SQL_server()
        {
            sqlConnection.Close();
        }
    }
}
