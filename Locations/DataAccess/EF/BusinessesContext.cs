using Locations.DataAccess.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Locations.DataAccess.EF
{
  public class BusinessesContext : DbContext
  {
    public BusinessesContext() : base("Businesses")
    {
      Database.SetInitializer(new BusinessDbInitializer());
    }

    public DbSet<Business> Business { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<Order> Order { get; set; }
  }

  

  internal sealed class Configuration : DbMigrationsConfiguration<BusinessesContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = true;
      AutomaticMigrationDataLossAllowed = true;
      ContextKey = "SimpleCodeFirst.SimpleContext";
    }
  }
}