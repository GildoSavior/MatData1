using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Matdata.API.Models;
using MatData;
using MatData.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Matdata.API.Services.Gallery
{
    public class GalleryService : IGalleryService
    {
        private readonly AppDbContext _db;

        public static IWebHostEnvironment _environment;
        public GalleryService(AppDbContext db, IWebHostEnvironment environment)
        {
            _db = db;
            _environment = environment;
    }

        public async Task<ServiceResponse<bool>> CreateGallery(Models.Gallery gallery, IFormFile file)
        {
        
        try
            {
                var repositoryPath = Path.Combine(_environment.WebRootPath, "Repository");
                if (!Directory.Exists(repositoryPath))
                {
                    Directory.CreateDirectory(repositoryPath);
                }

                var destinationPath = Path.Combine(repositoryPath, "Images");

                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }
                var fileName = Path.Combine(destinationPath, file.FileName);
                using (var filestream = File.Create(fileName))
                {
                    await file.CopyToAsync(filestream);
                    filestream.Flush();
                }
                _db.Galleries.Add(gallery);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Gallery created with success",
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

        public ServiceResponse<bool> DeleteGallery(int id)
        {
            try
            {
                var galleryFinded = _db.Galleries.Find(id);
                _db.Galleries.Remove(galleryFinded);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Gallery deleted with success",
                    Time = DateTime.Now,
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Gallery not found",
                    Time = DateTime.Now,
                    Data = false
                };
            }
        }

        public Models.Gallery GetGalleryById(int id)
        {
            return _db.Galleries.Find(id);
        }

        public List<Models.Gallery> GetGallery()
        {
            return _db.Galleries
                .OrderBy(o => -o.Id)
                .ToList();
        }
    }
}

