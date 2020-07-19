using System;
using System.Collections.Generic;

namespace task_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "Lorem ipsum Dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut dolor labore et dolore magna aliqua. Ut enim ad minim dolor veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip minim ex ea commodo consequat.";

            char[] separatorsArrChar = new char[] { ' ', '.' };
            string[] words = inputText.Split(separatorsArrChar);

            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    char[] trimArr = new char[] { ',', ';', ':', '!', '?' };
                    string word = words[i].ToLower().Trim(trimArr);

                    if (result.ContainsKey(word))
                    {
                        result[word]++;
                    }
                    else
                    {
                        result.Add(word, 1);
                    }
                }
            }

            Console.WriteLine("Исходные данные: " + inputText);
            Console.WriteLine("Количество повторяющихся слов: ");

            foreach (var element in result)
            {
                Console.WriteLine(element.Key+ ": " + element.Value);
            }
        }
    }
}
