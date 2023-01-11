using System;

namespace returnMethods
{
    class Program
    {
        static void Main(string[] args)

        {

            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();

        }

        static int /* < returns integer*/ cube(int num)
        {

            int result = num * num * num;
            return result;



        }




    }

}
