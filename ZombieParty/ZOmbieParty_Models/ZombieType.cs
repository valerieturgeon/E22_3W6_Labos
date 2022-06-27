using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class ZombieType
  {
    public int Id { get; set; }
        // La clé du DisplayName doit être identique à celle du fichier resource
    [DisplayName("TypeName")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "RequiredValidation")]
    public string TypeName { get; set; }
    
        [DisplayName("Point")]
    public int Point { get; set; }

        // Propriété de navigation
        //OBLIGATOIRE Pour la relation 1 à plusieurs avec Zombie
        public ICollection<Zombie> Zombies { get; set; }
  }
}
