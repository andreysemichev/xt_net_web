using System;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 10;
            int[] array = new int[n];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }

            foreach (int el in array)
            {
                Console.Write(el + " ");
                if (el > 0)
                {
                    sum += el;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Сумма неотрицательных элементов: " + sum);
        }
    }
}
