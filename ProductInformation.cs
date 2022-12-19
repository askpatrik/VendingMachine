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


        internal static Dictionary<string, int> AllItems = new Dictionary<string, int>()
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
            {"MisoSoup", "Soup of fermented soybeans" },
            {"Ramen Bowl", "Dish of Noodles in chicken broth with pak choi, eggs and roasted onion, " },
            {"Soda","Carbonated soda drink" },
            {"Sake", "Rice wine, it contains alcohol"},
            {"MatchaLatte", "Green tea drink with foamed milk"},
            {"CandyBar", "Japanese snack" },
            {"Mochi", "Strawberry flavored rice cake" },
            {"Dorayaki", "Soft honey pancakes with sweet adzuki bean paste" }

        };
        internal static Dictionary<string, int> FoodItems = new Dictionary<string, int>()
        {   
            {"Sushi", 45 },
            {"MisoSoup", 20 },
            {"RamenBowl", 60 }
        };
        internal static Dictionary<string, int> DrinkItems = new Dictionary<string, int>()
        {
             {"Soda", 15},
             {"Sake", 10 },
             {"MatchaLatte ", 35 }
        }; 
        internal static Dictionary<string, int> DesserItems = new Dictionary<string, int>()
        {
             {"CandyBar", 5 },
             {"Mochi", 10 },
             {"Dorayaki", 15 }
        };
 

        internal static void ViewList()
        {
            Console.WriteLine("Products and prices: ");
            Console.WriteLine();
            Console.WriteLine("Food Items:");           
            foreach (KeyValuePair<string, int> item in FoodItems)
            {
                Console.WriteLine($"{count}. {item.Key}: {item.Value}");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("Drink items:");       
            foreach (KeyValuePair<string, int> item in DrinkItems)
            {
                Console.WriteLine($"{count}. {item.Key}: {item.Value}");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("Dessert items: ");
            foreach (KeyValuePair<string, int> item in DesserItems)
            {
                Console.WriteLine($"{count}. {item.Key}: {item.Value}");
                count++;
            }
         
       
            count = 1;

        }


    }
}
