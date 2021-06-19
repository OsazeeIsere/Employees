using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        //create a subclass object and access base class functionality
        static void Main(string[] args)
        {
            Console.WriteLine("the employee class hierachy");
            SalesPerson joan = new SalesPerson("Joan",11,55,"ss14",20000,90);
            //alternative way of passing parameter
            //joan.Name = "Joan";
            //joan.Age = 11;
            //joan.SalesNumber = 50;
            joan.GiveBonus(200);
            joan.DisplayStatus();

            joan.Congrate(20000);

            Manager jason = new Manager("Jason", 11, 1, "333-33", 50000, 9000);
            double cost = jason.GetBenefitCosts();
            //successful access to the BenefitPackage clase
            //(has-a relationship)
            Console.WriteLine($"Your benefit cost: {cost}");
            jason.GiveBonus(300);
            jason.DisplayStatus();

            Console.ReadLine();




        }
    }
}
