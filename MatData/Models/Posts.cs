﻿using System.Collections.Generic;
using MatData.Models;

namespace Matdata.API.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
