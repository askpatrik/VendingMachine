namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vending machine application");


            var wal1 = new Wallet();
            var sushi = new Sushi();


            Console.WriteLine((wal1.Balance));
            Console.WriteLine($"TOTAL:  {wal1.GetBalance()}   Enkronor: {wal1.oneKronaAmount},  Femkronor:  {wal1.fiveKronaAmount},   TioKronor:  {wal1.tenKronaAmount},   20krona:   {wal1.twentyKronaAmount}  50kronor:   {wal1.fiftyKronaAmount},   100kronoa:   {wal1.hundredKronaAmount} ");


     
            wal1.InsertCoin(10);
            wal1.Purchase(sushi);
            wal1.ReturnChange(wal1.insertedAmount);

            Console.WriteLine($" TOTAL: {wal1.GetBalance()}   Enkronor: {wal1.oneKronaAmount},  Femkronor:  {wal1.fiveKronaAmount},   TioKronor:  {wal1.tenKronaAmount},   20krona:   {wal1.twentyKronaAmount}  50kronor:   {wal1.fiftyKronaAmount},   100kronoa:   {wal1.hundredKronaAmount} ");










        }
    }
}