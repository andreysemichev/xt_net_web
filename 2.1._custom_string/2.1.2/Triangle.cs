using System;

namespace _2._1._2
{
    public class Triangle : SimpleFigure
    {
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }

        public double GetLenghA()
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }

        public double GetLenghB()
        {
            return Math.Sqrt(Math.Pow((X2 - X3), 2) + Math.Pow((Y2 - Y3), 2));
        }

        public double GetLenghC()
        {
            return Math.Sqrt(Math.Pow((X3 - X1), 2) + Math.Pow((Y3 - Y1), 2));
        }

        public double halfPerimetr()
        {
            return (GetLenghA() + GetLenghB() + GetLenghC()) / 2;
        }

        public override double GetArea()
        {
            return Math.Sqrt(halfPerimetr() * (halfPerimetr() - GetLenghA()) * (halfPerimetr() - GetLenghB()) * (halfPerimetr() - GetLenghC()));
        }
    }
}
