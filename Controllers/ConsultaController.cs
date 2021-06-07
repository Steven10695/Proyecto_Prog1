using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Huerto_Del_valle.Data;
using Huerto_Del_valle.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Huerto_Del_valle.Controllers
{
    public class ConsultaController : Controller
    {
       private readonly ILogger<ConsultaController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public ConsultaController(ILogger<ConsultaController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context=context;
            _userManager = userManager;
        }

    public IActionResult Consulta(){
            return View();
        }
         [HttpPost]
          [ValidateAntiForgeryToken]
    public IActionResult Consulta([Bind("id,nombre,correo,descripcion")]Consulta c)
        {
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                 Console.WriteLine("Consulta enviada");
                return RedirectToAction("Consulta");
            }
            return View(c);
        }
    public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    [HttpPost]
        public IActionResult Eliminar(int id)
        {
            var consultas = _context.Consulta.FirstOrDefault(c => c.id == id);
            _context.Remove(consultas);
            _context.SaveChanges();
            return RedirectToAction("Consultas");
        }
        

        public IActionResult Consultas()
        { 
        var consultas = _context.Consulta.ToList();
            return View(consultas);
        }
        

    }
}