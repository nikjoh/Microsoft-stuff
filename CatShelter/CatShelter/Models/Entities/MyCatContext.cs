using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CatShelter.Models.DetailsCatVM;

namespace CatShelter.Models.Entities
{
    public partial class CatContext
    {

        public CatContext(DbContextOptions<CatContext> options) : base(options)
        {

        }


        public ListCatVM[] GetCats()
        {
            return Cat.Select(c => new ListCatVM
            {
                Id = c.Id,
                Name = c.Name,
                IsDangerous = c.RageRange >= 5
            }).ToArray();
        }

        public DetailsCatVM GetCat(int id)
        {
            Cat cat = Cat.SingleOrDefault(c => c.Id == id);

            return new DetailsCatVM
            {
                Name = cat.Name,
                Weight = cat.Weight,
                Temper = (CatTemper)cat.RageRange
            };

        }

        internal IndexVM getIndexVM()
        {
            return new IndexVM
            {
                AddCatVM = new AddCatVM
                {
                    TemperamentItems = new SelectListItem[]
                    {
                        new SelectListItem { Text = "Cute", Value = "1"},
                        new SelectListItem { Text = "Aggressive", Value = "5"},
                        new SelectListItem { Text = "Weird", Value = "10"},
                    }
                },
                ListCatVMs = GetCats() 
                
            };
        }

        public void AddCat(AddCatVM catVM)
        {
            Cat.Add(new Cat
            {
                Name = catVM.Name,
                Weight = catVM.Weight,
                RageRange = Convert.ToInt32(catVM.SelectedTemperament)
            });
            SaveChanges();

        }

        public void RemoveCat(int id)
        {
            Cat cat = Cat.SingleOrDefault(c => c.Id == id);
            Cat.Remove(cat);
            SaveChanges();
        }
    }
}
