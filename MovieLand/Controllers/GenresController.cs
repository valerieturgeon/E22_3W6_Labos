using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLand_DataAccess.Data;
using MovieLand_Models;
using MovieLand_Models.ViewModels;
using System.Linq;

namespace MovieLand.Controllers
{
    public class GenresController : Controller
    {
        private readonly MovieLandDbContext _db;

        public GenresController(MovieLandDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Genres
                            .OrderBy(g => g.Name)
                                .Select(g => new GenreForListVM(g))
                                    .ToList());
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            GenreDetailsVM gdvm = _db.Genres
                                        .Where(g => g.GenreId == id)
                                            .Include(g => g.Movies)
                                                .ThenInclude(mg => mg.Movie)
                                                    .Select(g => new GenreDetailsVM(g))
                                                        .FirstOrDefault();
            if (gdvm == null)
            {
                return NotFound();
            }

            return View(gdvm);
        }
    }
}
