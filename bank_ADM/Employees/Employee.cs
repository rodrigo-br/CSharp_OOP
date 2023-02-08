using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.Employees
{
    public abstract class Employee
    {
        public string Name { get; private set; }
        public string Id { get; private set; }
        public double Salary { get; protected set; }
        public static int TotalEmployees { get; private set; }
        public abstract double GetBonus();
        public abstract void RaiseSalary();
        public Employee(string name, string id, double salary)
        {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
            TotalEmployees++;
        }
    }
}
