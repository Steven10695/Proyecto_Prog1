using System.ComponentModel.DataAnnotations;

namespace Proyecto_Prog1.Models
{
    public class SendMailDto
    {
        [Required]
        public string Nombre {get; set;}
        [Required]
        public string Mail {get; set;}
        [Required]
        public string Subject {get; set;}
        [Required]
        public string Mensaje {get; set;}



    }
}