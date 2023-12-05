using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public void View()
    {
        Console.WriteLine($"Imie: {FirstName}");
        Console.WriteLine($"Nazwisko: {LastName}");
        Console.WriteLine($"Wiek: {Age}");
    }
}
