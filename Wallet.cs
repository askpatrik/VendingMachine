using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Wallet
    {    
        internal const int oneKrona = 1;
        internal const int fiveKrona = 5;
        internal const int tenKrona = 10;
        internal const int twentyKrona = 20;
        internal const int fiftyKrona = 50;
        internal const int hundredKrona = 100;

        internal int inputAmount = 50;

        internal int oneKronaAmount = 10;
        internal int fiveKronaAmount = 10;
        internal int tenKronaAmount = 10;

        internal int Balance { get => (oneKronaAmount * oneKrona) + (fiveKronaAmount * fiveKrona) + (tenKronaAmount * tenKrona); }
   

        internal int GetBalance()
        {
            return Balance;
        }

        internal void Purchase(int amount)
        {
            //har 50, handlar för 20
            //kan den ge tillbaka 100, 50, 20, 10. 

            if (30%20 != 30)
            {
                //add a twenty 
                //recurse with 10
            }

            

        }
    }
}
