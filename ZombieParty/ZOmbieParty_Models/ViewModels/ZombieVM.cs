using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ZombieParty_Models.ViewModels
{
  public class ZombieVM
  {
        // Pour Upsert 1 zombie à la fois
    public Zombie Zombie { get; set; }
    public string Previous { get; set; }
        // Pour créer les deux listes déroulantes
    public IEnumerable<SelectListItem> ZombieTypeSelectList { get; set; }
    public IEnumerable<SelectListItem> ForceLevelSelectList { get; set; }

    }
}
