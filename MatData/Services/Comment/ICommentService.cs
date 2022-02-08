using System;
using System.Collections.Generic;
using System.Linq;
using MatData;
using MatData.Data;

namespace Matdata.API.Services.Comment
{
	public interface ICommentService
	{
		List<Models.Comment> GetComments();
		Models.Comment GetCommentById(int id);
		ServiceResponse<bool> DeleteComment(int id);
		ServiceResponse<bool> CreateComment(Models.Comment comment);
	}

    public class CommentService : ICommentService
    {
        private readonly AppDbContext _db;

        public CommentService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<bool> CreateComment(Models.Comment comment)
        {
            try
            {
                _db.Comments.Add(comment);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Comment created with success",
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

        public ServiceResponse<bool> DeleteComment(int id)
        {
            try
            {
                var finded = _db.Comments.Find(id);
                _db.Comments.Remove(finded);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Comment deleted with success",
                    Time = DateTime.Now,
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Comment not found",
                    Time = DateTime.Now,
                    Data = false
                };
            }
        }

        public Models.Comment GetCommentById(int id)
        {
            return _db.Comments.Find(id);
        }

        public List<Models.Comment> GetComments()
        {
            return _db.Comments
                .OrderBy(o => -o.Id)
                .ToList();
        }
    }
}

