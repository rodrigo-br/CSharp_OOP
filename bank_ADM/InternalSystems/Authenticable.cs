using bank_ADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.InternalSystems
{
    public interface IAuthenticable
    {
        public string Password { get; set; }
        public bool Authenticate(string password);
    }
}
