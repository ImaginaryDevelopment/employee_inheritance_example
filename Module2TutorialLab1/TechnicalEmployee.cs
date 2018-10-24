using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2TutorialLab1
{
    class TechnicalEmployee : Employee
    {
        public TechnicalEmployee(string name) : base(name, 75_000)
        {

        }

        public int successfulCheckIns = 5;

        public override string EmployeeStatus()
        {
            return this.ToString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
