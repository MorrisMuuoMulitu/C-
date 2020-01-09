using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    class Drink
    {
        public int OrderedQuantity { get; private set; }
        public int TotalQuantity { get; private set; }
        public int Income { get; private set; }

        public string DrinkName { get; private set; }
        public int UnitPrice { get; private set; }

        public Drink(string drinkName, int unitPrice)
        {
            this.DrinkName = drinkName;
            this.UnitPrice = unitPrice;
        }
        //During ordering the number of ordered drinks rises
        public void Order(int piece)
        {
            OrderedQuantity += piece;
        }
        public int Payable()
        {
            return UnitPrice * OrderedQuantity;
        }
        //After paying the ordered quantity is zero again
        public void Pay()
        {
            TotalQuantity += OrderedQuantity;
            Income += Payable();
            OrderedQuantity = 0;
        }
        public string ToPriceList()
        {
            return DrinkName + " (" + UnitPrice + " Ft)";
        }
        public string ToBooking()
        {
            return DrinkName + ";" + TotalQuantity + ";" + Income;
        }
        public override string ToString()
        {
            return OrderedQuantity.ToString().PadLeft(4) + " " + DrinkName.PadRight(33) + Payable().ToString().PadLeft(10) + "Ft";
            //PadLeft and PadRight methods only work with Consolas and Courier fonts.

        }

    }
}
