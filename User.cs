using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PROJEKT_NR_1
{
    public class User
    {
        static List<User> Users = new List<User> { };
       
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            this.UserName = name;
            this.Password = password;
        }
        public static void AddUser(User user)
        {
            Users.Add(user);
        }

    }
}
