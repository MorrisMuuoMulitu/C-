using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    class Competitor
    {
        public string Name { get; private set; }
        public string ImageName { get; private set; }
        public int NumberOfVotes { get; private set; }
        //constructor

        public Competitor(string name,string imageName)
        {
            this.Name = name;
            this.ImageName = imageName;
        }
        public void GetVotes()
        {
            NumberOfVotes++;
        }
        public override string ToString()
        {
            return Name + "\t" + NumberOfVotes + " number of votes";
        }
    }
}
