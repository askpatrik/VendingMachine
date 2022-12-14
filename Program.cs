namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vending machine application");

            var a = new Sushi();
            a.Use();
            a.Describe();
            Console.WriteLine(a.Price);
        }
    }
}