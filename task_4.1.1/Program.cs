﻿using System;
using System.IO;

namespace task_4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим работы программы:");
            Console.WriteLine("1. Режим наблюдения");
            Console.WriteLine("2. Режим восстановления");

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    if (!Directory.Exists(ProgramPaths.WatchedDir))
                    {
                        Directory.CreateDirectory(ProgramPaths.WatchedDir);
                    }

                    Observer.StartWatch(ProgramPaths.WatchedDir, ProgramPaths.WatchedDirCopy, ProgramPaths.TempDir);

                    break;

                case 2:
                    try
                    {
                        Console.WriteLine("Для отката необходимо ввести дату в формате dd.MM.yyyy HH:mm:ss");

                        string date = Console.ReadLine();

                        if (date != "")
                        {
                            DateTime dateTime = DateTime.Parse(date);
                            BackUpSystem.StartRecovery(dateTime, ProgramPaths.WatchedDir, ProgramPaths.WatchedDirCopy);
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неверный формат даты");
                        break;
                    }
            }
        }

    }

    static class ProgramPaths
    {
        public static string WatchedDir { get; } = @"D:\task 4.1.1";

        public static string WatchedDirCopy { get; } = @"C:\backup\source";

        public static string TempDir { get; } = @"C:\backup\temp";

        public static string LogFilePath { get; } = @"C:\backup\log.txt";

    }
}
