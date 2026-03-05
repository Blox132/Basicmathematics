namespace GeometricFigures.Backend
{

    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            Name = name;
            B = ValidateB(b);
        }

        public override double GetArea()
        {
            return A * B;
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