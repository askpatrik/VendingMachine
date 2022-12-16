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

        internal int oneKronaAmount = 10;
        internal int fiveKronaAmount = 10;
        internal int tenKronaAmount = 10;
        internal int twentyKronaAmount = 0;
        internal int fiftyKronaAmount = 0;
        internal int hundredKronaAmount = 0;

        int[] kronaValues = new int[] { hundredKrona, fiftyKrona, twentyKrona, tenKrona, fiveKrona, oneKrona };
       

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

      
        internal void Purchase(BaseProduct product)
        {
            if (Balance >= product.Price)          
                insertedAmount -= product.Price;
            ItemList.items.Add(product.Name);

        }
        internal void InsertCoin(int value)
        {      

            if (value == 1)
                oneKronaAmount--;
            else if (value == 5)
                fiveKronaAmount--;
            else if (value == 10)
                tenKronaAmount--;
            else if (value == 20)
                twentyKronaAmount--;
            else if (value == 50)
                fiftyKronaAmount--;
            else if (value == 100)
                hundredKronaAmount--;

            insertedAmount += value;          
        }
        internal void ReturnChange(int value)
        {
            for (int i = 0; i < kronaValues.Length; i++)
            {            

                if (value % kronaValues[i] == value)
                    continue;

                while (value % kronaValues[i] == 0)
                {
                    IncreaseAmount(kronaValues[i]);
                    value -= kronaValues[i];

                    if (value == 0)
                        break;
                }
                
                if (value > 0)
                {
                    IncreaseAmount(kronaValues[i]);
                    value -= kronaValues[i];
                    ReturnChange(value);
                }
                break;            
            }
             
                








            }
        }
    }
