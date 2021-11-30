using MatData.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MatData.Services.UrbanDistrictCommune
{
    public class UrbanDistrictCommuneService : IUrbanDistrictCommuneService
    {
        private readonly AppDbContext _db;

        public UrbanDistrictCommuneService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<Models.UrbanDistrictCommune> CreateUrbanDistrictCommune(Models.UrbanDistrictCommune urbanDistrictCommune)
        {
            try
            {
                _db.UrbanDistrictCommunes.Add(urbanDistrictCommune);
                _db.SaveChanges();
                return new ServiceResponse<Models.UrbanDistrictCommune>
                {
                    IsSuccess = true,
                    Message = "New UrbanDistrictCommune added",
                    Time = DateTime.Now,
                    Data = urbanDistrictCommune
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.UrbanDistrictCommune>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now,
                    Data = urbanDistrictCommune
                };
            }
        }

        public ServiceResponse<bool> DeleteUrbanDistrictCommune(int id)
        {
            var municipe = _db.Municipes.Find(id);
            var now = DateTime.Now;

            if (municipe == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "UrbanDistrictCommune delete not found!",
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
                    Message = "UrbanDistrictCommune created",
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

        public List<Models.UrbanDistrictCommune> GetAllUrbanDistrictCommunes()
        {
            return _db.UrbanDistrictCommunes
                .Include(urban => urban.Municipe)
                    .ThenInclude(municipe => municipe.Province)
                .OrderBy(urban => urban.Name)
                .ToList();
        }

        public Models.UrbanDistrictCommune GetById(int id)
        {
            return _db.UrbanDistrictCommunes
                .Include(urban => urban.Municipe)
                .First(urban => urban.Id == id);
        }

        public List<Models.UrbanDistrictCommune> GetAllByMunicipeId(int id)
        {
            return _db.UrbanDistrictCommunes
                .Include(u => u.Municipe)
                .Where(u => u.Municipe.Id == id)
                .ToList();
        }
    }
}
