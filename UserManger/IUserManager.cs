namespace UserNamespace;

public interface IUserManager
{
    bool Login(string email,string password);
    bool Register(string email, string password);
    
}