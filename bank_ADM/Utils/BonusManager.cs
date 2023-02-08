using bank_ADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.Utils
{
    public class BonusManager
    {
        public double TotalBonus { get; private set; }

        public void SignIn(Employee employee)
        {
            this.TotalBonus += employee.GetBonus();
        }
    }
}
