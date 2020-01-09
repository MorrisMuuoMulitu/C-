using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItServiceComp
{
    class ApplicationOperator:Employee
    {
        public string DiplomaCode { get; private set; }
        public int HoursWorked { get; private set; }
        public static int HourlyRate { get; set; }

        //constructor
        public ApplicationOperator(string name,int birthYear,string diplomaCode) : base(name, birthYear)
        {
            this.DiplomaCode = diplomaCode;
        }
        //methods
        public void Software_Operation(int hour)
        {
            HoursWorked +=hour;
        }
        public override int Income()
        {
            return base.Income()+HoursWorked*HourlyRate;
        }
    }
}
