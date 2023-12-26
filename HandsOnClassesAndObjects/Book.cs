using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Book
    { 
        public int bookId;
        public string? bookName;
        public string? language;
        public float? price;
        public string author;
        public string publisher;
    }
    class BookRepository
    {
        public Book[] books=new Book[10];
        int index = 0;
        public void AddBook(Book book) 
        {
            if (index <= books.Length)
            {
                books[index] = book;
                index++;
            }
            else
            {
                Console.WriteLine("Book is Full!!!");
            }
        }
        public Book GetBookByName(string bookName)
        {
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if(book.bookName == bookName)
                    {
                        return book;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        public Book GetBooksByAuthor(string author)
        {
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.author == author)
                    {
                        return book;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        public Book GetBooksByPublisher(string publisher)
        {
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.publisher == publisher)
                    {
                        return book;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        public Book[] GetAllBooks()
        {
            return books;
        }
    }
    class Book_Main()
    {
        static void Main()
        {
            BookRepository bookRepository = new BookRepository();
            do
            {
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Get Book By Name");
                Console.WriteLine("3.Get Books By Author");
                Console.WriteLine("3.Get Books By Publisher");
                Console.WriteLine("5.Get All Books");
                Console.WriteLine("Enter U r Choice");
                int ch = int.Parse(Console.ReadLine());
            } while (true);
        }
    }
  /* 1. Create a Book class with following attributes
                bookId
                bookName
                language
                price
                author
                publisher
    2. Defind follwing methods in BookRepository class
                AddBook
                GetBookByName
                GetBooksByAuthor
                GetBooksByPublisher
                GetAllBooks
    3. Test all the BookRepository methods in main class using menu programming*/


}
