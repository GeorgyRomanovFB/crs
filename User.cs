using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlumBlumShub
{
    public class User
    {
        public string login;
        private string password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string Login { get => login; }
        public string Password { get => password; }

        public bool IsCorrect()
        {
            DB database = new DB("Data Source=DB.db;Version=3;");

            if (database.CheckUser(this))
                return true;

            return false;
        }
    }
}

