using System.Net.Sockets;
using TrainingGround;

public class Person
{
    //Null is possible
    public Person() { }

    //------------------------ Name of Person--------------------------------
    // Name property, set is private
    public string? Name { get; private set; }
    //Person name constructor
    public Person(string name)
    {
        this.Name = name;
    }

    //--------------------- BirthYear // GetAge----------------------
    //BirthYear property, set is private
    public int BirthYear { get; private set; }

    // Person BirthYear contructor
    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }

    // GetAge Method using currentYear
    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }

    //----------------------Length--------------------
    // Length property, get set
    public double LengthInMeters { get; set; }


    // ---COmposition : Person HAS An Adress
    public Address? Address { get; set; }
}