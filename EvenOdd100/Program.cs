namespace EvenOdd100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 10; num <= 100; num++)
            {
                if (num %2==0 )
                {
                    Console.WriteLine("Even Number"+num);
                }
                else
                {
                    Console.WriteLine("Odd" + num);
                }
            }
            Console.Beep(); 
            Console.ReadLine();
        }
    }
}