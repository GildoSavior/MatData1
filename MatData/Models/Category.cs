using System;
using System.Collections.Generic;

namespace MatData.Models
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public string? Icon { get; set; }
    }
}
