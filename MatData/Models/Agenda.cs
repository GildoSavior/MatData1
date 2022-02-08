using System;
using System.Collections.Generic;

namespace Matdata.API.Models
{
    public class Agenda
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public Status Status { get; set; }
        public DateTime DateAgenda { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
    }

}

