using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class ItemList
    {
    internal static ConsoleKeyInfo input;
   
        
        internal static void ChoseItem()
        {
            do
            {
                Console.Clear();
                ProductInformation.ViewList();
                Console.WriteLine("(Press X to return)");
                Console.WriteLine();
                Console.WriteLine($"Money in machine: {Machine.InsertedAmount} kronor");
                Console.Write("Enter the number of desired product: ");             
               
              
                input = Console.ReadKey();
                switch (input.KeyChar.ToString())
                {
                    case "1": 
                        Console.Clear();
                        Sushi sushi = new Sushi();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, sushi) == true)
                            break;
                        Machine.AskToBuy(sushi);                                            
                        sushi.Buy();
                        sushi.Use();
                        Menu.VendingMachineMenu();
                        break;

                    case "2":
                        Console.Clear();
                        MisoSoup miso = new MisoSoup();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, miso) == true)
                            break;
                        Machine.AskToBuy(miso);
                        miso.Buy();
                        miso.Use();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        RamenBowl ramen = new RamenBowl();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, ramen) == true)
                            break;
                        Machine.AskToBuy(ramen);                       
                        ramen.Buy();
                        ramen.Use();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Soda soda = new Soda();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, soda) == true)
                            break;
                        Machine.AskToBuy(soda);
                        soda.Buy();
                        soda.Use();
                        Console.ReadKey();
                        break;
                       
                    case "5":
                        Console.Clear();
                        Sake sake = new Sake();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, sake) == true)
                            break;
                        Machine.AskToBuy(sake);
                        sake.Buy();
                        sake.Use();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        MachaLatte latte = new MachaLatte();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, latte) == true)
                            break;
                        Machine.AskToBuy(latte);
                        latte.Buy();
                        latte.Use();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        CandyBar candy = new CandyBar();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, candy) == true)
                            break;
                        Machine.AskToBuy(candy);
                        candy.Buy();
                        candy.Use();
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.Clear();
                        Mochi mochi = new Mochi();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, mochi) == true)
                            break;
                        Machine.AskToBuy(mochi);
                        mochi.Buy();
                        mochi.Use();
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.Clear();
                        DoraYaki yaki = new DoraYaki();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, yaki) == true)
                            break;
                        Machine.AskToBuy(yaki);
                        yaki.Buy();
                        yaki.Use();
                        Console.ReadKey();
                        break;
                }
            } while (input.KeyChar.ToString() != "x");
        }
    }

}
