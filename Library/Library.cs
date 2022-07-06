using System;


public sealed class Library
{
    private UserManager usermanager = new UserManager();
    private BookManager bookmanager = new BookManager();
    public bool Login(string email, string password)
    {
        return usermanager.Login(email, password);
    }

    public bool Register(string email, string password)
    {
        return usermanager.Register(email, password);
    }

    public void ListBooks()
    {
        bookmanager.ListBooks();
    }

    public void AddBook(string bookname, string bookauthor)
    {
        bookmanager.AddBook(bookname, bookauthor);

    }

    public bool Rent(string bookname)
    {
        return bookmanager.Rent(bookname);
    }

    public bool Return()
    {
        return bookmanager.Rent();
    }
}