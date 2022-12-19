using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Machine
    {
        internal static int InsertedAmount = 200;
        internal string input = "";
        internal static int AskToBuy(BaseProduct product)
        {
            Console.Clear();
            Console.WriteLine($"You chose {product.Name} : {product.Description}. Price: {product.Price}");
            Console.Write("Do you want to buy this item (y/n): ");
            string input = Console.ReadLine();

            if (input == "y")
                return default;                    
            else if (input == "n")
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
            Console.WriteLine($"You chose not to buy {product.Name}. ");
            Console.WriteLine("Returning to main menu...");
            Thread.Sleep(2000);
            Menu.VendingMachineMenu();
        }
    }
}
