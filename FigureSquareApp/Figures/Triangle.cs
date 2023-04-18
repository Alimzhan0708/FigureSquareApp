namespace FigureSquareApp.Figures
{
    internal class Triangle : IFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
