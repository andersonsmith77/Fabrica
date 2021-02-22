using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoSystem.Data.Entities
{
    public class Auto
    {
        public int ID { get; set; }
        [Display(Name = "ID")]
        public int VelocidadMaxima { get; set; }
        [Display(Name = "Velocidad Maxima")]
        public String Modelo { get; set; }
        [Display(Name = "Modelo")]

        public string Especificaciones
        {
            get
            {
                return VelocidadMaxima + ' ' + Modelo;
            }
        }
    }
}
