using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Account
    {
        public string userName;
        public string email;
        public Account(string username, string em) {
            this.userName = username;
            this.email = em;
        }
    }
}
