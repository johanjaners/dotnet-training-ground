public class Person
{
    //Null is possible
    public Person() { }
    //------------------------ Name --------------------------------
    public string? Name { get; private set; }
    public Person(string name)
    {
        this.Name = name;
    }
    //--------------------- Birthyear // GetAge----------------------
    public int BirthYear { get; private set; }

    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }

    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }
    //----------------------Length--------------------
    public double LengthInMeters;
}