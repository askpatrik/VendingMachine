using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Menu
    {
        internal static ConsoleKeyInfo input;
        internal static int count = 1;
        
        public static void VendingMachineMenu()
        {
            do
            {
                ConsoleKeyInfo input;
                Console.Clear();
                Console.WriteLine("Welcome to the vending machine");

                Console.WriteLine($"You currently have {Machine.InsertedAmount} kronor inserted in the machine! ");
                Console.WriteLine();
                Console.WriteLine("1. Insert coins ");
                Console.WriteLine("2. Add item");
                Console.WriteLine("3. View purchase list");
                Console.WriteLine("4. Purchase item/s");
                Console.WriteLine("5. Use item/s");
                Console.WriteLine();
                
                Console.Write("Your choice: ");
                input = Console.ReadKey();


                switch (input.KeyChar.ToString())
                {
                    case "1":
                        Console.Clear();
                        Transaction.InsertCoin();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();                 
                        ItemList.ChoseItem();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Basket.ViewBasketList();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Transaction.Purchase(Basket.BasketPrice);
                        break;
                    case "5":
                        Console.Clear();
                        Sushi sushi = new Sushi();
                        sushi.Use();
                        Console.ReadKey();
                        break;
                        




                }

            } while (true);

     

        }
        


    }
}
