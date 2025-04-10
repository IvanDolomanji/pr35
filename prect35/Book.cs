using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prect35
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        protected Book(string title, string author, int year, decimal price)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
        }

        public abstract void DisplayInfo();
    }

}
