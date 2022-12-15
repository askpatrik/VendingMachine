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
        internal static Dictionary<string, int> Prices = new Dictionary<string, int>()
        {
            {"Sushi", 45 },
            {"Miso Soup", 20 },
            {"Ramen Bowl", 60 },
            {"Soda", 15},
            {"Sake", 10 },
            {"Matcha Latte ", 35 },
            {"Candy Bar", 5 },
            {"Mochi", 10 },
            {"Dorayaki", 15 }
        };
        internal static Dictionary<string, string> Descriptions = new Dictionary<string, string>()
        {
            {"Sushi", "Raw Fish Dish" },
            {"Miso Soup", "Its Soup of Miso" },
            {"Ramen Bowl", "Noodles in buljong and goodies!" }
        };


    }
}
