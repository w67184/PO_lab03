using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    protected string title { get; set; }
    protected Person author { get; set; }
    protected int releaseDate { get; set; }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public Person Author
    {
        get { return author; }
        set { author = value; }
    }

    public int ReleaseDate
    {
        get { return releaseDate; }
        set { releaseDate = value; }
    }

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
        Console.WriteLine($"Data wydania: {ReleaseDate}\n");
    }
}