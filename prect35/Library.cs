using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prect35
{
    using System;
    using System.Collections.Generic;

    public class Library
    {
        private List<FictionBook> fictionBooks;
        private List<NonFictionBook> nonFictionBooks;
        private List<Textbook> textbooks;

        public Library()
        {
            fictionBooks = new List<FictionBook>();
            nonFictionBooks = new List<NonFictionBook>();
            textbooks = new List<Textbook>();
        }

        public void AddFictionBook(FictionBook book)
        {
            fictionBooks.Add(book);
        }

        public void AddNonFictionBook(NonFictionBook book)
        {
            nonFictionBooks.Add(book);
        }

        public void AddTextbook(Textbook book)
        {
            textbooks.Add(book);
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("\nFiction Books:");
            foreach (FictionBook book in fictionBooks)
            {
                book.DisplayInfo();
            }

            Console.WriteLine("\nNon-Fiction Books:");
            foreach (NonFictionBook book in nonFictionBooks)
            {
                book.DisplayInfo();
            }

            Console.WriteLine("\nTextbooks:");
            foreach (Textbook book in textbooks)
            {
                book.DisplayInfo();
            }
        }
    }

}
