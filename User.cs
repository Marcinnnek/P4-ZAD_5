using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PROJEKT_NR_1
{
    public class User
    {
        public static Dictionary<string, string> Uzyszkodnicy = new Dictionary<string, string>();
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            this.UserName = name;
            this.Password = password;
        }
        public static void AddUser(User user)
        {
            Uzyszkodnicy.Add(user.UserName, user.Password);
        }

    }
}
