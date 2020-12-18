using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortafolioProyectos.Models
{
    public class Lenguaje
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Descripcion { get; set; }
        [StringLength(1)]
        public char Nivel { get; set; }
    }
}
