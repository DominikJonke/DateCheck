using System;

namespace DateCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Check.ShowTitle();

            Check.SetandCheckDate();

            Check.LeapYear();

            Console.ReadKey();
        }
    }
}
