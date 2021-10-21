using System;

namespace MatData.Models
{
    public class Indicator
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public Theme Theme { get; set; }
    }
}
