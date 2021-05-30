using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Huerto_Del_valle.Models
{
      [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int id { get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un producto!")]
        [Display(Name="Nombre del producto")]
        public string nombre{ get; set; }
      
       [Required(ErrorMessage="¡Espacio en blanco, Ingrese una url correcta!")]
        [Display(Name="URL de la foto")]
        public string url_producto { get; set; }
        
        [Required(ErrorMessage="¡Espacio en blanco, Ingrese una descripción!")]
        [Display(Name="Descripción de la publicación")]
        public string descripcion { get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un precio!")]
        [Display(Name="Precio a pagar")]
        public double precio { get; set; }
 
        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un lugar de compra del producto!")]
        [Display(Name="Lugar de compra del producto")]
        public string lugarcompraproducto { get; set; }
        
        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un usuario!")]
        [Display(Name="Nombre del usuario")]
        public string usuario { get; set; }

        [Required]
        public DateTime addDate { get; set; }

         [Required(ErrorMessage="¡Espacio en blanco, Ingrese un lugar de compra del producto!")]
        [Display(Name="Ingrese el tipo de producto!")]
         public string tipo_producto {get; set;}
    }
}