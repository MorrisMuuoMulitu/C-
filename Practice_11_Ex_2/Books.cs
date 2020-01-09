using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_11_Ex_2
{
    class Books
    {
        //properties
        public string Author { get; private set; }
        public string Title { get; private set; }
        public int PageNumber { get; private set; }
        public int NumberOfVotes { get; private set; }

        //constructor
        public Books(string author,string title,int pageNumber)
        {
            this.Author = author;
            this.Title = author;
            this.PageNumber = pageNumber;
        }
        //Meethod to calculate votes
        public void GetVotes()
        {
            NumberOfVotes++;//modifies the number of votes property.
        }
        public override string ToString()
        {
            return Author + "\t" + Title + NumberOfVotes + " number of votes";
        }
        private string ToBookList()
        {
            return Author + Title + "(" + PageNumber + " pages";
        }
    }
}

