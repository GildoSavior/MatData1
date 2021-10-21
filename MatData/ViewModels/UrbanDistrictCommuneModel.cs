using MatData.Models;
using System;

namespace MatData.ViewModels
{
    public class UrbanDistrictCommuneModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public MunicipeModel Municipe { get; set; }
    }
}
