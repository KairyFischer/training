using System;

namespace TestMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHi("Kaylea", 19);
            Console.ReadLine();
        }


        static void /* < No Info*/ SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + "You are " + age);
        }

    }

}
