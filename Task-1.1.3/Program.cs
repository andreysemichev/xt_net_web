using System;

namespace Task_1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int x = 1;

            while (true)
            {
                try
                {
                    Console.Write("Введите N - ");
                    count = int.Parse(Console.ReadLine());

                    
                    for (int i = 1; i <= count; i++)
                    {
                        for (int j = count; j >= x / 2 + 2; j--)
                        {
                            Console.Write(' ');
                        }

                        for (int j = 1; j <= x; j++)
                        {
                            Console.Write('*');
                        }

                        x += 2;
                        Console.WriteLine();
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
