using System;

namespace MatData.Models
{
    public class HistoryData
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public int MunicipeId { get; set; }
        public Municipe Municipe { get; set; }
        public string FileName { get; set; }
        public string Year { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
    