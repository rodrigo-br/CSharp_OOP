using bank_ADM.InternalSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.Partners
{
    public class Partner : IAuthenticable
    {
        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return Password == password;
        }

    }
}
