using System;
using System.Collections.Generic;

namespace _2._1._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Line> myLine = new List<Line>();
            List<Square> mySquare = new List<Square>();
            List<Rectangle> myRectangle = new List<Rectangle>();
            List<Triangle> myTriangle = new List<Triangle>();
            List<Circle> myCircle = new List<Circle>();
            List<Ring> myRing = new List<Ring>();

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1. Добавить фигуру");
                Console.WriteLine("2. Вывести фигуры");
                Console.WriteLine("3. Очистить холст");
                Console.WriteLine("4. Выход");

                var str = Console.ReadLine();
                var actionType = (byte)Enum.Parse(typeof(Act), str);

                switch (actionType)
                {
                    case 1:
                        Console.WriteLine("Выберите тип фигуры");
                        Console.WriteLine("1. Линия");
                        Console.WriteLine("2. Квадрат");
                        Console.WriteLine("3. Прямоугольник");
                        Console.WriteLine("4. Треугольник");
                        Console.WriteLine("5. Круг");
                        Console.WriteLine("6. Кольцо");
                        Console.WriteLine("7. Выход");

                        string str1 = Console.ReadLine();
                        byte figureType = (byte)Enum.Parse(typeof(TypeFigure), str1);

                        Console.WriteLine(figureType);

                        switch (figureType)
                        {
                            case 1:
                                Console.WriteLine("Введите параметры фигуры Линия");
                                Console.WriteLine("Введите координаты x1");

                                int xLine1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y1");

                                int yLine1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x2");

                                int xLine2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y2");

                                int yLine2 = int.Parse(Console.ReadLine());

                                Line line = new Line(xLine1, yLine1, xLine2, yLine2);

                                Console.WriteLine("Фигура Линия создана!");

                                myLine.Add(line);

                                break;

                            case 2:
                                Console.WriteLine("Введите параметры фигуры Квадрат");

                                Console.WriteLine("Введите координаты x1");
                                int xSquare1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y1");
                                int ySquare1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты x2");
                                int xSquare2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y2");
                                int ySquare2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты x3");
                                int xSquare3 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y3");
                                int ySquare3 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты x4");
                                int xSquare4 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y4");
                                int ySquare4 = int.Parse(Console.ReadLine());

                                Square square = new Square(xSquare1, ySquare1, xSquare2, ySquare2, xSquare3, ySquare3, xSquare4, ySquare4);

                                Console.WriteLine("Фигура Квадрат создана!");

                                mySquare.Add(square);

                                break;

                            case 3:
                                Console.WriteLine("Введите параметры фигуры Прямоугольник");

                                Console.WriteLine("Введите координаты x1");
                                int xRectangle1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y1");
                                int yRectangle1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты x2");
                                int xRectangle2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y2");
                                int yRectangle2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты x3");
                                int xRectangle3 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y3");
                                int yRectangle3 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты x4");
                                int xRectangle4 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y4");
                                int yRectangle4 = int.Parse(Console.ReadLine());

                                Rectangle rectangle = new Rectangle(xRectangle1, yRectangle1, xRectangle2, yRectangle2, xRectangle3, yRectangle3, xRectangle4, yRectangle4);

                                myRectangle.Add(rectangle);

                                Console.WriteLine("Фигура Прямоугольник создана!");

                                break;

                            case 4:
                                Console.WriteLine("Введите параметры фигуры Треугольник");

                                Console.WriteLine("Введите координаты x1");
                                int xTriangle1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y1");
                                int yTriangle1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты x2");
                                int xTriangle2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y2");
                                int yTriangle2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты x3");
                                int xTriangle3 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты y3");
                                int yTriangle3 = int.Parse(Console.ReadLine());

                                Triangle triangle = new Triangle(xTriangle1, yTriangle1, xTriangle2, yTriangle2, xTriangle3, yTriangle3);

                                myTriangle.Add(triangle);

                                Console.WriteLine("Фигура Треугольник создана!");

                                break;

                            case 5:
                                Console.WriteLine("Введите параметры фигуры Круг");

                                Console.WriteLine("Введите координаты центра x1");
                                int xCircle1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты центра y1");
                                int yCircle1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите радиус окружности");
                                int rCircle = int.Parse(Console.ReadLine());

                                Circle circle = new Circle(xCircle1, yCircle1, rCircle);

                                myCircle.Add(circle);

                                Console.WriteLine("Фигура Круг создана!");

                                break;

                            case 6:
                                Console.WriteLine("Введите параметры фигуры Кольцо");

                                Console.WriteLine("Введите координаты центра x1");
                                int xRing1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите координаты центра y1");
                                int yRing1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите радиус внешней окружности");
                                int rRadius = int.Parse(Console.ReadLine());

                                Console.WriteLine("Введите радиус внутренней окружности");
                                int rInnerRadius = int.Parse(Console.ReadLine());

                                Ring ring = new Ring(xRing1, yRing1, rRadius, rInnerRadius);

                                myRing.Add(ring);

                                Console.WriteLine("Фигура Кольцо создана!");

                                break;
                        }

                        break;

                    case 2:
                        if (myLine.Count > 0)
                        {
                            foreach (Line l in myLine)
                            {
                                Console.WriteLine("Фигура Линия");
                                Console.WriteLine($" X1 = {l.X1}");
                                Console.WriteLine($" Y1 = {l.Y1}");
                                Console.WriteLine($" X2 = {l.X2}");
                                Console.WriteLine($" Y2 = {l.Y2}");
                                Console.WriteLine($"Длина Линии = {l.GetLengh()}");
                            }
                        }

                        if (mySquare.Count > 0)
                        {
                            foreach (Square sq in mySquare)
                            {
                                Console.WriteLine("Фигура Квадрат");
                                Console.WriteLine($" X1 = {sq.X1}");
                                Console.WriteLine($" Y1 = {sq.Y1}");
                                Console.WriteLine($" X2 = {sq.X2}");
                                Console.WriteLine($" Y2 = {sq.Y2}");
                                Console.WriteLine($" X3 = {sq.X3}");
                                Console.WriteLine($" Y3 = {sq.Y3}");
                                Console.WriteLine($" X4 = {sq.X4}");
                                Console.WriteLine($" Y4 = {sq.Y4}");
                                Console.WriteLine($" Площадь = {sq.GetArea() }");

                            }
                        }

                        if (myRectangle.Count > 0)
                        {
                            foreach (Rectangle rc in myRectangle)
                            {
                                Console.WriteLine("Фигура Прямоугольник");
                                Console.WriteLine($" X1 = {rc.X1}");
                                Console.WriteLine($" Y1 = {rc.Y1}");
                                Console.WriteLine($" X2 = {rc.X2}");
                                Console.WriteLine($" Y2 = {rc.Y2}");
                                Console.WriteLine($" X3 = {rc.X3}");
                                Console.WriteLine($" Y3 = {rc.Y3}");
                                Console.WriteLine($" X4 = {rc.X4}");
                                Console.WriteLine($" Y4 = {rc.Y4}");
                                Console.WriteLine($" Площадь = {rc.GetArea()}");

                            }
                        }

                        if (myTriangle.Count > 0)
                        {
                            foreach (Triangle tri in myTriangle)
                            {
                                Console.WriteLine("Фигура Треугольник");
                                Console.WriteLine($" X1 = {tri.X1}");
                                Console.WriteLine($" Y1 = {tri.Y1}");
                                Console.WriteLine($" X2 = {tri.X2}");
                                Console.WriteLine($" Y2 = {tri.Y2}");
                                Console.WriteLine($" X3 = {tri.X3}");
                                Console.WriteLine($" Y3 = {tri.Y3}");
                                Console.WriteLine($" Длина А = {tri.GetLenghA()}");
                                Console.WriteLine($" Длина В = {tri.GetLenghB()}");
                                Console.WriteLine($" Длина С = {tri.GetLenghC()}");
                                Console.WriteLine($" Полупериметр = {tri.halfPerimetr()}");
                                Console.WriteLine($" Площадь = {tri.GetArea()}");
                            }
                        }

                        if (myCircle.Count > 0)
                        {
                            foreach (Circle cir in myCircle)
                            {
                                Console.WriteLine("Фигура Круг");
                                Console.WriteLine($" X = {cir.X1}");
                                Console.WriteLine($" Y = {cir.Y1}");
                                Console.WriteLine($" Радиус = {cir.outerRadius}");
                                Console.WriteLine($" Площадь = {cir.GetArea()}");
                                Console.WriteLine($" Длина окружности  = {cir.GetСircumscribedСircle()}");
                            }
                        }

                        if (myRing.Count > 0)
                        {
                            foreach (Ring rin in myRing)
                            {
                                Console.WriteLine("Фигура Кольцо");
                                Console.WriteLine($" X = {rin.X1}");
                                Console.WriteLine($" Y = {rin.Y1}");
                                Console.WriteLine($" OuterRadius = {rin.outerRadius}");
                                Console.WriteLine($" InnerRadius = {rin.innerRadius}");
                                Console.WriteLine($" Площадь =  {rin.GetArea()}");
                            }
                        }

                        break;

                    case 3:
                        myLine.Clear();
                        mySquare.Clear();
                        myRectangle.Clear();
                        myTriangle.Clear();
                        myCircle.Clear();
                        myRing.Clear();
                        break;

                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
