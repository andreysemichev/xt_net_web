using System;

namespace _2._2._1
{
    public class Stone : Items // Ловушка
    {
        public override int GetEffect(int x, int y)
        {
            if (this.x == x && this.y == y)
            {
                Console.WriteLine("Пропуск хода");
                return -1;
            }

            return 0;
        }
    }
}
