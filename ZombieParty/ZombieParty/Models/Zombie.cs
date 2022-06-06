using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty.Models
{
  public class Zombie
  {
    [Key]
    public int Id { get; set; }
    [Range(1, 10, ErrorMessage = "RangeValidation")]
    public int Point { get; set; }
    public string ShortDesc { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    [Display(Name = "Zombie Type")]
    // FACULTATIF on peut formellement identifier le champ lien
    public int ZombieTypeId { get; set; }
    [ForeignKey("ZombieTypeId")]
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec ZombieType
    public virtual ZombieType ZombieType { get; set; }

    }
}
