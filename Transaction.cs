using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Transaction

    {
        internal static ConsoleKeyInfo input;


        internal static void InsertCoin()
        {

            do
            {
                Console.Clear();
                Console.WriteLine("-- Insert cash in the vending machine --");
                Console.WriteLine();
                Console.WriteLine($"Your current wallet balance is: {Wallet.myWallet.GetBalance()}");
                Console.WriteLine($"Current inserted value is: {Machine.InsertedAmount}");
                Console.WriteLine("This is your current available cash to input: ");

                Console.WriteLine($" 1. 1-kronor:{Wallet.myWallet.oneKronaAmount}");
                Console.WriteLine($" 2. 5-kronor:{Wallet.myWallet.fiveKronaAmount}");
                Console.WriteLine($" 3. 10-kronor:{Wallet.myWallet.tenKronaAmount}");
                Console.WriteLine($" 4. 20-kronor:{Wallet.myWallet.twentyKronaAmount}");
                Console.WriteLine($" 5. 50-kronor:{Wallet.myWallet.fiftyKronaAmount}");
                Console.WriteLine($" 6. 100-kronor:{Wallet.myWallet.hundredKronaAmount}");
                Console.WriteLine("(Press X to return to main menu)");
                Console.WriteLine();
                Console.Write("Add cash by pressing corresponding number: ");

                input = Console.ReadKey();
                switch (input.KeyChar.ToString())
                {

                    case "1":
                        Console.Clear();
                        if (Exceptions.CheckIfZero(Wallet.myWallet.oneKronaAmount) == true)
                            break;

                        Wallet.myWallet.oneKronaAmount--;
                        Machine.InsertedAmount += Wallet.oneKrona;
                        Console.WriteLine($"Added {Wallet.oneKrona} to the machine");

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

        internal static void Purchase(int sum)
        {
            if (Machine.InsertedAmount >= sum)
                Machine.InsertedAmount -= sum;

            ReturnChange(Machine.InsertedAmount, Wallet.myWallet);

            //add to basket

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

                    Console.WriteLine($"{wallet.kronaValues[i]} was returned");

                    if (value == 0)
                        break;
                }

                if (value > 0)
                {
                    wallet.IncreaseAmount(wallet.kronaValues[i]);
                    value -= wallet.kronaValues[i];
                    Console.WriteLine($"{wallet.kronaValues[i]} was returned");
                    ReturnChange(value, Wallet.myWallet);
                }
                break;
            }
            Console.ReadKey();
            Machine.InsertedAmount = 0;
            
        }
    }
}