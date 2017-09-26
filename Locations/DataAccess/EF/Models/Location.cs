using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locations.DataAccess.EF.Models
{
  public class Location : BaseModel
  {
    public int LocationId { get; set; }
    [Column(TypeName = "varchar")]
    [Required]
    [MaxLength(256)]
    public string LocationName { get; set; }
    [Required]
    public double Latitude { get; set; }
    [Required]
    public double Longitude { get; set; }
    public ICollection<Order> Orders { get; set; }
  }
}