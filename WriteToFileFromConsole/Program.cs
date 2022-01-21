using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFileFromConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"c:\Temp\TestConsole.txt";
            WriteToFile(file);
            ReadFromFile(file);
        }

        static void WriteToFile(string file)
        {
            StreamWriter writer = new StreamWriter(file,true,Encoding.Unicode);// if param = true Append will occure, if param = false, everything will be overwritten
            string line = string.Empty;
            do
            {
                Console.WriteLine("Enter a name please [-1 to Exite] ");
                line = Console.ReadLine();

                if (line != "-1")
                {
                    writer.WriteLine(line);
                }

            } while (line != "-1");

            writer.Flush();
            writer.Close();
        }

        static void ReadFromFile(string file)
        {
            StreamReader reader = new StreamReader(file);
            int count = 0;

            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
                count++;
            }
            Console.WriteLine($"There are {count} lines in your file");
            reader.Close();
        }
    }
}
