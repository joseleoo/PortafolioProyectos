using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortafolioProyectos.Models
{
    public class Lenguaje
    {

        public int Id { get; set; }
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
