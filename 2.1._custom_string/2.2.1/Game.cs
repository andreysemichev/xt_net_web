using System;
using System.Collections.Generic;

namespace _2._2._1
{
    public class Game
    {
        private int[] gameField = new int[2];
        private int randX;
        private int randY;

        public Game(int x, int y)
        {
            this.gameField[0] = x;
            this.gameField[1] = y;

            Console.WriteLine("Размер игрового поля - " + this.gameField[0] + "x" + this.gameField[1]);
        }

        public void start()
        {
            Random rnd = new Random();

            randX = rnd.Next(0, this.gameField[0]);
            randY = rnd.Next(0, this.gameField[1]);

            Player user1 = new Player(randX, randY); // Начальные координаты игрока

            randX = rnd.Next(0, this.gameField[0]);
            randY = rnd.Next(0, this.gameField[1]);

            Enemy enemy1 = new Enemy(randX, randY); // Начальные координаты монстра 

            List<Items> items = new List<Items>(); // Массив итемов (ловушки/бонусы)

            items.Add(new Cherry()); // Создамим первую винушку (если ни одной в рандоме не выпадет)

            randX = rnd.Next(0, this.gameField[0]);
            randY = rnd.Next(0, this.gameField[1]);

            items[0].SetItem(randX, randY);

            for (int i = 1; i < 5; i++) // Разбрасываем по полю
            {                           // 5 случайных итемов
                int rand = rnd.Next(0, 1);
                randX = rnd.Next(0, this.gameField[0]);
                randY = rnd.Next(0, this.gameField[1]);

                if (rand == 1)
                {
                    items.Add(new Stone());

                }
                else
                {
                    items.Add(new Cherry());
                }

                items[i].SetItem(randX, randY);
            }
        }
    }
}
