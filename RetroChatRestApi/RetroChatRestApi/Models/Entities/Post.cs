using System;
using System.Collections.Generic;

namespace RetroChatRestApi.Models.Entities
{
    public partial class Post
    {
        public Post()
        {
            Comment = new HashSet<Comment>();
            Like = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Like> Like { get; set; }
    }
}
