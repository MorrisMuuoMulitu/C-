using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Restaurant
    {
       //fields
        private string name;
        private string address;
        private double gratuityaRate;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }//end of property 
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double GratuityRate
        {
            get { return gratuityaRate; }
            set
            {
                if (value>0)
                {
                    gratuityaRate = value; 
                }
            }
        }//end of property
        public Restaurant(string name,string address, double gratuityRate)
        {
            this.GratuityRate = gratuityaRate;
            this.Name = name;
            this.Address = address;
        }
        public void GenerateReceipt()
        {
            double price=0,subTotal=0,gratuityAmount=0,grandTotal=0;
            int people;
            while (price!=-1)
            {
                subTotal = subTotal + price;
                Console.Write("Enter the price of the food item.[-1 to quit]");
                price = Convert.ToDouble(Console.ReadLine());
                
            }
            Console.Write("How many people are attending the party tonight?");
            people = Convert.ToInt32(Console.ReadLine());

            if (people >= 6)
            {
                gratuityAmount = subTotal * gratuityaRate;
            }
            grandTotal = subTotal + gratuityAmount;

            Console.WriteLine( "Subtotal: {0}",subTotal);
            Console.WriteLine("{1} Gratuity: {1}", gratuityaRate, gratuityAmount);
            Console.WriteLine("Grand Total: {0}", grandTotal);
        }

    }//end of the class
}
