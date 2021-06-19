using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //the salesperson needs to know the number of sales made
    class SalesPerson:Employee
    {
        public int SalesNumber { get; set; }

        //custom constructor
        // as a general rule all subclasses should explicitly call
        //an appropriate base class constructor.
        public SalesPerson()
        {
        }
        public SalesPerson(string fullName, int age, int empID, string ssn, float currPay
            , int saleNumber)
            : base(fullName, age, empID, ssn, currPay)
        {
            //this property is defined by the SalesPerson class
            SalesNumber = saleNumber;
        }

        //accessing the  field data of the parent class directly
        //because the field data are assigned protected keyword
        public void Congrate(float pay)
        {
            if (pay > 10000)
            {
                Console.WriteLine("Congratulations! {0} You Really Tried",
                    empName);
            }
        }

        //method overide to impliment polymorphism
        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if(SalesNumber>0 && salesBonus<=100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber > 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }

            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStatus()
        {
            BenefitPackage.BenefitPackageLevel empLevel = BenefitPackage.BenefitPackageLevel.Gold;
            base.DisplayStatus();
            Console.WriteLine("The number of Sales is(are): {0}, Your Level: {1} ",SalesNumber,empLevel);
        }

    }
}



