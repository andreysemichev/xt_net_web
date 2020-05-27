using System;
using System.Text;

namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("написать программу, которая");
            string str2 = "описание";

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str[i] == str2[j])
                    {
                        str.Insert(i, str2[j]);
                        i++;
                    }
                }
            }

            Console.WriteLine(str);
        }
    }
}
