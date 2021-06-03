using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Huerto_Del_valle.Models
{
      [Table("t_reclamo")]
    public class Reclamo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int id { get; set; }

        [Required(ErrorMessage="¡Espacio en blanco. Por favor ingrese su nombre!")]
        [Display(Name="Nombre del Usuario")]
        public string nombre{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco. Por favor ingrese su teléfono!")]
        [Display(Name="Teléfono del Usuario")]
        public string telefono{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco. Por favor ingrese el asunto!")]
        [Display(Name="Asunto del reclamo")]
        public string asunto{ get; set; } 

        [Required(ErrorMessage="¡Espacio en blanco. Por favor ingrese la descripción de su reclamo!")]
        [Display(Name="Descripción del reclamo")]    
        public string descripcion { get; set; }

        [Required]
        public DateTime addDate { get; set; }
    }
}