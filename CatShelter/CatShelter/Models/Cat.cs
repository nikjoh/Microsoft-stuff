using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatShelter.Models
{
    public class Cat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int RageRange { get; set; }

        public Cat(int id, string name, int weight, int rageRange)
        {
            ID = id;
            Name = name;
            Weight = weight;
            RageRange = rageRange;
        }
    }
}
