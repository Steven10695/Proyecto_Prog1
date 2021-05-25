using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Prog1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Proyecto_Prog1.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdministradorContext _context;

        public AdminController(AdministradorContext context){
            _context = context;
        }
         public IActionResult Productos(){
           var productos = _context.Productos.Include(x => x.TipoProductos).OrderBy(r => r.Nombre_Producto).ToList();
           return View(productos);
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