using System;
using System.IO;

namespace Files_ReadingInABook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linesOfBook = File.ReadAllLines("Sidewinders From Sirius by Fox B. Holden.txt");
            string book = File.ReadAllText("Sidewinders From Sirius by Fox B. Holden.txt");
            Console.WriteLine(book);

            //string book = File.ReadAllText(PATH);
        }
    }
}
