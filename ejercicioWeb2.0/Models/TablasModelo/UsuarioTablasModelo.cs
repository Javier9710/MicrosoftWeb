using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ejercicioWeb2._0.Models.TablasModelo
{
    public class UsuarioTablasModelo
    {
        [Required]
        [EmailAddress]
        [StringLength(100,ErrorMessage ="el {0} debe tener al menos {1} caracteres",MinimumLength =1)]
        [Display(Name ="Correo Electronico")]
        public String Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        public String Password { get; set; }
        [Display(Name = "Confirmar Contraseña")]
        [Compare("Password", ErrorMessage ="Las contraseñas no son iguales")]
        public String ConfirmPassword { get; set; }
        [Required]
        public int Edad { get; set; }
    }
}