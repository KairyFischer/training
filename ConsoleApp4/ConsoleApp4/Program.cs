using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);

            Console.ReadLine();
        }
    }
}
