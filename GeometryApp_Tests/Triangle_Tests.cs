using GeometryApp_Library;

namespace GeometryApp_Tests
{
    [TestClass]
    public class Triangle_Tests
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            // Arrange
            var triangle = new Triangle(5, 7, 8);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(10, area);
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            // Arrange
            var triangle = new Triangle(5, 7, 8);

            // Act
            var p = triangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, p);
        }
    }
}
