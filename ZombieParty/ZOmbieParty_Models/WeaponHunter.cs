using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class WeaponHunter
  {
    //[Key]
    [ForeignKey("Hunter")]
    public int Hunter_Id { get; set; }
    //[Key]
    [ForeignKey("Weapon")]
    public int Weapon_Id { get; set; }

    // Propriété de navigation vers Hunter
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec Hunter
    public Hunter Hunter { get; set; }

    // Propriété de navigation vers Weapon
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec Weapon
    public Weapon Weapon { get; set; }

  }
}
