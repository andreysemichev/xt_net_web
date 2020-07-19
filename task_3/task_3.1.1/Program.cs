using System;
using System.Collections.Generic;

namespace task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int peopleCount = int.Parse(Console.ReadLine());

            Console.Write("Введите, какой по счету человек будет вычеркнут каждый раунд: ");
            int deletePeople = int.Parse(Console.ReadLine());

            List<int> obj = Add(peopleCount);

            Remove(obj, deletePeople);
        }

        public static List<int> Add(int n)
        {
            List<int> elements = new List<int>(n);

            for (int i = 1; i <= elements.Capacity; i++)
            {
                elements.Add(i);
            }

            return elements;
        }

        public static void Remove(List<int> elements, int delete)
        {

            int deleteEmelent = delete - 1;
            int count = 1;

            while (elements.Count > 1)
            {
                if (deleteEmelent >= elements.Count)
                {
                    Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
                    break;
                }

                elements.RemoveAt(deleteEmelent);
                Console.WriteLine("Раунд " + count + ". Вычеркнут человек. Людей осталось: " + elements.Count);

                count++;
            }
        }
    }
}