using System;
using System.Collections.Generic;

namespace RetroChatRestApi.Models.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TextValue { get; set; }
        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
