using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StatehandlingProject.Models
{
    public class CreateSettingsVM
    {
        [Required]
        [Display(Name = "Support e-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; }
    }
}
