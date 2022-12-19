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
                        Machine.AskToBuy(miso);
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, miso) == true)
                            break;
                        miso.Buy();
                        miso.Use();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        RamenBowl ramen = new RamenBowl();
                        Machine.AskToBuy(ramen);
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, ramen) == true)
                            break;
                        ramen.Buy();
                        ramen.Use();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                       
                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        
                        break;

                }
            } while (input.KeyChar.ToString() != "x");
        }
    }

}
