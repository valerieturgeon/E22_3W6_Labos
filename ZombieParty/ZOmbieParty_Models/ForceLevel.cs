﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class ForceLevel
  {
    [Key]
    public int Id { get; set; }

    [Display(Name = "ForceLevelNiv")]
    [Range(5, 10, ErrorMessage = "RangeValidation")]
    public int ForceLevelNiv { get; set; }

    // Propriété de navigation
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec Zombies
    public ICollection<Zombie> Zombies { get; set; }
  }
}
