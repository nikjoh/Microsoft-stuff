using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatShelter.Models
{
    [Bind(Prefix = nameof(IndexVM.AddCatVM))]
    public class AddCatVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Weight { get; set; }

        public SelectListItem[] TemperamentItems { get; set; }

        [Display(Name="Temper")]
        [Required(ErrorMessage = "Choose temper")]
        public string SelectedTemperament { get; set; }

        public AddCatVM()
        {
            TemperamentItems = new SelectListItem[]
            {
                new SelectListItem { Text = "Cute", Value = "1"},
                new SelectListItem { Text = "Aggressive", Value = "5"},
                new SelectListItem { Text = "Weird", Value = "10"},

            };
        }
    }
}
