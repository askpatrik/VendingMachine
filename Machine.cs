using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Machine
    {
        internal static int InsertedAmount = 0;
        internal static ConsoleKeyInfo input;

        internal static int AskToBuy(BaseProduct product)
        {
            Console.Clear();
            Console.WriteLine($"You chose a {product.Name}. It is a {product.Description}.");
            Console.WriteLine($"Price: {product.Price} kronor. ");
            Console.Write("Do you want to buy this product (y/n): ");
            input = Console.ReadKey();
                   
            if (input.KeyChar.ToString() == "y")
                return default;                      
            else if (input.KeyChar.ToString() == "n")
               
                CancelTransaction(product);
            else
            {
                Console.WriteLine("Not a valid choice. Press any key to try again. ");
                Console.ReadKey();
                AskToBuy(product);
            }
            return default;

        }
        internal static void CancelTransaction(BaseProduct product)
        {
            Console.Clear();
            Console.WriteLine($"You chose not to buy the {product.Name}. ");
            Console.WriteLine("Returning to main menu...");
            Thread.Sleep(1500);
            Menu.VendingMachineMenu();
        }
    }
}
