using System;

namespace _2._1._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyString myString = new MyString("Hello, World!");

            Console.WriteLine(myString.Equals("Hello, World!"));
            Console.WriteLine(myString.Find('W'));
            Console.WriteLine(myString.Concat("Two"));

            char[] charArray = myString.StringToCharArr("Test");
            Console.WriteLine(charArray);

            Console.WriteLine(myString.CharArrToString(charArray));
        }
    }
}