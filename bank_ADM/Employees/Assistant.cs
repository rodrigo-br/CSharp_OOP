using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.Employees
{
    internal class Assistant : Employee
    {
        public override double GetBonus()
        {
            return this.Salary * 0.20;// o base nesse contexto invoca o método da classe Employee, evitando loop infinito e somando apenas 10%
        }

        public Assistant(string name, string id) : base(name, id, 2000) { }

        public override void RaiseSalary()
        {
            this.Salary *= 1.1;
        }
    }
}
