using MatData.Models;
using System;

namespace MatData.ViewModels
{
    public class DynamicProfile
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        //public User User { get; set; }
        public Province Province { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
