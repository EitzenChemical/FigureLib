using FigureLib.Entities.Figures;
using FigureLib.Entities.Figures.Base;

namespace Tests
{

    public class TriangleTest
    {
        public const double Eps = 0.001;


        [Fact]
        public void TestArea1()
        {
            // Arrange
            var p1 = new Point(5, 7);
            var p2 = new Point(9, 7);
            var p3 = new Point(10, 2);
            var f = new Triangle(new List<Point> { p1, p2, p3 });
            var result = 10;

            // Act
            var resultArea = f.GetArea();

            // Assert
            Assert.True(Math.Abs(resultArea - result) < Eps);
        }

        [Fact]
        public void TestArea2()
        {
            // Arrange
            var f = new Triangle(new List<double> { 1, 3, 3 });
            var result = 1.479;

            // Act
            var resultArea = f.GetArea();

            // Assert
            Assert.True(Math.Abs(resultArea - result) < Eps);
        }

        [Fact]
        public void TestArea3()
        {
            // Arrange
            var p1 = new Point(0, 0);
            var p2 = new Point(2, 2);
            var p3 = new Point(2, 0);
            var f = new Triangle(new List<Point> { p1, p2, p3 });
            var result = 2;

            // Act
            var resultArea = f.GetArea();

            // Assert
            Assert.True(Math.Abs(resultArea - result) < Eps);
        }

        [Fact]
        public void IsRectangular()
        {
            // Arrange
            var p1 = new Point(0, 0);
            var p2 = new Point(2, 2);
            var p3 = new Point(2, 0);
            var f = new Triangle(new List<Point> { p1, p2, p3 });

            // Act
            var resultArea = f.IsRectangular();

            // Assert
            Assert.True(resultArea);
        }

        [Fact]
        public void IsNotRectangular()
        {
            // Arrange
            var p1 = new Point(0, 1);
            var p2 = new Point(2, 2);
            var p3 = new Point(2, 0);
            var f = new Triangle(new List<Point> { p1, p2, p3 });

            // Act
            var resultArea = f.IsRectangular();

            // Assert
            Assert.False(resultArea);
        }

        [Fact]
        public void IsNotValid1()
        {
            // Arrange
            var a = 3;
            var b = 4;
            var c = 8;
            Triangle t;

            // Act
            var ex = Assert.Throws<ArgumentException>(() => t = new Triangle(new List<double> { a, b, c }));

            // Assert
            Assert.Equal("invalid triangle", ex.Message);
        }
    }
}