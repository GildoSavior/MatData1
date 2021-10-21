using System;

namespace MatData.Models
{
    public class Municipe
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public Province Province { get; set; }
    }
}
