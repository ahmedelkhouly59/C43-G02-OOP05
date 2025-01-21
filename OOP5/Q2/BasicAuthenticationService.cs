using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.Q2
{
    internal class BasicAuthenticationService: IAuthenticationService
    {
        string[] usernames = { "ahmed", "mohamed","zoz" };
        string[] passwords = { "ahm12345", "54321moh","zoz123"};
        string[] roles = { "admin", "user", "user" };

        public bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (username == usernames[i] && passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username,string role)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (username == usernames[i] && roles[i] == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
