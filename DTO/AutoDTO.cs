using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutosSystem.DTO
{
    public class AutoDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The Max Velocity is required")]
        [Display(Name = "Last Name")]
        public int VelocidadMaxima { get; set; }

        [Required(ErrorMessage = "The Model is required")]
        [Display(Name = "Model")]
        public string Modelo { get; set; }

    }
}
