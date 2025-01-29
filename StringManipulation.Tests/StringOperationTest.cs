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

    [Fact]
    public void RemoveWhitespace()
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        var result = stringOperation.RemoveWhitespace("Hello World");

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal("HelloWorld", result);
    }

    [Fact]
    public void QuantintyInWords()
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        var result = stringOperation.QuantintyInWords("cat", 10);

        // Assert
        Assert.StartsWith("ten", result);
        Assert.Contains("cat", result);
    }
}
