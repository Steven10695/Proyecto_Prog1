using System;
using System.Collections.Generic;

namespace Proyecto_Prog1.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
        public ICollection<Producto> Productos {get;set;}
    }
}