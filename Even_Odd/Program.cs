namespace Even_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 123;

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Numver");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}