using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Locations.DataAccess.EF
{
  public class LocationsContext : DbContext
  {
    public LocationsContext() : base("Locations")
    {

    }
  }

  internal sealed class Configuration : DbMigrationsConfiguration<LocationsContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = true;
      AutomaticMigrationDataLossAllowed = true;
      ContextKey = "SimpleCodeFirst.SimpleContext";
    }
  }
}