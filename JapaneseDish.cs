using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal abstract class JapaneseDish
    {
        protected Dictionary<int, string> names = new Dictionary<int, string>()
        {
            {1, "Sushi" },
            {2, "Miso Soup" },
            {3, "Ramen Bowl" }
        };
        protected Dictionary<string, int> prices = new Dictionary<string, int>()
        {
            {"Sushi", 50 },
            {"Miso Soup", 20 },
            {"Ramen Bowl", 75 }
        };
        protected Dictionary<string, string> descriptions = new Dictionary<string, string>()
        {
            {"Sushi", "Raw Fish Dish" },
            {"Miso Soup", "Its Soup of Miso" },
            {"Ramen Bowl", "Noodles in buljong and goodies!" }
        };

        

        internal abstract string Description { get;}
        internal abstract int Price { get; }
        internal abstract string Name { get; }

        internal abstract void GetPrice();

        
       
    }
}
