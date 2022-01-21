using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesWithClasses.Models
{
    public class Sevices
    {

        public static void WriteToFile(List<Book> books, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < books.Count; i++)
                {
                    sw.WriteLine(books[i].Title );
                    sw.WriteLine(books[i].Author);
                    sw.WriteLine(books[i].Year);
                }
            }
        }

        public static void WriteToFileOneBook(Book book, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                Book b = new Book();
                sw.WriteLine(b.Title = book.Title);
                sw.WriteLine(b.Author = book.Author);
                sw.WriteLine(b.Year = Convert.ToInt32(book.Year));
            }
        }

        public static List<Book> ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                List<Book> lines = new List<Book>();

                while (!sr.EndOfStream)
                {
                    Book b = new Book();
                    b.Title = sr.ReadLine();
                    b.Author = sr.ReadLine();
                    b.Year = Convert.ToInt32(sr.ReadLine());
                    lines.Add(b);
                } 
                return lines;   
            }
        }
        public static List<Book> PopulateBooks()
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
