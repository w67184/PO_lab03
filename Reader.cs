using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Reader:Person
{
    public List<Book> ReadBooks { get; set; }

    public Reader(string FirstName, string LastName, int Age) : base(FirstName, LastName, Age)
    {
        ReadBooks = new List<Book>();
    }
    public void ViewBooks()
    {
        Console.WriteLine($"{FirstName} {LastName} przeczytal ksiazki");
        foreach (var book in ReadBooks)
        {
            Console.WriteLine($"- {book.Title} (Autor: {book.Author.FirstName} {book.Author.LastName})");
        }
    }
    public void View()
    {
        base.View();

        Console.WriteLine($"{FirstName} {LastName} przeczytal następujące książki:");
        ViewBooks();
    }

}