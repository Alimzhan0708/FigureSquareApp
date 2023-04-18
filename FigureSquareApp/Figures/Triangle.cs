namespace FigureSquareApp.Figures
{
    public class Triangle : IFigure
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

        public bool IsRightangled()
        {
            if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2)) return true;
            return false;
        }
    }
}
