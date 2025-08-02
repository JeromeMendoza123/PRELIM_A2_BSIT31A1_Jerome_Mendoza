namespace PRELIM_A2_BSIT31A1_Jerome_Mendoza.Models
{

    // Represents a book in the library
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public Author Author { get; set; }
        public bool IsBorrowed { get; set; }  // This was missing earlier

        public bool IsAvailable => !IsBorrowed;

        public Book(string title, string isbn, string genre, Author author, bool isBorrowed)
        {
            Title = title;
            ISBN = isbn;
            Genre = genre;
            Author = author;
            IsBorrowed = isBorrowed;
        }
    }
}
