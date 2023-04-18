using FigureSquareApp.Figures;

namespace FigureSquareApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(25);
            var triangle = new Triangle(15, 11, 23);
            var resultCircle = CalculateFigureSquare(circle);
            var resultTriangle = CalculateFigureSquare(triangle);

            Console.WriteLine(resultCircle);
            Console.WriteLine(resultTriangle);
        }

        static double CalculateFigureSquare(IFigure figure)
        {
            return figure switch
            {
                Circle => MathLib.MathLib.CalculateCircleSquare((Circle)figure),
                Triangle => MathLib.MathLib.CalculateTriangleSquare((Triangle)figure),
                _ => 0
            };
        }
    }
}