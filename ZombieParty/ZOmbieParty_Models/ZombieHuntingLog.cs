using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class ZombieHuntingLog
  {  //[Key]
    [ForeignKey("Zombie")]
    public int Zombie_Id { get; set; }
    //[Key]
    [ForeignKey("HuntingLog")]
    public int HuntingLog_Id { get; set; }

    // Propriété de navigation vers zombie
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec Zombie
    public Zombie Zombie { get; set; }

    // Propriété de navigation vers HuntingLog
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec HuntingLog
    public HuntingLog HuntingLog { get; set; }
  }
}
