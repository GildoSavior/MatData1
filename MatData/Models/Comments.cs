using MatData.Models;

namespace Matdata.API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
    }
}

