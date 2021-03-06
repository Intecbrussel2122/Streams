using FilesWithClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesWithClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"c:\Temp\OneBook.txt";
            Book book = new Book() { Author = "Aness", Title = "C# book for advanced student in Intec", Year = 2021 };
            Sevices.WriteToFileOneBook(book, path1);


            string path = @"c:\Temp\BooksLine.txt";
            List<Book> books = new List<Book>();
            books = Sevices.PopulateBooks();

            Sevices.WriteToFile(books, path);


            List<Book> bk = Sevices.ReadFromFile(path);
            Console.WriteLine("Unsorted books");
            Console.WriteLine();
            foreach (var item in bk)
            {
                Console.WriteLine(item);
            }

            List<Book> sortedList = Sevices.ReadFromFile(path);
            sortedList.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted by name");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            //using lambda
            Console.WriteLine();
            Console.WriteLine("Sorted by year with lambda");
            List<Book> SortedListBook = bk.OrderBy(b => b.Year).ToList();
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
