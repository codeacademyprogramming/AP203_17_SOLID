using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    internal class UserCRUD
    {
        public void AddUser(User user)
        {
            Data.Users.Add(user);
        }

        public void RemoveUser(User user)
        {
            Data.Users.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            return Data.Users;
        }

        public User GetUser(int index)
        {
            return Data.Users[index];
        }
    }
}
