using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Wallet
    {
        internal static Wallet myWallet = new Wallet();

        internal const int oneKrona = 1;
        internal const int fiveKrona = 5;
        internal const int tenKrona = 10;
        internal const int twentyKrona = 20;
        internal const int fiftyKrona = 50;
        internal const int hundredKrona = 100;

        internal int oneKronaAmount = 10;
        internal int fiveKronaAmount = 10;
        internal int tenKronaAmount = 10;
        internal int twentyKronaAmount = 0;
        internal int fiftyKronaAmount = 0;
        internal int hundredKronaAmount = 0;

        internal int[] kronaValues = new int[] { hundredKrona, fiftyKrona, twentyKrona, tenKrona, fiveKrona, oneKrona };
       

        internal int insertedAmount = 0; 
        internal int change = 0;
        internal int price = 0;

       
        internal int Balance { get => (oneKronaAmount * oneKrona) + (fiveKronaAmount * fiveKrona) + (tenKronaAmount * tenKrona); }
        internal void IncreaseAmount(int a)
        {
            if (a == 1)
                oneKronaAmount++;
            else if (a == 5)
                fiveKronaAmount++;
            else if (a == 10)
                tenKronaAmount++;
            else if (a == 20)
                twentyKronaAmount++;
            else if (a == 50)
                fiftyKronaAmount++;
            else if (a == 100)
                hundredKronaAmount++;
        }

        internal int GetBalance() => Balance; 
        internal int GetInsertedAmount() => insertedAmount; 

      
     
        
          

        
      
             
                








            }
        }
    