using System.Collections.Generic;

namespace PRELIM_A2_BSIT31A1_Jerome_Mendoza.Models
{
    // Represents a library that stores a collection of books
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        // Adds a book to the library collection
        public void Add(Book item)
        {
            if (item != null) Books.Add(item);
        }

        public void Remove(Book item)
        {
            if (item != null) Books.Remove(item);
        }

        public List<Book> GetAllBooks() => Books;
    }
}
