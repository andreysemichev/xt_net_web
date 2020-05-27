using System;

namespace Task_1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] array = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < array.GetUpperBound(0); i++)
            {
                for (int j = 0; j < array.GetUpperBound(1); j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                }
            }

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < array.GetUpperBound(0); i++)
            {
                for (int j = 0; j < array.GetUpperBound(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Считаем сумму
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum = sum + array[i, j];
                    }
                }
            }

            Console.Write("Сумма элементов массива, стоящих на чётных позициях: " + sum);
        }
    }
}
