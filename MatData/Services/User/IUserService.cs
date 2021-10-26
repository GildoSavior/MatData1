namespace MatData.Services.User
{
    public interface IUserService
    {
        Models.User Get(string username, string password);
    }
}
