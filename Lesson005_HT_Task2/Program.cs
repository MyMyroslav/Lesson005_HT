using System;

namespace Lesson005_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Прямокутник
            int n = 10;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Ромб
            for (int row = 1; row < n; row++)
            {
                var spaces = Math.Abs(n / 2 - row);
                var stars = n / 2 - spaces;
                for (int col = 1; col <= spaces; col++)
                    Console.Write(" ");
                for (int col = 1; col <= stars; col++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            //Прямокутний трикутний 
            int NumberOfLines = 5;
            int count = 1;
            while (NumberOfLines-- != 0)
            {
                int c = count;
                while (c-- != 0)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                count = count + 2;
            }
            //Рівносторонній трикутник
            for (int i = 1; i < 10; i += 2)
            {
                for (int k = 0; k < (4 - i / 2); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}



