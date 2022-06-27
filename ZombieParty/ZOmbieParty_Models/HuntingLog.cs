using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class HuntingLog
  {
    public int Id { get; set; }

    [Display(Name = "Title")]
    public string Title { get; set; }

    [Display(Name = "Description")]
    public string Description { get; set; }

    [Display(Name = "Date")]
    [DataType(DataType.Date)] //Mettre aussi le type de input
    public DateTime AdventureDate { get; set; }

    // Propriété de navigation vers zombieHuntingLog
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec zombieHuntingLog
    public ICollection<ZombieHuntingLog> zombieHuntingLogs { get; set; }

    // FACULTATIF on peut formellement identifier le champ lien
    [ForeignKey("Hunter")]
    // Un Hunter PEUT avoir un ou plusieurs HuntingLog
    public int HunterId { get; set; }
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec Hunter
    public virtual Hunter Hunter { get; set; }
  }
}
