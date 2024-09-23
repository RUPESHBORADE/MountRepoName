namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            int reversed = 0;

            while (num != 0)
            {
                // Get the last digit of num
                int digit = num % 10;
                // Add it to the reversed number
                reversed = reversed * 10 + digit;
                // Remove the last digit from num
                num /= 10;
            }

            Console.WriteLine("Reversed number: " + reversed);
            Console.ReadLine();
        }
    }
}