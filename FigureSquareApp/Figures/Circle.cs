namespace FigureSquareApp.Figures
{
    internal class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
