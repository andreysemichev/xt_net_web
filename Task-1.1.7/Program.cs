using System;

namespace Task_1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            Random rand = new Random();
            int indexOfMax = 0;
            int indexOfMin = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);

                if (array[i] > array[indexOfMax])
                {
                    indexOfMax = i;
                }
                else if (array[i] < array[indexOfMin])
                {
                    indexOfMin = i;
                }
            }

            foreach (int el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Максимальное значение массива: " + array[indexOfMax]);
            Console.WriteLine("Минимальное значение массива: " + array[indexOfMin]);

            // Сортировка вставками
            int key, j;

            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    array[j] = key;

                    j--;
                }
            }

            foreach (int el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
