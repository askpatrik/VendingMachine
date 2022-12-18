using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Sushi : Food, IProduct
    {
     
        internal override string Description { get => ProductInformation.Descriptions[GetType().Name]; }
        internal override int Price { get => ProductInformation.Prices[GetType().Name];}
        internal override string Name { get => GetType().Name; }
   
        public void Buy()
        {
            Transaction.Purchase(this.Price);
        }

        public void Describe()
        {
            Console.WriteLine(Description);
        }

        public void Use()
        {
            Console.WriteLine($"You ate the {GetType().Name}");
        }
    }
}
