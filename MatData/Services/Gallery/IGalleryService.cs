using System.Collections.Generic;
using MatData;
using Microsoft.AspNetCore.Http;

namespace Matdata.API.Services.Gallery
{
    public interface IGalleryService
	{
		List<Models.Gallery>GetGallery();
		Models.Gallery GetGalleryById(int id);
		ServiceResponse<bool> DeleteGallery(int id);
		ServiceResponse<bool> CreateGallery(Models.Gallery gallery, IFormFile file);
	}
}

