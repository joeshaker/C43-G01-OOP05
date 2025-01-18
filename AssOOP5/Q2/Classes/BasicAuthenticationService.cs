using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP5.Q2.Enum;
using AssOOP5.Q2.Interfaces;

namespace AssOOP5.Q2.Classes
{
    internal class BasicAuthenticationService:IAuthenticationService
    {
        public  string Username { get; set; }
        public  string Password { get; set; }
        public Roles Role {  get; set; }
        private Roles[] AdminRoles = [Roles.Admin,Roles.admin,Roles.user,Roles.User];
        private Roles[] UserRoles = [Roles.User,Roles.user];

        public BasicAuthenticationService() { }

        public BasicAuthenticationService(string username, string password,Roles role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public bool AuthenticateUser(BasicAuthenticationService basic)
        {
            return (basic.Username !=null)&& (basic.Password !=null);
            
        }
        public bool AuthorizeUser(BasicAuthenticationService basic)
        {
            if (basic.Username == null || basic.Password == null)
            {
                return false; 
            }

            if (basic.Username == "admin" || basic.Username == "Admin")
            {
                
                for (int i = 0; i < AdminRoles.Length; i++)
                {
                    if (basic.Role == AdminRoles[i])
                    {
                        return true;
                    }
                }
            }
            else if (basic.Username == "user" || basic.Username == "User")
            {
            
                for (int i = 0; i < UserRoles.Length; i++)
                {
                    if (basic.Role == UserRoles[i])
                    {
                        return true;
                    }
                }
            }

            return false;
        }





    }
}
