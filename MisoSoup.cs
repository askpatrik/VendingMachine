using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class MisoSoup: Food, IProduct
    {

        internal override string Description { get => ProductInformation.Descriptions[GetType().Name]; }
        internal override int Price { get => ProductInformation.AllItems[GetType().Name]; }
        internal override string Name { get => GetType().Name; }


        public void Buy()
        {
            Console.WriteLine($"You bought a {GetType().Name}");
            Transaction.Purchase(this);
        }

        public void Describe()
        {
            Console.WriteLine(Description);
        }

        public void Use()
        {
            Console.Clear();
            Console.WriteLine($"You ate the {GetType().Name}. Such comfort, such soup! You feel warm and fuzzy. ");
       
        }


    }
}
    
