using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty.Models
{
  public class ZombieType
  {
    [Key]
    public int Id { get; set; }
    [DisplayName("Type Name")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Type Name have to be fill.")]
    public string TypeName { get; set; }
  }
}
