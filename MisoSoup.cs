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
            internal override int Price { get => ProductInformation.Prices[GetType().Name]; }
            internal override string Name { get => GetType().Name; }

            public void Buy()
            {
                Transaction.Purchase(this.Price);
                Console.WriteLine($"You have purchased a {GetType().Name}");

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

