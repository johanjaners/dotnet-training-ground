using System.Buffers;
using System.Net.Sockets;
using TrainingGround;

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

    [Fact]
    public void an_employee_is_a_person()
    {
        // act
        var emp = new Employee();
        emp.LengthInMeters = 1.95;

        // assert
        Assert.IsType(typeof(Employee), emp);
        Assert.Equal(1.95, emp.LengthInMeters);
    }


    [Fact]
    public void an_employee_has_an_employeeId()
    {
        // act
        var emp = new Employee("Marcus", "234-BDAS");


        // assert
        Assert.IsType(typeof(Employee), emp);
        Assert.Equal("Marcus", emp.Name);
        Assert.Equal("234-BDAS", emp.EmployeeId);

    }

    [Fact]
    public void a_person_has_an_adress()
    {
        // arrange
        var p = new Person("Marcus");

        // act
        p.Address = new Address();
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // assert
        Assert.NotNull(p.Address);
        Assert.IsType(typeof(Address), p.Address);



    }


    [Fact]
    public void an_employee_gets_a_nice_printed_address()
    {
        // arrange
        var emp = new Employee("Marcus", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "A Street";
        emp.Address.StreetNo = 23;
        emp.Address.City = "Stockholm";

        // act
        var printString = emp.GetPrintString();

        // asswert
        Assert.Equal(@"Marcus (234-BDAS) A Street 23 Stockholm", printString);
    }

    public void Print(IPrintable printable)
    {
        var printString = printable.GetPrintString();
        Console.WriteLine(printString);
    }

    [Fact]
    public void can_print_printables()
    {
        // arrange
        var emp = new Employee("Ossian", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "B street";
        emp.Address.StreetNo = 22;
        emp.Address.City = "Malmö";

        var p = new Person("Marcus");
        p.Address = new Address();
        p.Address.Street = "A street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // act
        this.Print(p);
        this.Print(emp);

    }

    [Fact]
    public void Someonepersonbornin1972_is50_in2022()
    {
        // arrange
        var p = new Person(1982);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(40, age);
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