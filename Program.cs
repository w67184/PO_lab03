using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*           Person person1 = new Person("Jaroslaw", "Kaczynski", 79);
                       Person person2 = new Person("Andrzej", "Sapkowski", 75);
                       Book book1 = new Book("Polityka", person1, 2009);
                       Book book2 = new Book("Wiedzmin", person2, 1986);
                       // book.View();
                       Reader reader1 = new Reader("Mariusz", "Jakis", 25);
                       Reader reader2 = new Reader("Adam", "Sobolewski", 33);
                       reader1.ReadBooks.Add(book1);
                       reader2.ReadBooks.Add(book2);

                       reader1.View();
                       reader2.View();

                       Reviewer reviewer1 = new Reviewer("Mariusz", "Jakis", 25);
                       Reviewer reviewer2 = new Reviewer("Adam", "Sobolewski", 33);

                       reviewer1.ReadBooks.Add(new Book("Wiedzmin", new Person("Andrzej", "Sapkowski", 75), 1986));
                       reviewer1.WypiszOceny();
                       reviewer2.ReadBooks.Add(new Book("Polityka", new Person("Jaroslaw", "Kaczynski", 79), 2009));
                       reviewer2.WypiszOceny();*/
            //    reader1.ViewBooks();
            

            List<Person> people = new List<Person>();

            Reader reader1 = new Reader("Mariusz", "Jakis", 25);
            reader1.ReadBooks.Add(new Book("Wiedzmin", new Person("Andrzej", "Sapkowski", 75), 1986));
            people.Add(reader1);

            Reader reader2 = new Reader("Adam", "Sobolewski", 33);
            reader2.ReadBooks.Add(new Book("Polityka", new Person("Jaroslaw", "Kaczynski", 79), 2009));
            people.Add(reader2);

            Reviewer reviewer1 = new Reviewer("Mariusz", "Soplica", 30);
            reviewer1.ReadBooks.Add(new Book("Wiedzmin", new Person("Andrzej", "Sapkowski", 75), 2009));
            reviewer1.WypiszOceny();
            people.Add(reviewer1);

            Reviewer reviewer2 = new Reviewer("Adam", "Sobolewski", 33);
            reviewer2.ReadBooks.Add(new Book("Polityka", new Person("Jaroslaw", "Kaczynski", 79), 2009));
            reviewer2.WypiszOceny();
            people.Add(reviewer2);

            foreach (var person in people)
            {
                person.View();
            }
        }
    }
}
