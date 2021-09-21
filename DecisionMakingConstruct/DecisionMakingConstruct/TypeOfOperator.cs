using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithCSharp
{
    class IfElseIfDemo
    {
        static void Main()
        {
            // Using if-else-if we can check multiple condtions
            Console.Write("Enter Item Name:");
            string Item = Console.ReadLine();
            Item = Item.ToLowerInvariant();
            if (Item == "food")
            {
                Console.WriteLine("1%");
            }
            else if (Item == "Ornaments")
            {
                Console.WriteLine("5%");
            }
            else if (Item == "Services")
            {
                Console.WriteLine("18%");
            }
            else
            {
                Console.WriteLine("Invalid Item");
            }
                
                Console.ReadLine();
        }
    }
}
