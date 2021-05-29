using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Huerto_Del_valle.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
        public ICollection<Producto> Productos {get;set;}
}
}