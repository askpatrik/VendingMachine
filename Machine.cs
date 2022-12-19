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
        internal string input = "";
        internal static void AskToAdd(BaseProduct product)
        {
            Console.WriteLine($"You chose {product.Name} : {product.Description}. Price: {product.Price}");
            Console.Write("Do you want to add this item to the basket? (y/n): ");
            string input = Console.ReadLine();
            if (input == "n")
                CancelTransaction(product);
            

        }
        internal static void CancelTransaction(BaseProduct product)
        {
            Console.WriteLine($"You chose not to add {product.Name} to the basket list. ");
            Console.WriteLine("Returning to main menu...");
            Thread.Sleep(2000);
            Menu.VendingMachineMenu();
        }
    }
}
