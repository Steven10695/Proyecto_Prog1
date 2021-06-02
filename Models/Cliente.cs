using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Prog1.Models
{
    [Table("t_clientes")]
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id {get;set;}

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un Nombre!")]
        [Display(Name="Ingresel Nombres")]
        public string Nombres{get;set;}

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un Apellido!")]
        [Display(Name="Ingrese Apellidos")]
        public string Apellidos{get;set;}

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un Correo!")]
        [Display(Name="Ingrese un correo")]
        public string Correo{get;set;}

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un Contraseña!")]
        [Display(Name="Ingrese una Contraseña")]
        public string Contraseña{get;set;}

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese un Teléfono!")]
        [Display(Name="Ingrese un Teléfono")]
        public string Telefono{get;set;}

         [Required(ErrorMessage="¡Espacio en blanco, Ingrese una Direccion!")]
        [Display(Name="Ingrese una Direccion")]
        public string Direccion{get;set;}
    
    }
}