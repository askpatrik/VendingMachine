using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal abstract class BaseProduct
    {
        internal abstract string Description { get; }
        internal abstract int Price { get; }
        internal abstract string Name { get; }
        //internal abstract int Id { get; }
      //  internal abstract bool IsAvailable { get; }

    }
}
