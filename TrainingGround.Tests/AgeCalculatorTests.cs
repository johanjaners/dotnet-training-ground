namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    /* previous _calculator field and constructor when using Instance method
    private AgeCalculator _calculator;

    public AgeCalculatorTests()
    {
        _calculator = new AgeCalculator();
    }
    */

    [Fact]
    public void Someone_born_1972_is_50_in_2022()
    {
        //act
        var age = AgeCalculator.GetAge(1972, 2022);
        //assert
        Assert.Equal(50, age);   
    }

    [Fact]
    public void Someone_born_2022_is_0_in_2022()
    {
        //act
        var age = AgeCalculator.GetAge(2022, 2022);
        //assert
        Assert.Equal(0, age);
    }
}
