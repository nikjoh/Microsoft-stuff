using System;
using System.Collections.Generic;

namespace RetroChatRestApi.Models.Entities
{
    public partial class Like
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LikeValue { get; set; }
        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
