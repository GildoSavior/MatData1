using Matdata.API.Serialization;
using Matdata.API.ViewModels;
using MatData.Data;
using System;
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

        public ServiceResponse<bool> Create(Models.User user)
        {
            try
            {
                _db.Add(user);
                _db.Users.Remove(user);
                _db.SaveChanges();
                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "User created",
                    Time = DateTime.Now,
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now,
                    Data = false
                };
            }
        }

        public Models.User Get(string username, string password)
        {
            return _db.Users
                .Where(u => u.Username == username && u.Password == password)
                .FirstOrDefault();
        }

        public ServiceResponse<bool> Update(UserModel user, int id)
        {

            try
            {
                var userFinded = _db.Users.Find(id);
                UserMapper.Serialize(user, userFinded);
                _db.SaveChanges();
                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Update deleted",
                    Time = DateTime.Now,
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now,
                    Data = false
                };
            }
        }


        public ServiceResponse<bool> Delete(int id)
        {
            try
            {
                var user = _db.Users.Find(id);
                _db.Users.Remove(user);
                _db.SaveChanges();
                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "User deleted",
                    Time = DateTime.Now,
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now,
                    Data = false
                };
            }
        }
    }
}
