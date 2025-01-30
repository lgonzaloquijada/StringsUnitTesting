namespace StringManipulation.Tests;

public class StringOperationTest
{
    [Fact(Skip = "This isn't a valid test for now")]
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

    [Theory]
    [InlineData("Hello", false)]
    [InlineData("madam", true)]
    public void IsPalindrome(string input, bool expected)
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        var result = stringOperation.IsPalindrome(input);

        // Assert
        Assert.Equal(result, expected);
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

    [Fact]
    public void GetStringLength_Exception()
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        Action act = () => stringOperation.GetStringLength(null);

        // Assert
        var exception = Assert.Throws<ArgumentNullException>(act);
        Assert.NotNull(exception);
    }

    [Fact]
    public void TruncateString()
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        var result = stringOperation.TruncateString("Hello World", 5);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal("Hello", result);
    }

    [Fact]
    public void TruncateString_Exception()
    {
        // Arrange
        var stringOperation = new StringOperations();

        // Act
        Action act = () => stringOperation.TruncateString("Hello World", 0);

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(act);
        Assert.NotNull(exception);
    }

    [Theory]
    [InlineData("III", 3)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    public void FromRomanToNumber(string romanNumber, int expected)
    {
        var stringOperation = new StringOperations();

        var result = stringOperation.FromRomanToNumber(romanNumber);

        Assert.Equal(expected, result);
    }
}
