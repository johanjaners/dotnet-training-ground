public class Person
{
    private string? Name;
    public string? Name
    {
        get { return _name; }
        set
        {
            if (value.Length > 5)
            {
                this - _name = value;
            }
        }
    }





    public int birthYear;
    public double LengthInMeters;

    public Person() { }
    public Person(string name)
    {
        this.Name = name;
    }
    
}