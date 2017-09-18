using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatShelter.Models
{
    
    public class ListCatVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDangerous { get; set; }
    }
}
