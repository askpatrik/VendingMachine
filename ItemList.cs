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
                Console.WriteLine();
                Console.WriteLine("-- Chose which item to add --");
                Console.WriteLine("Press x to quit ");
                Console.WriteLine();             
                Console.WriteLine($"Current inserted value is: {Machine.InsertedAmount}");
                Console.WriteLine($"Price of current basket: {Basket.BasketPrice}");

                input = Console.ReadKey();
                switch (input.KeyChar.ToString())
                {
                    case "1":
                        Console.Clear();
                        Sushi sushi = new Sushi();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, Basket.BasketPrice, sushi) == true)
                            break;                                     
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, sushi) == true)
                            break;
                        Basket.BasketPrice += sushi.Price;
                        Basket.AddToBasket(sushi);                                                                 
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();                     
                        MisoSoup miso = new MisoSoup();
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, Basket.BasketPrice, miso) == true)
                            break;
                        if (Exceptions.CheckIfEnoughCash(Machine.InsertedAmount, miso) == true)
                            break;
                        Basket.BasketPrice += miso.Price;
                        Basket.AddToBasket(miso);
                        Console.ReadKey();
                        break;

                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        
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
