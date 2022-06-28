using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieParty_Models.ViewModels
{
 public class ZombieCardVM
  {
        // Pour afficher les Zombies sous forme de card Bootstrap (PartialView)
    public IEnumerable<Zombie> Zombies { get; set; }
        // Pour créer la liste des types sous forme de boutons (filtre)
    public IEnumerable<ZombieType> ZombieTypes { get; set; }
    }
}
