using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionProject.Models
{
    public class IndexVM
    {
        public IndexVM(string header, string body)
        {
            Header = header;
            Body = body;
        }

        public string Header { get; set; }
        public string Body { get; set; }
    }
}
