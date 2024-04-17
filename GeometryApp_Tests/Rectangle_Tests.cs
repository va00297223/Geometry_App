using GeometryApp_Library;

namespace GeometryApp_Tests
{
    [TestClass]
    public class Rectangle_Tests
    {
        [TestMethod]
        public void TestRectangleArea()
        {
            // Arrange
            var rectangle = new Rectangle(6, 7);

            // Act
            var area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(42, area);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            // Arrange
            var rectangle = new Rectangle(6, 7);

            // Act
            var p = rectangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(26, p);
        }
    }
}
