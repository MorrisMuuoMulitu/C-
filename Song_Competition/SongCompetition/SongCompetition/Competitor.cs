using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongCompetition
{
    class Competitor
    {
        //fields
        private int idNumber;
        private string name;
        private string department;
        private int score;

        //constructor
        public Competitor(int idNumber,string name, string department)
        {
            this.name = name;
            this.department = department;
            this.idNumber = idNumber;
        }
        //methods
        public void Scoring(int point)
        {
            score += point;
        }
        public override string ToString()
        {
            return idNumber +"\t" + name
               + "\t" + department + "\t" + score + "points";
        }

        //properties

        public int Score
        {
            get { return score; }
            
        }


        public string Department
        {
            get { return department; }
            
        }


        public string Name
        {
            get { return name; }
        }


        public int IdNumber
        {
            get { return idNumber; }
            
        }

    }
}
