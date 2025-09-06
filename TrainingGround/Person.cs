public class Person
{


    private string? Name;
    public string GetName
    {
        return this.Name;
    }




    public string SetName(string nameToSet)
    {
        if (nameToSet.Length > 5)
        {
            this.Name = nameToSet
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