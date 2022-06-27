﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class Category
  {
    public int Id { get; set; }
    [Display(Name = "CategoryName")]
    [StringLength(20, MinimumLength = 10, ErrorMessage = "MinMaxCaractersValidation")]
    public string CategoryName { get; set; }

    // Propriété de navigation
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec Weapon
    public ICollection<Weapon> Weapons { get; set; }
  }
}
