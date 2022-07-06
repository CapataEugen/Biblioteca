using UserNamespace;

namespace DefaultNamespace;

public class UserManager : IUserManager
{
    private User currentUser;
    private List<User> userList;
    private string email, password;

    public bool Login(string email, string password)
    {
        User currentUser = new User(email, password);
        
        if (userList.Exists(x => (x.Email == currentUser.Email)))
        {
            return true;
        }
        return false;
    }

    public bool Register(string email, string password)
    {
        User currentUser = new User(email, password);
        if (!userList.Exists(x => (x.Email == currentUser.Email )))
        {
            userList.Add(currentUser);
            return true;
        }
        return false;
    }
}