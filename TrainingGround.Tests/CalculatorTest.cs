using Xunit.Sdk;

namespace TrainingGround;



public class CalculatorTest
{
    [Fact]
    public void Calcsum_calcdiff_Test()
    {
        // arrange
        var Sum = new Calculator();
        // act
        var sum = Sum.Calcsum(2, 3);
        // assert
        Assert.Equal(5, sum);
    }

    [Fact]
    public void Calcdiff_Test()
    {
        // arrange
        var Diff = new Calculator();
        // act
        var diff = Diff.Calcdiff(10, 3);
        // assert
        Assert.Equal(7, diff);
    }
}