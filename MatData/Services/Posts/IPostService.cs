using System.Collections.Generic;
using MatData;

namespace Matdata.API.Services.Message
{
    public interface IPostService
	{
		List<Models.Post>GetPosts();
		Models.Post GetPostById(int id);
		ServiceResponse<bool> DeletePost(int id);
		ServiceResponse<bool> CreatePost(Models.Post post);
	}
}

