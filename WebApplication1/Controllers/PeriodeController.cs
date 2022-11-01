using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class PeriodeController : Controller
    {
        private readonly LoContext locontext;

        public PeriodeController(LoContext locontext)
        {
            this.locontext = locontext;
        }

        // affiche la liste des cours de la base de donnees
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Periode> periodes = locontext.Periode.ToList();
            return View(periodes);


        }
        //initialise 
        [HttpGet]

        public IActionResult Add()
        {

            return View();



        }
        // ajouter un cour dans la base de donnees
        [HttpPost]
        public async Task<IActionResult> Add(Periode addperiodesrequest)
        {
            var periode = new Periode();
            {
              //  periode.Id = addperiodesrequest.Id();
                periode.Nom = addperiodesrequest.Nom;

            }

            await locontext.Periode.AddAsync(periode);
            await locontext.SaveChangesAsync();
            return RedirectToAction("Index");



        }
        // recuperer l'id afin de selection  l'enregistrement a modifier
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var periode = await locontext.Periode.FirstOrDefaultAsync(x => x.Id == id);
            if (periode != null)
            {
                var viewmodel = new Periode()
                {
                    Id = periode.Id,
                    Nom = periode.Nom
                };

                return await Task.Run(() => View("View", viewmodel));
            }
            return RedirectToAction("Index");
        }
        //modifier une periode

        [HttpPost]
        public async Task<IActionResult> Edit(Periode model)
        {
            var periode = await locontext.Periode.FindAsync(model.Id);
            if (periode != null)
            {
                periode.Id = model.Id;
                periode.Nom = model.Nom;

                await locontext.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }

        [HttpPost]

        public async Task<IActionResult> Delete(Periode model)
        {
            var periode = await locontext.Periode.FindAsync(model.Id);
            if (periode != null)
            {
                locontext.Periode.Remove(periode);
                await locontext.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return RedirectToAction("Index");


        }

    }
}

