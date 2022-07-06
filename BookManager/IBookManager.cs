
public interface IBookManager
{
    public bool AddBook(string name, string author);
    public bool RentBook(User user, string name);
    public bool ReturnBook(User user);
    public void ListAvailableBooks();
}