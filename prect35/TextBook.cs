using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prect35
{
    public class Textbook : Book
    {
        public string GradeLevel { get; set; }

        public Textbook(string title, string author, int year, decimal price, string gradeLevel)
            : base(title, author, year, price)
        {
            GradeLevel = gradeLevel;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Textbook] {Title} by {Author}, {Year}, ${Price}, Level: {GradeLevel}");
        }
    }

}
