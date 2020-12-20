
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortafolioProyectos.Models
{
    public class Proyecto : IValidatableObject
    {
        public int Id { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Descripción requerida")]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "Cliente requerido")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        //public IEnumerable<Cliente> Clientes { get; set; }

        [Display(Name = "Fecha de inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe especificar una fecha de inicio")]
        [DataType(DataType.Date, ErrorMessage = "Fecha incorrecta")]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha de finalización")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Fecha incorrecta")]

        public DateTime FechaFin { get; set; }


        [DataType(DataType.Currency, ErrorMessage = "Precio incorrecto")]
        public double Precio { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int Horas { get; set; }

        [Required(ErrorMessage = "Estado requerido"), Display(Name = "Estado")]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

        public int LenguajeId { get; set; }
        public Lenguaje Lenguaje { get; set; }
        public List<Lenguaje> Lenguajes { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FechaFin < FechaInicio)
            {
                yield return new ValidationResult(
                    errorMessage: "EndDate must be greater than StartDate",
                    memberNames: new[] { "FechaFin", "FechaInicio" }
               );
            }

            //if (ClienteId < 1)
            //{
            //    yield return new ValidationResult(
            //     errorMessage: "Debe escoger un cliente",
            //     memberNames: new[] { "ClienteId" }
            //    );
            //}

            //if (EstadoId < 1)
            //{
            //    yield return new ValidationResult(
            //     errorMessage: "Debe escoger un estado",
            //     memberNames: new[] { "EstadoId" }
            //    );
            //}

            //if (LenguajeId < 1)
            //{
            //    yield return new ValidationResult(
            //     errorMessage: "Debe escoger un lenguaje",
            //     memberNames: new[] { "LenguajeId" }
            //    );
            //}
        }
    }
}
