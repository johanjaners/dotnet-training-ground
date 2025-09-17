using Xunit.Sdk;

namespace TrainingGround;



public class CalculatorTest
{
    [Fact]
    public void CalcsumTest()
    {
        // arrange
        var Sum = new Calculator();

        // act
        var sum = Sum.Calcsum(2, 3);

        // assert
        Assert.Equal(5, sum);

    }
}