namespace TrainingGround
{
    public class Employee : Person
    {
        public Employee() { }
        public Employee(string name, string employeeId) : base(name)
        {
            this.EmployeeId = employeeId;
        }
    
        public string EmployeeId { get; set; }
    }
}