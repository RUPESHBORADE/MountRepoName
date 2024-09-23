namespace SwapValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}