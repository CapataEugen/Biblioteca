
public class BookManager : IBookManager
{
    private List<Book> AvailableBooks = new List<Book>();
    private List<Book> RentedBooks = new List<Book>();

    public bool AddBook(string name, string author)
    {
        AvailableBooks.Add(new Book(name, author));
        return true;
    }

    public bool RentBook(User user, string name)
    {
        Book? book = AvailableBooks.Find(x => (x.Name == name));
        if(book is not null && user.getRentedBook() is null) {
            RentedBooks.Add(book);
            AvailableBooks.Remove(book);
            user.setRentedBook(book);
            return true;
        }
        else {
            Console.WriteLine("indisponibila");
            return false;
        }
    }

    public bool ReturnBook(User user)
    {
        Book? book = user.getRentedBook();
        if(book is not null) {
            RentedBooks.Remove(book);
            AvailableBooks.Add(book);
            user.setRentedBook(null);

            return true;
        }
        
        return false;
    }

    public void ListAvailableBooks() {
        foreach(Book b in AvailableBooks) {
            Console.WriteLine(b.Name + " by " + b.Author);
        }
    }
}
