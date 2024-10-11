using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Library
{
    public class Library : IEnumerable<Book>, IComparable<Library>
    {
        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> Books { get; private set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public static bool operator >(Library lib1, Library lib2)
        {
            return lib1.CompareTo(lib2) > 0;
        }

        public static bool operator <(Library lib1, Library lib2)
        {
            return lib1.CompareTo(lib2) < 0;
        }

        public static bool operator ==(Library lib1, Library lib2)
        {
            return lib1.CompareTo(lib2) == 0;
        }

        public static bool operator !=(Library lib1, Library lib2)
        {
            return lib1.CompareTo(lib2) != 0;
        }

        public int CompareTo(Library other)
        {
            // negative (-1) if this is smaller than other
            // zero (0) if equal
            //positive (1) if this is bigger than other

            if (this.Books.Count > other.Books.Count)
            {
                return 1;
            }
            else if (this.Books.Count < other.Books.Count)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        //Замества писането на LibraryEnumator

        /*public IEnumerator<Book> GetEnumerator()
        {
            for (int currentIndex = 0; currentIndex < Books.Count; currentIndex++)
            {
                yield return Books[currentIndex];
            }
        }*/

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryEnumenator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    public class LibraryEnumenator : IEnumerator<Book>
    {
        private int currentIndex = -1;

        private readonly List<Book> books;

        public LibraryEnumenator(List<Book> books)
        {
            this.books = books;
        }

        public Book Current => books[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            currentIndex++;

            if (currentIndex >= books.Count)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}