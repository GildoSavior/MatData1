using System;
using System.Collections.Generic;
using System.Linq;
using Matdata.API.Models;
using MatData;
using MatData.Data;

namespace Matdata.API.Services.Message
{
    public class MessageService : IMessageService
    {
        private readonly AppDbContext _db;

        public MessageService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<bool> CreateMessage(Models.Message message)
        {

            try
            {
                _db.Messages.Add(message);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Message created with success",
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

        public ServiceResponse<bool> DeleteMessage(int id)
        {
            try
            {
                var messageFinded = _db.Messages.Find(id);
                _db.Messages.Remove(messageFinded);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Message deleted with success",
                    Time = DateTime.Now,
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Message not found",
                    Time = DateTime.Now,
                    Data = false
                };
            }
        }

        public Models.Message GetMessageById(int id)
        {
            return _db.Messages.Find(id);
        }

        public List<Models.Message> GetMessages()
        {
            return _db.Messages
                .OrderBy(o => - o.Id)
                .ToList();
        }
    }
}

