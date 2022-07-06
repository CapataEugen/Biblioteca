
class Menu
{
    static public void Start()
    {
        Library library = new Library(new UserManager(), new BookManager());

        bool loggedIn = false;
        while (!loggedIn)
        {
            Console.Write("(L)ogin, (R)egister: ");
            string choice = Console.ReadLine()!.ToLower();

            Console.WriteLine("Enter email: ");
            string? email = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string? password = Console.ReadLine();

            switch (choice)
            {
                case "l":
                case "login":
                    loggedIn = library.Login(email, password);
                    break;
                case "r":
                case "register":
                    loggedIn = library.Register(email, password);
                    break;
                default:
                    break;
            }

            if(!loggedIn)
                Console.WriteLine("An error occured, try again.");
        }

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("What would you like to do?");
            Console.Write("(C)heckout the library, (r)ent book, r(e)turn book, (a)dd book, e(x)it: ");
            string? choice = Console.ReadLine()!.ToLower();

            bool state = true;
            switch (choice)
            {
                case "c":
                case "checkout":
                case "check":
                    library.ListBooks();
                    break;
                case "r":
                case "rent":
                    Console.Write("Enter book name: ");
                    state = library.Rent(Console.ReadLine());
                    break;
                case "e":
                case "return":
                    state = library.Return();
                    break;
                case "a":
                case "add":
                    Console.Write("Enter book name: ");
                    string bookName = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string bookAuthor = Console.ReadLine();
                    state = library.AddBook(bookName, bookAuthor);
                    break;
                case "x":
                case "exit":
                    exit = true;
                    break;
                default:
                    break;
            }

            if(!state)
                Console.WriteLine("An error occured, try again.");
        }

        Console.WriteLine("Goodbye");
    }
}
