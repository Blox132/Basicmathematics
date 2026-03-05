namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public string Name
        {
            get;
            set;
        } = null!;

        public abstract double GetArea();
        public abstract double GetPerimiter();
        public override string ToString()
        {
            double area = GetArea();
            double perimeter = GetPerimiter();

            return Name.PadRight(13) + " => " +
                   "Area.....: " + area.ToString("F5").PadLeft(12) + "    " +
                   "Perimiter: " + perimeter.ToString("F5").PadLeft(12);
        }
    }
}