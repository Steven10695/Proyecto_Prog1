
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Huerto_Del_valle.Models;
using Huerto_Del_valle.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Huerto_Del_valle.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public AdminController(ILogger<AdminController> logger,
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }
        public async Task<IActionResult> Add(int? id){
            var userID = _userManager.GetUserName(User);
            if(userID == null){
                ViewData["Message"] = "Por favor debe loguearse";
                return  View("Index");
            }else{
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Index));
            }
        }
    }
}