﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatRestApi.Models.Members
{
    public class PostVM
    {
        public int Id { get; set; }
        public bool UserLike { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
    }
}
