using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.FirstName = "Morris";
            me.LastName = "Muuo";

            me.GetFullName();
            me.Talk();
            me.Walk();

            SuperPerson superPerson = new SuperPerson();
            superPerson.FirstName = "Super";
            superPerson.LastName = "Dude";

            superPerson.GetFullName();
            superPerson.Talk();
            superPerson.Walk();


        }
    }
}
