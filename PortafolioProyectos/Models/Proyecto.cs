using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortafolioProyectos.Models
{
    public class Proyecto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Descripción requerida")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public double Precio { get; set; }
        public int Horas { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}
