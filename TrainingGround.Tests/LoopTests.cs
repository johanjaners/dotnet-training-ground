using System.Runtime.CompilerServices;

namespace TrainingGround;



public class LoopTests
{
    [Fact]
    public void WhileLoop()
    {
        // arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };

        // act
        var i = 0;
        while (i < ints.Length)
        {
            var currentValueInTheLoop = ints[i];

            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

            //
            Assert.Equal(i + 1, currentValueInTheLoop);

            i = i + 1;
        }
    }


    [Fact]
    public void ForLoop()
    {
        // arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };

        // act
        for (var i = 0; i < ints.Length; i++)
        {
            var currentValueInTheLoop = ints[i];

            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

            // assert
            Assert.Equal(i + 1, currentValueInTheLoop);
        }
    }


    [Fact]
    public void ForEachLoop()
    {
        // arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };
        int i = 0;

        // act
        foreach (var currentValueInTheLoop in ints)
        {
            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");
            i++;

            // assert
            Assert.IsType<int>(currentValueInTheLoop);
        }
    }

    [Fact]
    public void ForEachLoopOverAddresses()
    {
        // arrange
        var addressList = new List<Address>();
        addressList.Add(new Address() { Street = "street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "street", StreetNo = 3 });

        // act

        foreach (Address address in addressList)
        {
            Console.WriteLine("'{ address.StreetNo}'");

            // act
            Assert.IsType<Address>(address);
        }

    }


    [Fact]
    public void BreakStopsLoops()
    {
        // arrange
        var addressList = new List<Address>();
        addressList.Add(new Address() { Street = "street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "street", StreetNo = 3 });

        // act
        var foundIt = false;
        foreach (var currentValueInTheLoop in addressList)
        {
            if (currentValueInTheLoop.StreetNo == 2)
            {
                foundIt = true;
                break; //stop iterating
            }
        }

    }

}



