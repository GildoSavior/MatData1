using MatData.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MatData.Services.NeighborhoodVillage
{
    public class NeighborhoodVillageService : INeighborhoodVillageService
    {
        private readonly AppDbContext _db;

        public NeighborhoodVillageService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<Models.NeighborhoodVillage> CreateNeighborhoodVillage(Models.NeighborhoodVillage neighborhoodVillage)
        {
            try
            {
                _db.NeighborhoodVillages.Add(neighborhoodVillage);
                _db.SaveChanges();
                return new ServiceResponse<Models.NeighborhoodVillage>
                {
                    IsSuccess = true,
                    Message = "New neighborhoodVillageService added",
                    Time = DateTime.Now,
                    Data = neighborhoodVillage
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.NeighborhoodVillage>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now,
                    Data = neighborhoodVillage
                };
            }
        }

        public ServiceResponse<bool> DeleteNeighborhoodVillage(int id)
        {
            var neighborhoodVillage = _db.NeighborhoodVillages.Find(id);
            var now = DateTime.Now;

            if (neighborhoodVillage == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "NeighborhoodVillageService delete not found!",
                    Data = false
                };
            }
            try
            {
                _db.NeighborhoodVillages.Remove(neighborhoodVillage);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "NeighborhoodVillageService created",
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

        public List<Models.NeighborhoodVillage> GetAllNeighborhoodVillages()
        {
            return _db.NeighborhoodVillages
                .Include(n => n.UrbanDistrictCommune)
                    .ThenInclude(u => u.Municipe)
                        .ThenInclude(m => m.Province)
                .OrderBy(urban => urban.Name)
                .ToList();
        }

        public Models.NeighborhoodVillage GetById(int id)
        {
            return _db.NeighborhoodVillages
                .Include(n => n.UrbanDistrictCommune)
                    .ThenInclude(u => u.Municipe)
                        .ThenInclude(m => m.Province)
                .First(urban => urban.Id == id);
        }

        public object GetNeighborhoodVillagePerPage(int pageIndex, int pageSize)
        {
            var neighborhoods = _db.NeighborhoodVillages
                .Include(n => n.UrbanDistrictCommune)
                    .ThenInclude(u => u.Municipe)
                        .ThenInclude(m => m.Province)
                .ToList();

            var page = new PaginateResponse<Models.NeighborhoodVillage>(neighborhoods, pageIndex, pageSize);

            var totalCount = neighborhoods.Count();
            var totalPages = Math.Ceiling((double) totalCount / pageSize);

            return new { Page = page, Total = totalPages };
        }
    }
}
