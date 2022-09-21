namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
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
