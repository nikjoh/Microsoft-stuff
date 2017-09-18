using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatShelter.Models
{
    public class IndexVM
    {
        public ListCatVM[] ListCatVMs { get; set; }
        public AddCatVM AddCatVM { get; set; }
    }
}
