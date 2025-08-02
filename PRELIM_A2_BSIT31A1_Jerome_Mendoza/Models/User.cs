namespace PRELIM_A2_BSIT31A1_Jerome_Mendoza.Models
{
    // Represents a user who can borrow books from the library
    public class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }
}
