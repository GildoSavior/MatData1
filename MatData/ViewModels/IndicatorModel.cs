using MatData.Models;
using System;

namespace MatData.ViewModels
{
    public class IndicatorModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public Theme Theme { get; set; }
    }
}
