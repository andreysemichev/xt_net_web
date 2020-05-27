using System;

namespace Task_1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int sumA = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % a == 0)
                {
                    sumA = sumA + i;
                }

            }

            int b = 5;
            int sumB = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % b == 0)
                {
                    sumB = sumB + i;
                }
            }

            int answer = sumA + sumB;

            Console.WriteLine(answer);
        }
    }
}
