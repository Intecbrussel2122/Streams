using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] textToWrite =
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit,",
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris",
                "nisi ut aliquip ex ea commodo consequat dot net c#."
            };

            string fileName = @"c:\Temp\test.txt";
            FileInfo file = new FileInfo(fileName);

            if (file.Exists)
            {
                file.Delete();
                file.Create().Close();
            }
            else
            {
                file.Create().Close();
            }

            using (StreamWriter sw = file.AppendText())
            {
                foreach (var item in textToWrite)
                {
                    sw.WriteLine(item);
                }
            }

            using (StreamReader sr = file.OpenText())
            {
                string line = string.Empty;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
