using System;

namespace IFOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num2 = { 3023, 8760, 1112, 8232, 8107 };
            Array.Sort(num2);
            var highest = num2[0] + num2[1] + num2[2] + num2[3];
            var lowest = num2[4] + num2[3] + num2[2] + num2[1];
            Console.WriteLine($"The lowest value can be {lowest} and the highest value can be {highest}");








            //var min = int.MaxValue;
            //var max = int.MinValue;
            //int[] nbrs = {
            //    754, 233, 509, 792, 700, 596, 833, 658, 998, 742, 187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
            //    460, 241, 770, 324, 599, 259, 120, 800, 336, 609, 690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
            //    435, 643, 809, 874, 906, 620, 328, 369, 426, 561};
            //foreach(var nbr in nbrs)
            //{
            //    if(nbr > max) {
            //        max = nbr;
            //    }
            //    if (nbr < min) {
            //        min = nbr;
            //    }
            //}
            //Console.WriteLine($"Your min is {min} and your max is {max}");
            //var Sum = 0;
            //for (int idx = 1; idx <= 50; idx++)
            //{
            //    if (idx % 5 == 0 || idx % 7 == 0)
            //    {
            //        Sum = Sum + idx;
            //    }
            //}
            //Console.WriteLine($"The sum of all the numbers from 1-50, evenly divisible by 5 or 7 is {Sum}");

            //var comma = "";
            // for ( int Idx = 1; Idx < 26; Idx++)
            //{
            //    Console.Write($"{comma} {Idx}");
            //    comma = ",";
            //}


            //for(var idx =  0; idx < 5; idx++)
            //{
            //Console.Write("Enter a digit: ");

            //var Num = Console.ReadLine();
            // var value = Convert.ToInt32(Num);
            //if (value % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else {
            //    Console.WriteLine("The number is odd");

            //}

            //}

        }
    }
}
