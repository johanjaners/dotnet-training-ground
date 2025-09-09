namespace TrainingGround
{
    public class Employee : Person, IPrintable
    {
        public Employee() { }
        public Employee(string name, string employeeId) : base(name)
        {
            this.EmployeeId = employeeId;
        }
    
        public string EmployeeId { get; set; }

        public string GetPrintString()
        {
            throw new NotImplementedException();
        }
    }
}