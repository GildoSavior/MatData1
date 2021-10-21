using System;
using System.Collections.Generic;

namespace MatData.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public string CodName { get; set; }
        public Category Category { get; set; }
        public List<Indicator> Indicator { get; set; }
    }
}
