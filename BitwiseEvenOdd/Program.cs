namespace BitwiseEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 13;

            int output = num1 & num2;
            int output1 = num1 | num2;

            Console.WriteLine("This is Even no." + output);

            Console.WriteLine("This is Odd no." + output1);
            //Console.Beep(800,800);
            Console.ReadLine();
          
        }
    }
}