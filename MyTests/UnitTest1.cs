namespace MyTests;

using MyApp;

internal sealed class UnitTest1
{
    [SetUp]
    public void Setup()
    {
    }

    // 0 => { 1, 0, 5, 0, 10, 0, 25, 0 }
    [Test]
    public void TestFunction2_WithInputZero_ReturnsZero()
    {
        // Arrange
        var classUnderTest = new Class1();
        classUnderTest.Function1(0);
        int expected = 0;

        // Act
        var result = classUnderTest.Function2();

        // Assert
        int actual = TestHelper.CalculateSum(result);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
