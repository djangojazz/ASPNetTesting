using System;
using System.Security.Principal;

namespace Locations.DataAccess.EF.Models
{
  public abstract class BaseModel
  {
    public BaseModel()
    {
      DateCreated = DateTime.UtcNow;
      CreatedBy = WindowsIdentity.GetCurrent().Name;
      DateModified = DateTime.UtcNow;
      LastModifiedBy = WindowsIdentity.GetCurrent().Name;
    }

    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; }
    public DateTime DateModified { get; set; }
    public string LastModifiedBy { get; set; }
  }
}