
public class Book
{
    private string name;
    private string author;
    public Book(string name, string author)
    {
        this.name = name;
        this.author = author;
    }

    public string Name
    {
        get { return name;}
    }

    public string Author
    {
        get { return author;}
    }
}