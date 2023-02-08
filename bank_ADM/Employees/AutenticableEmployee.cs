using bank_ADM.InternalSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.Employees
{
    public abstract class AutenticableEmployee : Employee, IAuthenticable
    {
        protected AutenticableEmployee(string name, string id, double salary) : base(name, id, salary)
        {}
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
