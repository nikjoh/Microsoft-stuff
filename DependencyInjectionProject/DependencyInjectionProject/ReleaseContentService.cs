using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionProject
{
    public class ReleaseContentService : IContentService
    {
        public string GetBody()
        {
            return "This is release service body!";
        }

        public string GetHeader()
        {
            return "Release Service!";
        }
    }
}
