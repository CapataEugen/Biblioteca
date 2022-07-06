using System;



public class BookManager : Book
{
    List<Book> AvailableBooks = new List<Book>();
    List<Book> RentedBooks = new List<Book>();

    public void AddBook(string name, string author)
    {
        book.name = Console.ReadLine();
        book.author = Console.ReadLine();   
    }

    public void RentBook(Book book.name)
    {
        if(BookList.Contains(book))
        {
            RentedBooks.Add(book);
            Console.WriteLine("The book is yours");
        }
        else
        {
            if(RentedBooks.Contains(book))
                Console.WriteLine("The book is taken");
            else
                Console.WriteLine("We don't have this book");
            
        }
    }

    public void ReturnBook(Book book)
    {
        if(RentedBooks.Contains(book))
        {
            RentedBooks.Remove(book);
            BookList.Add(book);
            Console.WriteLine("The book is returned");
        }
    }
}
