using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        //field data
        protected string empName;
        protected int empID;
        protected float currPay;

        //new field
        protected string empSSN;
        protected int empAge;

        //contain a BenefitPackage object
        //(2nd flavor of inheritance-containment/delegation 
        protected BenefitPackage empBenefits = new BenefitPackage();
        
        //constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
           : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            empName = name;
            empAge = age;
            empID = id;
            currPay = pay;
        }
        public Employee(string name, int age, int id, string ssn, float pay)
          :this(name,age,id,pay)
        {
            empSSN = ssn;
        }
    }
}
