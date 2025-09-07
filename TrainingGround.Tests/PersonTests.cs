public class PersonTests
{
    [Fact]
    public void Can_create_person_using_parameterless_constructor()
    {
        // arrange
        var p = new Person("Marcus");

        // assert
        Assert.NotNull(p);
        Assert.Equal("Marcus", p.Name);
    }


    [Fact]
    public void A_person_born_1972_is_50_2022()
    {
        // arrange
        var p = new Person(1972);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);
    }

    [Fact]
    public void A_person_born_1982_is_40_2022()
    {
        // arrange
        var p = new Person(1982);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(40, age);
    }

    [Fact]
    public void A_person_born_1992_is_30_2022()
    {
        // arrange
        var p = new Person(1992);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(30, age);
    }

    [Fact]
    public void A_person_born_2022_is_0_2022()
    {
        // arrange
        var p = new Person(2022);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(0, age);
    }

}