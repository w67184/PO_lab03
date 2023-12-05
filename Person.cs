using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private int Age { get; set; }

    public string firstname
    {
        get { return FirstName; }
        set { FirstName = value; }
    }
    public string lastname
    {
        get { return LastName; }
        set { LastName = value; }
    }
    public int age
    {
        get { return Age; }
        set { Age = value; }
    }
    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public virtual void View()
    {
        Console.WriteLine($"Imie: {FirstName}");
        Console.WriteLine($"Nazwisko: {LastName}");
        Console.WriteLine($"Wiek: {Age}\n");
    }
}
