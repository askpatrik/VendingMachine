using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Sushi : JapaneseDish, iProductFunctions
    {
   
        internal override string Description { get => descriptions["Sushi"]; }
        internal override int Price { get => prices["Sushi"]; }
        internal override string Name { get => names[1]; }
                
        internal override void GetPrice()
        {
            Console.WriteLine($"The price of {Name} is {Price}");
        }
        public void Buy()
        {
            throw new NotImplementedException();
        }

        public void Describe()
        {
            Console.WriteLine($"{Name} costs {Price}");
        }

        public void Use()
        {
            Console.WriteLine($"You ate the {Name}, Yummy! ");
        }
    }
}
