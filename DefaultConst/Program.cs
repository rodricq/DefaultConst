using System;

namespace DefaultConst
{
    class Program
    {
        int a;

        static void Main(string[] args)
        {
            //Call default constructor
            Program p1 = new Program();

            Console.WriteLine("Default value of a: " + p1.a);
            Console.ReadLine();

        }
    }
}
