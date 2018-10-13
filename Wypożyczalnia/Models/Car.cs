using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    public class Car
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string VIN { get; set; }
        [Required]
        [Display(Name = "Producent")]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }

        [Display(Name = "Rodzaj")]
        public string Style { get; set; }
        [Required]
        [Display(Name = "Rok")]
        public int Year { get; set; }
        [Required]
        [Display(Name = "Przebieg")]
        public double Miles{ get; set; }

        [Display(Name = "Kolor")]
        public string Color { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
