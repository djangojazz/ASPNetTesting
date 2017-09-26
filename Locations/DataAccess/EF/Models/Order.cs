using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locations.DataAccess.EF.Models
{
  public class Order : BaseModel
  {
    public int OrderId { get; set; }
    [Column(TypeName = "varchar")]
    [Required]
    [MaxLength(256)]
    public string OrderDescription { get; set; }
    [Required]
    public double Amount { get; set; }
  }
}