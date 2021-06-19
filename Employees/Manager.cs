using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // manager needs to know their number of stock  options
    class Manager:Employee
    {
        public int StockOptions { get; set; }

        //default constructor
        public Manager(){}

        //custom constructor
        public Manager(string fullName,int age,int empID,string ssn, float currPay
            ,int numOfOptions)
            :base(fullName,age,empID,ssn,currPay)
        {
            //this property is defined by the manager class
            StockOptions = numOfOptions;
        }

        //method overide to impliment polymorphism
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);

        }
        public override void DisplayStatus()
        {
            BenefitPackage.BenefitPackageLevel empLevel = BenefitPackage.BenefitPackageLevel.Gold;

            base.DisplayStatus();

            Console.WriteLine("The number of Stock options: {0}, Your level {1}", StockOptions,empLevel);
        }

    }
}
