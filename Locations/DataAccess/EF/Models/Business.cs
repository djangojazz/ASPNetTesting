using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locations.DataAccess.EF.Models
{
  public class Business : BaseModel
  {
    public int BusinessId { get; set; }

    [Column(TypeName = "varchar")]
    [Required]
    [MaxLength(256)]
    public string BusinessName { get; set; }
    public ICollection<Location> Locations { get; set; }
  }
}