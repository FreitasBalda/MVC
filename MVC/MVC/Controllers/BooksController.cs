using Microsoft.AspNetCore.Mvc;
using MVC.Models; 

public class BooksController : Controller
{
        
    private static List<Book> books = new List<Book>
    {   
        new Book { Id = 1, Title = "O Livro", Author = "Autor do (O Livro)", Genre = "Livro", PublishedYear = 1999, Description = "Um livro" },
        new Book { Id = 2, Title = "O Livro 2", Author = "Autor do (O Livro)", Genre = "Livro", PublishedYear = 2000, Description = "Dois livro" },
        new Book { Id = 3, Title = "O Livro 3", Author = "Autor do (O Livro)", Genre = "Livro", PublishedYear = 2020, Description = "Tres livro" }
    };

    public IActionResult Index()
    {
        return View(books);
    }

    public IActionResult Details(int id)
    {
        var book = books.Find(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book);
    }
}
