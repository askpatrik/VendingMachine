using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Basket
    {
        internal static List<string> BasketItems = new List<string>();
        
        internal static int BasketPrice = 0; 

        internal static void AddToBasket(BaseProduct product)
        {
            BasketItems.Add(product.Name);

 
        
            Console.WriteLine($"{product.Name} was added to the purchase list");
            Console.WriteLine("Press any key to return to the item list");
        }
        internal static void ViewBasketList()
        {
            Console.WriteLine("These are the items you have added to the purchase list: ");
            Console.WriteLine();
            foreach (var item in BasketItems)
            {
                Console.WriteLine($"{item}, {ProductInformation.Prices[item]} kronor");


                //get the price from casss
            }
            Console.WriteLine();
            Console.WriteLine($"Total price of current basket: {Basket.BasketPrice}");
        }
        internal static void UseItems()
        {
            int counter = 1;
            int input = 0;
            Console.WriteLine("These are your purchased items: ");
            Console.WriteLine();

 
            foreach (var item in BasketItems)
            {
              
                Console.WriteLine($"{counter}. {item}");
                counter++;
            }
            Console.WriteLine("Now, you can chose to use these different items ");
            Console.WriteLine("Enter the number ");

          
           

        }
      
    }
}
