using System;

namespace Book;

class BookManager
{
    List<Book> AvailableBooks = new List<Book>();
    List<Book> RentedBooks = new List<Book>();

    public bool AddBook(Book book)
    {
        AvailableBooks.Add(book);
        return true;
    }

    public bool RentBook(Book book)
    {
        if(AvailableBooks.Exists(x => (x._name == book._name)))
        {
            RentedBooks.Add(book);
            return true;
        }
        else
        {
            Console.WriteLine("indisponibila");
            return false;
        }
    }

    public bool ReturnBook(Book book)
    {
        RentedBooks.Remove(book);
        AvailableBooks.Add(book);

        return true;
    }

}
