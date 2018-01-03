using System;
using System.Collections;

namespace Delegates
{

    public struct Book
    {
        public string Title;
        public decimal Price;
        public bool Paperback;

        public Book(string title, decimal price,bool paperback)
        {
            Title = title;
            Price = price;
            Paperback = paperback;
        }
    }

    //declaring a delegate
    public delegate void ProcessBookDelegate(Book b);

    //book database + instantiating delegates
    public class BookDB
    {
        ArrayList books = new ArrayList();

        public void AddBook(string title, decimal price, bool paperback)
        {
            books.Add(new Book(title,price,paperback));
        }

        
        public void ProcessPaperbackBook(ProcessBookDelegate processBookDelegate)
        {
            foreach (Book b in books)
            {
                if (b.Paperback && processBookDelegate!=null)
                {
                    processBookDelegate(b);
                }
            }
        }
    }


    class Program
    {
        static void PrintTitle(Book book)
        {            
            Console.WriteLine("    {0}",book.Title);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Available Books : ");
            var bookdb = new BookDB();
            bookdb.AddBook("Jungle Book", 6.5m, true);
            bookdb.AddBook("Soft Computing",99.99m,false);
            bookdb.AddBook("The Greate Escape",8.9m,true);
            bookdb.AddBook("World War II",55.2m,true);

            
            bookdb.ProcessPaperbackBook(PrintTitle);
            Console.ReadKey();
        }
    }
}
