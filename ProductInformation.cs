using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class ProductInformation
        //innehåller all produktinformation
    {
        internal static int count = 1;
        internal static Dictionary<string, int> Prices = new Dictionary<string, int>()
        {
            {"Sushi", 45 },
            {"MisoSoup", 20 },
            {"RamenBowl", 60 },
            {"Soda", 15},
            {"Sake", 10 },
            {"MatchaLatte ", 35 },
            {"CandyBar", 5 },
            {"Mochi", 10 },
            {"Dorayaki", 15 }
        };
        internal static Dictionary<string, string> Descriptions = new Dictionary<string, string>()
        {
            {"Sushi", "Raw Fish Dish" },
            {"Miso Soup", "Its Soup of Miso" },
            {"Ramen Bowl", "Noodles in buljong and goodies!" }
        };
        internal static void ViewList()
        {
            Console.WriteLine("Here are the available items: ");
            Console.WriteLine();
            foreach (KeyValuePair<string, int> item in Prices)
            {
                Console.WriteLine($"{count}. {item.Key}: {item.Value}");
                count++;
            }
            count = 1;

        }


    }
}
