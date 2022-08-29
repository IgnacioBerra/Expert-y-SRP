using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Biblioteca bookUno = new Biblioteca();
            bookUno.ShelveBook(book1,"A","7");
            Biblioteca bookDos = new Biblioteca();
            bookDos.ShelveBook(book2,"B","3");
            Console.WriteLine($"El sector del libro {book1.Title} es {bookUno.LibrarySector} y la estanteria es {bookUno.LibraryShelve}.");
            Console.WriteLine($"El sector del libro {book2.Title} es {bookDos.LibrarySector} y la estanteria es {bookDos.LibraryShelve}.");
        }
    }
}