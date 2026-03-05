namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;
        public double R 
        { 
            get { return _r; }
            set { _r = value; }
        }

        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override double GetPerimiter()
        {
            return 2 * Math.PI * R;
        }

        private double ValidateR(double r)
        {
            if (r < 0)
            {
                return 0;
            }
            return r;
        }
    }
}
