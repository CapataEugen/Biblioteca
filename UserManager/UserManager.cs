
public class UserManager : IUserManager
{
    private User currentUser;
    private List<User> userList = new List<User>();
    private string email, password;

    public User getCurrentUser() {
        return currentUser;
    }

    public bool Login(string email, string password)
    {
        currentUser = new User(email, password);

        User? user = userList.Find(x => (x.Email == currentUser.Email));
        
        if (user is not null && user.Password == password)
            return true;
        
        return false;
    }

    public bool Register(string email, string password)
    {
        currentUser = new User(email, password);
        
        if (!userList.Exists(x => (x.Email == currentUser.Email )))
        {
            userList.Add(currentUser);
            return true;
        }

        return false;
    }
}