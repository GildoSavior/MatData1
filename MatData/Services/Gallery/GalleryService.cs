using System;
using System.Collections.Generic;
using System.Linq;
using Matdata.API.Models;
using MatData;
using MatData.Data;
using Microsoft.AspNetCore.Http;

namespace Matdata.API.Services.Gallery
{
    public class GalleryService : IGalleryService
    {
        private readonly AppDbContext _db;

        public GalleryService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<bool> CreateGallery(Models.Gallery gallery, IFormFile file)
        {

            try
            {
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

