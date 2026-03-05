namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public Kite(string name, double a, double b, double d1, double d2)
            : base(name, a, d1, d2)
        {
            Name = name;
            B = ValidateB(b);
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimiter()
        {
            return 2 * (A + B);
        }

        private double ValidateB(double b)
        {
            if (b < 0)
            {
                return 0;
            }
            return b;
        }
    }
}