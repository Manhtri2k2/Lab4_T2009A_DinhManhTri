namespace Part4
{
    public class Lecturers : Person
    {
        private string officeHours;
        private string rank;

        public Lecturers(string name, string phoneNumber, string email, string officeHours, string rank)
        {
            this.officeHours = officeHours;
            this.rank = rank;
        }
    }
}