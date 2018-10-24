using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2TutorialLab1
{
    abstract class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int ID { get; set; }

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = ++employeeCount;
        }
        static int employeeCount;
        public override string ToString()
        {
            return this.ID + " " + this.Name;
        }

        public abstract string EmployeeStatus();


    }
}
