using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionProject
{
    public class DevContentService : IContentService
    {
        public string GetBody()
        {
            return "This is development service body!";
        }

        public string GetHeader()
        {
            return "Development Service!";
        }
    }
}
