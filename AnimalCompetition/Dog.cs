using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCompetition
{
    class Dog:Animal
    {
        public int RelationToOwnerPoint { get; private set;}
        public bool HasRelationToOwnerPoint { get; private set; }

        //The constructor calls the parent class constructor
        public Dog(int idNumber,string name,int birthYear) : base(idNumber, name, birthYear)
        {

        }
        public void ScoringRelation(int relationToOwnerPoint)
        {
            this.RelationToOwnerPoint = relationToOwnerPoint;
            HasRelationToOwnerPoint = true;
        }
        //The method inherited from animal class
        public override int Score()
        {
            int point = 0;
            if (HasRelationToOwnerPoint)
            {
                point = base.Score() + RelationToOwnerPoint;
            }
            return point;
        }
    }
}
