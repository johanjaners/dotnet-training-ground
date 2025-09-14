using System.Collections.Generic;

namespace TrainingGround
{
    public class Employee : Person, IPrintable
    {
        public Employee() { }

        /* Construcor, explicit
         public Employee()
        {
            this.Addresses = new List<Address>();
        }
        */

        public Employee(string name, string employeeId) : base(name)
        {
            //  this.Addresses = new List<Address>();
            this.EmployeeId = employeeId;
        }

        public string EmployeeId { get; set; }

        public string GetPrintString()
        {
            return @$"{this.Name} ({this.EmployeeId}) {this.Address.Street} {this.Address.StreetNo} {this.Address.City}";
        }

        // initializer instead of constructor
        public List<Address> Addresses { get; } = new();
    }
}