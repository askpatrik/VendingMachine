using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Transaction
    {
        
        //eller en bool
        public static void TryPurchase(Wallet wallet, BaseProduct product)
        {
            if (wallet.GetBalance() >= product.Price)
            {
                wallet.Purchase(product.Price);
               
            }
               

        }
    }
}
