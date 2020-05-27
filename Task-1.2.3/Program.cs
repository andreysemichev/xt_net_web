using System;

namespace Task_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', '.', ',', '!', '?', ':', ';' };

            string str = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (Char.IsLower(words[i][0]))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
