namespace TrainingGround;

public class ExceptionTest
{
    [Fact]
    public void NotHandlingException()
    {
        // arrange
        var i = 1;

        // act
        var result = 14 / (i - 1);
    }
}