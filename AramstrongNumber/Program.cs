namespace AramstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 153;
            int rem;                          // for reminder
            int cube;                        // for cube
            int result = 0;
            int tem =number;

            while (number != 0)
            {
                rem = number % 10;          // Reminder mnje bki em mdhe save honr 
                cube = rem * rem * rem;    // cube save value
                result = result + cube; 
                number = number / 10;

            }
            number = tem;
            if (number == result)
            {
                Console.WriteLine("Is Amr number ");
            }
            else
            {
                Console.WriteLine("is not arm no");
            }

        }
    }
}