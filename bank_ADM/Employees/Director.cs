using bank_ADM.InternalSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.Employees
{
    public class Director : AutenticableEmployee
    {
        public override double GetBonus()
        {
            return this.Salary * 0.5;// o base nesse contexto invoca o método da classe Employee, evitando loop infinito e somando apenas 10%
        }
        public override void RaiseSalary()
        {
            this.Salary *= 1.15;
        }
        public Director(string name, string id) : base(name, id, 5000) { }
    }
}
