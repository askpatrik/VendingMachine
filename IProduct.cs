using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal interface IProduct
    {      
        void Describe();
        void Buy();
        void Use();
    }
}
