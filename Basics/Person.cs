using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Person
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }

        public Person(string firstName, string lastName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public Person()
        {
        }

        //Methods
        public void GetFullName()
        {
            Console.WriteLine("Get my full name {0} {1}.", FirstName, LastName);
        }
        public void Walk()
        {
            Console.WriteLine("I am walking");
        }
        public void Talk()
        {
            Console.WriteLine("I am talking");
        }
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }
    }
}
