using System;

namespace Task_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            string stars = "";

            while (true)
            {
                try
                {
                    Console.Write("Введите N - ");
                    count = int.Parse(Console.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        stars += "*";
                        Console.WriteLine(stars);
                    }

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! Значение может быть только типа int.");
                }
            }
        }
    }
}
