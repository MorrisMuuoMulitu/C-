using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    class Student
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public int BirthYear { get; private set; }

        public Student(string name,string code,int birthYear)
        {
            this.Name = name;
            this.Code = code;
            this.BirthYear = birthYear;
        }
        public override string ToString()
        {
            return Name + " (" + Code + ")";
        }
    }
}
