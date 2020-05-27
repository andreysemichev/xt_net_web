using System;

namespace Task_1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            while (true)
            {
                try
                {
                    Console.Write("Введите a - ");
                    a = int.Parse(Console.ReadLine());

                    if (a <= 0)
                    {
                        Console.WriteLine("Вы ввели некорректное значение");
                        continue;
                    }

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите b - ");
                    b = int.Parse(Console.ReadLine());

                    if (b <= 0)
                    {
                        Console.WriteLine("Вы ввели некорректное значение");
                        continue;
                    }

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
                
            }

            int answer = a * b;

            Console.WriteLine("Площадь прямоугольника со сторонами a и b = " + answer);
        }
    }
}
