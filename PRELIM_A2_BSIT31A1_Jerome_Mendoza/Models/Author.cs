namespace PRELIM_A2_BSIT31A1_Jerome_Mendoza.Models
{
    // Represents an author of a book
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Author(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
