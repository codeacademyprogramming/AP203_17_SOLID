using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    internal class UserValidator
    {
        public bool CheckUserName(string username)
        {
            if (!string.IsNullOrWhiteSpace(username) && username.Length > 2 && username.Length < 8)
                return true;

            return false;
        }

        public bool CheckPassword(string password)
        {
            if (!string.IsNullOrWhiteSpace(password) && password.Length > 7 && password.Length < 21)
                return true;

            return false;
        }
    }
}
