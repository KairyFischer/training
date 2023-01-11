using System;

namespace twodarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine(a[1, 0]);

            Console.ReadLine();
        }
    }

}