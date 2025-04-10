using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prect35
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Library library = new Library();

                
                library.AddFictionBook(new FictionBook("1984", "George Orwell", 1949, 19.99m, "Dystopian"));
                library.AddNonFictionBook(new NonFictionBook("A Brief History of Time", "Stephen Hawking", 1988, 25.50m, "Science"));
                library.AddTextbook(new Textbook("Mathematics for Grade 10", "Ivan Petrov", 2020, 15.00m, "10 класс"));

                
                library.DisplayAllBooks();
                Console.Read();
        }
    }

}


