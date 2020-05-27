using System;

namespace Task_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', '.', ',', '!', '?', ':', ';' };

            string str = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int letterCounter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                letterCounter += words[i].Length;

            }

            int result = letterCounter / words.Length;

            Console.WriteLine(result);
        }
    }
}
