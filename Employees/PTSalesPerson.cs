using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   sealed class PTSalesPerson:SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID, string ssn, float currPay
           , int saleNumber)
           : base(fullName, age, empID, ssn, currPay,saleNumber)
        {
            // property  defined by the PTSalesPerson class
            //is assigned here
        }

    }
}
