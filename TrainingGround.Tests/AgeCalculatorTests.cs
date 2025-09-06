namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    [Fact]
    public void Someone_born_1972_is_50_in_2022()
    {
        
        // arrange
        var calculator = new AgeCalculator();

        //act
        var age = calculator.GetAge(2022, 2022);

        //assert
        Assert.Equal(0, age);
        
    }
}
