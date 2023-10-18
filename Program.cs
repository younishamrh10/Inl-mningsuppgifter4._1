using System;

namespace Inlämningsuppgifter4._1
{
    class Program
    {
        static void Main(string[] arga)
        {
            for (int i=10; i < 31; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 200; i > 179; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 1000; i < 1405; i+= 5)
            {
                Console.WriteLine(i);
            }
        }
    }
}