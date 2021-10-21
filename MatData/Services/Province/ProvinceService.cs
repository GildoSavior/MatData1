using MatData.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MatData.Services.Province
{
    public class ProvinceService : IProvinceService
    {
        private readonly AppDbContext _db;

        public ProvinceService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<Models.Province> CreateProvince(Models.Province province)
        {
            try
            {
                _db.Provinces.Add(province);
                _db.SaveChanges();
                return new ServiceResponse<Models.Province>
                {
                    IsSuccess = true,
                    Message = "New province added",
                    Time = DateTime.Now,
                    Data = province
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Province>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now,
                    Data = province
                };
            }
        }

        public ServiceResponse<bool> DeleteProvince(int id)
        {
            var province = _db.Provinces.Find(id);
            var now = DateTime.Now;

            if (province == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "Province delete not found!",
                    Data = false
                };
            }
            try
            {
                _db.Provinces.Remove(province);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "Province created",
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

        public List<Models.Province> GetAllProvinces()
        {
            return _db.Provinces
                .OrderBy(province => province.Name)
                .ToList();
        }

        public Models.Province GetById(int id)
        {
            return _db.Provinces.Find(id);
        }
    }
}
