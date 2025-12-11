using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class UserManager
    {
        public List<User> Users { get; set; } = new List<User>();

        public void AddUser(User user) => Users.Add(user);
    }
}
