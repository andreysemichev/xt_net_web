using System;
using System.Linq;

namespace _2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Поиск символа
            MyString str = new MyString("Hello, World!");
            Console.WriteLine(str.MyFind('l'));

            // Сравнение 2х строк
            MyString str2 = new MyString("Word");
            Console.Write(str2.MyEquals("Word"));

            // Конкатенация
            MyString str3 = new MyString("One");
            Console.WriteLine(str3.MyConcat("Two"));

            // Конвертация в массив
            MyString str4 = new MyString();
            char[] charArray = str4.MyInArrayConvertation("Word");

            foreach (char item in charArray)
            {
                Console.WriteLine(item);
            }

            // Конвертация мз массива
            MyString str5 = new MyString();
            Console.WriteLine(str5.MyOutArrayConvertation(charArray));
        }
    }

    class MyString
    {
        char[] myChars;

        public MyString()
        {
            // ...
        }

        public MyString(string str)
        {
            this.myChars = str.ToCharArray();
        }

        public bool MyEquals(string str) // Сравнение 2х строк
        {
            char[] outChars = str.ToCharArray();
            bool isEqual = Enumerable.SequenceEqual(myChars, outChars);

            return isEqual;
        }

        public string MyFind(char inputChar) // Поиск символа в строке
        {

            string outInfo = "";
            foreach (char item in myChars)
            {
                if (inputChar == item)
                {
                    outInfo = $"Символ {inputChar} найден";
                    break;
                }
                else
                {
                    outInfo = $"Символ {inputChar} не найден";
                }
            }

            return outInfo;
        }

        public char[] MyConcat(string inputString) // Конкатенация строк
        {
            char[] charArr = inputString.ToCharArray();
            string inString = String.Concat(myChars);
            string outString = String.Concat(charArr);
            string inStringAndOutString = inString + outString;
            char[] result = inStringAndOutString.ToCharArray();

            return result;
        }

        public char[] MyInArrayConvertation(string inputString) // Конвертация в массив
        {
            char[] outChars = inputString.ToCharArray();

            return outChars;
        }

        public string MyOutArrayConvertation(char[] inputCharArr) // Конвертация из массива
        {
            string resultString = null;

            foreach (char item in inputCharArr)
            {
                resultString = resultString + item;
            }


            return resultString;
        }
    }
}
