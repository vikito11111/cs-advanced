using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Library library2 = new Library();

            library.AddBook(new Book("1984", 1980, 100.0M, new List<string> { "Jorge Orwell" }));

            library.AddBook(new Book("The Godfather", 1981, 150.0M, new List<string> { "Mario Puzo" }));

            library.AddBook(new Book("The Lord Of The Rings", 1954, 120, new List<string> { "J.K. Tolkin" }));

            //library.AddBook(new Book("The Lord Of The Rings", 1954, 100.0M, "J.K. Tolkin"));

            library2.AddBook(new Book("1984", 1980, 100.0M, new List<string> { "Jorge Orwell" }));

            library2.AddBook(new Book("The Godfather", 1981, 150.0M, new List<string> { "Mario Puzo" }));

            library2.AddBook(new Book("The Lord Of The Rings", 1954, 120, new List<string> { "J.K. Tolkin" }));

            library2.Books.Sort(new ComparerByPrice());

            if (library.CompareTo(library2) > 0)
            {
                Console.WriteLine("Library1 > Library2");
            }
            else if (library.CompareTo(library2) < 0)
            {
                Console.WriteLine("Library1 < Library2");
            }
            else if (library.CompareTo(library2) == 0)
            {
                Console.WriteLine("Library1 = Library2");
            }

            if (library > library2)
            {
                Console.WriteLine("Library1 > Library2");
            }
            else if (library < library2)
            {
                Console.WriteLine("Library1 < Library2");
            }
            else if (library == library2)
            {
                Console.WriteLine("Library1 = Library2");
            }

            foreach (var book in library)
            {
                Console.WriteLine($"{string.Join(", ", book.Authors)} - {book.Price} - {book.Title} ({book.Year})");
            }

            foreach (var book in library2)
            {
                Console.WriteLine($"{string.Join(", ", book.Authors)} - {book.Price} - {book.Title} ({book.Year})");
            }

            Console.ReadLine();
        }
    }
}