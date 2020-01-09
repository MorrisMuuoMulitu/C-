using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalCompetition
{
    class Controller
    {
        private List<Animal> animals = new List<Animal>();
        public void Start()
        {
            Animal.ActualYear = 2019;
            Animal.AgeLimit = 10;

            Registration();
           // Output("\nThe registered competitors\n");
            Competition();
           // Output("\nResult of the competition");
        }
        private void Competition()
        {
            Random rand = new Random();
            int ScoreLimit = 11;
            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    (animal as Dog).ScoringRelation(rand.Next(ScoreLimit));
                }
                animal.Scoring(rand.Next(ScoreLimit), rand.Next(ScoreLimit));
            }
        }
        private void Registration()
        {
            /*StreamReader streamReader = new StreamReader("animals.txt");
            string species, name;
            int idNumber = 1, birthYear;
            bool isBox;

            while (!streamReader.EndOfStream)
            {
                species = streamReader.ReadLine();
                name = streamReader.ReadLine();
                birthYear = int.Parse(streamReader.ReadLine());

                if (species=="dog")
                {
                    animals.Add(new Dog(idNumber, name, birthYear));
                }
                if (species=="cat")
                {
                    isBox = bool.Parse(streamReader.ReadLine());
                    animals.Add(new Cat(idNumber, name, birthYear, isBox));
                }
                idNumber++;
            }
            streamReader.Close();
            */

            // better data reading way. With exception handling too.
            StreamReader streamReader = new StreamReader("animals2.txt");
            string dataLine;
            string name;
            int idNumber = 1, birthYear;
            bool isBox;
            string[]data;
            try
            {
                while (!streamReader.EndOfStream)
                {
                    dataLine = streamReader.ReadLine();
                    Console.WriteLine(dataLine);
                    data = dataLine.Split(';');

                    name = data[0];
                    birthYear = int.Parse(data[1]);

                    if (data.Length==2)
                    {
                        animals.Add(new Dog(idNumber, name, birthYear));
                    }
                    if (data.Length==3)
                    {
                        animals.Add(new Cat(idNumber, name, birthYear, isBox));
                    }
                    idNumber++;
                }
                streamReader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }
    }
}
