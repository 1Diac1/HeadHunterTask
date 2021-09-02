using HeadHunterTaskLibrary.Shapes;
using Xunit;

namespace HeadHunterTaskLibraryTests
{
    public class ShapeTests
    {
        [Fact]
        public void AreaOfCircle_20Radius_1256Dot6371Returned()
        {
            // Arrange
            var circle = new Circle("First circle", 20);

            // Act
            var result = circle.GetArea();

            // Assert
            Assert.Equal(1256.6371, result);
        }

        [Fact]
        public void AreaOfTriangle_5And12And13_30Returned()
        {
            // Arrange
            var triangle = new Triangle("First triangle", 5, 12, 13);

            // Act
            var result = triangle.GetArea();

            // Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void IsTriangleRectangular_IsRectangular_TrueReturned()
        {
            // Arrange
            var triangle = new Triangle("First triangle", 5, 12, 13);

            // Act
            var result = triangle.IsTriangleRectangular();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsTriangleExist_IsExist_TrueReturned()
        {
            // Arrange
            var triangle = new Triangle("First triangle", 3, 4, 5);

            // Act
            var result = triangle.IsTriangleExist();

            // Assert
            Assert.True(result);
        }
    }
}
