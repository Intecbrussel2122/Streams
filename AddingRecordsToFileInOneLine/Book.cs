using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingRecordsToFileInOneLine
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book()
        {
            Title = " N/A";
            Author = "N/A";
            Year = 1900;
        }

        public override string ToString()
        {
            return $"{Title,-20} {Author,20} {Year}";
        }


    }
}
