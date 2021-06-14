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
    public class CalificacionController : Controller
    {
        private readonly ILogger<CalificacionController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public CalificacionController(ILogger<CalificacionController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context=context;
            _userManager = userManager;
        }
        public IActionResult Calificacion(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calificacion([Bind("id,calificacion")] Calificacion c)
        {
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                 Console.WriteLine("Calificación agregada");
                return RedirectToAction("HuertodelValle");
            }
            return View(c);
        }
    }

}