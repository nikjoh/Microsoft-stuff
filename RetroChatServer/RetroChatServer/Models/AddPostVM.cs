﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatServer.Models
{
    public class AddPostVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
    }
}