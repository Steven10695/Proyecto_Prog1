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

        [Display(Name="Apellidos")]
        public string apellidos{ get; set; } 

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su DNI!")]
        [Display(Name="DNI")]
        public string dni{ get; set; } 

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su teléfono!")]
        [Display(Name="Teléfono")]    
        public string telefono{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su correo!")]
        [Display(Name="Correo")]    
        public string correo{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su distrito!")]
        [Display(Name="Distrito")]    
        public string distrito{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese su dirección!")]
        [Display(Name="Dirección")]    
        public string direccion{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese la referencia de su domicilio!")]
        [Display(Name="Referencia")]    
        public string referencia{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese el número de la tarjeta!")]
        [Display(Name="Tarjeta")]    
        public string tarjeta{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese la fecha de vencimiento!")]
        [Display(Name="Fecha de vencimiento")]    
        public string vence{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese el código de seguridad!")]
        [Display(Name="Código de Seguridad")]    
        public string codigo{ get; set; }

        [Required]
        public DateTime addDate { get; set; }
    }
}