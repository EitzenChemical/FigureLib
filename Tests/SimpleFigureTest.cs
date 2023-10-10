using FigureLib.Entities.Figures;
using FigureLib.Entities.Figures.Base;

namespace Tests
{
    public class SimpleFigureTest
    {
        [Fact]
        public void TestArea1()
        {
            // Arrange
            var p1 = new Point(5, 7);
            var p2 = new Point(9, 7);
            var p3 = new Point(10, 2);
            var p4 = new Point(2, 2);
            var f = new SimpleFigure(new List<Point> { p1, p2, p3, p4 });

            // Act
            var resultArea = f.GetArea();

            // Assert
            Assert.Equal(30, resultArea);
        }

        [Fact]
        public void TestArea2()
        {
            // Arrange
            var p1 = new Point(5, 7);
            var p2 = new Point(9, 7);
            var p3 = new Point(10, 2);
            var f = new SimpleFigure(new List<Point> { p1, p2, p3 });

            // Act
            var resultArea = f.GetArea();

            // Assert
            Assert.Equal(10, resultArea);
        }

        [Fact]
        public void TestInvalidArea()
        {
            // Arrange
            var p1 = new Point(5, 7);
            var p2 = new Point(9, 7);
            var f = new SimpleFigure(new List<Point> { p1, p2 });

            // Act
            var resultArea = f.GetArea();

            // Assert
            Assert.Equal(0, resultArea);
        }
    }
}