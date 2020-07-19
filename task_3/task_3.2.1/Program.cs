using System;

namespace task_3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3};

            DynamicArray<int> dynamicArray = new DynamicArray<int>(new int[] {1, 2});

            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(i + ": " + dynamicArray[i]);
            }

            dynamicArray.AddRange(arr);
            dynamicArray.Add(999);
            dynamicArray.Insert(333, 3);

            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(i + ": " + dynamicArray[i]);
            }
        }
    }
}
