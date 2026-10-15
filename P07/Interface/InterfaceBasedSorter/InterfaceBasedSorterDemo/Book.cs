using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasedSorterDemo
{
    class Book : ISortable
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public Book(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public int CompareTo(ISortable other)
        {
            Book otherBook = (Book)other;

            if (this.Year < otherBook.Year)
                return 1;
            else if (this.Year > otherBook.Year)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"Book(Title: {Title}, Year: {Year})";
        }
    }
}
