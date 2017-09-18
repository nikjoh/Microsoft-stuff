using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatShelter.Models
{
    public class DetailsCatVM
    {
        public enum CatTemper
        {
            Cute = 1,
            Aggressive = 5,
            Weird = 10
        }

        public string Name { get; set; }
        public int Weight { get; set; }
        public CatTemper Temper { get; set; }
    }
}
