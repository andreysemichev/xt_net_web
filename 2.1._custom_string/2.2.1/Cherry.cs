using System;

namespace _2._2._1
{
    public class Cherry : Items // Бонус
    {
        public override int GetEffect(int x, int y)
        {
            if (this.x == x && this.y == y)
            {
                Console.WriteLine("Дополнительный ход");

                return 1;
            }

            return 0;
        }
    }
}
