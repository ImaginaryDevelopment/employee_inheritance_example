using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2TutorialLab1
{
    class BusinessEmployee : Employee
    {
        public BusinessEmployee(string name) : base(name, 50_000)
        {
        }

        // this isn't used elsewhere in the app, and fields generally shouldn't be public
        readonly double bonusBudget = 1_000;

        public override string EmployeeStatus()
        {
            return ToString() + " with a budget of " + this.bonusBudget;
        }

    }


}
