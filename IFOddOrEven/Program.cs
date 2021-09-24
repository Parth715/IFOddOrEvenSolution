using System;

namespace IFOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");

            var Num = Console.ReadLine();
            var value = Convert.ToInt32(Num);
            if (value % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else {
                Console.WriteLine("The number is odd");
            
            }
        }
    }
}
