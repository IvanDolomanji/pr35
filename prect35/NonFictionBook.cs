using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prect35
{
    public class NonFictionBook : Book
    {
        public string Subject { get; set; }

        public NonFictionBook(string title, string author, int year, decimal price, string subject)
            : base(title, author, year, price)
        {
            Subject = subject;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Non-Fiction] {Title} by {Author}, {Year}, ${Price}, Subject: {Subject}");
        }
    }

}
