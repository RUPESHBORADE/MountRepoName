namespace EvenOdd_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            if ((num & 1) == 1)
            {
                Console.WriteLine("Odd"+num);
            }
            else
            {
                Console.WriteLine("Even"+num);
            }
            Console.ReadLine();
        }
    }
}