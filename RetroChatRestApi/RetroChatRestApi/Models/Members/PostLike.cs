using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatRestApi.Models.Members
{
    public class PostLike
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}
