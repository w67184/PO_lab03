using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public Person Author { get; set; }
    public int ReleaseDate { get; set; }

    public Book(string Title, Person Author, int ReleaseDate)
    {
        this.Title = Title;
        this.Author = Author;
        this.ReleaseDate = ReleaseDate;
    }
    public void View()
    {
        Console.WriteLine($"Tytul: {Title}");
        Console.WriteLine($"Autor: ");
        Author.View();
        Console.WriteLine($"Data wydania: {ReleaseDate}");
    }
}