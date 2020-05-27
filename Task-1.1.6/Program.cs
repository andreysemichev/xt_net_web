using System;

namespace Task_1._1._6 {
    [Flags]
    enum Fonts
    {
        None      = 0b_0000_0000,
        Bold      = 0b_0000_0001,
        Italic    = 0b_0000_0010,
        Underline = 0b_0000_0100
    }

    class Program
    {
        static void Main(string[] args)
        {
            int selectedNum;
            Fonts fonts = Fonts.None;


            while (true)
            {
                try
                {
                    Console.WriteLine("Параметры надписи - " + fonts);
                    Console.WriteLine("Введите:");
                    Console.WriteLine("\t1. bold");
                    Console.WriteLine("\t2. italic");
                    Console.WriteLine("\t3. underline");

                    selectedNum = int.Parse(Console.ReadLine());

                    switch (selectedNum)
                    {
                        case 1:
                            fonts = fonts ^ Fonts.Bold;
                            break;

                        case 2:
                            fonts = fonts ^ Fonts.Italic;
                            break;

                        case 3:
                            fonts = fonts ^ Fonts.Underline;
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! Значение может быть только типа int.");
                }
            }
        }
    }
}
