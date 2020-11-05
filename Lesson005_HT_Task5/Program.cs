using System;

namespace Lesson005_HT_Task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b, fact = 1;
            int key;
            do
            {
                Console.WriteLine ("\nPlease enter a positive integer : ");
                b = int.Parse(Console.ReadLine());

                for (a = b; a >= 1; a--)
                    fact = fact * a;

                Console.WriteLine($"The output of {b} is: {fact}");
                Console.WriteLine("\nPlease enter 1 to continue: ");
                key = int.Parse(Console.ReadLine());
            }
            while (key == 1);
        }
    }
}
