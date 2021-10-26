using MatData.Data;
using System.Linq;

namespace MatData.Services.User
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _db;

        public UserService(AppDbContext db)
        {
            _db = db;
        }

        public Models.User Get(string username, string password)
        {
            return _db.Users
                .Where(u => u.Username == username && u.Password == password)
                .FirstOrDefault();
        }
    }
}
