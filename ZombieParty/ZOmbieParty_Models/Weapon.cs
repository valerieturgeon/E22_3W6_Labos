using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class Weapon
  {
    public int Id { get; set; }
    [StringLength(20)]
    public string TypeName { get; set; }
    [StringLength(50)]
    
       
    [Display(Name = "Category")]
    // FACULTATIF on peut formellement identifier le champ lien
    [ForeignKey("Category")]
    // Un Zombie DOIT avoir un ZombieType, donc int Ne peut PAS être null
    public int CategoryId { get; set; }

    //OBLIGATOIRE Pour la relation 1 à plusieurs avec ZombieType
    public  Category Category { get; set; }
    }
}
