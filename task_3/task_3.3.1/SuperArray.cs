using System.Collections.Generic;
using System.Linq;

namespace task_3._3._1
{
    public static class SuperArray
    {
        public static int Sum(this int[] array)
        {
            int sum = 0;

            foreach (int item in array)
            {
                sum += item;
            }

            return sum;
        }

        public static double Average(this int[] array) {
            return array.Sum() / (double)array.Length;
        }

        public static int MaxRepeat(this int[] array)
        {
            Dictionary<int, int> repeats = new Dictionary<int, int>();

            foreach (int item in array)
            {
                if (repeats.ContainsKey(item))
                {
                    repeats[item]++;
                }

                else
                {
                    repeats.Add(item, 1);
                }
            }
            return repeats.OrderBy(i => i.Value).LastOrDefault().Key;
        }

    }
}
