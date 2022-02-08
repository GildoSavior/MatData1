using MatData.Models;

namespace Matdata.API.Models
{
    public class Message
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

