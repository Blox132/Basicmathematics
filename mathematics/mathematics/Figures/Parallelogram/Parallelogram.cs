namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        public Parallelogram(string name, double a, double b, double h)
            : base(name, a, b)
        {
            Name = name;
            H = ValidateH(h);
        }

        public override double GetArea()
        {
            return B * H;
        }

        public override double GetPerimiter()
        {
            return 2 * (A + B);
        }

        private double ValidateH(double h)
        {
            if (h < 0)
            {
                return 0;
            }
            return h;
        }
    }
}