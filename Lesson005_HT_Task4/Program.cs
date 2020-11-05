using System;

namespace Lesson005_HT_Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 4;
            int b = 8;
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j<b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
