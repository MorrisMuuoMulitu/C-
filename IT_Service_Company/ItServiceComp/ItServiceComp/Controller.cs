using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ItServiceComp
{
    class Controller
    {
        private List<Employee> employees = new List<Employee>();
        public void Start()
        {
            StaticInitialize();
            ReadData();
            DisplayResults();
            Working();
            DisplayIncomes();
            RichestEmployees();
        }

        private void StaticInitialize()
        {
            //All these are the static properties
            Employee.CurrentYear = 2019;
            //Employee.CurrentYear = DateTime.Now.Year;
            Employee.BaseSalary = 120000;
            Employee.AnnualSuppPayment = 1000;
            HelpDesk.CommissionMultiplier = 10;
            ApplicationOperator.HourlyRate = 150;
        }

        private void ReadData()
        {
            StreamReader reader = new StreamReader("employeesITservice.txt");
            //The local variables
            string jobtitle, name, language, languageCertCode; 
            int birthYear;
            while ((jobtitle=reader.ReadLine())!=null)
            {
                name = reader.ReadLine();
                birthYear = int.Parse(reader.ReadLine());
                if (jobtitle.Equals("helpDesk"))
                {
                    language = reader.ReadLine();
                    languageCertCode = reader.ReadLine();
                    employees.Add(new HelpDesk(name, birthYear, language, languageCertCode));//Add to the employees list
                }
                else
                {
                    languageCertCode = reader.ReadLine();
                    employees.Add(new ApplicationOperator(name, birthYear, languageCertCode));
                }
            }
            reader.Close();
        }

        private void DisplayResults()
        {
            Console.WriteLine("\nThe employees: ");
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
        }
        private void Working()
        {
            Random rand = new Random();
            int n = rand.Next(100); //Max value is 100
            int hour, low = 1, upper = 10;
            int index;

            for (int i = 0; i <= n; i++)
            {
                index = rand.Next(employees.Count);
                if (employees[index] is HelpDesk)
                {
                    (employees[index] as HelpDesk).Call();
                }
                else
                {
                    hour = rand.Next(low, upper);
                    (employees[index] as ApplicationOperator).Software_Operation(hour);
                }
            }
        }

        private void DisplayIncomes()
        {
            foreach (var item in employees)
            {
                if (item is HelpDesk)
                {
                    Console.WriteLine(item.Name + " income" + ((HelpDesk)item).Income() + " Ft.");
                }
                else
                {
                    Console.WriteLine(item.Name + "income " + ((ApplicationOperator)item).Income() + " Ft.");
                }
            }
        }

        private void RichestEmployees()
        {
            //Finish
        }
    }
}
