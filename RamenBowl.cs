using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class RamenBowl : Food, IProduct

    {
        internal override string Description => throw new NotImplementedException();

        internal override int Price => throw new NotImplementedException();

        internal override string Name => throw new NotImplementedException();

        public void Buy()
        {
            throw new NotImplementedException();
        }

        public void Describe()
        {
            throw new NotImplementedException();
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
