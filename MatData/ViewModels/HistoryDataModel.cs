using System;
namespace Matdata.API.ViewModels
{
	public class HistoryDataModel
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProvinceId { get; set; }
        public int MunicipeId { get; set; }
        public string FileName { get; set; }
        public string Year { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

