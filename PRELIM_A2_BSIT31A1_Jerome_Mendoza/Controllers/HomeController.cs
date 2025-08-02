using Microsoft.AspNetCore.Mvc;
using PRELIM_A2_BSIT31A1_Jerome_Mendoza.Models;
using System.Collections.Generic;

namespace PRELIM_A2_BSIT31A1_Jerome_Mendoza.Controllers
{
    public class HomeController : Controller
    {
        // Displays a list of books with authors to the home page
        public IActionResult Index()
        {
            var author1 = new Author("George", "Orwell", "Known for dystopian novels.");
            var author2 = new Author("J.K.", "Rowling", "Author of the Harry Potter series.");
            var author3 = new Author("Harper", "Lee", "Famous for 'To Kill a Mockingbird'.");
            var author4 = new Author("F. Scott", "Fitzgerald", "Wrote 'The Great Gatsby'.");
            var author5 = new Author("J.R.R.", "Tolkien", "Author of 'The Lord of the Rings'.");
            var author6 = new Author("Mary", "Shelley", "Pioneer of science fiction.");
            var author7 = new Author("Dan", "Brown", "Thriller novel writer.");

            var books = new List<Book>
    {
        new Book("1984", "1234567890", "Dystopian", author1, true),
        new Book("Harry Potter and the Philosopher's Stone", "0987654321", "Fantasy", author2, false),
        new Book("To Kill a Mockingbird", "1111222233", "Classic", author3, true),
        new Book("The Great Gatsby", "2222333344", "Tragedy", author4, false),
        new Book("The Hobbit", "3333444455", "Fantasy", author5, true),
        new Book("Frankenstein", "4444555566", "Science Fiction", author6, true),
        new Book("The Da Vinci Code", "5555666677", "Thriller", author7, false)
    };

            return View(books);
        }
        // Returns the static privacy view
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
