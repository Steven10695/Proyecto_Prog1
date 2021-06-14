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
                return RedirectToAction("Calificacion");
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
        public IActionResult Delete(int id)
        {
            var Calificaciones = _context.Calificacion.FirstOrDefault(p => p.id == id);
            _context.Remove(Calificaciones);
            _context.SaveChanges();
            return RedirectToAction("Calificaciones");
        }
        public IActionResult Calificacion(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calificacion([Bind("id,calificacion,pregunta")] Calificacion a)
        {
            if(ModelState.IsValid){
                _context.Add(a);
                _context.SaveChanges();
                 Console.WriteLine("Calificación agregada");
                return RedirectToAction("HuertodelValle","Admin");
            }
            return View(a);
        }
        public IActionResult Calificaciones(){
            var Calificaciones = _context.Calificacion.ToList();
            return View(Calificaciones);
        } 

        public IActionResult Pagos()
        { 
        var pagos = _context.Pago.ToList();
            return View(pagos);
        }
        public IActionResult EditarCliente(int id){
            var pago = _context.Pago.Find(id);
            return View(pago);
        }
         [HttpPost]
        public IActionResult EditarCliente(Pago p)
        {   
            if(ModelState.IsValid){
                var pago = _context.Pago.Find(p.id);
                pago.nombre= p.nombre;
                pago.apellido=p.apellido;
                pago.dni=p.dni;
                pago.telefono=p.telefono;
                pago.correo=p.correo;
                pago.region=p.region;
                pago.ciudad=p.ciudad;
                pago.direccion=p.direccion;
                pago.referencia=p.referencia;
                _context.SaveChanges();
                 Console.WriteLine("Cliente editado");
                return RedirectToAction("Pagos");
            }
            return View(p);
        }
    }
}