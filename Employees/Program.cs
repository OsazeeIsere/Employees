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

            GivePromotion(jason);
            jason.DisplayStatus();
            CastingExamples();
            //try to test for compactibility
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = "firs Thing";
            things[2] = new Manager();
            things[3] = "Last thing";
            CompactibilityTest(things);
            Console.ReadLine();




        }
        static void CastingExamples()
        {
            //A manager is-a 'system.Object', so we can store 
            //a Manager reference in an object variable just fine
            object frank = new Manager("Frank Osas", 45, 2, "444-444", 40000, 800);
            GivePromotionWithPatternMatching((Employee)frank);//syntax (ClassIWantToCastTo)referenceIHave
            //catch possible invalid cast
            object kate = new Manager();
            try { 
            Hexagon hex = (Hexagon)kate;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //A manager is an Employee too
            Employee boss = new Manager("Boss Men", 50, 3, "222-22-222"
                , 90000, 300);
            GivePromotionWithPatternMatching(boss);


            // A PTSalesPerson is-a SalesPerson also
            SalesPerson sonia = new PTSalesPerson("Sonia Mark", 30, 4, "111-22",
                20000, 10);
           // GivePromotion(sonia);
            GivePromotionWithPatternMatching(sonia);

        }
        static void GivePromotion(Employee emp)
        {
            //Increase pay
            Console.WriteLine($"{emp.Name} was promoted");

            emp.GiveBonus(1000);
            if(emp is Manager m)
            {
                Console.WriteLine("{0} had {1} stock options",emp.Name,m.StockOptions);
            }
            if(emp is SalesPerson s)
            {
                Console.WriteLine("{0} made {1} sale(s)",s.Name,s.SalesNumber);
            }
            //give new parking space in the company garage..
            Console.WriteLine($"New Pay now: {emp.Pay}");

        }
        static void GivePromotionWithPatternMatching(Employee emp)
        {
            Console.WriteLine($"{emp.Name} was promoted");
            switch (emp)
            {
                case SalesPerson s when s.SalesNumber>5:
                    {
                        Console.WriteLine("{0} made {1} sale(s). You are " +
                            "One of the best sales persons", s.Name, s.SalesNumber);
                        break;
                    }
                case Manager m:
                    {
                        Console.WriteLine("{0} had {1} stock options", emp.Name, m.StockOptions);
                        break;
                    }
                //case Intern _:
                    //ignors interns
                   // break;
                case null:
                    //do something when null
                    break;
            }
        }
        static void CompactibilityTest(object[] obj)
        {
            foreach (object item in obj) { 
                Hexagon h = item as Hexagon;
                if(h==null)
                {
                    Console.WriteLine("Item is not Hexagon");

                }
                else
                {
                    h.Draw();

                }
            }
        }
    }
}
