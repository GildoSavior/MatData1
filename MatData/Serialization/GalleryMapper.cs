using System;
using Matdata.API.Models;
using Matdata.API.ViewModels;

namespace Matdata.API.Serialization
{
	public class GalleryMapper
	{
		public static Gallery Serialize(GalleryVM galleryVM, string fileName)
		{
			return new Gallery
			{
				Image = fileName,
				Description = galleryVM.Description
			};
		}
	}
}

