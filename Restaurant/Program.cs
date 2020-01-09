using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant obj = new Restaurant("Dairy Queen", "123 Main", .15);
            obj.GenerateReceipt();
        }
    }
}
