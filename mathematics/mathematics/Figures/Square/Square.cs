namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;
        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public Square(string name, double a)
        {
            Name = name;
            A = ValidateA(a);
        }

        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimiter()
        {
            return 4 * A;
        }

        private double ValidateA(double a)
        {
            if (a < 0)
            {
                return 0;
            }
            return a;
        }
    }
}