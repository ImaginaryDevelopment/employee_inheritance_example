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
            // new employee array
            var employees = new Employee[]
            {
                new TechnicalEmployee("Libby"),
                new TechnicalEmployee("Zaynah"),
                new BusinessEmployee("Winter")
            };

            var statuses = employees.Select(e => e.EmployeeStatus());

            Console.WriteLine(String.Join("...", statuses));
            Console.WriteLine("alternatively:");
            Console.WriteLine(statuses.Aggregate((es1, es2) => es1 + "..." + es2));
            Console.ReadLine();
        }
    }
}
