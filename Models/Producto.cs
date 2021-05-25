using System.Collections.Generic;

namespace Proyecto_Prog1.Models
{
    public class Producto
    {
        public string Id{get;set;}
        public string Nombre_Producto{get;set;}
        public string Cantidad_Producto{get;set;}
        public string Categoria_Producto{get;set;}
        public string Precio_Producto{get;set;}
          public ICollection<TipoProducto> TipoProductos {get; set;}
    }
}