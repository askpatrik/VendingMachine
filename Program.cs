namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vending machine application");



            var sushi = new Sushi();
            Console.WriteLine($"{sushi.Name}, {sushi.Price}, {sushi.Description}");
            var wallet1 = new Wallet();


            Console.WriteLine(wallet1.Balance);
            Console.WriteLine(sushi.Name);

            Transaction.TryPurchase(wallet1, sushi);

            
            Console.WriteLine(sushi.Price);

        }
    }
}