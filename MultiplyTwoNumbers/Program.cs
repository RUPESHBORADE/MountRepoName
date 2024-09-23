namespace MultiplyTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 11;
            int result = 0;

            for (int i = 0; i < b; i++)
            {
                result += a;
            }

            Console.WriteLine(result);
        }
    }
}