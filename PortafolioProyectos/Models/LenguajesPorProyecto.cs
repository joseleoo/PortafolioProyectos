using System.Collections.Generic;

namespace PortafolioProyectos.Models
{
    public class LenguajesPorProyecto
    {
        public int LenguajeId { get; set; }
        public Lenguaje Lenguaje { get; set; }
        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }


    }
}
