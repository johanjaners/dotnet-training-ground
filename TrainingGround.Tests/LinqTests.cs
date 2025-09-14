namespace TrainingGround;
public class LinqTests
{
    [Fact]
    public void LoopToFilesNumbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = new List<int>();
        foreach (var number in numbers)
        {
            if (number > 15)
            {
                numbersLargerThan15.Add(number);
                continue;
            }
        }
        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }

    [Fact]
    public void LinqToFilesNumbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = numbers.FindAll(number => number > 15);

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }
}


