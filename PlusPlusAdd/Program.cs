namespace PlusPlusAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++ + ++a;      //6   6

            Console.WriteLine(b);
        }
    }
}