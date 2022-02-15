using System;
using Matdata.API.Models;

namespace Matdata.API.ViewModels
{
	public class AgendaVM
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; }
        public DateTime DateAgenda { get; set; }
        public string Description { get; set; }
    }
}

