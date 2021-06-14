namespace Part4
{
    public class Employee : Person
    {
        private string department;
        private string salary;
        private string dateHired;

        public Employee(string name, string phoneNumber, string email, string department, string salary,
            string dateHired) : base(name, phoneNumber, email)
        {
            this.department = department;
            this.salary = salary;
            this.dateHired = dateHired;
        }
    }
}