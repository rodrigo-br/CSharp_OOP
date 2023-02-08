using bank_ADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.InternalSystems
{
    public class InternalSystem
    {
        public bool Login(IAuthenticable username, string password)
        {
            bool registeredUser = username.Authenticate(password);
            if (registeredUser)
            {
                Console.WriteLine("Welcome " + username);
                return true;
            }
            Console.WriteLine("Fail to login as " + username);
            return false;
        }
    }
}
