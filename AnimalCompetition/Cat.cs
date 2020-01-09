using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCompetition
{
    class Cat:Animal
    {
        public bool IsSupplierBox { get; set; }
        //The constructor calls the constructor of the main class and completes it with IsSupplierBox property
        public Cat(int idNumber,string name,int birthYear,bool isSupplierBox) : base(idNumber, name, birthYear)
        {
            this.IsSupplierBox = isSupplierBox;
        }
        //The method is inherited from the Animal class
        public override int Score()
        {
            if (IsSupplierBox)
            {
                return base.Score();
            }
            return 0;
        }
        
    }
}
