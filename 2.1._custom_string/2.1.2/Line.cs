using System;

namespace _2._1._2
{
    public class Line : SimpleFigure
    {

        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public double GetLengh()
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }

        public override double GetArea() => -1;
    }
}
