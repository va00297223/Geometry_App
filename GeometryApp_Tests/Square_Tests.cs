using GeometryApp_Library;

namespace GeometryApp_Tests
{
    [TestClass]
    public class Square_Tests
    {
        [TestMethod]
        public void TestSquareArea()
        {
            // Arrange
            var square = new Square(7);

            // Act
            var area = square.CalculateArea();

            // Assert
            Assert.AreEqual(49, area);
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            // Arrange
            var square = new Square(7);

            // Act
            var p = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(28, p);
        }
    }
}
