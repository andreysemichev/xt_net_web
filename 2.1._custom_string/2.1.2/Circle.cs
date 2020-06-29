using System;

namespace _2._1._2
{
    public class Circle : SimpleFigure
    {
        public Circle(int x, int y, int outR)
        {
            X1 = x;
            Y1 = y;
            outerRadius = outR;
        }

        public override double GetArea() => Math.PI * outerRadius * outerRadius;
        public double GetСircumscribedСircle() => 2 * Math.PI * outerRadius;
    }
}
