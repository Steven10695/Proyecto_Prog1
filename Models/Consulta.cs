using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Huerto_Del_valle.Models
{
      [Table("t_consulta")]
    public class Consulta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int id { get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su nombre!")]
        [Display(Name="Nombre del Cliente")]
        public string nombre{ get; set; } 

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su correo!")]
        [Display(Name="Correo del Cliente")]
        public string correo{ get; set; } 

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su consulta!")]
        [Display(Name="Descripción de la Consulta")]    
        public string descripcion { get; set; }

        [Required]
        public DateTime addDate { get; set; }
    }
}