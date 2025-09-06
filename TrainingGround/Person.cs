public class Person
{
    public string? Name { get; set; }

    public int birthYear;
    public double LengthInMeters;

    public Person() { }
    public Person(string name)
    {
        this.Name = name;
    }
    
}