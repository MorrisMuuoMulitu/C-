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
        public Competitor(int idNumber,string Name,string department)
        {
            this.idNumber = idNumber;
            this.name = name;
            this.department = department;
        }
        //methods
        public void Scoring(int point)
        {
            score += point;
        }
        public override string ToString()
        {
            return idNumber + "\t" + name + "\t "  + department + "\t" + score +"\t"+ "point";
        }
        //properties
        public int IdNumber{get { return idNumber; } }
        public string Name { get { return name; } }
        public string Department { get { return department; } }
        public int Score { get { return score; } }
    }
}
