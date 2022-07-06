
public class User
{

    private string email;
    private string password;
    private Book? rentedBook;
    
    public User(string email, string password)
    {
        this.email = email;
        this.password = password;
    }
    public string Email
    {
        get { return email;}
    }

    public string Password
    {
        get { return password;}
    }

    public void setRentedBook(Book? book) {
        rentedBook = book;
    }

    public Book? getRentedBook() {
        return rentedBook;
    }

}