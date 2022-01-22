using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteOneLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books = PopulateBooks();
            WriteToFile(books,@"C:\temp\good.txt");
        }
        static void WriteToFile(List<Book> books, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < books.Count; i++)
                {
                   
                    sw.WriteLine(books[i]);

                    //foreach (var item in books)
                    //{
                    //    sw.WriteLine(item);

                    //}
                }
            }
        }
        static List<Book> PopulateBooks()
        {

            List<Book> books = new List<Book>();

            books.Add(new Book { Author = "Kenan", Title = "Title 3", Year = 2010 });
            books.Add(new Book { Author = "Anass", Title = "Title 4", Year = 2000 });
            books.Add(new Book { Author = "Fatih", Title = "Title 1", Year = 2003 });
            books.Add(new Book { Author = "Florian", Title = "Title 2", Year = 2008 });
            books.Add(new Book { Author = "Wouter", Title = "Title 5", Year = 2015 });

            return books;
        }
    }
}
