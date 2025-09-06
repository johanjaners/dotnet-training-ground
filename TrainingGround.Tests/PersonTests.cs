public class PersonTests
{
    [Fact]
    public void Can_create_person_using_parameterless_constructor()
    {
        // act
        var p = new Person();

        // assert
        Assert.NotNull(p);
    }
}