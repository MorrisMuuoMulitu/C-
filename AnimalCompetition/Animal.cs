using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCompetition
{
    class Animal
    {
        //fields
        private string name;
        private int birthYear;

        private int beautyPoint;
        private int behaviourPoint;
        private int score;

        //static fields
        private static int actualYear;
        private static int ageLimit;


        //Automatic properties
        public string Name { get; private set; }
        public int BirthYear { get; private set; }
        public int IdNumber { get; private set; }

        public int BeautyPoint { get; private set; }
        public int BehaviorPoint { get; private set; }

        public static  int ActualYear { get; set; }
        public static int AgeLimit { get; set; }

        //constructor

        public Animal(int idNumber,string name,int birthYear)
        {
            this.Name = name;
            this.IdNumber = idNumber;
            this.BirthYear = birthYear;
        }
        //methods
        public int Age()
        {
            return ActualYear - BirthYear;
        }
        
        public void Scoring(int beautyPoint,int behaviorPoint)
        {
            this.BeautyPoint = beautyPoint;
            this.BehaviorPoint = behaviorPoint;

            if (Age() <= ageLimit)
            {
                score = this.behaviourPoint * Age() + this.beautyPoint * (ageLimit - Age());
            }
            else
            {
                score = 0;
            }
        }
        //The method returns the class name too
        public override string ToString()
        {
            return name + " score: " + score + "  point (beauty: " + beautyPoint + ", behaviour:" + behaviourPoint + ")";
        }

    }
}
