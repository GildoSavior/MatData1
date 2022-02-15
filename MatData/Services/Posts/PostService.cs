using System;
using System.Collections.Generic;
using System.Linq;
using Matdata.API.Models;
using Matdata.API.Services.Message;
using MatData;
using MatData.Data;

namespace Matdata.API.Services.Posts

{
    public class PostService : IPostService
    {
        private readonly AppDbContext _db;

        public PostService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<bool> CreatePost(Models.Post post)
        {

            try
            {
                _db.Posts.Add(post);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Post created with success",
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

        public ServiceResponse<bool> DeletePost(int id)
        {
            try
            {
                var messageFinded = _db.Posts.Find(id);
                _db.Posts.Remove(messageFinded);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Post deleted with success",
                    Time = DateTime.Now,
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Post not found",
                    Time = DateTime.Now,
                    Data = false
                };
            }
        }

        public Models.Post GetPostById(int id)
        {
            return _db.Posts.Find(id);
        }

        public List<Models.Post> GetPosts()
        {
            return _db.Posts
                .OrderBy(o => - o.Id)
                .ToList();
        }
    }
}

