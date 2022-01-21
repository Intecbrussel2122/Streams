using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchInFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText(@"c:\Temp\TestConsole.txt").Split(' ');
            Console.WriteLine("Enter a word to be searched...");

            string searchFor = Console.ReadLine().ToLower().Trim();

            bool found=false;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(searchFor))
                {
                    found = true;
                    Console.WriteLine($"Serched term {searchFor} is found");
                    break;
                }
                else
                {
                    Console.WriteLine($"Serched term {searchFor} is NOT found");
                    
                }

            }
           
            if (found)
            {
                Console.WriteLine("It was easy to find it");
            }
            else
            {
                Console.WriteLine("It was NOT easy to find it");

            }

        }
    }
}
