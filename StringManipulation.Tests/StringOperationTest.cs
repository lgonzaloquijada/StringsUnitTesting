namespace StringManipulation.Tests;

public class StringOperationTest
{
    [Fact]
    public void ConcatenateStrings()
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        var result = stringOperation.ConcatenateStrings("Hello", "World");

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void IsPalindrome_True()
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        var result = stringOperation.IsPalindrome("madam");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_False()
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        var result = stringOperation.IsPalindrome("hello");

        // Assert
        Assert.False(result);
    }
}
