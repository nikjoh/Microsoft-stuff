using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionProject
{
    public interface IContentService
    {
        string GetHeader();
        string GetBody();
    }
}
