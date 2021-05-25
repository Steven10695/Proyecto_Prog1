using Microsoft.AspNetCore.Mvc;
using Proyecto_Prog1.Models;

namespace Proyecto_Prog1.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdministradorContext _context;
        public IActionResult Productos(){
            return View();
        }
        public IActionResult RegistrarProducto(){
            return View();
        }
        
        [HttpPost]
        public IActionResult RegistrarProducto(Producto p){
            if(ModelState.IsValid){
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("RegistrarProductoConfirmacion"); 
            }
                return View(p);
        }
        public IActionResult RegistrarProductoConfirmacion (){
            return View();
        }
    }
}