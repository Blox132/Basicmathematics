namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get { return _d1; }
            set { _d1 = value; }
        }

        public double D2
        {
            get { return _d2; }
            set { _d2 = value; }
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = ValidateD1(d1);
            D2 = ValidateD2(d2);
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimiter()
        {
            return 4 * A;
        }

        private double ValidateD1(double d1)
        {
            if (d1 < 0) return 0;
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 < 0) return 0;
            return d2;
        }
    }
}
