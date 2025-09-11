


[Fact]
public void ShouldBeKid_WhenYoungerThan18()
{
    // arrange
    var p = new Person(2005);

    // act
    var category = AgeCalculator.GetAgeCategory(p, 2022);

    // assert
    Assert.Equal(AgeCategory.Kid, category);
}
