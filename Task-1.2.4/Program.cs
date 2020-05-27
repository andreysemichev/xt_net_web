using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!";
            string[] temp = Regex.Split(str, @"(?<=[!?.])\s");

            for (int i = 0; i < temp.Length; i++)
            {
                char[] array = temp[i].ToCharArray();
                array[0] = char.ToUpper(array[0]);

                foreach (char el in array)
                {
                    Console.Write(el);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
