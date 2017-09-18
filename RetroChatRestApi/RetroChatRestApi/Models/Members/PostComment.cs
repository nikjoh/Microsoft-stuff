using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatRestApi.Models.Members
{
    public class PostComment
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
    }
}
