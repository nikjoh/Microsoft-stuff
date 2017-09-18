using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatServer.Models
{
    public class AccountVM
    {
        public LoginVM LoginVM { get; set; }
        public RegisterVM RegisterVM { get; set; }
    }
}
