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
            Person person = new Person("Jaroslaw", "Kaczynski", 75);
            Book book = new Book("Wiedzmin", new Person("Andrzej", "Sapkowski", 75), 1986);
            // book.View();
            Reader reader1 = new Reader("Mariusz", "Jakis", 25);
            reader1.ReadBooks.Add(book);

            reader1.View();
        //    reader1.ViewBooks();
        }
    }
}
