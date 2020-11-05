using System;

namespace Lesson005_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 2;
            int b = 10;
            int sum = 0;
            int count = 0;
            Console.WriteLine("//-------------//");
            //Сума проміжних елементів.
            for (int i = a + 1; i < b; i++)
            {
                count++;
                sum = sum + i;
                Console.WriteLine($"{count} step -> {sum}");
            }
            Console.WriteLine("//-------------//");
            //Непарні
            count = 0;
            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                    Console.WriteLine($"{count} step -> {i} -> odd");
                }
            }
        }
    }
}
