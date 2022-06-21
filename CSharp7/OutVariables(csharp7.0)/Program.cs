using System;


/// <summary>
/// can define a method's out parameters directly in the method
/// </summary>
namespace OutVariables_V7_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthorByOutParam(out string authorName, out string bookTitle, out long publishedYear);
            Console.WriteLine("Author: {0}, Book: {1}, Year: {2}",
            authorName, bookTitle, publishedYear);
            Console.ReadKey();
        }

        static void AuthorByOutParam(out string name, out string title, out long year)
        {
            name = "Mahesh Chand";
            title = "A Programmer's Guide to ADO.NET with C#";
            year = 2001;
        }
    }
}
