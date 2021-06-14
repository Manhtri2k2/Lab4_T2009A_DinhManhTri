namespace Part4
{
    public class Student : Person
    {
        private string faculty;

        public Student(string name, string phoneNumber, string email, string faculty) : base(name, phoneNumber, email)
        {
            this.faculty = faculty;
        }
    }
}