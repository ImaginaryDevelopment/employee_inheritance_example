using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2TutorialLab1
{
    abstract class Employee
    {

        // nothing special going on, expanded properties not needed/useful
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int ID { get; set; }

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            // instead of employeeCount++;
            // increment before passing the result
            this.ID = ++employeeCount;
        }

        // this is already exposed via the property directly
        //public double GetBaseSalary()
        //{
        //    return this.BaseSalary;
        //}


        // this is already exposed via the property directly
        //public string GetName()
        //{
        //    return this.Name;
        //}

        // private is implied
        static int employeeCount;

        // this is already exposed via the property directly
        // PascalCase for members
        //public int GetEmployeeID()
        //{
        //    return this.ID;
        //}

        // this should be ToString in C#, not toString
        public override string ToString()
        {
            return this.ID + " " + this.Name;
        }

        // PascalCase for members
        public abstract string EmployeeStatus();


    }
}
