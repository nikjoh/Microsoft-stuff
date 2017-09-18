using System;
using System.Collections.Generic;

namespace CatShelter.Models.Entities
{
    public partial class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int RageRange { get; set; }
    }
}
