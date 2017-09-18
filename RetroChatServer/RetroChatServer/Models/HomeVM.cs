using RetroChatServer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatServer.Models
{
    public class HomeVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        public string Info { get; set; }
        public UserPost[] Posts { get; set; }
    }
}
