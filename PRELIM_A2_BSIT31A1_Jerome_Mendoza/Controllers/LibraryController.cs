using Microsoft.AspNetCore.Mvc;
using PRELIM_A2_BSIT31A1_Jerome_Mendoza.Models;
using System.Collections.Generic;

namespace PRELIM_A2_BSIT31A1_Jerome_Mendoza.Controllers
{
    public class LibraryController : Controller
    {
        // Displays a different list of books as a sample library catalog
        public IActionResult Index()
        {
            var author1 = new Author("George", "Orwell", "george.orwell@example.com");
            var author2 = new Author("J.K.", "Rowling", "jk.rowling@example.com");

            var books = new List<Book>
            {
                new Book("1984", "123-ABC", "Dystopian", author1, false),
                new Book("Harry Potter", "456-DEF", "Fantasy", author2, true)
            };

            return View(books);
        }
    }
}
