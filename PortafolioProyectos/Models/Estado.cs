using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortafolioProyectos.Models
{
    public class Estado
    {

        public int Id { get; set; }
        [StringLength(50)]
        public string Descripcion { get; set; }

    }
}
