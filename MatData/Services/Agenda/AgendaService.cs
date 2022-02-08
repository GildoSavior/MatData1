using System;
using System.Collections.Generic;
using System.Linq;
using MatData;
using MatData.Data;

namespace Matdata.API.Services.Agenda
{
    public class AgendaService : IAgendaService
    {
        private readonly AppDbContext _db;

        public AgendaService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<bool> CreateAgenda(Models.Agenda agenda)
        {
            try
            {
                _db.Agendas.Add(agenda);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Agenda created with success",
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

        public ServiceResponse<bool> DeleteAgenda(int id)
        {
            try
            {
                var finded = _db.Agendas.Find(id);
                _db.Agendas.Remove(finded);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Message = "Agenda deleted with success",
                    Time = DateTime.Now,
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Agenda not found",
                    Time = DateTime.Now,
                    Data = false
                };
            }
        }

        public Models.Agenda GetAgendaById(int id)
        {
            return _db.Agendas.Find(id);
        }

        public List<Models.Agenda> GetAgendas()
        {
            return _db.Agendas
                .OrderBy(o => -o.Id)
                .ToList();
        }
    }
}

