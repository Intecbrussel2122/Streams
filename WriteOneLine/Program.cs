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
            string path = @"C:\temp\good.txt";

            //List<Book> booksFromMethod = new List<Book>();
            //booksFromMethod = PopulateBooks();
            //WriteToFile(booksFromMethod, path);

            List<Book> booksFromFile = new List<Book>();
            booksFromFile = ReadFromFile(path);
            
            foreach (var item in booksFromFile)
            {
                Console.WriteLine(item);
            }
        }

        static List<Book> PopulateBooks()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book { Title = "Title 3,", Author = "Kenan,", Year = 2010 }); // without coma is not working problem Title 3
            books.Add(new Book { Title = "Title 4,", Author = "Anass,", Year = 2000 });
            books.Add(new Book { Title = "Title 1,", Author = "Fatih,", Year = 2003 });
            books.Add(new Book { Title = "Title 2,", Author = "Florian,", Year = 2008 });
            books.Add(new Book { Title = "Title 5,", Author = "Wouter,", Year = 2015 });
                                                 
            return books;
        }

        static void WriteToFile(List<Book> books, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (var item in books)
                {
                    sw.WriteLine(item);
                }
            }
        }
        public static List<Book> ReadFromFile(string path)
        {
            List<Book> books = new List<Book>();
            List<string> lines = File.ReadAllLines(path).ToList();

            foreach (var item in lines)
            {
                string[] field = item.Split(',');
                Book book = new Book();

                book.Title = field[0];
                book.Author = field[1];
                book.Year = Convert.ToInt32(field[2]);

                books.Add(book);
            }
            return books;
        }

    }
}
