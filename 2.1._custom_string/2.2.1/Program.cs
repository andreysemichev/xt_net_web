using System;

namespace _2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player(1, 1);
            var enemy = new Enemy(2, 2);
        }
    }

    public abstract class Unit
    {
        int X { get; set; }
        int Y { get; set; }
        public abstract void Runing();
    }

    public class Player : Unit
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override void Runing()
        {
            Console.WriteLine("Я убегаю со скоростью 10");
        }
    }

    public class Enemy : Unit
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override void Runing()
        {
            Console.WriteLine("Я преследую игрока со скоростью 11");
        }

        public void Finding()
        {
            Console.WriteLine("Поиск игрока, если он дальше 3х клеток");

        }

    }

    // При столкновении уменьшается скорость на 2 ед
    public class Stone
    {
        // Препятствия
    }

    // При столкновении уменьшается скорость на 1 ед
    public class Wood
    {
        // Препятствия
    }

    // Дает возможность создать ловушку для монстра. Если он на нее настутип, то пропускает ход
    public class Banan 
    {
        // Бонусы
    }

    // Увеличивает скорость на 1 ед
    public class Cherry
    {
        // Бонусы
    }

    // Конец игры
    public class Died
    {
        // Игрок был пойман
    }
}
