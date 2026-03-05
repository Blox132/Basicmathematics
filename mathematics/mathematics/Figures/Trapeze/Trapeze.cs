namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get { return _d; }
            set { _d = value; }
        }

        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h)
        {
            Name = name;
            D = ValidateD(d);
        }

        public override double GetArea()
        {
            return ((B + D) * H) / 2;
        }

        public override double GetPerimiter()
        {
            return A + B + C + D;
        }

        private double ValidateD(double d)
        {
            if (d < 0)
            {
                return 0;
            }
            return d;
        }
    }
}