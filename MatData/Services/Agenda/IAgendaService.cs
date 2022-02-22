using System.Collections.Generic;
using System.Threading.Tasks;
using MatData;
using Microsoft.AspNetCore.Http;

namespace Matdata.API.Services.Agenda
{
    public interface IAgendaService
	{
		List<Models.Agenda> GetAgendas();
		Models.Agenda GetAgendaById(int id);
		ServiceResponse<bool> DeleteAgenda(int id);
		Task<ServiceResponse<bool>> CreateAgenda(Models.Agenda agenda, IFormFile file);
	}
}

