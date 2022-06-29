
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty_DataAccess.Data;
using ZombieParty_Models;
using ZombieParty_Models.ViewModels;
using ZombieParty_Utility;
using static System.Net.Mime.MediaTypeNames;

namespace ZombieParty.Controllers
{
  public class ZombieController : Controller
  {
        private readonly ZombiePartyDbContext _db;
        // Permet le transfert de fichiers, dont les images
        private readonly IWebHostEnvironment _webHostEnvironment;


        public ZombieController(ZombiePartyDbContext zombiePartyDbContext, IWebHostEnvironment webHostEnvironment)
    {
            _db = zombiePartyDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
    
    public async Task<IActionResult> Index()
    {
      ZombieCardVM zombieCardVM = new ZombieCardVM()
      {
        
        Zombies = await _db.Zombie.Include(z => z.ZombieType).Include(z => z.ForceLevel).ToListAsync(),
        ZombieTypes = await _db.ZombieType.OrderBy(t => t.TypeName).OrderBy(t => t.TypeName).ToListAsync()
      };
      return View(zombieCardVM);

    }

    public async Task<IActionResult> IndexList()
    {
            IEnumerable<Zombie> objList = await _db.Zombie.Include(z => z.ZombieType).Include(z => z.ForceLevel).ToListAsync();
            return View(objList);
        }

        //GET UPSERT
        public async Task<IActionResult> Upsert(int? id)
    {
            ZombieVM zombieVM = new ZombieVM();
            zombieVM.ZombieTypeSelectList =  _db.ZombieType.Select(t => new SelectListItem
                {
                Text = t.TypeName,
                Value = t.Id.ToString()
            }).OrderBy(t => t.Text);
            zombieVM.ForceLevelSelectList = _db.ForceLevel.Select(f => new SelectListItem
            {
                Text = f.ForceLevelNiv.ToString(),
                Value = f.Id.ToString()
            }).OrderBy(f => f.Text);

            if (id == null)
      {
        //CREATE
        return View(zombieVM);
      }
      else
      {
       //EDIT
        zombieVM.Zombie = await _db.Zombie.FindAsync(id.GetValueOrDefault());
        if (id == null || id == 0)
        {
          return NotFound();
        }
        zombieVM.Previous = zombieVM.Zombie.Image;
        return View(zombieVM);
      }
    }


    //POST - UPSERT
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Upsert(ZombieVM zombieVM)
    {
      if (ModelState.IsValid) //validation côté serveur
      {
        var files = HttpContext.Request.Form.Files; //nouvelle image récupérée
        string WebRootPath = _webHostEnvironment.WebRootPath; //Chemin des images zombies
        string PreviousImage = zombieVM.Previous;      
                if (zombieVM.Zombie.Id == 0)
        {
                    //Insert  
                    string upload = WebRootPath + AppConstants.ImageZombiePath; //ServeurProjet + la constante du chemin relatif
                    string fileName = Guid.NewGuid().ToString(); //Récupérer le nom du fichier
                    string extension = Path.GetExtension(files[0].FileName);//extraire l'extension (pour Nom fichier complet)

                    // Créer le nouveau fichier dans le dossier upload
                    using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    //Update l'image dans le form
                    // choix de gérer le path préalable ici ou ailleurs
                    zombieVM.Zombie.Image = fileName + extension;

                    await _db.Zombie.AddAsync(zombieVM.Zombie); //Ajouter dans la BD

                }
                else
                {

                    //Update
                    // var objFromDb = await _db.Zombie.FirstOrDefaultAsync(u => u.Id == zombieVM.Zombie.Id);
                   

                    if (files.Count > 0)
                    {
                        string upload = WebRootPath + AppConstants.ImageZombiePath; //ServeurProjet + la constante du chemin relatif
                        string fileName = Guid.NewGuid().ToString(); //Récupérer le nom du fichier
                        string extension = Path.GetExtension(files[0].FileName);//extraire l'extension (pour Nom fichier complet)
                       //Supprimer l'ancien fichier physiquement pour le remplacer (edit)
                        if (PreviousImage != null)
                        {
                            var oldFile = Path.Combine(upload, PreviousImage);

                            if (System.IO.File.Exists(oldFile))
                            {
                                System.IO.File.Delete(oldFile);
                            }
                        }
                        // Créer le nouveau fichier dans le dossier upload
                        using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                        {
                            files[0].CopyTo(fileStream);
                        }

                        zombieVM.Zombie.Image = fileName + extension;

                    }
                    else //si image pas modifiée
                    {
                        zombieVM.Zombie.Image = PreviousImage;
                    }

                    //Update
                    _db.Update(zombieVM.Zombie); // Mettre à jour dans DB
                }

                await _db.SaveChangesAsync(); // pour que les changements soient appliqués dans BD
                return RedirectToAction("Index");
            }
            zombieVM.ZombieTypeSelectList = (IEnumerable<SelectListItem>)await _db.ZombieType.ToListAsync();

            return View(zombieVM); //retourne l'objet pour avoir les données
        }



        //GET DELETE
        public async Task<IActionResult> Delete(int? id)
    {
      if (id == null || id == 0)
      {
        return NotFound();
      }

      var obj = await _db.Zombie.FindAsync(id.GetValueOrDefault());
      if (obj == null)
      {
        return NotFound();
      }

      return View(obj);
    }

    //POST DELETE
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> DeletePost(int? id)
    {
      var obj = await _db.Zombie.FindAsync(id.GetValueOrDefault());
            if (obj == null)
      {
        return NotFound();
      }

      _db.Zombie.Remove(obj);
      await _db.SaveChangesAsync();

      return RedirectToAction("Index");
    }
  }
}
