using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using LoginApp.Data;
using Microsoft.AspNetCore.Identity;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Controllers
{
    public class PeriodeController : Controller
    {
        private readonly IPeriodeRepository _periodeRepo;
        private readonly UserManager<IdentityUser> _userManager;

        public PeriodeController(IPeriodeRepository periodeRepo, UserManager<IdentityUser> userManager)
        {
            _periodeRepo = periodeRepo;
            _userManager = userManager;
        }

        // affiche la liste des periodes de la base de donnees
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Periode> periodes = _periodeRepo.GetPeriodesPerUser(_userManager.GetUserId(User));
            return View(periodes);


        }
        
    }
}

