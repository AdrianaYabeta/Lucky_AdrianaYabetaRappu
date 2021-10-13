using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLuckyParcial.Models
{
    public class Suerte
    {
        [Key]
        public int SuerteId { get; set; }
        [Required(ErrorMessage = "Suerte de la persona")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Debe tener entre 5 a 80 caracteres")]
        [Display(Name = "Suerte")]
        public string Detalle { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La longitd de la imagen debe tener entre 2 a 100 caracteres")]
        [Display(Name = "Imagen")]
        public string Imagen { get; set; }

    }
}
