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
                Console.WriteLine("Welcome to the vending machine! ");
                Console.WriteLine();
               
                Console.WriteLine($"You have {Wallet.myWallet.Balance} kronor in your wallet, " +
                    $"and there is currently {Machine.InsertedAmount} kronor in the vending machine.");
                Console.WriteLine();
               
                Console.WriteLine("1. Insert money into the vending machine");
                Console.WriteLine("2. Register a product to buy");
                Console.WriteLine("3. View registred products ");
                Console.WriteLine("4. Purchase product/s");
                Console.WriteLine("5. Use item/s");
                Console.WriteLine();
                Console.Write("Enter menu choice: ");

                input = Console.ReadKey();


                switch (input.KeyChar.ToString())
                {
                    case "1":
                        Console.Clear();
                        Transaction.InsertMoney();
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
