﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class Hunter
  {
    [Key]
    public int Id { get; set; }
    
    [Display(Name = "Nickname")]
    [StringLength(10, MinimumLength = 5, ErrorMessage = "MinMaxCaractersValidation")]
    public string Nickname { get; set; }
    
        [Display(Name = "Biography")] 
    public string Biography { get; set; }

    // Propriété de navigation vers HuntingLog
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec zombieHuntingLog
    public ICollection<HuntingLog> HuntingLogs { get; set; }
  }
}
