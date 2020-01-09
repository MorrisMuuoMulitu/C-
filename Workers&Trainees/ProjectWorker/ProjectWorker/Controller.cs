using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectWorker
{
    class Controller
    {
        private List<Worker> workers = new List<Worker>();
        public void Start()
        {
            InitiateStaticValues();
            Hiring();
            WriteOut("The hired employeees");
            Console.WriteLine("\nThe hiring process is finished, let us start work!\n");
            WorkersWork();
            PaidSalary();
            TotalSalary();
        }

        private void InitiateStaticValues()
        {
            Worker.HourlyRate = 1000;
            Trainee.SalaryPercent = 65;
        }

        private void Hiring()
        {
            StreamReader streamReader = new StreamReader("employees.txt");
            string name, job, type;
            Worker worker;
            type = streamReader.ReadLine();
            while (type!=null)
            {
                name = streamReader.ReadLine();
                job = streamReader.ReadLine();
                if (type.Equals("worker"))
                {
                    worker = new Worker(name, job);
                }
                else
                {
                    worker = new Trainee(name, job);
                }
                workers.Add(worker);
                type = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        private void WriteOut(string title)
        {
            Console.WriteLine(title);
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }
        }

        private void WorkersWork()
        {
            int maxHour = 150;
            Random rand = new Random();
            int hour;
            Console.WriteLine("Number of hours worked by the employees");
            foreach (Worker worker in workers)
            {
                hour = rand.Next(maxHour);
                worker.Works(hour);
                Console.WriteLine(worker.Name + " worked " + worker.NumberOfHoursWorked + " hours");
            }
        }

        private void PaidSalary()
        {
            Console.WriteLine("\nThe salary of employees\n");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.Name + "salary is " + worker.salary()+"Ft.");
            }
        }

        private void TotalSalary()
        {
            int total = 0;
            foreach (Worker worker in workers)
            {
                total += worker.salary();
            }
            Console.WriteLine("\nAll the salary paid to the workers: " + total + "Ft.");
        }
    }
}
