using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MatData;
using MatData.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Matdata.API.Services.Agenda
{
    public class AgendaService : IAgendaService
    {
        private readonly AppDbContext _db;
        public static IWebHostEnvironment _environment;

        public AgendaService(AppDbContext db, IWebHostEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }

        public async Task<ServiceResponse<bool>> CreateAgenda(Models.Agenda agenda, IFormFile file)
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

