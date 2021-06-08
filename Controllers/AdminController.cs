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
    public class AdminController : Controller
    {
       private readonly ILogger<AdminController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(ILogger<AdminController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context=context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Add(int? id){
            var userID = _userManager.GetUserName(User);
            if(userID == null){
                ViewData["Message"] = "Por favor debe loggearse";
                return  View("Index");
            }else{
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Index));
            }
        }

        public IActionResult IndexNC()
        {
            DateTime fecha= DateTime.Today.AddDays(-7);
            var productos = _context.Productos.Where(p => p.addDate == fecha).ToList();
            return View();
        }

        public IActionResult Index()
        {
            DateTime fecha= DateTime.Today.AddDays(-7);
            var productos = _context.Productos.Where(p => p.addDate == fecha).ToList();
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult HuertodelValle()
        { 
        var productos = _context.Productos.ToList();
            return View(productos);
        }
        /*
        [HttpGet]
        public IActionResult BuscarProducto(Producto p){

            var productos = _context.Productos.ToList();
            if(productos.Equals(p)){
                return View(productos);
            }
            
            return View("HuertodelValle");
        }*/
         [HttpPost]
        public IActionResult HuertodelValle(string filtro)
        {
            var listProd= _context.Productos.OrderBy(s => s.id).ToList();
            
            
                listProd=_context.Productos.Where(c => c.nombre.ToUpper().Contains(filtro.ToUpper())).OrderBy(s=>s.id) .ToList(); 
               
            return View(listProd);
        }
        public IActionResult Producto(){
            return View();
        }
         [HttpPost]
          [ValidateAntiForgeryToken]
        public IActionResult Producto([Bind("id,nombre,url_producto,descripcion,precio,lugarcompraproducto,usuario,tipo_producto")]Producto p)
        {
            if(ModelState.IsValid){
                _context.Add(p);
                _context.SaveChanges();
                 Console.WriteLine("Producto añadido");
                return RedirectToAction("HuertodelValle");
            }
            return View(p);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            var productos = _context.Productos.FirstOrDefault(p => p.id == id);
            _context.Remove(productos);
            _context.SaveChanges();
            return RedirectToAction("HuertodelValle");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult EditarProducto(int id){
            var producto = _context.Productos.Find(id);
            return View(producto);
        }
         [HttpPost]
        public IActionResult EditarProducto(Producto p)
        {   
            if(ModelState.IsValid){
                var producto = _context.Productos.Find(p.id);
                producto.nombre= p.nombre;
                producto.descripcion=p.descripcion;
                producto.precio=p.precio;
                producto.lugarcompraproducto=p.lugarcompraproducto;
                producto.usuario=p.usuario;
                producto.tipo_producto=p.tipo_producto;
                _context.SaveChanges();
                 Console.WriteLine("Producto añadido");
                return RedirectToAction("HuertodelValle");
            }
            return View(p);
        }
        public async Task<IActionResult> DetallesProforma(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proforma = await _context.Proforma
                .FirstOrDefaultAsync(m => m.id == id);
            if (proforma == null)
            {
                return NotFound();
            }

            return View(proforma);
        }

      public async Task<IActionResult> Agregar(int? id)
        {
            var userID = _userManager.GetUserName(User);
            if(userID == null){ 
                return RedirectToAction("Producto");
            }else{
                var producto = await _context.Productos.FindAsync(id);
                Proforma proforma = new Proforma();
                proforma.ProductoId = producto;
                
                proforma.Precio = producto.precio;
                proforma.Cantidad = 1;
                proforma.UserId = userID;
                _context.Add(proforma);
                await _context.SaveChangesAsync();
                return  RedirectToAction("MostrarProforma");
            }
        }
     public async Task<IActionResult> MostrarProforma()
        {
                 var userID = _userManager.GetUserName(User);
            var items = from o in _context.Proforma select o;
            items = items.
                Include(p => p.ProductoId).
                Where(s => s.UserId.Equals(userID));
            return View(await items.ToListAsync());
        }

    public IActionResult EliminarProforma(int id) 
        {
            var Producto= _context.Proforma.Find(id);
            _context.Remove(Producto);
            _context.SaveChanges();
            return RedirectToAction("EliminarProforma");
        }

    }}
    
