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
    public class PagoController : Controller
    {
       private readonly ILogger<PagoController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public PagoController(ILogger<PagoController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context=context;
            _userManager = userManager;
        }

    public IActionResult Pago(){
            return View();
        }
         [HttpPost]
          [ValidateAntiForgeryToken]
    public IActionResult Pago([Bind("id,nombre,apellido,dni,telefono,correo,region,ciudad,direccion,referencia,tarjeta,vence,codigo")]Pago c)
        {
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                 Console.WriteLine("Pago enviado");
                return RedirectToAction("Final");
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
            var pagos = _context.Pago.FirstOrDefault(p => p.id == id);
            _context.Remove(pagos);
            _context.SaveChanges();
            return RedirectToAction("Pagos");
        }
        public IActionResult Final(){
            return View();
        }
        
        

        public IActionResult Pagos()
        { 
        var pagos = _context.Pago.ToList();
            return View(pagos);
        }
    }
}