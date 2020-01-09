using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prac10_Pub
{
    class Drink
    {
        public string DrinkName { get; private set; }
        public int UnitPrice { get;  set; }
        public int OrderedQuantity { get; private set; }
        public int TotalQuantity { get; private set; }
        public int Income { get; private set; }

        //constructor
        public Drink(string drinkName,int unitPrice)
        {
            this.DrinkName = drinkName;
            this.UnitPrice = unitPrice;
        }
        //methods

        //During the ordering(buying) the number of ordered drinks increases.
        //The parameter is the ordered pieces
        public void Order(int piece)
        {
            OrderedQuantity += piece;
        }
        public int Payable()
        {
            return OrderedQuantity * UnitPrice;
        }
        //After paying the ordered quantity the value of it is 0 again.
        public void Pay()
        {
            TotalQuantity += OrderedQuantity;
            Income += Payable();
            OrderedQuantity = 0;
        }
        //To place the text beside the check boxes
        public string ToPriceList()
        {
            return DrinkName + "(" + UnitPrice + " Ft)";
        }
        //To save the data into a file
        public string ToBooking()
        {
            return DrinkName + ";"+ TotalQuantity + ";" + Income;
        }
        public override string ToString()
        {
            return OrderedQuantity.ToString().PadLeft(4) + " " + DrinkName.PadRight(33) + Payable().ToString().PadLeft(10) + " Ft"; ;
        }
    }
}
