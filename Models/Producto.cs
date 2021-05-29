using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace app.Models
{
    public class Producto
    {
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
        
        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un número de contacto!")]
        [Display(Name="Celular para contacto")]       
        public int celular { get; set; }
 
        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un lugar de compra del producto!")]
        [Display(Name="Lugar de compra del producto")]
        public string lugarcompraproducto { get; set; }
        
        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un usuario!")]
        [Display(Name="Nombre del usuario")]
        public string usuario { get; set; }

        [Required]
        public DateTime addDate { get; set; }
         public ICollection<Categoria> Categorias {get; set;}
    }
}