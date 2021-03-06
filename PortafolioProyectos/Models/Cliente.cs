﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortafolioProyectos.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Nombre requerido" )]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage ="Apellido requerido")]
        [StringLength(50)]
        public string Apellido{ get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Telefono requerido" )]
        [Phone(ErrorMessage = "Telefono incorrecto" )]
        [Display(Name ="Teléfono")]
 
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Email incorrecto" )]
        [Display(Name = "Correo Electrónico")]
        [StringLength(100, ErrorMessage ="Solo se permiten 100 caracteres")]
        public string Email { get; set; }

        public List<Proyecto> Proyectos { get; set; }
    }
}
