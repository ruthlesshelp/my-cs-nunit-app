using MyApp;

namespace MyTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Function1_WithInputZero_ReturnsZero()
    {
        // Arrange
        var class1 = new Class1();
        int input = 0;
        int expected = 0;

        // Act
        int actual = class1.Function1(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
