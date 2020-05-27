using System;

namespace Task_1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            while (true)
            {
                try
                {
                    Console.Write("Введите N - ");
                    count = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= count; i++)
                    {
                        for (int j = 1; j <= 2 * i; j += 2)
                        {
                            for (int n = count; n >= j / 2 + 2; n--)
                            {
                                Console.Write(' ');
                            }

                            for (int n = 1; n <= j; n++)
                            {
                                Console.Write('*');
                            }

                            Console.WriteLine();
                        }
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
