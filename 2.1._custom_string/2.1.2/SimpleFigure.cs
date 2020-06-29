using System;

namespace _2._1._2
{
    public abstract class SimpleFigure
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
        public int X4 { get; set; }
        public int Y4 { get; set; }

        private int _inner_radius;
        public int innerRadius
        {
            get { return _inner_radius; }
            set
            {
                if (value <= 0) throw new ArgumentException("Радиус должен быть позитивным");
                _inner_radius = value;
            }
        }

        private int _outer_radius;
        public int outerRadius
        {
            get { return _outer_radius; }
            set
            {
                if (value <= 0) throw new ArgumentException("Радиус должен быть позитивным");
                _outer_radius = value;
            }
        }

        public abstract double GetArea();
    }
}
