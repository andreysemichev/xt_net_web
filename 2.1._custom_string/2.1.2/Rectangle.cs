using System;

namespace _2._1._2
{
    public class Rectangle : SimpleFigure
    {
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;
        }

        public double GetLenghA()
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }

        public double GetLenghB()
        {
            return Math.Sqrt(Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2));
        }

        public override double GetArea() => GetLenghA() * GetLenghB();
    }
}
