namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Test1()
    {
        var actualResult = Delegate.reverseStringDelegate("virker det?");
        var expected = "?ted rekriv";
        actualResult.Should().Be(expected);
    }

    [Fact]
    public void Test2()
    {
        var actualResult = Delegate.productDoubleDelegate(3.3,3.3);
        var expected = 10.889999999999999;
        actualResult.Should().Be(expected);
    }

    [Fact]
    public void TestBoolWithoutZero()
    {
        var actualResult = Delegate.equalBoolDelegate(42, "42");
        var expected = true;
        actualResult.Should().Be(expected);
    }

    [Fact]
    public void TestBoolWithZero()
    {
        var actualResult = Delegate.equalBoolDelegate(42, "0042");
        var expected = true;
        actualResult.Should().Be(expected);
    }
}
