using MatData.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MatData.Services.Municipe
{
    public class MunicipeService : IMunicipeService
    {
        private readonly AppDbContext _db;

        public MunicipeService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<Models.Municipe> CreateMunicipe(Models.Municipe municipe)
        {
            try
            {
                _db.Municipes.Add(municipe);
                _db.SaveChanges();
                return new ServiceResponse<Models.Municipe>
                {
                    IsSuccess = true,
                    Message = "New municipe added",
                    Time = DateTime.Now,
                    Data = municipe
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Municipe>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now,
                    Data = municipe
                };
            }
        }

        public ServiceResponse<bool> DeleteMunicipe(int id)
        {
            var municipe = _db.Municipes.Find(id);
            var now = DateTime.Now;

            if (municipe == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "Municipe delete not found!",
                    Data = false
                };
            }
            try
            {
                _db.Municipes.Remove(municipe);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "Municipe created",
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Data = false
                };
            }
        }

        public List<Models.Municipe> GetAllMunicipes()
        {
            return _db.Municipes
                .Include(municipe => municipe.Province)
                .OrderBy(municipe => municipe.Name)
                .ToList();
        }

        public Models.Municipe GetById(int id)
        {
            return _db.Municipes
                .Include(municipe => municipe.Province)
                .First(municipe => municipe.Id == id);
        }
    }
}
