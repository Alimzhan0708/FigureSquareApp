using FigureSquareApp.Figures;

namespace FigureSquareApp.MathLib
{
    internal static class MathLib
    {
        internal static double CalculateCircleSquare(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        internal static double CalculateTriangleSquare(Triangle triangle)
        {
            double p = (triangle.A + triangle.B + triangle.C) / 2;
            double S = Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
            return S;
        }
    }
}
