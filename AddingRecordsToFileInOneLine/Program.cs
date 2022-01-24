using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingRecordsToFileInOneLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\temp\Addgood.txt";
            string path = ConfigurationManager.AppSettings["file"];

            List<Book> booksFromMethod = new List<Book>();
            booksFromMethod = PopulateBooks();
            WriteToFile(booksFromMethod, path);


            ////Add new record
            Book newBook = new Book();
            newBook.Title = "Sql Databases,";
            newBook.Author = "Olga,";
            newBook.Year = 2021;
            booksFromMethod.Add(newBook);

            ////Add another new record
            Book newBook1 = new Book();
            newBook1.Title = "C# design patterns,";
            newBook1.Author = "Serap,";
            newBook1.Year = 2021;
            booksFromMethod.Add(newBook1);

            WriteToFile(booksFromMethod, path);


            // show items as string
            //List<string> booksFromFile = new List<string>();
            //booksFromFile = ReadAndDisplayAsString(path);

            //foreach (var item in booksFromFile)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"This is total {total}"); // will not work


            List<Book> booksFromFile = new List<Book>();
            booksFromFile = ReadFromFile(path);
            int total = 0;
            foreach (var item in booksFromFile)
            {
                Console.WriteLine(item);
                total += item.Year;
            }
            Console.WriteLine($"This is total {total}");
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

                for (int i = 0; i < books.Count; i++) 
                {
                    sw.Write(books[i].Title);
                    sw.Write(books[i].Author);
                    sw.WriteLine(books[i].Year);
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

        static List<string> ReadAndDisplayAsString(string path) // order very important
        {
            List<string> booksAsString = new List<string>();
            FileInfo file = new FileInfo(path);
            using (StreamReader sr = file.OpenText())
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    booksAsString.Add(line);
                }
                return booksAsString;
            }
        }
    }
}
