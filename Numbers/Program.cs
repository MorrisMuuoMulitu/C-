using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, divisor = 5; //We need to check if this number is divisible by 5 and whether odd or even.
            Console.Write("Enter the number please buddy: ");
            if (int.TryParse(Console.ReadLine(),out number) && number>0)
            {
                if (number%2==0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
                if (number%divisor==0)
                {
                    Console.WriteLine("The number is divisible by " + divisor);
                }
                else
                {
                    Console.WriteLine("The number is not divisible by " + divisor);
                }
            }
            else
            {
                Console.WriteLine("Wrong data buddy");
            }
            Console.ReadKey(); //Obtains the next character or function key pressed by the user.The pressed key is displayed in the console window.
        }
    }
}
