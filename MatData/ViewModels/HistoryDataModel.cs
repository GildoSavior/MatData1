using System;
namespace Matdata.API.ViewModels
{
	public class HistoryDataModel
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ProvinceName { get; set; }
        public string MunicipeName { get; set; }
        public int ProvinceId { get; set; }
        public int MunicipeId { get; set; }
        public string FileName { get; set; }
        public string Year { get; set; }
        public string CreatedOn { get; set; }
    }
}

