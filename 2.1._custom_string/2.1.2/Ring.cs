using System;

namespace _2._1._2
{
    public class Ring : SimpleFigure
    {

        public Ring(int x, int y, int outRadius, int inRadius)
        {
            X1 = x;
            Y1 = y;
            outerRadius = outRadius;
            innerRadius = inRadius;
            if (innerRadius >= outerRadius)
            {
                throw new ArgumentException("Внутренний радиус не должен быть больше или равен внешнему радиусу");
            }
        }

        public override double GetArea() => Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius);
        public double GetTotalLenght() => (2 * Math.PI * outerRadius) + (2 * Math.PI * innerRadius);
    }
}
