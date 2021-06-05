using System; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Huerto_Del_valle.Models;

namespace Proyecto_Prog1.Models
{
    [Table("t_proforma")]
    public class Proforma
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        [Key]
        public int id { get; set; }
        [Display(Name="Usuario_Id")]
        public String UserId { get; set; }
        [Display(Name="Producto_Id")]
        public Producto ProductoId { get; set; }
        [Display(Name="Cantidad")]
        public int Cantidad { get; set; }
        [Display(Name="Precio")]
        public double Precio { get; set; }

    }
}