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
        Console.WriteLine($"{firstname} {lastname} przeczytal ksiazki");
        foreach (var book in ReadBooks)
        {
            Console.WriteLine($"- {book.Title} (Autor: {book.Author.firstname} {book.Author.lastname})\n");
        }
    }
    public override void View()
    {
        base.View();
        ViewBooks();
    }

}