using FigureLib.Entities.Figures;

namespace Tests
{

    public class CircleTest
    {
        public const double Eps = 0.001;
        public double Result(int r) => Math.PI * r * r;

        [Fact]
        public void TestArea()
        {
            // Arrange
            var r = 10;
            var c = new Circle(r);

            // Act
            var resultArea = c.GetArea();

            // Assert
            Assert.True(Math.Abs(resultArea - Result(r)) < Eps);
        }

        [Fact]
        public void TestInvalidRadius()
        {
            // Arrange
            var r = 0;
            Circle c;

            // Act
            var ex = Assert.Throws<ArgumentException>(() => c = new Circle(r));

            // Assert
            Assert.Equal("invalid circle", ex.Message);
        }
    }
}