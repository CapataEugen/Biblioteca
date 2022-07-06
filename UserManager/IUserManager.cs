
public interface IUserManager
{
    public User getCurrentUser();
    bool Login(string email,string password);
    bool Register(string email, string password);
}