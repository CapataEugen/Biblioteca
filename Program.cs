
using DefaultNamespace;
namespace Book;
class Program
{
    static void Main(string[] args)
    {
        UserManager manager = new UserManager();
        manager.Login(Console.ReadLine(), Console.ReadLine());
    }
}


