using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCompetition
{
    class Competitor
    {
        //properties
        public string Name { get; private set; }
        public string ImageName { get; private set; }
        public int NumberOfVotes { get; private set; }

        //constructor
        public Competitor(string name,string imageName)
        {
            Name = name;
            ImageName = imageName;
        }
        //Method to calculate the number of votes
        public void GetVotes()
        {
            NumberOfVotes++; //Modifies the NumberOfVotes Property
        }
        public override string ToString()
        {
            return Name + "\t" + NumberOfVotes + " number of votes";
        }
    }
}
