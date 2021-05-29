using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Huerto_Del_valle.Models;
using Proyecto_Prog1.Models;
using System.Net.Mail;
using System.Net;

namespace Huerto_Del_valle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

          public IActionResult IniciarSesion()
        {
            return View();
        }
          public IActionResult Registrarse()
        {
            return View();
        }
        public IActionResult Nosotros()
        {
            return View();
        }

        [HttpGet]
         public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Contacto(SendMailDto sendMailDto)
        {
            if (!ModelState.IsValid) 

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("steven_palma@atmosferasweb.com");

                mail.To.Add("steven_palma@atmosferasweb.com");

                mail.Subject = sendMailDto.Subject;

                mail.IsBodyHtml = true;

                string content = "Name: " + sendMailDto.Nombre;
                content += "<br/> Correo: " + sendMailDto.Mail;
                content += "<br/> Mensaje: " + sendMailDto.Mensaje;

                mail.Body = content;

                //SMTP 

                SmtpClient smtpClient = new  SmtpClient("mail.atmosferasweb.com");

                // Credenciales

                NetworkCredential networkCredential = new NetworkCredential("steven_palma@atmosferasweb.com","StevenPalma1!");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 25;
                smtpClient.EnableSsl = false;
                smtpClient.Send(mail);

                ViewBag.Message = "Mail Enviado";

                ModelState.Clear();


            }
            catch(Exception e)
            {
                ViewBag.Message = e.Message.ToString();
            }

            return View();

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
