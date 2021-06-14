using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Huerto_Del_valle.Models
{
      [Table("t_pago")]
    public class Pago
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int id { get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su nombre!")]
        [Display(Name="Nombre")]
        public string nombre{ get; set; }

        [Display(Name="Apellido")]
        public string apellido{ get; set; } 

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su DNI!")]
        [Display(Name="DNI")]
        public string dni{ get; set; } 

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su teléfono!")]
        [Display(Name="Teléfono")]    
        public string telefono{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su correo!")]
        [Display(Name="Correo")]    
        public string correo{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su región!")]
        [Display(Name="Region")]    
        public string region{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su ciudad!")]
        [Display(Name="Ciudad")]    
        public string ciudad{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su dirección!")]
        [Display(Name="Dirección")]    
        public string direccion{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese la referencia de su domicilio!")]
        [Display(Name="Referencia")]    
        public string referencia{ get; set; }

        
        [Display(Name="Tarjeta")]    
        public string tarjeta{ get; set; }

        
        [Display(Name="Fecha de vencimiento")]    
        public string vence{ get; set; }

        
        [Display(Name="Código de Seguridad")]    
        public string codigo{ get; set; }

        [Required]
        public DateTime addDate { get; set; }
    }
}