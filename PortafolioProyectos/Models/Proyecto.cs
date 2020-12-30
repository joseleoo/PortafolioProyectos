
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortafolioProyectos.Models
{
    public class Proyecto 
    {
        public int Id { get; set; }
        [Display(Name = "Descripción"),Required(ErrorMessage = "Descripción requerida"),StringLength(100)]
        public string Descripcion { get; set; }

        [Display(Name = "Cliente"), Required(ErrorMessage = "Cliente requerido")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        [NotMapped]
        public IEnumerable<Cliente> Clientes { get; set; }

        [Display(Name = "Fecha de inicio"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Required(ErrorMessage = "Debe especificar una fecha de inicio")]
        [DataType(DataType.Date, ErrorMessage = "Fecha incorrecta")]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha de finalización"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), DataType(DataType.Date, ErrorMessage = "Fecha incorrecta")]
        public DateTime FechaFin { get; set; }


        [DataType(DataType.Currency, ErrorMessage = "Precio incorrecto")]
        public double Precio { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int Horas { get; set; }

        [Required(ErrorMessage = "Estado requerido"), Display(Name = "Estado")]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

        //[NotMapped]
        //public int LenguajesPorProyectoId { get; set; }
        //[NotMapped]
        //public LenguajesPorProyecto LenguajesPorProyecto { get; set; }



    }
}
