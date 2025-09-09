using System.Net.Sockets;
using System.Runtime.InteropServices;
using TrainingGround;

public class Person : IPrintable
{

    



    //Null is possible, constructor
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



    //-----------------Implement IPrintable interface
    public string GetPrintString()
    {
        return @$"{this.Name} {this.Address.Street} {this.Address.StreetNo} {this.Address.City}";
    }

    //----------------------Length--------------------
    // Length property, get set
    public double LengthInMeters { get; set; }


    // ---COmposition : Person HAS An Adress
    public Address Address { get; set; }
}