using System;
namespace Matdata.API.ViewModels
{
	public class UserModel
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PhoneNumber { get; set; }
        public int ProvinceId { get; set; }
        public int MunicipeId { get; set; }
        public string UserType { get; set; }
        public string Role { get; set; }
    }
}

