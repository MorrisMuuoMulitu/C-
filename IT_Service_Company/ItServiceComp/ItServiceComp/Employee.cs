using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItServiceComp
{
    class Employee
    {
        //properties
        public String Name { get; private set; }
        public int BirthYear { get; private set; }
        public static int AnnualSuppPayment { get; set; }
        public static int BaseSalary { get; set; }
        public static int CurrentYear { get; set; }
        public int BirthYar { get; private set; }
           


        //constructor
        public Employee(string name,int birthYear)
        {
            this.Name = name;
            this.BirthYear = birthYear;
        }
        //methods
        public int Age()
        {
            return CurrentYear - BirthYear;
        }
        private int Age_allowance()
        {
            return Age() * AnnualSuppPayment;
        }
        public virtual int Income()
        {
            return BaseSalary + Age_allowance();
        }
        public override string ToString()
        {
            return "\n The " + this.GetType().Name.ToLower() + "name is : " + this.Name;
        }
    }
}
