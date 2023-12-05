using System;
class Reviewer : Reader
{
    public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

    public void WypiszOceny()
    {
        Random rand = new Random();
        foreach (var book in ReadBooks)
        {
            Console.WriteLine($"{book.Title} - Ocena: {rand.Next(1, 6)}\n");
        }
    }
}