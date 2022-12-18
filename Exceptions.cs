using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal static class Exceptions
    {
        internal static bool CheckIfZero(int kronaAmount)
        {
            if (kronaAmount == 0)
            {
                Console.WriteLine($"You have {kronaAmount} of that coin left. You cant insert it");
                Console.Write("Press any key to continue: ");
                Console.ReadKey();
                return true;
            }
            return false;
        }
        internal static bool CheckIfEnoughCash(int cash, BaseProduct product)
        {

            if (cash < product.Price)
            {
                Console.Clear();
                Console.WriteLine("Insufficient funds. Add more cash ");
                Console.WriteLine("Press any key to return to the item list");
                Console.ReadKey();
                return true;
            }
            return false;
        }
        internal static bool CheckIfEnoughCash(int cash, int price, BaseProduct product)
        {
            if (price +  product.Price> cash)
            {
                Console.WriteLine("You cant add that item to the list, not enough inserted amount");
                Console.WriteLine("Press any key to return to the item list");
                Console.ReadKey();
                return true;
            }
            return false;
        }
    }
}
