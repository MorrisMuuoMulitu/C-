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

        //constructor
        public Animal(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        //methods
        public int Age()
        {
            return actualYear - birthYear;
        }
        public void scoring(int beautyPoint, int behaviourPoint)
        {
            this.beautyPoint = beautyPoint;
            this.behaviourPoint = behaviourPoint;

            if (Age() <= ageLimit)
            {
                score = this.behaviourPoint * Age() + this.beautyPoint * (ageLimit - Age());
            }
            else
            {
                score = 0;
            }
        }

        public override string ToString()
        {
            return name + " score: " + score + "  point (beauty: " + beautyPoint + ", behaviour:" + behaviourPoint + ")";
        }
        //properties
        public string Name
        {
            get { return name; }
        }
        public int BirthYear
        {
            get { return birthYear; }
        }
        public int BeautyPoint
        {
            get { return beautyPoint; }
        }
        public int BehaviourPoint
        {
            get { return behaviourPoint; }
        }
        public int Score
        {
            get { return score; }
        }
        //Read-write properties
        public static int ActualYear
        {
            get { return actualYear; }
            set { actualYear = value; }
        }
        public static int AgeLimit
        {
            get { return ageLimit; }
            set { ageLimit = value; }
        }
    }
}
