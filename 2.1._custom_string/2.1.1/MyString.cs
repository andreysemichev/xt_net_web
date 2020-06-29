using System;

namespace _2._1._1
{
    public class MyString
    {
        private char[] fromConstructor;

        public MyString()
        {
            // ...
        }

        public MyString(string inputString)
        {
            this.fromConstructor = inputString.ToCharArray();
        }

        public bool Equals(string inputString) // Сравнение 2х строк
        {
            for (int i = 0; i < fromConstructor.Length; i++)
            {
                if (fromConstructor[i] == inputString[i])
                {
                    continue;

                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public int Find(char inputChar)
        {

            for (int i = 0; i < fromConstructor.Length; i++)
            {
                if (fromConstructor[i] == inputChar)
                {
                    return i;
                }
            }

            return -1;
        }

        public string Concat(string inputString)
        {
            char[] inputStringToCharArr = inputString.ToCharArray();
            char[] result = new char[fromConstructor.Length + inputStringToCharArr.Length];

            for (int i = 0; i < fromConstructor.Length; i++)
            {
                result[i] = fromConstructor[i];
            }

            Console.WriteLine(result);

            for (int i = 0; i < inputStringToCharArr.Length; i++)
            {
                result[i + fromConstructor.Length] = inputStringToCharArr[i];
            }

            return new String(result);
        }

        public char[] StringToCharArr(string inputString)
        {
            return inputString.ToCharArray();
        }

        public string CharArrToString(char[] inputCharArr)
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
