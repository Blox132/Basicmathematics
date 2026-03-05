namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        public Triangle(string name, double a, double b, double c, double h)
            : base(name, a, b)
        {
            Name = name;
            C = ValidateC(c);
            H = ValidateH(h);
        }

        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimiter()
        {
            return A + B + C;
        }

        private double ValidateC(double c)
        {
            if (c < 0) return 0;
            return c;
        }

        private double ValidateH(double h)
        {
            if (h < 0) return 0;
            return h;
        }
    }
}