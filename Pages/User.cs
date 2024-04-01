using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp40.Pages
{
    internal class User
    {
        static public List<User> Users = new List<User>();

        public User(string name, string password)
        {
            Name = name;
            Password = password;
            Users.Add(this);
        }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
