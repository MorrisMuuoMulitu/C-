using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWorker
{
    class Worker
    {
        public string Name { get; private set; }
        public string Job { get; private set; }
        public int NumberOfHoursWorked { get; private set; }
        public static int HourlyRate { get; set; }

        //constructor
        public Worker(string name, string job)
        {
            this.Name = name;
            this.Job = job;
            this.NumberOfHoursWorked = 0;
        }
        //methods
        public void Works(int hour)
        {
            NumberOfHoursWorked += hour;
        }
        public virtual int salary()
        {
            return NumberOfHoursWorked * HourlyRate;
        }
        public override string ToString()
        {
            return "Name of the " + this.GetType().Name.ToLower() + "is " + this.Name + "works as a " + this.Job;
        }
    }
}
