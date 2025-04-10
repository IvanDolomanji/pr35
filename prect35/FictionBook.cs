using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prect35
{
        public class FictionBook : Book
        {
            public string Genre { get; set; }

            public FictionBook(string title, string author, int year, decimal price, string genre)
                : base(title, author, year, price)
            {
                Genre = genre;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"[Fiction] {Title} by {Author}, {Year}, ${Price}, Genre: {Genre}");
            }
        }

    }

