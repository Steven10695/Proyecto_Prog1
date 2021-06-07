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
    public class ReclamoController : Controller
    {
       private readonly ILogger<ReclamoController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public ReclamoController(ILogger<ReclamoController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context=context;
            _userManager = userManager;
        }

    public IActionResult Reclamo(){
            return View();
        }
         [HttpPost]
          [ValidateAntiForgeryToken]
    public IActionResult Reclamo([Bind("id,nombre,telefono,asunto,descripcion")]Reclamo r)
        {
            if(ModelState.IsValid){
                _context.Add(r);
                _context.SaveChanges();
                 Console.WriteLine("Reclamo enviado con éxito");
                return RedirectToAction("Reclamo");
            }
            return View(r);
        }
    public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    [HttpPost]
        public IActionResult Eliminar(int id)
        {
            var reclamos = _context.Reclamo.FirstOrDefault(r => r.id == id);
            _context.Remove(reclamos);
            _context.SaveChanges();
            return RedirectToAction("Reclamos");
        }
        

        public IActionResult Reclamos()
        { 
        var reclamos = _context.Reclamo.ToList();
            return View(reclamos);
        }

    }
}