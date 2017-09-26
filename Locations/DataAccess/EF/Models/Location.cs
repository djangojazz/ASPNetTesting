using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locations.DataAccess.EF.Models
{
  public class Location : BaseModel
  {
    public int LocationId { get; set; }
    [Required, Column(TypeName = "varchar"), MaxLength(256)]
    public string LocationName { get; set; }
    [Column(TypeName = "varchar")]
    [Required]
    [MaxLength(256)]
    public string Address { get; set; }
    [Column(TypeName = "varchar")]
    [Required]
    [MaxLength(128)]
    public string City { get; set; }
    [Column(TypeName = "char")]
    [Required]
    [StringLength(2)]
    public string State { get; set; }
    [Required]
    public int Zip { get; set; }
    [Required]
    public double Latitude { get; set; }
    [Required]
    public double Longitude { get; set; }
    public ICollection<Order> Orders { get; set; }
  }
}