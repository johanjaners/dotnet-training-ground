public class PersonTests
{
    [Fact]
    public void Can_create_person_using_parameterless_constructor()
    {
        // arrange
        var p = new Person();
        p.birthYear = 1972;

        //
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);
    }
}