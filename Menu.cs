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
        internal static bool runMachine = true;
        public static void VendingMachineMenu()
        {
            do
            {
                ConsoleKeyInfo input;
                Console.Clear();
                Console.WriteLine("Welcome to the vending machine! ");
              
                Console.WriteLine();

                Console.WriteLine($"There are currently {Machine.InsertedAmount} kronor in the machine. You have {Wallet.myWallet.Balance} kronor left in your wallet.");
                Console.WriteLine();
               
                Console.WriteLine("1. Insert money");
                Console.WriteLine("2. Buy product");                    
                Console.WriteLine("3. Terminate program and Receive change");
                Console.WriteLine();
                Console.Write("What do you want to do?: ");

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
                        break;
                    case "3":
                        Console.Clear();
                        Transaction.ReturnChange(Machine.InsertedAmount, Wallet.myWallet);
                        Console.WriteLine($"A total of {Transaction.totalChange} kronor was returned.");
                        Transaction.totalChange = 0;
                        Console.WriteLine("Did you forget to buy anything? (y/n)?");
                        input = Console.ReadKey();
                        if (input.KeyChar.ToString() == "y")                       
                            Menu.VendingMachineMenu();

                        if (input.KeyChar.ToString() == "n")
                        {
                            Console.WriteLine("Vending machine shutting down in three seconds...");
                            Thread.Sleep(3000);
                            runMachine = false;
                            break;

                        }
                        break;

                }

            } while (runMachine);

     

        }
        


    }
}
