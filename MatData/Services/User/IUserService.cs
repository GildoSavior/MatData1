using Matdata.API.ViewModels;

namespace MatData.Services.User
{
    public interface IUserService
    {
        Models.User Get(string username, string password);
        ServiceResponse<bool> Create(Models.User user);
        ServiceResponse<bool> Update(UserModel user, int id);
        ServiceResponse<bool> Delete(int id);
    }
}
