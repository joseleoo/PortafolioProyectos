using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortafolioProyectos.Models
{
    public class LenguajesPorProyecto
    {
        [Key]
        public int Id { get; set; }
        public int LenguajeId { get; set; }
        public Lenguaje Lenguaje { get; set; }
        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }

        [StringLength(1)]
        public char Nivel { get; set; }


    }
}
