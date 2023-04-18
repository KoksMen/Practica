using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12_4
{
    public delegate void DelegatSorted(int method);
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = {
            new Book("Книга1", "Автор1", "Издатель1"),
            new Book("МегаКнига", "МегаАвтор", "МегаИздатель"),
            new Book("БетаКнига", "БетаАвтор", "БетаИзатель"),
            new Book("ЙодоКнига", "ЙодаАвтор", "ЙодоИздатель")
        };

            var bookContainer = new BookContainer(books);

            bookContainer.SortingLibrary(new DelegatSorted(bookContainer.Sort), 1);
            bookContainer.SortingLibrary(new DelegatSorted(bookContainer.Sort), 2);
            bookContainer.SortingLibrary(new DelegatSorted(bookContainer.Sort), 3);

            Console.ReadLine();
        }
    }

    class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Publisher { get; }

        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, published by {Publisher}";
        }
    }

    class BookContainer
    {
        private Book[] books;

        public BookContainer(Book[] books)
        {
            this.books = books;
        }

        public void SortingLibrary(DelegatSorted sortDelegate, int i)
        {
            sortDelegate.Invoke(i);
        }
        public void Sort(int kret)
        {
            if (kret == 1)
            {
                Console.Write("По заголовку ");
                books = books.OrderBy(e => e.Title).ToArray();
            }
            else if (kret == 2)
            {
                Console.Write("По автору ");
                books = books.OrderBy(e => e.Author).ToArray();
            }
            else
            {
                Console.Write("По издательству ");
                books = books.OrderBy(e => e.Publisher).ToArray();
            }
            Console.WriteLine("Отсортированныи массив");
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
