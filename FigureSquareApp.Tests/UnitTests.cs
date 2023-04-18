using FigureSquareApp.Figures;

namespace FigureSquareApp.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 28)]
        public void IsCircleSquareRight(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var resultCircle = Program.CalculateFigureSquare(circle);
            resultCircle = Math.Round(resultCircle);

            // Assert
            Assert.Equal(expected, resultCircle);
        }

        [Theory]
        [InlineData(15, 11, 22, 75)]
        [InlineData(3, 4, 5, 6)]
        public void IsTriangleSquareRight(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var resultTriangle = Program.CalculateFigureSquare(triangle);
            resultTriangle = Math.Round(resultTriangle);

            // Assert
            Assert.Equal(expected, resultTriangle);
        }

        [Theory]
        [InlineData(15, 11, 22, false)]
        [InlineData(3, 4, 5, true)]
        public void IsTriangleRightangled(double a, double b, double c, bool expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var isRightangled = triangle.IsRightangled();

            // Assert
            Assert.Equal(expected, isRightangled);
        }
    }
}
