using ChampsSpeciaux.Data;
using ChampsSpeciaux.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChampsSpeciaux.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext applicationDbContext)
        {
           _db = applicationDbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Travel> TravelList =  _db.Travel.ToList();

            return View(TravelList);
        }

        //GET CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST CREATE
        [HttpPost]
        public async Task<IActionResult> Create(Travel travel)
        {
            if (ModelState.IsValid)
            {
                // Ajouter à la BD
                _db.Travel.Add(travel);

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return this.View(travel);
        }

        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            Travel travel = new Travel();
            travel = _db.Travel.FirstOrDefault(u => u.Id == id);
            if (travel == null)
            {
                return NotFound();
            }
            return View(travel);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Travel travel)
        {
            if (ModelState.IsValid)
            {
                _db.Travel.Update(travel);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(travel);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
