using System;
using Matdata.API.ViewModels;
using MatData.Models;

namespace Matdata.API.Serialization
{
	public class UserMapper
	{
		public static void Serialize(UserModel user, User userToSave)
		{
			userToSave.Id = user.Id;
			userToSave.Name = user.Name;
			userToSave.Email = user.Email;
			userToSave.Username = user.Username;
			userToSave.Password = user.Password;
			userToSave.PasswordConfirm = user.PasswordConfirm;
			userToSave.PhoneNumber = user.PhoneNumber;
			userToSave.ProvinceId = user.ProvinceId;
			userToSave.MunicipeId = user.MunicipeId;
			userToSave.UserType = user.UserType;
			userToSave.Role = user.Role;
		}

		public static User Serialize(UserModel user)
		{
			return new User
			{
				Id = user.Id,
				Name = user.Name,
				Email = user.Email,
				Username = user.Username,
				Password = user.Password,
				PasswordConfirm = user.PasswordConfirm,
				PhoneNumber = user.PhoneNumber,
				ProvinceId = user.ProvinceId,
				MunicipeId = user.MunicipeId,
				UserType = user.UserType,
				Role = user.Role
			};
		}
	}
}

