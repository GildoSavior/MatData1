using System.Collections.Generic;
using MatData;

namespace Matdata.API.Services.Agenda
{
    public interface IAgendaService
	{
		List<Models.Agenda> GetAgendas();
		Models.Agenda GetAgendaById(int id);
		ServiceResponse<bool> DeleteAgenda(int id);
		ServiceResponse<bool> CreateAgenda(Models.Agenda agenda);
	}
}

