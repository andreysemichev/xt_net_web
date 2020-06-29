using System;

namespace _2._2._1
{
    public class Enemy : Unit
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override void Finding(int x, int y)
        {
            // Если игрок дальше 5 клеток
            if (x + 5 <= this.X && y + 5 <= this.Y)
            {
                Console.WriteLine("Координаты игрока " + x + "x" + y);
            }
            else
            {
                Console.WriteLine("Игрок очень близко");
            }
        }
    }
}
