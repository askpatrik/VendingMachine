using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Transaction

    {
        internal static int totalChange = 0;
        internal static ConsoleKeyInfo input;


        internal static void InsertMoney()
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"There is {Machine.InsertedAmount} kronor in the vending machine. You have {Wallet.myWallet.Balance} kronor " +
                    $"left in your wallet");
                             
                Console.WriteLine("In your wallet you have the following coins and bills:");
                Console.WriteLine();
                Console.WriteLine($"1. 1-krona: {Wallet.myWallet.oneKronaAmount} pieces");
                Console.WriteLine($"2. 5-krona: {Wallet.myWallet.fiveKronaAmount} pieces");
                Console.WriteLine($"3. 10-krona: {Wallet.myWallet.tenKronaAmount} pieces");
                Console.WriteLine($"4. 20-bill: {Wallet.myWallet.twentyKronaAmount} pieces");
                Console.WriteLine($"5. 50-bill: {Wallet.myWallet.fiftyKronaAmount} pieces");
                Console.WriteLine($"6. 100-bill: {Wallet.myWallet.hundredKronaAmount} pieces");
                Console.WriteLine("Press X to return");
                Console.WriteLine();
                Console.Write("Enter choice for desired coin or bill to insert to the machine:");
                input = Console.ReadKey();
                switch (input.KeyChar.ToString())
                {

                    case "1":
                        Console.Clear();
                        if (Exceptions.CheckIfZero(Wallet.myWallet.oneKronaAmount) == true)
                            break;

                        Wallet.myWallet.oneKronaAmount--;
                        Machine.InsertedAmount += Wallet.oneKrona;
                        Console.WriteLine($"Added {Wallet.oneKrona} krona to the machine");
                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        if (Exceptions.CheckIfZero(Wallet.myWallet.fiveKronaAmount) == true)
                            break;
                        Wallet.myWallet.fiveKronaAmount--;
                        Machine.InsertedAmount += Wallet.fiveKrona;
                        Console.WriteLine($"Added {Wallet.fiveKrona} kronor to the machine");

                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        if (Exceptions.CheckIfZero(Wallet.myWallet.tenKronaAmount) == true)
                            break;
                        Wallet.myWallet.tenKronaAmount--;
                        Machine.InsertedAmount += Wallet.tenKrona;
                        Console.WriteLine($"Added {Wallet.tenKrona} kronor to the machine");

                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        if (Exceptions.CheckIfZero(Wallet.myWallet.twentyKronaAmount) == true)
                            break;
                        Wallet.myWallet.twentyKronaAmount--;
                        Machine.InsertedAmount += Wallet.twentyKrona;
                        Console.WriteLine($"Added {Wallet.twentyKrona} kronor to the machine");

                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        if (Exceptions.CheckIfZero(Wallet.myWallet.fiftyKronaAmount) == true)
                            break;
                        Wallet.myWallet.fiftyKronaAmount--;
                        Machine.InsertedAmount += Wallet.fiftyKrona;
                        Console.WriteLine($"Added {Wallet.fiftyKrona} kronor to the machine");

                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        if (Exceptions.CheckIfZero(Wallet.myWallet.hundredKronaAmount) == true)
                            break;
                        Wallet.myWallet.hundredKronaAmount--;
                        Machine.InsertedAmount += Wallet.hundredKrona;
                        Console.WriteLine($"Added {Wallet.hundredKrona} kronor to the machine");

                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        break;

                }
            } while (input.KeyChar.ToString() != "x");
        }

        internal static void Purchase(BaseProduct product)
        {
            Console.Clear();
            Machine.InsertedAmount -= product.Price;
            Console.WriteLine($"{product.Price} kronor for a {product.Name} was transferred from your inserted amount. You now have {Machine.InsertedAmount} kronor left in the machine");
            Console.Write("Press any key to use the product! : ");
            Console.ReadKey();

        }
        internal static void ReturnChange(int value, Wallet wallet)
        {
            
            for (int i = 0; i < wallet.kronaValues.Length; i++)
            {

                if (value % wallet.kronaValues[i] == value)
                    continue;

                while (value % wallet.kronaValues[i] == 0)
                {
                    wallet.IncreaseAmount(wallet.kronaValues[i]);
                    value -= wallet.kronaValues[i];

                    Console.WriteLine($"A {wallet.kronaValues[i]} krona was returned.");
                    totalChange += wallet.kronaValues[i];
                    if (value == 0)
                        break;
                }

                if (value > 0)
                {
                    wallet.IncreaseAmount(wallet.kronaValues[i]);
                    value -= wallet.kronaValues[i];
                    Console.WriteLine($"A {wallet.kronaValues[i]} krona was returned.");
                    totalChange += wallet.kronaValues[i];
                    ReturnChange(value, Wallet.myWallet);
                }
                Console.WriteLine();
                
                break;
            }
            Console.WriteLine($"A total of {totalChange} kronor was returned.");
            Machine.InsertedAmount = 0;
            
        }
    }
}