using System.Linq;
using System.Threading.Tasks;
using Huerto_Del_valle.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Prog1.Models;

namespace Proyecto_Prog1.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ProductoController(ILogger<ProductoController> logger,
            ApplicationDbContext context ,  UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;

        }

        public IActionResult Producto()
        {
            var listProductos=_context.Productos.ToList();
            return View(listProductos);
        }
/*
        public async Task<IActionResult> Add(int? id)
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
                return  RedirectToAction("Producto");
            }
        }

*/
    }
}