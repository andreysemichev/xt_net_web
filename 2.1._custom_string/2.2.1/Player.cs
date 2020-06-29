using System;

namespace _2._2._1
{
    public class Player : Unit
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Player(int x, int y)
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
            if (x - 5 <= this.X && y - 5 <= this.Y) // Если монстр ближе 5 клеток
            {
                Console.WriteLine("Монстр очень близко");

            }
            else
            {
                Console.WriteLine("Монстр далеко");
            }
        }
    }
}
