using System;
using Matdata.API.Models;
using Matdata.API.ViewModels;

namespace Matdata.API.Serialization
{
	public class AgendaMapper
	{
		public static Agenda Serialize(AgendaVM agendaVM, string fileName)
		{
			return new Agenda
			{
				Title = agendaVM.Title,
				Cover = fileName,
				Status = agendaVM.Status,
				DateAgenda = DateTime.Now,
				Description = agendaVM.Description
			};
		}
	}
}

