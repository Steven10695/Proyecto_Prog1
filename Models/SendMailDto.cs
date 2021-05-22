using System.ComponentModel.DataAnnotations;

namespace Proyecto_Prog1.Models
{
    public class SendMailDto
    {
        [Required]
        public string nombre {get; set;}
        [Required]
        public string mail {get; set;}
        [Required]
        public string subject {get; set;}
        [Required]
        public string mensaje {get; set;}



    }
}