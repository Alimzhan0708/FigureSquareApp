using FigureSquareApp.Figures;

namespace FigureSquareApp
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static double CalculateFigureSquare(IFigure figure)
        {
            return figure switch
            {
                Circle => MathLib.MathLib.CalculateCircleSquare((Circle)figure),
                Triangle => MathLib.MathLib.CalculateTriangleSquare((Triangle)figure),
                _ => throw new Exception("Not supported figure type")
            };
        }
    }
}