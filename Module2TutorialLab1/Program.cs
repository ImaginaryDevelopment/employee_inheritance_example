using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2TutorialLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Winter");

            Console.WriteLine(employee1.EmployeeStatus() + "..." + 
                employee2.EmployeeStatus() + "..." + employee3.EmployeeStatus());
        }
    }
}
