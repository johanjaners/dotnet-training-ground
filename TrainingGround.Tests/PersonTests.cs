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

    // Inline age test
    [Theory]
    [InlineData(1972, 2022, 50)]
    [InlineData(1982, 2022, 40)]
    [InlineData(1992, 2022, 30)]
    [InlineData(2022, 2022, 0)]
    public void Person_calculates_age_correctly(int birthYear, int currentYear, int expectedAge)
    {
        // arrange
        var p = new Person(birthYear);

        // act
        var age = p.GetAge(currentYear);

        // assert
        Assert.Equal(expectedAge, age);
    }


    /*  [Fact] age tests

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
    */

}