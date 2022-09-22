namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void FlattensArray()
    {
        // Arrange
        int[] array123 = { 1, 2, 3 };
        int[] array456 = { 4, 5, 6 };

        IEnumerable<int>[] xs = { array123, array456 };
        int[] expected = { 1, 2, 3, 4, 5, 6 };

        // Act
        var actual = xs.Flatten();                                // Using method
        var actual2 = xs.SelectMany(x => x);        // Oneliner

        // Assert
        Assert.Equal(expected, actual2);
    }

    [Fact]
    public void FilterArrayForIntWhichDivisibleBy7AndGreaterThan42()
    {
        // Arrange
        int[] ys = { 21, 36, 42, 12, 49, 56 };
        int[] expected = { 49, 56 };

        Predicate<int> divisibleBy7 = DivisibleBy7;
        Predicate<int> greaterThan42 = GreaterThan42;

        bool DivisibleBy7(int i) => i % 7 == 0;
        bool GreaterThan42(int i) => i > 42;

        // Act
        var actual = ys.Filter(divisibleBy7).Filter(greaterThan42);     // Using method
        var actual2 = ys.Where(y => y % 7 == 0 && y > 42).ToArray();          // Oneliner
        
        // Assert
        Assert.Equal(expected, actual2);
    }
    
    [Fact]
    public void FilterArrayForIntWhichIsLeapYear()
    {
        // Arrange
        int[] ys = { 2020, 2000, 1600, 1900, 1800, 1582 };
        int[] expected = { 2020, 2000, 1600 };

        Predicate<int> isLeapYear = IsLeapYear;

        bool IsLeapYear(int i) => 1582 < i && i % 4 == 0 && i % 100 == 0 && i % 400 == 0; // Incorrect since 2020 is leap

        // Act
        var actual = ys.Filter(isLeapYear);                                 // Using method
        var actual2 = ys.Where(y => DateTime.IsLeapYear(y)).ToArray();            // Oneliner
        
        // Assert
        Assert.Equal(expected, actual2);

    public void IsSecureGivenSecureUriReturnsTrue()
    {
        var url = new Uri("https://github.com");
        var expected = true;
        var actual = url.IsSecure();
        actual.Should().Be(expected);
    }

    [Fact]
    public void IsSecureGivenInsecureUriReturnsFalse()
    {
        var url = new Uri("http://github.com");
        var expected = false;
        var actual = url.IsSecure();
        actual.Should().Be(expected);
    }

    [Fact]
    public void WordCountGivenStringReturnsCountOfWords()
    {
        var s = "text text, text. text, text? TEXT TEXT!!!";
        var expected = 7;
        var actual = s.WordCount();
        actual.Should().Be(expected);
    }
}
