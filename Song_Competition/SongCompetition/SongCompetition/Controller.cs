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
            ReadData();
            OutPut("\nParticipants: \n");
            Competition();
            Output("\nResults : \n");
            Results();
            Search();
        }

        private void ReadData()
        {
            Competitor competitor;
            string name, department;
            int idNumber=1;

            //read the data
            StreamReader reader = new StreamReader("competitors.txt");
            while (!reader.EndOfStream)
            {
                name = reader.ReadLine();
                department = reader.ReadLine();

                //create an object
                competitor = new Competitor(idNumber, name, department);
                //add the new competitor object to list
                competitors.Add(competitor);

                idNumber++;
            }
            reader.Close();
          
        }

        private void OutPut(string title)
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
                //jury awards the scores
                for (int i = 1; i <= juryMembersNumber; i++)
                {
                    point = rand.Next(scoreLimit+1);
                    competitor.Scoring(point);
                }
            }
        }

        private void Output(string v)
        {
            
        }

        private void Results()
        {
            Winner();
            Sorting();
        }

        private void Winner()
        {
            int max = competitors[0].Score;
            //max score value
            foreach (Competitor competitor in competitors)
            {
                if (competitor.Score>max)
                {
                    max = competitor.Score;
                }
            }
            //who is the winner?
            Console.WriteLine("\nThe winners: \n");
            foreach (Competitor competitor in competitors)
            {
                if (competitor.Score==max)
                {
                    Console.WriteLine(competitor);
                }
            }
        }

        private void Sorting()
        {
            //sort
            Competitor temp;
            for (int i = 0; i < competitors.Count-1; i++)
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
            Console.WriteLine("\nSearch for the competitors of a given department.\n");
            Console.Write("\nAre you looking for somebody? (y/n)");
            char answer;
            while (!char.TryParse(Console.ReadLine(), out answer))
            {
                Console.Write("Only one character, please.");
            }
            string department;
            bool exists=false;

            while (answer=='y' || answer=='Y')
            {
                Console.Write("Department: ");
                department = Console.ReadLine();
                exists = false;
                foreach (Competitor competitor in competitors)
                {
                    if (competitor.Department==department)
                    {
                        Console.WriteLine(competitor);
                        exists = true;
                    }
                }
                if (!exists)
                {
                    Console.WriteLine("There is no competitor from this department!");
                }
                Console.Write("\nAre you looking for somebody else? (y/n)");
                answer = char.Parse(Console.ReadLine());
            }
            
        }
    }
}
