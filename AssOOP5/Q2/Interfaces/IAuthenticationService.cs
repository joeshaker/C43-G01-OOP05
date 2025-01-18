using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP5.Q2.Classes;

namespace AssOOP5.Q2.Interfaces
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(BasicAuthenticationService basic);
        public bool AuthorizeUser(BasicAuthenticationService basic);
    }
}
