using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDynamicControl
{
    class Pizza
    {
        public string Name  { get; private set; }

        public int PriceSmall { get; set; }
        public int PriceLarge { get; set; }
        //constructor
        public Pizza(string name,int priceSmall,int priceLarge)
        {
            this.Name = name;
            this.PriceSmall = priceSmall;
            this.PriceLarge = priceLarge;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
