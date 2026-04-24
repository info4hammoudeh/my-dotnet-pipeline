// This is a test file. Each [Fact] is one automated test.
using Xunit;

namespace MyApp.Tests;

public class CalculatorTests
{
    // Test 1: does 2 + 2 equal 4? (should pass)
    [Fact]
    public void Add_TwoPlusTwo_ReturnsFour()
    {
        var result = 2 + 2;
        Assert.Equal(99, result);
    }

    // Test 2: does our string work? (should pass)
    [Fact]
    public void Greeting_ReturnsHello()
    {
        var greeting = "Hello, World!";
        Assert.Contains("Hello", greeting);
    }
}
