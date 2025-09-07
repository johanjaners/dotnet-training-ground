public class Person
{
    //Null is possible
    public Person() { }

    //------------------------ Name of Person--------------------------------
    // Name property, set private
    public string? Name { get; private set; }
    //Person name constructor
    public Person(string name)
    {
        this.Name = name;
    }

    //--------------------- Birthyear // GetAge----------------------
    //BirthYear property, set private
    public int BirthYear { get; private set; }

    // Person Birthyear contructor
    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }

    // GetAge Method
    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }

    //----------------------Length--------------------
    public double LengthInMeters;
}