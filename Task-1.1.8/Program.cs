using System;

namespace Task_1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[4, 5, 6];
            Random rand = new Random();

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    for (int k = 0; k < array.GetUpperBound(2) + 1; k++)
                    {
                        array[i, j, k] = rand.Next(-100, 100);
                    }
                }
            }

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    for (int k = 0; k < array.GetUpperBound(2) + 1; k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // Замена на 0
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    for (int k = 0; k < array.GetUpperBound(2) + 1; k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }

            Console.WriteLine("Измененный массив");
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    for (int k = 0; k < array.GetUpperBound(2) + 1; k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
