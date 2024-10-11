using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Library
{
    public class Book : IComparable<Book>
    {
        //public Book(string title, int year, params string[] authors)

        public Book(string title, int year, decimal price, List<string> authors)
        {
            Title = title;

            Year = year;

            Price = price;

            Authors = authors;

            //Authors = authors.ToList();
        }

        public int CompareTo(Book other)
        {
            if (this.Year > other.Year)
            {
                return 1;
            }
            else if (this.Year < other.Year)
            {
                return -1;
            }
            else
            {
                //return this.Title.CompareTo(other.Title); //Ако не ми се пишат if-ове

                if (this.Title.Length > other.Title.Length)
                {
                    return 1;
                }
                else if (this.Title.Length < other.Title.Length)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public List<string> Authors { get; private set; }

        public decimal Price { get; set; }
    }
}