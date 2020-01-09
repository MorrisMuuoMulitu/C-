using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SongCompetition
{
    class Controller
    {
        private List<Competitor> competitors = new List<Competitor>();
        private int juryMembersNumber = 5;
        private int scoreLimit = 10;

        public void Start()
        {
            Input();
            Output("\nParticipants:\n");
            Competition();
            Output("\nResults:\n");
            Results();
            Search();
        }
        private void Input()
        {
            Competitor competitor;
            string name, department;

            //idNumber is the serial number of the reading
            int idNumber = 1;
            StreamReader streamReader = new StreamReader("competitors.txt");
            while (!streamReader.EndOfStream)
            {
                name = streamReader.ReadLine();
                department = streamReader.ReadLine();
                competitor = new Competitor(idNumber, name, department);
                //The competitor is added to the list of the competitors.
                competitors.Add(competitor);
                idNumber++;
            }
            streamReader.Close();
        }
        private void Output(string title)
        {
            Console.WriteLine(title);
            foreach (Competitor competitor in competitors)
            {
                Console.WriteLine(competitor);
            }
        }
        private void Competition()
        {
            Random rand = new Random();
            int point;
            foreach (Competitor competitor in competitors)
            {
                //The judges' scores
                for (int i = 1; i < juryMembersNumber; i++)
                {
                    point = rand.Next(scoreLimit);
                    competitor.Scoring(point);
                }
            }
        }
        private void Results()
        {
            Winner();
            Sorting();
        }
        private void Winner()
        {
            int max = competitors[0].Score;
            //The maximum value 
            foreach (Competitor competitor in competitors)
            {
                if (competitor.Score > max)
                {
                    max = competitor.Score;
                }
            }
            //The winners
            Console.WriteLine("\nThe winners\n");
            foreach (Competitor competitor in competitors)
            {
                if (competitor.Score == max)
                {
                    Console.WriteLine(competitor);
                }
            }
        }
        private void Sorting()
        {
            //sorting
            Competitor temp;
            for (int i = 0; i < competitors.Count - 1; i++)
            {
                for (int j = i+1; j < competitors.Count; j++)
                {
                    if (competitors[i].Score<competitors[j].Score)
                    {
                        temp = competitors[i];
                        competitors[i] = competitors[j];
                        competitors[j] = temp;
                    }
                }
            }
            Output("\nScoreboard\n");
        }
        private void Search()
        {
            Console.WriteLine("\nSearch for the competitors of a certain department\n");
            Console.Write("Are you looking for someone? (y/n)");
            char answer;
            while (!char.TryParse(Console.ReadLine(), out answer));
            {
                Console.WriteLine("Enter only one character please buddy.");
            }
            string department;
            bool exists;
            while (answer=='y' || answer=='Y')
            {
                Console.Write("Department: ");
                department = Console.ReadLine();
                exists = false;
                foreach (Competitor  competitor in competitors)
                {
                    if (competitor.Department==department)
                    {
                        Console.WriteLine(competitor);
                        exists = true;
                    }
                }
                if (!exists)
                {
                    Console.WriteLine("There is no competitor from this department.");
                }
                Console.Write("\nDo you want to look for another one? (y/n)");
                answer = char.Parse(Console.ReadLine());
            }
        }
    }
}
