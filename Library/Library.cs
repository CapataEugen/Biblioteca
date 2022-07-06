
public class Library
{
    private UserManager userManager = new UserManager();
    private BookManager bookManager = new BookManager();

    public Library() {
        //load users and books from file...
        userManager.Register("cosmin", "123123");
    }

    public bool Login(string email, string password)
    {
        return userManager.Login(email, password);
    }

    public bool Register(string email, string password)
    {
        return userManager.Register(email, password);
    }

    public void ListBooks()
    {
        bookManager.ListAvailableBooks();
    }

    public bool AddBook(string bookname, string bookauthor)
    {
        return bookManager.AddBook(bookname, bookauthor);

    }

    public bool Rent(string bookname)
    {
        return bookManager.RentBook(userManager.getCurrentUser(), bookname);
    }

    public bool Return()
    {
        return bookManager.ReturnBook(userManager.getCurrentUser());
    }
}