using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int actYear = 2019, ageLimit=10;
            Animal.ActualYear = actYear;
            Animal.AgeLimit = ageLimit;

            //TestForOneAnimal();
            competition();
        }

        private static void competition()
        {
            Animal animal;
            string name;
            int birthYear, beauty, behaviour;

            int randomScoreLimit = 10;

            Random rand = new Random();

            int competitorSum = 0;
            int scoreSum = 0;
            int maxScore = 0;

            Console.WriteLine("Competition begins\n");
            char next = 'y';

            while (next=='y')
            {
                Console.Write("\nThe name of the animal: ");
                name = Console.ReadLine();
                Console.Write("\nIts birthYear: ");
                while (!int.TryParse(Console.ReadLine(),out birthYear)||birthYear<=0 || birthYear>=Animal.ActualYear)
                {
                    Console.Write("Incorrect data, try again! ");
                }
                beauty = rand.Next(randomScoreLimit + 1);
                behaviour = rand.Next(randomScoreLimit + 1);
                //create an animal object.
                animal = new Animal(name, birthYear);
                animal.scoring(beauty, behaviour);
                Console.WriteLine(animal);

                scoreSum += animal.Score;
                competitorSum++;
                if (maxScore<animal.Score)
                {
                    maxScore = animal.Score;
                }
                Console.Write("Is there a new animal? (y/n)");
                next = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nThe number of competitors was: " + competitorSum + "\nThe total score points: " + scoreSum + "\nThe maximum score value: " + maxScore + " points."+ "\nThe average score is: "+scoreSum/(float)competitorSum + " point.");
           
        }

        private static void TestForOneAnimal()
        {
            Animal animal;
            string name;
            int birthYear, beauty, behaviour;


            name = "Micky";
            birthYear = 2012;
            beauty = 5;
            behaviour = 3;

            animal = new Animal(name, birthYear);
            animal.scoring(beauty, behaviour);

            Console.WriteLine(animal);
        }
    }
}
