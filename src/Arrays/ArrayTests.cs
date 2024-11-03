using Xunit;
using DSA.Arrays;

namespace DSA.Arrays
{
    public class ArrayTests
    {
        [Fact]
        public void Insert_ShouldAddElementAtSpecifiedIndex()
        {
            // Arrange
            var array = new Arrays(5);

            // Act
            array.Insert(0.10);

            // Assert
            Assert.Equal(10, array.Get(0));
        }

        [Fact]
        public void Get_ShouldReturnElementAtSpecifiedIndex()
        {
            // Arrange
            var array = new Arrays(5);
            array.Insert(0, 10);

            // Act
            int result = array.Get(0);

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Size_ShouldReturnCorrectNumberOfElements()
        {
            // Arrange
            var array = new Arrays(5);
            array.Insert(0, 10);
            array.Insert(1, 20);

            // Act
            int size = array.Size();

            // Assert
            Assert.Equal(2, size);
        }

        [Fact]
        public void Insert_ShouldAllowDuplicateValues()
        {
            // Arrange
            var array = new Array(5);
            
            // Act
            array.Insert(0, 10);
            array.Insert(1, 10);
            
            // Assert
            Assert.Equal(10, array.Get(0));
            Assert.Equal(10, array.Get(1));
        }

        [Fact]
        public void Get_ShouldThrowException_WhenArrayIsEmpty()
        {
            // Arrange
            var array = new Array(5);

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => array.Get(0));
        }

        [Fact]
        public void Size_ShouldReturnZero_WhenArrayIsEmpty()
        {
            // Arrange
            var array = new Array(5);

            // Act
            int size = array.Size();

            // Assert
            Assert.Equal(0, size);
        }

        [Fact]
        public void Delete_ShouldThrowException_WhenIndexIsOutOfBounds()
        {
            // Arrange
            var array = new Array(5);

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => array.Delete(10));
        }

        [Fact]
        public void Get_ShouldThrowException_WhenIndexIsOutOfBounds()
        {
            // Arrange
            var array = new Array(5);

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => array.Get(10));
        }

        [Fact]
        public void Insert_ShouldThrowException_WhenIndexIsOutOfBounds()
        {
            // Arrange
            var array = new Array(5);

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => array.Insert(10, 100));
        }                
    }
}