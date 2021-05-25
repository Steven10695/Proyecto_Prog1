using System.Collections.Generic;

namespace Proyecto_Prog1.Models
{
    public class TipoProducto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public ICollection<Producto> Productos {get; set;}
    }
}